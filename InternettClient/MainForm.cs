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
            sbyte[] sdata = client.ReturnQRPicture(Username);
            byte[] data = new byte[sdata.Length];
            for(int i=0; i < sdata.Length; i++)
            {
                data[i] = Convert.ToByte(sdata[i]);
            }
            MemoryStream mStream = new MemoryStream();
            mStream.Write(data, 0, data.Length);
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            qrPicture.Image = bm;
            qrPicture.Visible = true;
           
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            inputTB.Text = "";
            qrCheckBox.Checked = false;
            Stream FileStream;
            String jsonString = "";
            int byteCount = 0;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                uploadedFileText.Text = openFileDialog1.FileName;
                uploadedFileText.Visible = true;
                FileStream = openFileDialog1.OpenFile();
                StreamReader reader = new StreamReader(FileStream);
                String File = reader.ReadToEnd();    
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
            if (qrCheckBox.Checked)
            {

            }
            else if (String.IsNullOrEmpty(uploadedFileText.Text) == false)
            {
                int i = 0;
            }
            else if (String.IsNullOrEmpty(inputTB.Text) == false)
            {
                int i = 0;
            }
            else
            {
                uploadedFileText.Text = "Please choose one object to count";
                uploadedFileText.Visible = true;
            }
        }
    }
}
