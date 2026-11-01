namespace LibraryManegement
{
    partial class frmListCopiesOfBooks
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
            this.dgListCopyies = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCopyDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.damageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewBracodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.lblCountRecords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbIsVailable = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgListCopyies)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgListCopyies
            // 
            this.dgListCopyies.AllowUserToAddRows = false;
            this.dgListCopyies.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dgListCopyies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListCopyies.ContextMenuStrip = this.contextMenuStrip1;
            this.dgListCopyies.Location = new System.Drawing.Point(44, 158);
            this.dgListCopyies.Name = "dgListCopyies";
            this.dgListCopyies.Size = new System.Drawing.Size(1013, 235);
            this.dgListCopyies.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCopyToolStripMenuItem,
            this.deleteCopyToolStripMenuItem,
            this.showCopyDetailsToolStripMenuItem,
            this.updateCopyToolStripMenuItem,
            this.renewBracodeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(197, 114);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // addCopyToolStripMenuItem
            // 
            this.addCopyToolStripMenuItem.Name = "addCopyToolStripMenuItem";
            this.addCopyToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.addCopyToolStripMenuItem.Text = "Add Copy";
            this.addCopyToolStripMenuItem.Click += new System.EventHandler(this.addCopyToolStripMenuItem_Click);
            // 
            // deleteCopyToolStripMenuItem
            // 
            this.deleteCopyToolStripMenuItem.Name = "deleteCopyToolStripMenuItem";
            this.deleteCopyToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.deleteCopyToolStripMenuItem.Text = "Delete Copy";
            this.deleteCopyToolStripMenuItem.Click += new System.EventHandler(this.deleteCopyToolStripMenuItem_Click);
            // 
            // showCopyDetailsToolStripMenuItem
            // 
            this.showCopyDetailsToolStripMenuItem.Name = "showCopyDetailsToolStripMenuItem";
            this.showCopyDetailsToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.showCopyDetailsToolStripMenuItem.Text = "Show Copy Details";
            this.showCopyDetailsToolStripMenuItem.Click += new System.EventHandler(this.showCopyDetailsToolStripMenuItem_Click);
            // 
            // updateCopyToolStripMenuItem
            // 
            this.updateCopyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.goodToolStripMenuItem,
            this.damageToolStripMenuItem});
            this.updateCopyToolStripMenuItem.Name = "updateCopyToolStripMenuItem";
            this.updateCopyToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.updateCopyToolStripMenuItem.Text = "Update Stause Of Copy";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.DoubleClick += new System.EventHandler(this.Status_DoubleClick);
            // 
            // goodToolStripMenuItem
            // 
            this.goodToolStripMenuItem.Name = "goodToolStripMenuItem";
            this.goodToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.goodToolStripMenuItem.Text = "Good";
            this.goodToolStripMenuItem.DoubleClick += new System.EventHandler(this.Status_DoubleClick);
            // 
            // damageToolStripMenuItem
            // 
            this.damageToolStripMenuItem.Name = "damageToolStripMenuItem";
            this.damageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.damageToolStripMenuItem.Text = "Damage";
            this.damageToolStripMenuItem.DoubleClick += new System.EventHandler(this.Status_DoubleClick);
            // 
            // renewBracodeToolStripMenuItem
            // 
            this.renewBracodeToolStripMenuItem.Name = "renewBracodeToolStripMenuItem";
            this.renewBracodeToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.renewBracodeToolStripMenuItem.Text = "Renew Bracode";
            this.renewBracodeToolStripMenuItem.Click += new System.EventHandler(this.renewBracodeToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "FilterBy";
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "Copy ID",
            "Book ID",
            "Book Title",
            "Is Available",
            "Copy Status"});
            this.cbFilter.Location = new System.Drawing.Point(155, 101);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(121, 21);
            this.cbFilter.TabIndex = 3;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(155, 62);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(100, 20);
            this.txtFilter.TabIndex = 4;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // lblCountRecords
            // 
            this.lblCountRecords.AutoSize = true;
            this.lblCountRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountRecords.Location = new System.Drawing.Point(134, 490);
            this.lblCountRecords.Name = "lblCountRecords";
            this.lblCountRecords.Size = new System.Drawing.Size(43, 24);
            this.lblCountRecords.TabIndex = 5;
            this.lblCountRecords.Text = "###";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 490);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // cbIsVailable
            // 
            this.cbIsVailable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsVailable.FormattingEnabled = true;
            this.cbIsVailable.Items.AddRange(new object[] {
            "All",
            "yes",
            "No"});
            this.cbIsVailable.Location = new System.Drawing.Point(282, 103);
            this.cbIsVailable.Name = "cbIsVailable";
            this.cbIsVailable.Size = new System.Drawing.Size(121, 21);
            this.cbIsVailable.TabIndex = 7;
            // 
            // frmListCopiesOfBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 536);
            this.Controls.Add(this.cbIsVailable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCountRecords);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgListCopyies);
            this.Name = "frmListCopiesOfBooks";
            this.Text = "frmListCopiesOfBooks";
            this.Load += new System.EventHandler(this.frmListCopiesOfBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListCopyies)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgListCopyies;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label lblCountRecords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbIsVailable;
        private System.Windows.Forms.ToolStripMenuItem addCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showCopyDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewBracodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem damageToolStripMenuItem;
    }
}