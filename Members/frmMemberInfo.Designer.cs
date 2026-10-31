namespace LibraryManegement
{
    partial class frmMemberInfo
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
            this.ctrlMemberInfo1 = new LibraryManegement.ctrlMemberInfo();
            this.SuspendLayout();
            // 
            // ctrlMemberInfo1
            // 
            this.ctrlMemberInfo1.Location = new System.Drawing.Point(12, 31);
            this.ctrlMemberInfo1.Name = "ctrlMemberInfo1";
            this.ctrlMemberInfo1.Size = new System.Drawing.Size(968, 564);
            this.ctrlMemberInfo1.TabIndex = 0;
            // 
            // frmMemberInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 646);
            this.Controls.Add(this.ctrlMemberInfo1);
            this.Name = "frmMemberInfo";
            this.Text = "frmMemberInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlMemberInfo ctrlMemberInfo1;
    }
}