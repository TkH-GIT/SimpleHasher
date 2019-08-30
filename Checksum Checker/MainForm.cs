using System;
using System.ComponentModel;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Checksum_Checker
{
    public partial class MainForm : Form
    {
        // Hashing thread
        BackgroundWorker calcChecksumThread = new BackgroundWorker();

        public MainForm()
        {
            InitializeComponent();

            // Setup BackgroundWorker
            calcChecksumThread.WorkerReportsProgress = false;
            calcChecksumThread.WorkerSupportsCancellation = false;
            calcChecksumThread.DoWork += new DoWorkEventHandler(calcChecksumThread_DoWork);
            calcChecksumThread.RunWorkerCompleted += new RunWorkerCompletedEventHandler(calcChecksumThread_RunWorkerCompleted);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lstHash.SelectedIndex = 0;
            lstOpMode.SelectedIndex = 0;
            tssStatus.Text = "Ready...";
        }

        private void DisableInterface()
        {
            btnStart.Enabled = false;
            txtInput.ReadOnly = true;
        }

        private void EnableInterface()
        {
            btnStart.Enabled = true;
            txtInput.ReadOnly = false;
        }

        private void calcChecksumThread_DoWork(object sender, DoWorkEventArgs e)
        {
            // Retrieve arguments from array
            object[] args   = (object[])e.Argument;
            string filepath = (string)args[0];
            string result   = "";
            int hashChoice  = (int)args[1];

            // Open file and compute hash
            try
            {
                using (FileStream file = new FileStream(filepath, FileMode.Open, FileAccess.Read))
                    switch (hashChoice)
                    {
                        case 0: // MD5
                        {
                            using (MD5 md5 = MD5.Create())
                            {
                                result = BitConverter.ToString(md5.ComputeHash(file)).Replace("-", "").ToUpper();
                            }
                        }
                        break;
                        case 1: // SHA1
                        {
                            using (SHA1 sha1 = SHA1.Create())
                            {
                                result = BitConverter.ToString(sha1.ComputeHash(file)).Replace("-", "").ToUpper();
                            }
                        }
                        break;
                        case 2: // SHA256
                        {
                            using (SHA256 sha256 = SHA256.Create())
                            {
                                result = BitConverter.ToString(sha256.ComputeHash(file)).Replace("-", "").ToUpper();
                            }
                        }
                        break;
                        case 3: // SHA512
                        {
                            using (SHA512 sha512 = SHA512.Create())
                            {
                                result = BitConverter.ToString(sha512.ComputeHash(file)).Replace("-", "").ToUpper();
                            }
                        }
                        break;
                    }
            }
            catch
            {
                e.Result = "Error";
            }
            e.Result = result;
        }

        private void calcChecksumThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Check result
            pgbProgress.Style = ProgressBarStyle.Blocks;
            if (e.Error == null && (string)e.Result != "Error")
            {
                if (lstOpMode.SelectedIndex == 0)
                {
                    txtOutput.Text = (string)e.Result;
                    tssStatus.Text = "Hashing complete.";
                }
                else
                {
                    // Compare computed hash with input
                    txtOutput.Text = (string)e.Result;
                    txtInput.Text = txtInput.Text.ToUpper();
                    txtInput.Focus();
                    txtInput.Select(0, 0);
                    if (txtInput.Text == txtOutput.Text)
                    {
                        MessageBox.Show(this, "The hashes match!");
                        tssStatus.Text = "Hashes match!";
                    }
                    else
                    {
                        MessageBox.Show(this, "The hashes don't match.");
                        tssStatus.Text = "Hashes don't match.";
                    }
                }
            }
            else
            {
                MessageBox.Show(this, "There was a problem calculating the hash for the file, please try again.");
                tssStatus.Text = "Error";
            }
            EnableInterface();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            DisableInterface();
            if (calcChecksumThread.IsBusy)
            {
                MessageBox.Show(this, "Thread still busy, please try again in a few seconds.");
                tssStatus.Text = "Thread still busy.";
                return;
            }

            // Ask user for filepath
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                object[] threadArgs = { ofd.FileName, lstHash.SelectedIndex };
                calcChecksumThread.RunWorkerAsync(threadArgs);
                pgbProgress.Style = ProgressBarStyle.Marquee;
                tssStatus.Text = "Calculating hash...";
            }
            else
            {
                tssStatus.Text = "Cancelled.";
                EnableInterface();
            }
            ofd.Dispose();
        }
    }
}
