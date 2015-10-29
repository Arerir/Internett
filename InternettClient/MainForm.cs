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
    //
    //Hovedformet med gui for å benytte seg av de forskjellige WebService
    //metodene. benytter seg av samme WCF klient som blir satt opp i LoginForm.
    //
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

        //Lytter som henter qr-bildet fra WebServicen og setter det opp i pictureBox 
        //som ligger i formet.
        private void getQRPictureBTN_Click(object sender, EventArgs e)
        {
            byte[] data = client.ReturnQRPicture(Username);

            string base64String = System.Text.Encoding.Default.GetString(data);
            byte[] tmp2 = Convert.FromBase64String(base64String);

            ImageConverter converter = new ImageConverter();
            qrPicture.Image = converter.ConvertFrom(tmp2) as Image;
            qrPicture.Visible = true;           
        }

        //Bruker en fil dialog til å hente fil path for å hente filen senere og fjerner eventuel
        //data i de andre feltene
        private void FileButton_Click(object sender, EventArgs e)
        {
            inputTB.Text = "";
            qrCheckBox.Checked = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                uploadedFileText.Text = openFileDialog1.FileName;
                uploadedFileText.Visible = true;  
            }            
        }

        //Dersom man vil se hvor mange byte det er i qr-bildet velgen man denne, den fjerner 
        //også data i de andre feltene
        private void qrCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            inputTB.Text = "";
            uploadedFileText.Text = "";
        }

        //Fjerner data i de andre feltene om det blir skrevet noe i input feltet
        private void inputTB_TextChanged(object sender, EventArgs e)
        {
            qrCheckBox.Checked = false;
            uploadedFileText.Text = "";
        }

        private void byteCountBTN_Click(object sender, EventArgs e)
        {
            int byteCount = 0;
            String base64Data = "";
            bool chosenItem = false;

            //Utfører en bytecount på brukerens valgte måte ved å convertere byte array om til base64 string
            //Bruker med vilje forskjellige metoder for å convertere til byte array
            if (qrCheckBox.Checked)
            {
                Image picture = qrPicture.Image;
                chosenItem = true;

                //serialiserer bildet og konverterer det om til en base64 string
                using (MemoryStream ms = new MemoryStream())
                {
                    picture.Save(ms, ImageFormat.Png);
                    byte[] imageBytes = ms.ToArray();
                    base64Data = Convert.ToBase64String(imageBytes);
                }
            }
            else if (String.IsNullOrEmpty(uploadedFileText.Text) == false)
            {
                //henter filen som er valgt og gjør daten om til base64 string
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
                //konverterer input til base64 string
                chosenItem = true;
                base64Data = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(inputTB.Text));
            }
            else
            {
                //gir respons til brukeren om at det ikke er noe som er valgt for å 
                //sendes til bytecounteren i WebServicen
                uploadedFileText.Text = "Please choose one object to count";
                uploadedFileText.Visible = true;
            }
            if (chosenItem)
            {
                //dersom det er noe som er valgt vil dette sende til base64 stringen til WebServicen 
                //og vise dette til brukeren
                byteCount = client.ByteCounter(base64Data);
                byteTB.Text = "" + byteCount;
                byteTB.Visible = true;
                ByteLabel.Visible = true;
            }
            
        }
    }
}
