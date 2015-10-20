using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InternettClient.ServiceReference1;
using System.IO;
using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing.Imaging;

namespace InternettClient
{
    public partial class MainForm : Form
    {
        private ServicePortTypeClient client;
        private String Username;
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(ServicePortTypeClient client, String Username)
        {
            this.client = client;
            this.Username = Username;
            InitializeComponent();
        }

        private void getQRPictureBTN_Click(object sender, EventArgs e)
        {
            byte[] data = client.ReturnQRPicture(Username);

            MemoryStream ms = new MemoryStream(data);

            qrPicture.Image = Image.FromStream(ms);
            qrPicture.Visible = true;

            ms.Dispose();
           
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            inputTB.Text = "";
            qrCheckBox.Checked = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                uploadedFileText.Text = openFileDialog1.FileName;
                uploadedFileText.Visible = true;  
            }            
        }

        private void qrCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            inputTB.Text = "";
            uploadedFileText.Text = "";
        }

        private void inputTB_TextChanged(object sender, EventArgs e)
        {
            qrCheckBox.Checked = false;
            uploadedFileText.Text = "";
        }

        private void uploadedFileText_TextChanged(object sender, EventArgs e)
        {

        }

        private void byteCountBTN_Click(object sender, EventArgs e)
        {
            int byteCount = 0;
            String base64Data = "";
            bool chosenItem = false;


            /*
            **Utfører en bytecount på brukerens valgte måte ved å convertere byte array om til base64 string
            **Bruker med vilje forskjellige metoder for å convertere til byte array
            */
            if (qrCheckBox.Checked)
            {
                Image picture = qrPicture.Image;
                chosenItem = true;

                using (MemoryStream ms = new MemoryStream())
                {
                    picture.Save(ms, ImageFormat.Png);
                    byte[] imageBytes = ms.ToArray();
                    base64Data = Convert.ToBase64String(imageBytes);
                }
            }
            else if (String.IsNullOrEmpty(uploadedFileText.Text) == false)
            {
                chosenItem = true;
                try
                {
                    Stream s = File.Open(uploadedFileText.Text, FileMode.Open);
                    StreamReader sr = new StreamReader(s);
                    String fileData = sr.ReadToEnd();
                    sr.Dispose();
                    s.Dispose();
                    byte[] byteData = new byte[fileData.Length];
                    System.Buffer.BlockCopy(fileData.ToCharArray(), 0, byteData, 0, byteData.Length);

                    base64Data = Convert.ToBase64String(byteData);
                }
                catch { }
            }
            else if (String.IsNullOrEmpty(inputTB.Text) == false)
            {
                chosenItem = true;
                base64Data = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(inputTB.Text));
            }
            else
            {
                uploadedFileText.Text = "Please choose one object to count";
                uploadedFileText.Visible = true;
            }
            if (chosenItem)
            {
            byteCount = client.ByteCounter(base64Data);
            byteTB.Text = ""+byteCount;
            byteTB.Visible = true;
            ByteLabel.Visible = true;
            }
            
        }
    }
}
