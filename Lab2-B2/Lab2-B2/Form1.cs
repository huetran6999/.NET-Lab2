using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_B2
{
    public partial class frmLogin : Form
    {
       
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string user = "admin";
            string password = "admin";
            if (user.Equals(txtUsername.Text) && password.Equals(txtPassword.Text))
            {
                frmDetail frm = new frmDetail();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Incorrect Username or Password!!!");
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
