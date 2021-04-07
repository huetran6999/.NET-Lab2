
namespace Lab2_B1
{
    partial class frmStudent
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
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblHobbies = new System.Windows.Forms.Label();
            this.lblDivision = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblBirth = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lstClass = new System.Windows.Forms.ListBox();
            this.cboDiv = new System.Windows.Forms.ComboBox();
            this.lstHob = new System.Windows.Forms.CheckedListBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.Location = new System.Drawing.Point(112, 28);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(342, 36);
            this.lblDetails.TabIndex = 0;
            this.lblDetails.Text = "Student\'s Class Details";
            this.lblDetails.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(15, 114);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(130, 24);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Student Name";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblHobbies
            // 
            this.lblHobbies.AutoSize = true;
            this.lblHobbies.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHobbies.Location = new System.Drawing.Point(15, 371);
            this.lblHobbies.Name = "lblHobbies";
            this.lblHobbies.Size = new System.Drawing.Size(81, 24);
            this.lblHobbies.TabIndex = 2;
            this.lblHobbies.Text = "Hobbies";
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivision.Location = new System.Drawing.Point(21, 313);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(75, 24);
            this.lblDivision.TabIndex = 3;
            this.lblDivision.Text = "Division";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(15, 230);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(135, 24);
            this.lblClass.TabIndex = 4;
            this.lblClass.Text = "Standard/Class";
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirth.Location = new System.Drawing.Point(15, 169);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(110, 24);
            this.lblBirth.TabIndex = 5;
            this.lblBirth.Text = "Year of birth";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(169, 116);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(341, 22);
            this.txtName.TabIndex = 6;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(169, 169);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(341, 22);
            this.txtYear.TabIndex = 7;
            // 
            // lstClass
            // 
            this.lstClass.FormattingEnabled = true;
            this.lstClass.ItemHeight = 16;
            this.lstClass.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV",
            "V",
            "VI",
            "VII",
            "VIII",
            "IX",
            "X"});
            this.lstClass.Location = new System.Drawing.Point(169, 230);
            this.lstClass.Name = "lstClass";
            this.lstClass.Size = new System.Drawing.Size(259, 52);
            this.lstClass.TabIndex = 8;
            // 
            // cboDiv
            // 
            this.cboDiv.FormattingEnabled = true;
            this.cboDiv.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cboDiv.Location = new System.Drawing.Point(169, 313);
            this.cboDiv.Name = "cboDiv";
            this.cboDiv.Size = new System.Drawing.Size(255, 24);
            this.cboDiv.TabIndex = 9;
            // 
            // lstHob
            // 
            this.lstHob.FormattingEnabled = true;
            this.lstHob.Items.AddRange(new object[] {
            "Singing",
            "Dancing",
            "Swimming",
            "Reading",
            "Travelling"});
            this.lstHob.Location = new System.Drawing.Point(169, 371);
            this.lstHob.Name = "lstHob";
            this.lstHob.Size = new System.Drawing.Size(250, 55);
            this.lstHob.TabIndex = 10;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirm.Location = new System.Drawing.Point(54, 491);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(248, 41);
            this.btnConfirm.TabIndex = 11;
            this.btnConfirm.Text = "Confirm Student Details";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Location = new System.Drawing.Point(354, 491);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(126, 41);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 618);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lstHob);
            this.Controls.Add(this.cboDiv);
            this.Controls.Add(this.lstClass);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblBirth);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblDivision);
            this.Controls.Add(this.lblHobbies);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDetails);
            this.Name = "frmStudent";
            this.Text = "Student Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHobbies;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.ListBox lstClass;
        private System.Windows.Forms.ComboBox cboDiv;
        private System.Windows.Forms.CheckedListBox lstHob;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnClear;
    }
}

