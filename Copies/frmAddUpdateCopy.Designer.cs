namespace LibraryManegement
{
    partial class frmAddUpdateCopy
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
            this.tpcInfo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.tpCopyInfo = new System.Windows.Forms.TabPage();
            this.cbStatusCopy = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRenewBarcode = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chBoxIsAvailable = new System.Windows.Forms.CheckBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.ctrlBookInfoWithFilter1 = new LibraryManegement.ctrlBookInfoWithFilter();
            this.tpcInfo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tpCopyInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpcInfo
            // 
            this.tpcInfo.Controls.Add(this.tabPage1);
            this.tpcInfo.Controls.Add(this.tpCopyInfo);
            this.tpcInfo.Location = new System.Drawing.Point(24, 58);
            this.tpcInfo.Name = "tpcInfo";
            this.tpcInfo.SelectedIndex = 0;
            this.tpcInfo.Size = new System.Drawing.Size(1009, 637);
            this.tpcInfo.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightBlue;
            this.tabPage1.Controls.Add(this.btnNext);
            this.tabPage1.Controls.Add(this.ctrlBookInfoWithFilter1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1001, 611);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(763, 575);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tpCopyInfo
            // 
            this.tpCopyInfo.BackColor = System.Drawing.Color.LightBlue;
            this.tpCopyInfo.Controls.Add(this.cbStatusCopy);
            this.tpCopyInfo.Controls.Add(this.label6);
            this.tpCopyInfo.Controls.Add(this.btnRenewBarcode);
            this.tpCopyInfo.Controls.Add(this.lblID);
            this.tpCopyInfo.Controls.Add(this.label4);
            this.tpCopyInfo.Controls.Add(this.label3);
            this.tpCopyInfo.Controls.Add(this.chBoxIsAvailable);
            this.tpCopyInfo.Controls.Add(this.txtBarcode);
            this.tpCopyInfo.Controls.Add(this.label2);
            this.tpCopyInfo.Location = new System.Drawing.Point(4, 22);
            this.tpCopyInfo.Name = "tpCopyInfo";
            this.tpCopyInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpCopyInfo.Size = new System.Drawing.Size(1001, 611);
            this.tpCopyInfo.TabIndex = 1;
            this.tpCopyInfo.Text = "tabPage2";
            // 
            // cbStatusCopy
            // 
            this.cbStatusCopy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusCopy.Enabled = false;
            this.cbStatusCopy.FormattingEnabled = true;
            this.cbStatusCopy.Items.AddRange(new object[] {
            "New",
            "Good",
            "Damage"});
            this.cbStatusCopy.Location = new System.Drawing.Point(181, 195);
            this.cbStatusCopy.Name = "cbStatusCopy";
            this.cbStatusCopy.Size = new System.Drawing.Size(121, 21);
            this.cbStatusCopy.TabIndex = 8;
            this.cbStatusCopy.SelectedIndexChanged += new System.EventHandler(this.cbStatusCopy_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Condition";
            // 
            // btnRenewBarcode
            // 
            this.btnRenewBarcode.Enabled = false;
            this.btnRenewBarcode.Location = new System.Drawing.Point(306, 90);
            this.btnRenewBarcode.Name = "btnRenewBarcode";
            this.btnRenewBarcode.Size = new System.Drawing.Size(115, 38);
            this.btnRenewBarcode.TabIndex = 6;
            this.btnRenewBarcode.Text = "Renew BarCode";
            this.btnRenewBarcode.UseVisualStyleBackColor = true;
            this.btnRenewBarcode.Click += new System.EventHandler(this.btnRenewBarcode_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(176, 48);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(51, 25);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Barcode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "IsAvailable";
            // 
            // chBoxIsAvailable
            // 
            this.chBoxIsAvailable.AutoSize = true;
            this.chBoxIsAvailable.Checked = true;
            this.chBoxIsAvailable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBoxIsAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxIsAvailable.Location = new System.Drawing.Point(181, 149);
            this.chBoxIsAvailable.Name = "chBoxIsAvailable";
            this.chBoxIsAvailable.Size = new System.Drawing.Size(106, 24);
            this.chBoxIsAvailable.TabIndex = 2;
            this.chBoxIsAvailable.Text = "checkBox1";
            this.chBoxIsAvailable.UseVisualStyleBackColor = true;
            this.chBoxIsAvailable.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(181, 100);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.ReadOnly = true;
            this.txtBarcode.Size = new System.Drawing.Size(100, 20);
            this.txtBarcode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "CopyID";
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.BackColor = System.Drawing.Color.White;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.ForeColor = System.Drawing.Color.Black;
            this.lblMode.Location = new System.Drawing.Point(406, 26);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(85, 29);
            this.lblMode.TabIndex = 1;
            this.lblMode.Text = "label1";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(607, 697);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(700, 697);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ctrlBookInfoWithFilter1
            // 
            this.ctrlBookInfoWithFilter1.EnabledFilterBook = true;
            this.ctrlBookInfoWithFilter1.FilterEnabled = true;
            this.ctrlBookInfoWithFilter1.Location = new System.Drawing.Point(17, 40);
            this.ctrlBookInfoWithFilter1.Name = "ctrlBookInfoWithFilter1";
            this.ctrlBookInfoWithFilter1.Size = new System.Drawing.Size(919, 518);
            this.ctrlBookInfoWithFilter1.TabIndex = 0;
            // 
            // frmAddUpdateCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1126, 749);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.tpcInfo);
            this.Name = "frmAddUpdateCopy";
            this.Text = "frmAddUpdateCopy";
            this.Load += new System.EventHandler(this.frmAddUpdateCopy_Load);
            this.tpcInfo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tpCopyInfo.ResumeLayout(false);
            this.tpCopyInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tpcInfo;
        private System.Windows.Forms.TabPage tabPage1;
        private ctrlBookInfoWithFilter ctrlBookInfoWithFilter1;
        private System.Windows.Forms.TabPage tpCopyInfo;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chBoxIsAvailable;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Button btnRenewBarcode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbStatusCopy;
    }
}