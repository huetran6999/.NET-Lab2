using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_B3
{
    public partial class frmFlight : Form
    {
        public frmFlight()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lstSource.Text.Equals(lstDes.Text))
                MessageBox.Show("The Source and Destination cannot be the same. Please enter again!!!");
            else
            {
                MessageBox.Show("Verified Successfully!!!");
                this.Close();
            }
                
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtTNumber.Text = "";
            txtPNumber.Text = "";
            txtName.Text = "";
            lstSource.ClearSelected();
            lstDes.ClearSelected();
            lstClass.ClearSelected();
            lstService.ClearSelected();
            for(int index = 0; index <= lstService.Items.Count - 1; index++)
            {
                if (lstService.GetItemChecked(index))
                    lstService.SetItemChecked(index, false);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
