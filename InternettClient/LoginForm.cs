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

namespace InternettClient
{
    

    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
            
        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            
            if (loginComplete())
            {
                responseTxt.Text = "Login Complete!";

            }
            else
            {
                responseTxt.Text = "False credentials! Try again";
            }
        }

        private Boolean loginComplete()
        {
            ServicePortTypeClient client = new ServicePortTypeClient();

            if (AuthenticateClient())
            {
                return true;
            }
            return false;
        }
        private Boolean AuthenticateClient()
        {
            Boolean result = false;
            

            return result;
        }
    }
}
