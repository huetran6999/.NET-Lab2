
namespace Lab2_B2
{
    partial class frmDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblDep = new System.Windows.Forms.Label();
            this.lblEdu = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.dtpickerDate = new System.Windows.Forms.DateTimePicker();
            this.lstEdu = new System.Windows.Forms.ListBox();
            this.cboDep = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Details";
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDep.Location = new System.Drawing.Point(26, 424);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(103, 24);
            this.lblDep.TabIndex = 1;
            this.lblDep.Text = "Deparment";
            // 
            // lblEdu
            // 
            this.lblEdu.AutoSize = true;
            this.lblEdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdu.Location = new System.Drawing.Point(26, 351);
            this.lblEdu.Name = "lblEdu";
            this.lblEdu.Size = new System.Drawing.Size(95, 24);
            this.lblEdu.TabIndex = 2;
            this.lblEdu.Text = "Education";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(26, 294);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(134, 24);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date of Joining";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(26, 170);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(171, 24);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Employee Address";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(26, 109);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(152, 24);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Employee Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(210, 111);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(336, 22);
            this.txtName.TabIndex = 6;
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(210, 170);
            this.txtAdd.Multiline = true;
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(336, 87);
            this.txtAdd.TabIndex = 7;
            // 
            // dtpickerDate
            // 
            this.dtpickerDate.Location = new System.Drawing.Point(210, 294);
            this.dtpickerDate.Name = "dtpickerDate";
            this.dtpickerDate.Size = new System.Drawing.Size(234, 22);
            this.dtpickerDate.TabIndex = 8;
            // 
            // lstEdu
            // 
            this.lstEdu.FormattingEnabled = true;
            this.lstEdu.ItemHeight = 16;
            this.lstEdu.Items.AddRange(new object[] {
            "UnderGraduate",
            "Graduate",
            "High School"});
            this.lstEdu.Location = new System.Drawing.Point(210, 351);
            this.lstEdu.Name = "lstEdu";
            this.lstEdu.Size = new System.Drawing.Size(234, 52);
            this.lstEdu.TabIndex = 9;
            // 
            // cboDep
            // 
            this.cboDep.FormattingEnabled = true;
            this.cboDep.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cboDep.Location = new System.Drawing.Point(210, 426);
            this.cboDep.Name = "cboDep";
            this.cboDep.Size = new System.Drawing.Size(234, 24);
            this.cboDep.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(65, 517);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 39);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(237, 517);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(113, 39);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(408, 517);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 39);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 608);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboDep);
            this.Controls.Add(this.lstEdu);
            this.Controls.Add(this.dtpickerDate);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblEdu);
            this.Controls.Add(this.lblDep);
            this.Controls.Add(this.label1);
            this.Name = "frmDetail";
            this.Text = "Employee Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDep;
        private System.Windows.Forms.Label lblEdu;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.DateTimePicker dtpickerDate;
        private System.Windows.Forms.ListBox lstEdu;
        private System.Windows.Forms.ComboBox cboDep;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}