using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Services;
using InternettClient.ServiceReference1;
using System.ServiceModel;

namespace InternettClient
{
    

    public partial class LoginForm : Form
    {
        ServicePortTypeClient client;
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            
            if (loginComplete())
            {
                responseTxt.Text = "Login Complete!";
                MainForm mainForm = new MainForm(client, UserName.Text);
                mainForm.Show();

            }
            else
            {
                responseTxt.Text = "False credentials! Try again";
            }
        }

        private Boolean loginComplete()
        {
            TimeSpan TIMEOUT = new TimeSpan(0, 10, 0);
            BasicHttpBinding basicBinding = new BasicHttpBinding();
            basicBinding.SendTimeout = TIMEOUT;
            basicBinding.OpenTimeout = TIMEOUT;
            client = new ServicePortTypeClient(basicBinding, new EndpointAddress("http://localhost:8080/MainService/services/Service?wsdl"));
            if (client.Authenticate(UserName.Text, Password.Text))
            {
                return true;
            }
            return false;
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            Password.UseSystemPasswordChar = true;
        }
    }
}
