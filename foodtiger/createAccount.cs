using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foodtiger
{
    public partial class createAccount : Form
    {
        controller controller = new controller();
        public createAccount()
        {
            InitializeComponent();
        }

        private void createAccount_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateAc_Click(object sender, EventArgs e)
        {
            if (controller.createAccount(txtCreateAc.Text, txtCreatePwd.Text))
            {
                this.Close();
            }
            
        }
    }
}
