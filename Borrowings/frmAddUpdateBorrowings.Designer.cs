namespace LibraryManegement
{
    partial class frmAddUpdateBorrowings
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbMemberInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.tpCopyInfo = new System.Windows.Forms.TabPage();
            this.btnNext2 = new System.Windows.Forms.Button();
            this.tpBorrowingInfo = new System.Windows.Forms.TabPage();
            this.dtDueDate = new System.Windows.Forms.DateTimePicker();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblStatues = new System.Windows.Forms.Label();
            this.lblBorrowDate = new System.Windows.Forms.Label();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.lblCopyID = new System.Windows.Forms.Label();
            this.lblBorrowingID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblMode = new System.Windows.Forms.Label();
            this.ctrlMemberInfoWithFilter1 = new LibraryManegement.ctrlMemberInfoWithFilter();
            this.ctrlCopyInfoWithFilter1 = new LibraryManegement.ctrlCopyInfoWithFilter();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbMemberInfo.SuspendLayout();
            this.tpCopyInfo.SuspendLayout();
            this.tpBorrowingInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbMemberInfo);
            this.tabControl1.Controls.Add(this.tpCopyInfo);
            this.tabControl1.Controls.Add(this.tpBorrowingInfo);
            this.tabControl1.Location = new System.Drawing.Point(12, 59);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1165, 622);
            this.tabControl1.TabIndex = 0;
            // 
            // tbMemberInfo
            // 
            this.tbMemberInfo.Controls.Add(this.ctrlMemberInfoWithFilter1);
            this.tbMemberInfo.Controls.Add(this.btnNext);
            this.tbMemberInfo.Location = new System.Drawing.Point(4, 22);
            this.tbMemberInfo.Name = "tbMemberInfo";
            this.tbMemberInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbMemberInfo.Size = new System.Drawing.Size(1157, 596);
            this.tbMemberInfo.TabIndex = 0;
            this.tbMemberInfo.Text = "tabPage1";
            this.tbMemberInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1066, 537);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tpCopyInfo
            // 
            this.tpCopyInfo.Controls.Add(this.btnNext2);
            this.tpCopyInfo.Controls.Add(this.ctrlCopyInfoWithFilter1);
            this.tpCopyInfo.Location = new System.Drawing.Point(4, 22);
            this.tpCopyInfo.Name = "tpCopyInfo";
            this.tpCopyInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpCopyInfo.Size = new System.Drawing.Size(1157, 596);
            this.tpCopyInfo.TabIndex = 1;
            this.tpCopyInfo.Text = "tabPage2";
            this.tpCopyInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext2
            // 
            this.btnNext2.Location = new System.Drawing.Point(882, 509);
            this.btnNext2.Name = "btnNext2";
            this.btnNext2.Size = new System.Drawing.Size(75, 23);
            this.btnNext2.TabIndex = 1;
            this.btnNext2.Text = "Next";
            this.btnNext2.UseVisualStyleBackColor = true;
            this.btnNext2.Click += new System.EventHandler(this.btnNext2_Click);
            // 
            // tpBorrowingInfo
            // 
            this.tpBorrowingInfo.Controls.Add(this.lblDueDate);
            this.tpBorrowingInfo.Controls.Add(this.dtDueDate);
            this.tpBorrowingInfo.Controls.Add(this.lblUserName);
            this.tpBorrowingInfo.Controls.Add(this.lblStatues);
            this.tpBorrowingInfo.Controls.Add(this.lblBorrowDate);
            this.tpBorrowingInfo.Controls.Add(this.lblMemberID);
            this.tpBorrowingInfo.Controls.Add(this.lblCopyID);
            this.tpBorrowingInfo.Controls.Add(this.lblBorrowingID);
            this.tpBorrowingInfo.Controls.Add(this.label8);
            this.tpBorrowingInfo.Controls.Add(this.label7);
            this.tpBorrowingInfo.Controls.Add(this.label6);
            this.tpBorrowingInfo.Controls.Add(this.label5);
            this.tpBorrowingInfo.Controls.Add(this.label4);
            this.tpBorrowingInfo.Controls.Add(this.label3);
            this.tpBorrowingInfo.Controls.Add(this.label2);
            this.tpBorrowingInfo.Controls.Add(this.label1);
            this.tpBorrowingInfo.Controls.Add(this.txtNote);
            this.tpBorrowingInfo.Location = new System.Drawing.Point(4, 22);
            this.tpBorrowingInfo.Name = "tpBorrowingInfo";
            this.tpBorrowingInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpBorrowingInfo.Size = new System.Drawing.Size(1157, 596);
            this.tpBorrowingInfo.TabIndex = 2;
            this.tpBorrowingInfo.Text = "tabPage3";
            this.tpBorrowingInfo.UseVisualStyleBackColor = true;
            // 
            // dtDueDate
            // 
            this.dtDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDueDate.Location = new System.Drawing.Point(605, 67);
            this.dtDueDate.MinDate = new System.DateTime(2026, 9, 20, 17, 39, 32, 0);
            this.dtDueDate.Name = "dtDueDate";
            this.dtDueDate.Size = new System.Drawing.Size(100, 20);
            this.dtDueDate.TabIndex = 16;
            this.dtDueDate.Value = new System.DateTime(2026, 9, 26, 0, 0, 0, 0);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(493, 133);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(68, 20);
            this.lblUserName.TabIndex = 15;
            this.lblUserName.Text = "CopyID";
            // 
            // lblStatues
            // 
            this.lblStatues.AutoSize = true;
            this.lblStatues.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatues.Location = new System.Drawing.Point(493, 94);
            this.lblStatues.Name = "lblStatues";
            this.lblStatues.Size = new System.Drawing.Size(68, 20);
            this.lblStatues.TabIndex = 14;
            this.lblStatues.Text = "CopyID";
            // 
            // lblBorrowDate
            // 
            this.lblBorrowDate.AutoSize = true;
            this.lblBorrowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowDate.Location = new System.Drawing.Point(240, 178);
            this.lblBorrowDate.Name = "lblBorrowDate";
            this.lblBorrowDate.Size = new System.Drawing.Size(39, 20);
            this.lblBorrowDate.TabIndex = 12;
            this.lblBorrowDate.Text = "???";
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberID.Location = new System.Drawing.Point(249, 133);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(39, 20);
            this.lblMemberID.TabIndex = 11;
            this.lblMemberID.Text = "???";
            // 
            // lblCopyID
            // 
            this.lblCopyID.AutoSize = true;
            this.lblCopyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyID.Location = new System.Drawing.Point(249, 94);
            this.lblCopyID.Name = "lblCopyID";
            this.lblCopyID.Size = new System.Drawing.Size(39, 20);
            this.lblCopyID.TabIndex = 10;
            this.lblCopyID.Text = "???";
            // 
            // lblBorrowingID
            // 
            this.lblBorrowingID.AutoSize = true;
            this.lblBorrowingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowingID.Location = new System.Drawing.Point(249, 52);
            this.lblBorrowingID.Name = "lblBorrowingID";
            this.lblBorrowingID.Size = new System.Drawing.Size(39, 20);
            this.lblBorrowingID.TabIndex = 9;
            this.lblBorrowingID.Text = "???";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(73, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "CopyID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(73, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "MemberID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "BorrowDate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(375, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "DueDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(384, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Statues";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(363, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(400, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Note";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "BorrowingID";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(487, 178);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(293, 79);
            this.txtNote.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(1082, 683);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(976, 683);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.Location = new System.Drawing.Point(444, 28);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(76, 25);
            this.lblMode.TabIndex = 3;
            this.lblMode.Text = "label9";
            // 
            // ctrlMemberInfoWithFilter1
            // 
            this.ctrlMemberInfoWithFilter1.EnabledFilter = true;
            this.ctrlMemberInfoWithFilter1.Location = new System.Drawing.Point(3, 0);
            this.ctrlMemberInfoWithFilter1.Name = "ctrlMemberInfoWithFilter1";
            this.ctrlMemberInfoWithFilter1.Size = new System.Drawing.Size(1046, 572);
            this.ctrlMemberInfoWithFilter1.TabIndex = 4;
            // 
            // ctrlCopyInfoWithFilter1
            // 
            this.ctrlCopyInfoWithFilter1.EnabledFilerCopy = true;
            this.ctrlCopyInfoWithFilter1.Location = new System.Drawing.Point(64, 18);
            this.ctrlCopyInfoWithFilter1.Name = "ctrlCopyInfoWithFilter1";
            this.ctrlCopyInfoWithFilter1.Size = new System.Drawing.Size(926, 385);
            this.ctrlCopyInfoWithFilter1.TabIndex = 0;
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.Location = new System.Drawing.Point(502, 52);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(39, 20);
            this.lblDueDate.TabIndex = 17;
            this.lblDueDate.Text = "???";
            // 
            // frmAddUpdateBorrowings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 749);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmAddUpdateBorrowings";
            this.Text = "frmBorrowings";
            this.Load += new System.EventHandler(this.frmBorrowings_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbMemberInfo.ResumeLayout(false);
            this.tpCopyInfo.ResumeLayout(false);
            this.tpBorrowingInfo.ResumeLayout(false);
            this.tpBorrowingInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbMemberInfo;
        private System.Windows.Forms.TabPage tpCopyInfo;
        private System.Windows.Forms.TabPage tpBorrowingInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnNext2;
        private ctrlCopyInfoWithFilter ctrlCopyInfoWithFilter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Label lblCopyID;
        private System.Windows.Forms.Label lblBorrowingID;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblStatues;
        private System.Windows.Forms.Label lblBorrowDate;
        private System.Windows.Forms.DateTimePicker dtDueDate;
        private ctrlMemberInfoWithFilter ctrlMemberInfoWithFilter1;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label lblDueDate;
    }
}