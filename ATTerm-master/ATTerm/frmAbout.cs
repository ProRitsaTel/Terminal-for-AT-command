using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATTerm
{
    public partial class frmAbout : Form
    {
        string strVersion = "";
        public frmAbout()
        {
            InitializeComponent();
            strVersion = Application.ProductVersion;

            txtAbout.Text = "          AT GSM Test Application        " + Environment.NewLine +
                "             version: 1.0.0.10         " + Environment.NewLine +
                "          MH Carson       " + Environment.NewLine +
                "" + Environment.NewLine +
                " Donations and Assistance: https://ko-fi.com/markcarson" + Environment.NewLine +
                " https://github.com/markharleycarson/ATTerm " + Environment.NewLine +
                
                "Application Version" + strVersion +
                "" +
                "  (based on original idea https://github.com/oakkar7 and ATCommand?) ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
