﻿using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using Signum.Entities;
using Signum.Entities.Authorization;
using Signum.Entities.Disconnected;
using Signum.Utilities;
using System.Diagnostics;

namespace Signum.Windows.Disconnected
{
    /// <summary>
    /// Interaction logic for DownloadProgress.xaml
    /// </summary>
    public partial class DownloadProgress : Window
    {
        private string downloadFilePath;

        public DownloadProgress(): this(string.Empty) { }
        public DownloadProgress(string DownloadFilePath)
        {
            InitializeComponent();

            this.Loaded += new RoutedEventHandler(DownloadDatabase_Loaded);

            var a = DisconnectedMachineDN.Current;

            downloadFilePath = DownloadFilePath;
        }

        DisconnectedExportDN estimation;

        Lite<DisconnectedExportDN> currentLite;

        IDisconnectedTransferServer transferServer = DisconnectedClient.GetTransferServer();

        DispatcherTimer timer = new DispatcherTimer();

        void DownloadDatabase_Loaded(object sender, RoutedEventArgs e)
        {
            estimation = Server.Return((IDisconnectedServer ds) => ds.GetDownloadEstimation(DisconnectedMachineDN.Current));

            pbGenerating.Minimum = 0;
            pbGenerating.Maximum = 1;

            currentLite = transferServer.BeginExportDatabase(UserDN.Current.ToLite(), DisconnectedMachineDN.Current);

            timer.Tick += new EventHandler(timer_Tick);

            timer.Interval = TimeSpan.FromSeconds(1);

            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            var current = currentLite.RetrieveAndForget();

            ctrlStats.DataContext = null;
            ctrlStats.DataContext = current;

            if (current.State != DisconnectedExportState.InProgress)
            {
                timer.Stop();

                if (current.State == DisconnectedExportState.Error)
                {
                    expander.IsExpanded = true;
                    pbGenerating.IsIndeterminate = false;

                    if (MessageBox.Show(Window.GetWindow(this), "There have been an error. View Details?", "Error exporting database", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                        Navigator.View(current.Exception);
                }
                else
                {
                    pbGenerating.Value = 1;

                    StartDownloading();
                }
            }
            else
            {
                if (estimation == null)
                    pbGenerating.IsIndeterminate = true;
                else
                    pbGenerating.Value = current.Ratio(estimation);
            }
        }

        private void StartDownloading()
        {
            var file = transferServer.EndExportDatabase(new DownloadDatabaseRequests
            {
                User = UserDN.Current.ToLite(),
                DownloadStatistics = currentLite
            });

            string filePath = Path.Combine(downloadFilePath, DisconnectedClient.DownloadBackupFile);
            FileTools.CreateDirectory(filePath);

            pbDownloading.Minimum = 0;
            pbDownloading.Maximum = file.Length;

            Task.Factory.StartNew(() =>
            {
                using (var ps = new ProgressStream(file.Stream))
                {
                    if (!Debugger.IsAttached)
                    ps.ProgressChanged += (s, args) =>
                        Dispatcher.BeginInvoke(() => pbDownloading.Value = ps.Position);

                    using (FileStream fs = File.OpenWrite(filePath))
                        ps.CopyTo(fs);
                }

                Dispatcher.Invoke(() =>
                {
                    MessageBox.Show(Window.GetWindow(this), "You have successfully downloaded a local database. \r\nThe application will turn off now.\r\nNext time you start it up, choose Run Disconnected.", "Download complete", MessageBoxButton.OK);
                });

                Environment.Exit(0);
            });
        }
    }
}
