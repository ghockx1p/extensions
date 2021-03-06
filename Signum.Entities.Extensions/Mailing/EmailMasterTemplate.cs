﻿using Signum.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using Signum.Entities.Basics;
using Signum.Utilities.ExpressionTrees;

namespace Signum.Entities.Mailing
{
    [Serializable, EntityKind(EntityKind.Main, EntityData.Master)]
    public class EmailMasterTemplateEntity : Entity
    {
        [NotNullable, SqlDbType(Size = 100), UniqueIndex]
        [StringLengthValidator(AllowNulls = false, Min = 3, Max = 100)]
        public string Name { get; set; }

        [NotifyCollectionChanged, NotNullable]
        public MList<EmailMasterTemplateMessageEntity> Messages { get; set; } = new MList<EmailMasterTemplateMessageEntity>();

        [Ignore]
        public static readonly Regex MasterTemplateContentRegex = new Regex(@"\@\[content\]");

        static Expression<Func<EmailMasterTemplateEntity, string>> ToStringExpression = e => e.Name;
        [ExpressionField]
        public override string ToString()
        {
            return ToStringExpression.Evaluate(this);
        }

        protected override string PropertyValidation(System.Reflection.PropertyInfo pi)
        {
            if (pi.Name == nameof(Messages))
            {
                if (Messages == null || !Messages.Any())
                    return EmailTemplateMessage.ThereAreNoMessagesForTheTemplate.NiceToString();

                if (Messages.GroupCount(m => m.CultureInfo).Any(c => c.Value > 1))
                    return EmailTemplateMessage.TheresMoreThanOneMessageForTheSameLanguage.NiceToString();
            }

            return base.PropertyValidation(pi);
        }

        protected override void ChildCollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
        {
            if (sender == Messages)
            {
                if (args.OldItems != null)
                    foreach (var item in args.OldItems.Cast<EmailMasterTemplateMessageEntity>())
                        item.MasterTemplate = null;

                if (args.NewItems != null)
                    foreach (var item in args.NewItems.Cast<EmailMasterTemplateMessageEntity>())
                        item.MasterTemplate = this;
            }
        }

        protected override void PreSaving(ref bool graphModified)
        {
            base.PreSaving(ref graphModified);

            Messages.ForEach(e => e.MasterTemplate = this);
        }
    }

    [AutoInit]
    public static class EmailMasterTemplateOperation
    {
        public static ConstructSymbol<EmailMasterTemplateEntity>.Simple Create;
        public static ExecuteSymbol<EmailMasterTemplateEntity> Save;
    }

    [Serializable]
    public class EmailMasterTemplateMessageEntity : EmbeddedEntity
    {
        private EmailMasterTemplateMessageEntity() { }

        public EmailMasterTemplateMessageEntity(CultureInfoEntity culture)
        {
            this.CultureInfo = culture;
        }

        [Ignore]
        internal EmailMasterTemplateEntity masterTemplate;
        public EmailMasterTemplateEntity MasterTemplate
        {
            get { return masterTemplate; }
            set { masterTemplate = value; }
        }

        [NotNullable]
        [NotNullValidator]
        public CultureInfoEntity CultureInfo { get; set; }

        [NotNullable, SqlDbType(Size = int.MaxValue)]
        [StringLengthValidator(AllowNulls = false, MultiLine = true)]
        public string Text { get; set; }

        public override string ToString()
        {
            return CultureInfo?.ToString();
        }

        protected override string PropertyValidation(PropertyInfo pi)
        {
            if (pi.Name == nameof(Text) && !EmailMasterTemplateEntity.MasterTemplateContentRegex.IsMatch(Text))
            {
                throw new ApplicationException(EmailTemplateMessage.TheTextMustContain0IndicatingReplacementPoint.NiceToString().FormatWith("@[content]"));
            }

            return base.PropertyValidation(pi);
        }
    }
}
