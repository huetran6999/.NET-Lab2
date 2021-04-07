
namespace Lab2_B3
{
    partial class frmFlight
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
            this.lblFlight = new System.Windows.Forms.Label();
            this.lblTNumber = new System.Windows.Forms.Label();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblDes = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.lblPNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtTNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPNumber = new System.Windows.Forms.TextBox();
            this.lstSource = new System.Windows.Forms.ListBox();
            this.lstDes = new System.Windows.Forms.ListBox();
            this.dtpickerDate = new System.Windows.Forms.DateTimePicker();
            this.lstClass = new System.Windows.Forms.ListBox();
            this.lstService = new System.Windows.Forms.CheckedListBox();
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFlight
            // 
            this.lblFlight.AutoSize = true;
            this.lblFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlight.Location = new System.Drawing.Point(65, 25);
            this.lblFlight.Name = "lblFlight";
            this.lblFlight.Size = new System.Drawing.Size(415, 38);
            this.lblFlight.TabIndex = 0;
            this.lblFlight.Text = "Flight Reservation Details";
            // 
            // lblTNumber
            // 
            this.lblTNumber.AutoSize = true;
            this.lblTNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTNumber.Location = new System.Drawing.Point(44, 103);
            this.lblTNumber.Name = "lblTNumber";
            this.lblTNumber.Size = new System.Drawing.Size(131, 24);
            this.lblTNumber.TabIndex = 1;
            this.lblTNumber.Text = "Ticket number";
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSource.Location = new System.Drawing.Point(44, 262);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(71, 24);
            this.lblSource.TabIndex = 2;
            this.lblSource.Text = "Source";
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDes.Location = new System.Drawing.Point(44, 362);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(102, 24);
            this.lblDes.TabIndex = 3;
            this.lblDes.Text = "Destination";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(44, 471);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(99, 24);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Flight Date";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(44, 530);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(55, 24);
            this.lblClass.TabIndex = 5;
            this.lblClass.Text = "Class";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.Location = new System.Drawing.Point(44, 579);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(82, 24);
            this.lblService.TabIndex = 6;
            this.lblService.Text = "Services";
            // 
            // lblPNumber
            // 
            this.lblPNumber.AutoSize = true;
            this.lblPNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPNumber.Location = new System.Drawing.Point(44, 204);
            this.lblPNumber.Name = "lblPNumber";
            this.lblPNumber.Size = new System.Drawing.Size(171, 24);
            this.lblPNumber.TabIndex = 7;
            this.lblPNumber.Text = "Passenger number";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(44, 154);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(156, 24);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Passenger Name";
            // 
            // txtTNumber
            // 
            this.txtTNumber.Location = new System.Drawing.Point(250, 105);
            this.txtTNumber.Name = "txtTNumber";
            this.txtTNumber.Size = new System.Drawing.Size(246, 22);
            this.txtTNumber.TabIndex = 9;
            this.txtTNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(250, 156);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(246, 22);
            this.txtName.TabIndex = 10;
            // 
            // txtPNumber
            // 
            this.txtPNumber.Location = new System.Drawing.Point(250, 206);
            this.txtPNumber.Name = "txtPNumber";
            this.txtPNumber.Size = new System.Drawing.Size(246, 22);
            this.txtPNumber.TabIndex = 11;
            // 
            // lstSource
            // 
            this.lstSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSource.FormattingEnabled = true;
            this.lstSource.ItemHeight = 18;
            this.lstSource.Items.AddRange(new object[] {
            "Amsterdam",
            "Ha Noi",
            "Singapore"});
            this.lstSource.Location = new System.Drawing.Point(250, 262);
            this.lstSource.Name = "lstSource";
            this.lstSource.ScrollAlwaysVisible = true;
            this.lstSource.Size = new System.Drawing.Size(240, 58);
            this.lstSource.TabIndex = 12;
            // 
            // lstDes
            // 
            this.lstDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDes.FormattingEnabled = true;
            this.lstDes.ItemHeight = 18;
            this.lstDes.Items.AddRange(new object[] {
            "Amsterdam",
            "Ha Noi",
            "Singapore"});
            this.lstDes.Location = new System.Drawing.Point(250, 362);
            this.lstDes.Name = "lstDes";
            this.lstDes.ScrollAlwaysVisible = true;
            this.lstDes.Size = new System.Drawing.Size(240, 58);
            this.lstDes.TabIndex = 13;
            // 
            // dtpickerDate
            // 
            this.dtpickerDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpickerDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpickerDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpickerDate.Location = new System.Drawing.Point(250, 471);
            this.dtpickerDate.Name = "dtpickerDate";
            this.dtpickerDate.Size = new System.Drawing.Size(241, 24);
            this.dtpickerDate.TabIndex = 14;
            // 
            // lstClass
            // 
            this.lstClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstClass.FormattingEnabled = true;
            this.lstClass.ItemHeight = 18;
            this.lstClass.Items.AddRange(new object[] {
            "Second"});
            this.lstClass.Location = new System.Drawing.Point(250, 530);
            this.lstClass.Name = "lstClass";
            this.lstClass.ScrollAlwaysVisible = true;
            this.lstClass.Size = new System.Drawing.Size(240, 22);
            this.lstClass.TabIndex = 15;
            // 
            // lstService
            // 
            this.lstService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstService.FormattingEnabled = true;
            this.lstService.Items.AddRange(new object[] {
            "Child Care",
            "Nurse"});
            this.lstService.Location = new System.Drawing.Point(250, 579);
            this.lstService.Name = "lstService";
            this.lstService.ScrollAlwaysVisible = true;
            this.lstService.Size = new System.Drawing.Size(240, 42);
            this.lstService.TabIndex = 16;
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.Location = new System.Drawing.Point(143, 672);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(115, 38);
            this.btnVerify.TabIndex = 17;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(309, 672);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 38);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 742);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.lstService);
            this.Controls.Add(this.lstClass);
            this.Controls.Add(this.dtpickerDate);
            this.Controls.Add(this.lstDes);
            this.Controls.Add(this.lstSource);
            this.Controls.Add(this.txtPNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtTNumber);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPNumber);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblDes);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.lblTNumber);
            this.Controls.Add(this.lblFlight);
            this.Name = "frmFlight";
            this.Text = "Flight Reservation Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFlight;
        private System.Windows.Forms.Label lblTNumber;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblPNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtTNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPNumber;
        private System.Windows.Forms.ListBox lstSource;
        private System.Windows.Forms.ListBox lstDes;
        private System.Windows.Forms.DateTimePicker dtpickerDate;
        private System.Windows.Forms.ListBox lstClass;
        private System.Windows.Forms.CheckedListBox lstService;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button btnClear;
    }
}

