namespace LibraryManegement
{
    partial class frmManageBorrowing
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewBorrowingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extendDueDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgListBorrowings)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgListBorrowings
            // 
            this.dgListBorrowings.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgListBorrowings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListBorrowings.ContextMenuStrip = this.contextMenuStrip1;
            this.dgListBorrowings.Location = new System.Drawing.Point(12, 167);
            this.dgListBorrowings.Name = "dgListBorrowings";
            this.dgListBorrowings.Size = new System.Drawing.Size(1331, 250);
            this.dgListBorrowings.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(257, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "Borrowing ID",
            "Copy ID",
            "Book Title",
            "Statues"});
            this.cbFilter.Location = new System.Drawing.Point(130, 74);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(121, 21);
            this.cbFilter.TabIndex = 2;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBorrowingToolStripMenuItem,
            this.updateBToolStripMenuItem,
            this.extendDueDateToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(182, 92);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // addNewBorrowingToolStripMenuItem
            // 
            this.addNewBorrowingToolStripMenuItem.Name = "addNewBorrowingToolStripMenuItem";
            this.addNewBorrowingToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.addNewBorrowingToolStripMenuItem.Text = "Add New Borrowing";
            this.addNewBorrowingToolStripMenuItem.Click += new System.EventHandler(this.addNewBorrowingToolStripMenuItem_Click);
            // 
            // updateBToolStripMenuItem
            // 
            this.updateBToolStripMenuItem.Name = "updateBToolStripMenuItem";
            this.updateBToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.updateBToolStripMenuItem.Text = "Update Borrowing";
            this.updateBToolStripMenuItem.Click += new System.EventHandler(this.updateBToolStripMenuItem_Click);
            // 
            // extendDueDateToolStripMenuItem
            // 
            this.extendDueDateToolStripMenuItem.Name = "extendDueDateToolStripMenuItem";
            this.extendDueDateToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.extendDueDateToolStripMenuItem.Text = "Extend Due Date";
            this.extendDueDateToolStripMenuItem.Click += new System.EventHandler(this.extendDueDateToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.reportToolStripMenuItem.Text = "Report Lost Copy";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // frmManageBorrowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 530);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgListBorrowings);
            this.Name = "frmManageBorrowing";
            this.Text = "frmManageBorrowing";
            this.Load += new System.EventHandler(this.frmManageBorrowing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListBorrowings)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgListBorrowings;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addNewBorrowingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extendDueDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
    }
}