namespace LibraryManegement
{
    partial class frmActiveBorrowingsList
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
            this.components = new System.ComponentModel.Container();
            this.dgListBorrowings = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.returnCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgListBorrowings)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgListBorrowings
            // 
            this.dgListBorrowings.AllowUserToAddRows = false;
            this.dgListBorrowings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgListBorrowings.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgListBorrowings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListBorrowings.ContextMenuStrip = this.contextMenuStrip1;
            this.dgListBorrowings.Location = new System.Drawing.Point(-10, 182);
            this.dgListBorrowings.Name = "dgListBorrowings";
            this.dgListBorrowings.Size = new System.Drawing.Size(1232, 183);
            this.dgListBorrowings.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnCopyToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // returnCopyToolStripMenuItem
            // 
            this.returnCopyToolStripMenuItem.Name = "returnCopyToolStripMenuItem";
            this.returnCopyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.returnCopyToolStripMenuItem.Text = "Return Copy";
            this.returnCopyToolStripMenuItem.Click += new System.EventHandler(this.returnCopyToolStripMenuItem_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(261, 59);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(100, 20);
            this.txtFilter.TabIndex = 2;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "Barcode",
            "Borrowing ID"});
            this.cbFilter.Location = new System.Drawing.Point(112, 62);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(121, 21);
            this.cbFilter.TabIndex = 4;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // frmActiveBorrowingsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1317, 450);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.dgListBorrowings);
            this.Name = "frmActiveBorrowingsList";
            this.Text = "frmActiveBorrowingsList";
            this.Load += new System.EventHandler(this.frmActiveBorrowingsList_Load);
            this.Click += new System.EventHandler(this.frmActiveBorrowingsList_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgListBorrowings)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgListBorrowings;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem returnCopyToolStripMenuItem;
    }
}