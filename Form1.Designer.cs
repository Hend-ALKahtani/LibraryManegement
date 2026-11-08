namespace LibraryManegement
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookCopiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentFinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.memberToolStripMenuItem1,
            this.booksToolStripMenuItem,
            this.bookCopiesToolStripMenuItem,
            this.borrowingsToolStripMenuItem,
            this.returnCopyToolStripMenuItem,
            this.paymentFinesToolStripMenuItem,
            this.singOutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // memberToolStripMenuItem1
            // 
            this.memberToolStripMenuItem1.Name = "memberToolStripMenuItem1";
            this.memberToolStripMenuItem1.Size = new System.Drawing.Size(64, 20);
            this.memberToolStripMenuItem1.Text = "Member";
            this.memberToolStripMenuItem1.Click += new System.EventHandler(this.memberToolStripMenuItem1_Click);
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.booksToolStripMenuItem.Text = "Books";
            this.booksToolStripMenuItem.Click += new System.EventHandler(this.booksToolStripMenuItem_Click);
            // 
            // bookCopiesToolStripMenuItem
            // 
            this.bookCopiesToolStripMenuItem.Name = "bookCopiesToolStripMenuItem";
            this.bookCopiesToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.bookCopiesToolStripMenuItem.Text = "BookCopies";
            this.bookCopiesToolStripMenuItem.Click += new System.EventHandler(this.bookCopiesToolStripMenuItem_Click);
            // 
            // borrowingsToolStripMenuItem
            // 
            this.borrowingsToolStripMenuItem.Name = "borrowingsToolStripMenuItem";
            this.borrowingsToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.borrowingsToolStripMenuItem.Text = "Borrowings";
            this.borrowingsToolStripMenuItem.Click += new System.EventHandler(this.borrowingsToolStripMenuItem_Click);
            // 
            // returnCopyToolStripMenuItem
            // 
            this.returnCopyToolStripMenuItem.Name = "returnCopyToolStripMenuItem";
            this.returnCopyToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.returnCopyToolStripMenuItem.Text = "Return Copy";
            this.returnCopyToolStripMenuItem.Click += new System.EventHandler(this.returnCopyToolStripMenuItem_Click);
            // 
            // paymentFinesToolStripMenuItem
            // 
            this.paymentFinesToolStripMenuItem.Name = "paymentFinesToolStripMenuItem";
            this.paymentFinesToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.paymentFinesToolStripMenuItem.Text = "Payment Fines";
            this.paymentFinesToolStripMenuItem.Click += new System.EventHandler(this.paymentFinesToolStripMenuItem_Click);
            // 
            // singOutToolStripMenuItem1
            // 
            this.singOutToolStripMenuItem1.Name = "singOutToolStripMenuItem1";
            this.singOutToolStripMenuItem1.Size = new System.Drawing.Size(63, 20);
            this.singOutToolStripMenuItem1.Text = "Sing out";
            this.singOutToolStripMenuItem1.Click += new System.EventHandler(this.singOutToolStripMenuItem1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::LibraryManegement.Properties.Resources.Gemini_Generated_Image_5tb6jo5tb6jo5tb6;
            this.pictureBox1.Location = new System.Drawing.Point(151, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(461, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem singOutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookCopiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentFinesToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}