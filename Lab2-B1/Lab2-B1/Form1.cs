using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_B1
{
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int cnt = lstHob.CheckedItems.Count;
            string hobby= "";
            for(int index=0;index<=cnt-1;index++)
            {
                hobby = hobby + lstHob.CheckedItems[index];
                if (index < cnt - 1)
                    hobby = hobby + ",";
            }
            MessageBox.Show(txtName.Text + " born in " + txtYear.Text + " from Class " + lstClass.Text + ", Division " + cboDiv.Text + " has following hobbies " + hobby);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstClass.ClearSelected();
            cboDiv.Text = "";
            lstHob.ClearSelected();
            for(int index = 0; index <= lstHob.Items.Count - 1; index++)
            {
                if (lstHob.GetItemChecked(index))
                    lstHob.SetItemChecked(index, false);
            }
        }
    }
}
