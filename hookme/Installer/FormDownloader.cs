using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Threading;

namespace Installer
{
    public partial class FormDownloader : Form
    {
        public bool success = false;
        DownloaderDependencies dependencies;

        private bool fileDownloaded = false;

        int dependenciesDownloaded = 0;
        Thread tStartDownload;

        public FormDownloader(DownloaderDependencies dependencies)
        {
            this.dependencies = dependencies;
            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            success = false;
            this.Close();
        }

        private void FormDownloader_Load(object sender, EventArgs e)
        {
            lbInfo.Text = "";
            string path = dependencies.urlRepositorio;

            foreach (string file in dependencies.GetRequiered())
            {
                string fullPath = path + file;
                lbDependences.Items.Add(fullPath);
            }

            tStartDownload = new Thread(new ThreadStart(StartDownloading));
            tStartDownload.IsBackground = true;
            tStartDownload.Start();
        }

        private void StartDownloading()
        {
            string path = dependencies.urlRepositorio;

            foreach (string file in dependencies.GetRequiered())
            {
                progress.Invoke(new MethodInvoker(delegate
                    {
                        progress.Value = 0;
                    }));

                string fullPath = path + file;

                lbInfo.Invoke(new MethodInvoker(delegate
                    {
                        lbInfo.Text = "Downloading " + fullPath;
                    }));

                // Descargar los ficheros.
                WebClient wc = new WebClient();
                wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(wc_DownloadProgressChanged);
                wc.DownloadFileCompleted += new AsyncCompletedEventHandler(wc_DownloadFileCompleted);
                try
                {
                    fileDownloaded = false;
                    wc.DownloadFileAsync(new Uri(fullPath), System.IO.Directory.GetCurrentDirectory() + @"\" + file + ".tmp");
                   
                    do
                    {
                        System.Threading.Thread.Sleep(0); // El evento wc_DownloadFileCompleted se encarga de ponerlo a true
                        // Se usa DownloadFileAsync en vez de DownloadFile, porque con este ultimo no funciona el evento DownloadProgressChanged para la progressbar
                    } while (fileDownloaded == false);
                    wc = null;
                    System.IO.File.Move(file + ".tmp", file);
                    dependenciesDownloaded++;

                    if (dependenciesDownloaded == dependencies.GetRequiered().Count)
                    {
                        this.success = true;
                        this.Invoke(new MethodInvoker(delegate
                        {
                            this.Close();
                        }));
                    }
                }
                catch (ThreadAbortException ex)
                {
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            fileDownloaded = true;
        }

        void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progress.Invoke(new MethodInvoker(delegate
            {
                progress.Value = e.ProgressPercentage;
            }));
        }
    }
}
