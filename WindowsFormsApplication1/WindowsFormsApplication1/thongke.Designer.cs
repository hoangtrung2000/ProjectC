namespace WindowsFormsApplication1
{
    partial class thongke
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
            this.grdLocationViews = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdLocationViews)).BeginInit();
            this.SuspendLayout();
            // 
            // grdLocationViews
            // 
            this.grdLocationViews.AllowUserToAddRows = false;
            this.grdLocationViews.AllowUserToDeleteRows = false;
            this.grdLocationViews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLocationViews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdLocationViews.Location = new System.Drawing.Point(0, 0);
            this.grdLocationViews.Name = "grdLocationViews";
            this.grdLocationViews.ReadOnly = true;
            this.grdLocationViews.Size = new System.Drawing.Size(246, 261);
            this.grdLocationViews.TabIndex = 0;
            // 
            // thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 261);
            this.Controls.Add(this.grdLocationViews);
            this.Name = "thongke";
            this.Text = "thongke";
            ((System.ComponentModel.ISupportInitialize)(this.grdLocationViews)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdLocationViews;
    }
}