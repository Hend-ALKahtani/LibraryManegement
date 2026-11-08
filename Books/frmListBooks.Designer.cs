namespace LibraryManegement
{
    partial class frmListBooks
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
            this.button1 = new System.Windows.Forms.Button();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showBookInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCountRecord = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(890, 566);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvBooks.Location = new System.Drawing.Point(12, 297);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.Size = new System.Drawing.Size(953, 203);
            this.dgvBooks.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBookToolStripMenuItem,
            this.updateBookToolStripMenuItem,
            this.deleteBookToolStripMenuItem,
            this.showBookInfoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(158, 92);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // addNewBookToolStripMenuItem
            // 
            this.addNewBookToolStripMenuItem.Name = "addNewBookToolStripMenuItem";
            this.addNewBookToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.addNewBookToolStripMenuItem.Text = "Add New Book";
            this.addNewBookToolStripMenuItem.Click += new System.EventHandler(this.addNewBookToolStripMenuItem_Click);
            // 
            // updateBookToolStripMenuItem
            // 
            this.updateBookToolStripMenuItem.Name = "updateBookToolStripMenuItem";
            this.updateBookToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.updateBookToolStripMenuItem.Text = "Update Book";
            this.updateBookToolStripMenuItem.Click += new System.EventHandler(this.updateBookToolStripMenuItem_Click);
            // 
            // deleteBookToolStripMenuItem
            // 
            this.deleteBookToolStripMenuItem.Name = "deleteBookToolStripMenuItem";
            this.deleteBookToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.deleteBookToolStripMenuItem.Text = "Delete Book";
            this.deleteBookToolStripMenuItem.Click += new System.EventHandler(this.deleteBookToolStripMenuItem_Click);
            // 
            // showBookInfoToolStripMenuItem
            // 
            this.showBookInfoToolStripMenuItem.Name = "showBookInfoToolStripMenuItem";
            this.showBookInfoToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.showBookInfoToolStripMenuItem.Text = "Show Book Info";
            this.showBookInfoToolStripMenuItem.Click += new System.EventHandler(this.showBookInfoToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(413, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "List Books";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(248, 149);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(100, 20);
            this.txtFilter.TabIndex = 3;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "Book ID",
            "Book Title",
            "Author",
            "Category",
            "Puplisher",
            "ISBN"});
            this.cbFilter.Location = new System.Drawing.Point(112, 148);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(121, 21);
            this.cbFilter.TabIndex = 4;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // lblCountRecord
            // 
            this.lblCountRecord.AutoSize = true;
            this.lblCountRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountRecord.Location = new System.Drawing.Point(124, 566);
            this.lblCountRecord.Name = "lblCountRecord";
            this.lblCountRecord.Size = new System.Drawing.Size(43, 24);
            this.lblCountRecord.TabIndex = 6;
            this.lblCountRecord.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 566);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Record(s)";
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(808, 73);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(135, 70);
            this.btnBook.TabIndex = 8;
            this.btnBook.Text = "Adding Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // frmListBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1047, 633);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCountRecord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.button1);
            this.Name = "frmListBooks";
            this.Text = "frmListBooks";
            this.Load += new System.EventHandler(this.frmListBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCountRecord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addNewBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showBookInfoToolStripMenuItem;
        private System.Windows.Forms.Button btnBook;
    }
}