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

namespace InternettClient
{
    public partial class MainForm : Form
    {
        ServicePortTypeClient client;
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(ServicePortTypeClient client)
        {
            this.client = client;
            InitializeComponent();
        }
    }
}
