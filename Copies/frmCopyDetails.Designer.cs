namespace LibraryManegement
{
    partial class frmCopyDetails
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
            this.ctrlCopyDetails1 = new LibraryManegement.ctrlCopyDetails();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Copy Details";
            // 
            // ctrlCopyDetails1
            // 
            this.ctrlCopyDetails1.Location = new System.Drawing.Point(25, 123);
            this.ctrlCopyDetails1.Name = "ctrlCopyDetails1";
            this.ctrlCopyDetails1.Size = new System.Drawing.Size(866, 265);
            this.ctrlCopyDetails1.TabIndex = 0;
            this.ctrlCopyDetails1.Load += new System.EventHandler(this.ctrlCopyDetails1_Load);
            // 
            // frmCopyDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(903, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlCopyDetails1);
            this.Name = "frmCopyDetails";
            this.Text = "frmCopyDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private ctrlCopyDetails ctrlCopyDetails1;
    }
}