﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Signum.Entities.Basics;

namespace Signum.Entities.SMS
{
    [Serializable]
    public class SMSConfigurationEntity : EmbeddedEntity
    {
        [NotNullValidator]
        public CultureInfoEntity DefaultCulture { get; set; }
    }
}
