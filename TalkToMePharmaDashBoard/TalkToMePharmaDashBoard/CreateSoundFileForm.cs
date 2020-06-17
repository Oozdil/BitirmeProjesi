using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TalkToMePharmaDashBoard.Api;

namespace TalkToMePharmaDashBoard
{
    public partial class CreateSoundFileForm : Form
    {
        public CreateSoundFileForm()
        {
            InitializeComponent();
        }

        public string barcode;
        public string text;
        public string name;
        public int type;
        string path = "";
        public AdminUser User;




        private void CreateSoundFileForm_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("CreateSoundFileForm" + User.FullName);
            labelBarcode.Text = barcode;
            
            if (text.Length >= 30)
                labelText.Text = text.Substring(0, 30) + "....";
            else
                labelText.Text = text + "....";
            Api.WebApi api = new Api.WebApi();

            if (type == 0)
            {
                name = "nameTest.mp3";
                path = "FinalYearProject/Files/NameAudioFiles/";
              //  api.CreateLog("name sound create:"+barcode, User);
            }
            else
            {
                name = "descriptionTest.mp3";
                path = "FinalYearProject/Files/DescriptionAudioFiles/";
              //  api.CreateLog("desc sound create:" + barcode, User);
            }


            labelSoundFile.Text = name;

            CheckForIllegalCrossThreadCalls = false;


            Thread t1 = new Thread(DeleteOldFile);
            t1.Start();

           
           
        }

        private void DeleteOldFile(object obj)
        {
            labelInfo.Text = "Eski dosya siliniyor";
            Thread.Sleep(1000);
            try
            {
                File.Delete(name);
                checkBoxDelete.ForeColor = Color.Green;
                checkBoxDelete.Checked = true;
                CreateSoundFile();
            }
            catch
            {
                MessageBox.Show("Dosya silmede hata oluştu");
                this.Close();
            }
        }

        private void CreateSoundFile()
        {
            labelInfo.Text = "Ses dosyası oluşturuluyor";
            Thread.Sleep(1000);
            try
            {
                string result = CreateSound(name, text);
               // MessageBox.Show(result);

                if (result.Trim() == "1")
                {
                    checkBoxCreate.ForeColor = Color.Green;
                    checkBoxCreate.Checked = true;
                    UploadFile();
                }
                else
                {
                    MessageBox.Show("Dosya oluşturmada bir hata oluştu");
                    this.Close();
                }


            }
            catch
            {
                MessageBox.Show("Dosya oluşturmada bir hata oluştu");
                this.Close();
            }
        }


        ///Upload section


        class FtpSettings
        {
            public string Server { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string Filename { get; set; }
            public string Fullname { get; set; }

        }
        FtpSettings inputparameter;
        private void UploadFile()
        {
            labelInfo.Text = "Ses dosyası upload ediliyor : (" + barcode + ")";
            Thread.Sleep(1000);
            try
            {
                FileInfo fi = new FileInfo(name);
                inputparameter = new FtpSettings();
                inputparameter.Username = "orcunozd";
                inputparameter.Password = "Ozge140409";
                inputparameter.Server = "37.230.109.29";
                inputparameter.Filename = fi.Name;
                inputparameter.Fullname = fi.FullName;

                backgroundWorkerCreateSoundFile.DoWork += backgroundWorker1_DoWork;
                backgroundWorkerCreateSoundFile.ProgressChanged += backgroundWorker1_ProgressChanged;
                backgroundWorkerCreateSoundFile.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
                backgroundWorkerCreateSoundFile.WorkerReportsProgress = true;
                backgroundWorkerCreateSoundFile.RunWorkerAsync();
                checkBoxUpdate.ForeColor = Color.Green;
                checkBoxUpdate.Checked = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Upload işleminde hata oluştu" + ex);
                this.Close();
            }

        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            string fileName = inputparameter.Filename;
            string fullname = inputparameter.Fullname;
            string username = inputparameter.Username;
            string password = inputparameter.Password;
            string server = inputparameter.Server;
            Uri uri = new Uri("ftp://" + server + "/httpdocs/" +path+ barcode + ".mp3");

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uri);
            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.Credentials = new NetworkCredential(username, password);
            Stream ftpStream = request.GetRequestStream();
            FileStream fs = File.OpenRead(fullname);
            byte[] buffer = new byte[1024];
            double total = (double)fs.Length;

            int byteRead = 0;
            double read = 0;
            do
            {
                if (!backgroundWorkerCreateSoundFile.CancellationPending)
                {

                    byteRead = fs.Read(buffer, 0, 1024);
                    ftpStream.Write(buffer, 0, byteRead);
                    read += (double)byteRead;
                    double percentage = read / total * 100;
                    backgroundWorkerCreateSoundFile.ReportProgress((int)percentage);
                }
            }
            while (byteRead != 0);
            fs.Close();
            ftpStream.Close();
            

        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            labelInfo.Text = "Ses dosyası upload ediliyor : (" + barcode + ") &" + e.ProgressPercentage.ToString();

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            labelInfo.Text = "Upload Başarılı";
            MessageBox.Show("Upload Başarılı");
            this.Close();
        }
        //upload











        public string CreateSound(string name, string text)
        {
            string fileName = "C:\\Python36\\python.exe";
            string arguments = "C:\\Users\\orçun\\Desktop\\TalkToMePharmaDashBoard\\TalkToMePharmaDashBoard\\bin\\Debug\\CreateSound.py " + name + " \"" + text + "\"";
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo()
            {
                UseShellExecute = false,
                CreateNoWindow = false,
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = fileName,
                Arguments = arguments,
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            return output;
        }



        private void timerCreateSoundFile_Tick(object sender, EventArgs e)
        {
            int second = DateTime.Now.Second % 2;

           
            if(second==1)
            {
                labelInfo.Visible = false;
                labelPleaseWait.Visible = true;
            }
            else
            {
                labelInfo.Visible = true;
                labelPleaseWait.Visible = false;
            }
        }

        


    }
}
