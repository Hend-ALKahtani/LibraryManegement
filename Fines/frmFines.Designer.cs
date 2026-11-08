namespace LibraryManegement
{
    partial class frmFines
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLostCopyFines = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpAllFines = new System.Windows.Forms.TabPage();
            this.dgAllFines = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.tbpFinesLost = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tbpOverDueFines = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvOverDueFines = new System.Windows.Forms.DataGridView();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbIsPaid = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLostCopyFines)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbpAllFines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAllFines)).BeginInit();
            this.tbpFinesLost.SuspendLayout();
            this.tbpOverDueFines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverDueFines)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(493, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fines";
            // 
            // dgvLostCopyFines
            // 
            this.dgvLostCopyFines.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvLostCopyFines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLostCopyFines.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvLostCopyFines.Location = new System.Drawing.Point(3, 103);
            this.dgvLostCopyFines.Name = "dgvLostCopyFines";
            this.dgvLostCopyFines.Size = new System.Drawing.Size(1068, 327);
            this.dgvLostCopyFines.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paymentToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.paymentToolStripMenuItem.Text = "Payment";
            this.paymentToolStripMenuItem.Click += new System.EventHandler(this.paymentToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpAllFines);
            this.tabControl1.Controls.Add(this.tbpFinesLost);
            this.tabControl1.Controls.Add(this.tbpOverDueFines);
            this.tabControl1.Location = new System.Drawing.Point(53, 121);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1088, 472);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tbpAllFines
            // 
            this.tbpAllFines.BackColor = System.Drawing.Color.LightBlue;
            this.tbpAllFines.Controls.Add(this.dgAllFines);
            this.tbpAllFines.Controls.Add(this.label5);
            this.tbpAllFines.Location = new System.Drawing.Point(4, 22);
            this.tbpAllFines.Name = "tbpAllFines";
            this.tbpAllFines.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAllFines.Size = new System.Drawing.Size(1080, 446);
            this.tbpAllFines.TabIndex = 2;
            this.tbpAllFines.Text = "tabPage3";
            // 
            // dgAllFines
            // 
            this.dgAllFines.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgAllFines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAllFines.ContextMenuStrip = this.contextMenuStrip1;
            this.dgAllFines.Location = new System.Drawing.Point(6, 96);
            this.dgAllFines.Name = "dgAllFines";
            this.dgAllFines.Size = new System.Drawing.Size(1068, 310);
            this.dgAllFines.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(462, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "All Fines";
            // 
            // tbpFinesLost
            // 
            this.tbpFinesLost.BackColor = System.Drawing.Color.LightBlue;
            this.tbpFinesLost.Controls.Add(this.label3);
            this.tbpFinesLost.Controls.Add(this.dgvLostCopyFines);
            this.tbpFinesLost.Location = new System.Drawing.Point(4, 22);
            this.tbpFinesLost.Name = "tbpFinesLost";
            this.tbpFinesLost.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFinesLost.Size = new System.Drawing.Size(1080, 446);
            this.tbpFinesLost.TabIndex = 0;
            this.tbpFinesLost.Text = "tabPage1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(342, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fines Report Lost Copy";
            // 
            // tbpOverDueFines
            // 
            this.tbpOverDueFines.BackColor = System.Drawing.Color.LightBlue;
            this.tbpOverDueFines.Controls.Add(this.label2);
            this.tbpOverDueFines.Controls.Add(this.dgvOverDueFines);
            this.tbpOverDueFines.Location = new System.Drawing.Point(4, 22);
            this.tbpOverDueFines.Name = "tbpOverDueFines";
            this.tbpOverDueFines.Padding = new System.Windows.Forms.Padding(3);
            this.tbpOverDueFines.Size = new System.Drawing.Size(1080, 446);
            this.tbpOverDueFines.TabIndex = 1;
            this.tbpOverDueFines.Text = "tabPage2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(395, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fines over Due Days";
            // 
            // dgvOverDueFines
            // 
            this.dgvOverDueFines.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvOverDueFines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOverDueFines.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvOverDueFines.Location = new System.Drawing.Point(18, 73);
            this.dgvOverDueFines.Name = "dgvOverDueFines";
            this.dgvOverDueFines.Size = new System.Drawing.Size(1056, 298);
            this.dgvOverDueFines.TabIndex = 0;
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(331, 67);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(100, 20);
            this.txtFilter.TabIndex = 10;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "Library Card Number",
            "Borrowing ID",
            "Fine Type",
            "Is Paid"});
            this.cbFilter.Location = new System.Drawing.Point(182, 66);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(121, 21);
            this.cbFilter.TabIndex = 9;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(70, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fines";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1020, 599);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbIsPaid
            // 
            this.cbIsPaid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsPaid.FormattingEnabled = true;
            this.cbIsPaid.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsPaid.Location = new System.Drawing.Point(331, 67);
            this.cbIsPaid.Name = "cbIsPaid";
            this.cbIsPaid.Size = new System.Drawing.Size(121, 21);
            this.cbIsPaid.TabIndex = 12;
            this.cbIsPaid.SelectedIndexChanged += new System.EventHandler(this.cbIsPaid_SelectedIndexChanged);
            // 
            // frmFines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1200, 644);
            this.Controls.Add(this.cbIsPaid);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmFines";
            this.Text = "frmFines";
            this.Load += new System.EventHandler(this.frmFines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLostCopyFines)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbpAllFines.ResumeLayout(false);
            this.tbpAllFines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAllFines)).EndInit();
            this.tbpFinesLost.ResumeLayout(false);
            this.tbpFinesLost.PerformLayout();
            this.tbpOverDueFines.ResumeLayout(false);
            this.tbpOverDueFines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverDueFines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLostCopyFines;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpFinesLost;
        private System.Windows.Forms.TabPage tbpOverDueFines;
        private System.Windows.Forms.DataGridView dgvOverDueFines;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem paymentToolStripMenuItem;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tbpAllFines;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgAllFines;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cbIsPaid;
    }
}