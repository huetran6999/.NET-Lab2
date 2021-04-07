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
    public partial class frmDetail : Form
    {
        public frmDetail()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtAdd.Text = "";
            cboDep.Text = "";
            lstEdu.ClearSelected();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtName.Text + " live in " + txtAdd.Text + " join in " + dtpickerDate.Text + " with the education of " + lstEdu.Text + "are working at department " + cboDep.Text);
        }
    }
}
