namespace LibraryManegement
{
    partial class frmShowBookInfo
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
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlBookInfo1 = new LibraryManegement.ctrlBookInfo();
            this.dgvCopiesForBooks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCopiesForBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(804, 639);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(391, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Book Info";
            // 
            // ctrlBookInfo1
            // 
            this.ctrlBookInfo1.Location = new System.Drawing.Point(26, 76);
            this.ctrlBookInfo1.Name = "ctrlBookInfo1";
            this.ctrlBookInfo1.Size = new System.Drawing.Size(833, 306);
            this.ctrlBookInfo1.TabIndex = 3;
            // 
            // dgvCopiesForBooks
            // 
            this.dgvCopiesForBooks.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dgvCopiesForBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCopiesForBooks.Location = new System.Drawing.Point(49, 432);
            this.dgvCopiesForBooks.Name = "dgvCopiesForBooks";
            this.dgvCopiesForBooks.Size = new System.Drawing.Size(830, 150);
            this.dgvCopiesForBooks.TabIndex = 4;
            // 
            // frmShowBookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 674);
            this.Controls.Add(this.dgvCopiesForBooks);
            this.Controls.Add(this.ctrlBookInfo1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Name = "frmShowBookInfo";
            this.Text = "frmShowBookInfo";
            this.Load += new System.EventHandler(this.frmShowBookInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCopiesForBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private ctrlBookInfo ctrlBookInfo1;
        private System.Windows.Forms.DataGridView dgvCopiesForBooks;
    }
}