namespace WindowsFormsApplication1
{
    partial class UpdateForm
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
            this.nudTimework = new System.Windows.Forms.NumericUpDown();
            this.lblTimework = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblBirhday = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblHead = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimework)).BeginInit();
            this.SuspendLayout();
            // 
            // nudTimework
            // 
            this.nudTimework.Location = new System.Drawing.Point(281, 244);
            this.nudTimework.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudTimework.Name = "nudTimework";
            this.nudTimework.Size = new System.Drawing.Size(49, 20);
            this.nudTimework.TabIndex = 53;
            // 
            // lblTimework
            // 
            this.lblTimework.AutoSize = true;
            this.lblTimework.BackColor = System.Drawing.Color.Transparent;
            this.lblTimework.Location = new System.Drawing.Point(212, 246);
            this.lblTimework.Name = "lblTimework";
            this.lblTimework.Size = new System.Drawing.Size(59, 13);
            this.lblTimework.TabIndex = 52;
            this.lblTimework.Text = "Time Work";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(81, 104);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(88, 20);
            this.txtCode.TabIndex = 51;
            // 
            // cmbLocation
            // 
            this.cmbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Items.AddRange(new object[] {
            "Developer",
            "IT Manager",
            "HRM"});
            this.cmbLocation.Location = new System.Drawing.Point(81, 242);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(121, 21);
            this.cmbLocation.TabIndex = 50;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.BackColor = System.Drawing.Color.Transparent;
            this.lblSalary.Location = new System.Drawing.Point(346, 248);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(36, 13);
            this.lblSalary.TabIndex = 49;
            this.lblSalary.Text = "Salary";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(265, 291);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 48;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(147, 291);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 47;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(81, 171);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(200, 20);
            this.dtp.TabIndex = 46;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(81, 206);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 20);
            this.txtAddress.TabIndex = 45;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(81, 138);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 44;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(81, 73);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(69, 20);
            this.txtId.TabIndex = 43;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblLocation.Location = new System.Drawing.Point(17, 245);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(48, 13);
            this.lblLocation.TabIndex = 42;
            this.lblLocation.Text = "Location";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Location = new System.Drawing.Point(17, 209);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 41;
            this.lblAddress.Text = "Address";
            // 
            // lblBirhday
            // 
            this.lblBirhday.AutoSize = true;
            this.lblBirhday.BackColor = System.Drawing.Color.Transparent;
            this.lblBirhday.Location = new System.Drawing.Point(17, 171);
            this.lblBirhday.Name = "lblBirhday";
            this.lblBirhday.Size = new System.Drawing.Size(47, 13);
            this.lblBirhday.TabIndex = 40;
            this.lblBirhday.Text = "BirthDay";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Location = new System.Drawing.Point(17, 141);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 39;
            this.lblName.Text = "Name";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.BackColor = System.Drawing.Color.Transparent;
            this.lblCode.Location = new System.Drawing.Point(17, 107);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(32, 13);
            this.lblCode.TabIndex = 38;
            this.lblCode.Text = "Code";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Location = new System.Drawing.Point(17, 76);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 37;
            this.lblId.Text = "ID";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(385, 245);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(86, 20);
            this.txtSalary.TabIndex = 54;
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHead.ForeColor = System.Drawing.Color.Red;
            this.lblHead.Location = new System.Drawing.Point(100, 19);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(290, 37);
            this.lblHead.TabIndex = 55;
            this.lblHead.Text = "Update Information";
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 337);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.nudTimework);
            this.Controls.Add(this.lblTimework);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.cmbLocation);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblBirhday);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblId);
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudTimework)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudTimework;
        private System.Windows.Forms.Label lblTimework;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.ComboBox cmbLocation;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblBirhday;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblHead;
    }
}