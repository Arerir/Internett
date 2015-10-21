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
    //
    //Åpnings form med inlogging via ldap serverene på HiN, setter også opp 
    //WCF tilkobling mot WebServicen som er konfigurert til localhost.
    //
    public partial class LoginForm : Form
    {
        ServicePortTypeClient client; //WCF client
        
        public LoginForm()
        {
            InitializeComponent();//setter opp komponentene som er lagt til i design delen
        }

        private void LoginBTN_Click(object sender, EventArgs e) // lytter på loginknappen
        {
            
            if (loginComplete())
            {
                //gir en respons om brukeren har logget seg på
                responseTxt.Text = "Login Complete!";
                //åpner et nytt vindu med hovedformet
                MainForm mainForm = new MainForm(client, UserName.Text);
                mainForm.Show();

            }
            else
            {
                responseTxt.Text = "False credentials! Try again"+"\n"+"Example Username: 123456@hin.no";
            }
        }

        private Boolean loginComplete()
        {
            TimeSpan TIMEOUT = new TimeSpan(0, 10, 0);                  // 10 min timeout dersom det ikke er noe svar fra serveren
            BasicHttpBinding basicBinding = new BasicHttpBinding();
            basicBinding.SendTimeout = TIMEOUT;
            basicBinding.OpenTimeout = TIMEOUT;

            //setter opp WCF forbindelsen til WebServicen
            client = new ServicePortTypeClient(basicBinding, new EndpointAddress("http://localhost:8080/MainService/services/Service?wsdl"));

            //bruker WebServicen til å autentisere login dataene.
            if (client.Authenticate(UserName.Text, Password.Text))
            {
                return true;
            }
            return false;
        }

        //skjuler passord feltet
        private void Password_TextChanged(object sender, EventArgs e)
        {
            Password.UseSystemPasswordChar = true;
        }
    }
}
