namespace LibraryManegement
{
    partial class frmReturnCopy
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbFeesInfo = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblLateDays = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRetunDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDuDate = new System.Windows.Forms.Label();
            this.gbFeesInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Title";
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.Color.PowderBlue;
            this.txtNote.Location = new System.Drawing.Point(258, 105);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(211, 58);
            this.txtNote.TabIndex = 1;
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberName.Location = new System.Drawing.Point(254, 65);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(66, 24);
            this.lblMemberName.TabIndex = 2;
            this.lblMemberName.Text = "label2";
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTitle.Location = new System.Drawing.Point(254, 21);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(66, 24);
            this.lblBookTitle.TabIndex = 3;
            this.lblBookTitle.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Member Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Note";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(476, 342);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(364, 342);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbFeesInfo
            // 
            this.gbFeesInfo.Controls.Add(this.lblTotal);
            this.gbFeesInfo.Controls.Add(this.label10);
            this.gbFeesInfo.Controls.Add(this.lblFees);
            this.gbFeesInfo.Controls.Add(this.label8);
            this.gbFeesInfo.Controls.Add(this.lblLateDays);
            this.gbFeesInfo.Controls.Add(this.label6);
            this.gbFeesInfo.Enabled = false;
            this.gbFeesInfo.Location = new System.Drawing.Point(30, 226);
            this.gbFeesInfo.Name = "gbFeesInfo";
            this.gbFeesInfo.Size = new System.Drawing.Size(521, 110);
            this.gbFeesInfo.TabIndex = 8;
            this.gbFeesInfo.TabStop = false;
            this.gbFeesInfo.Text = "groupBox1";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(246, 68);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(54, 24);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Note";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(167, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 24);
            this.label10.TabIndex = 10;
            this.label10.Text = "Total";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.Location = new System.Drawing.Point(442, 30);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(54, 24);
            this.lblFees.TabIndex = 9;
            this.lblFees.Text = "Note";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(352, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "Fees";
            // 
            // lblLateDays
            // 
            this.lblLateDays.AutoSize = true;
            this.lblLateDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLateDays.Location = new System.Drawing.Point(246, 30);
            this.lblLateDays.Name = "lblLateDays";
            this.lblLateDays.Size = new System.Drawing.Size(54, 24);
            this.lblLateDays.TabIndex = 7;
            this.lblLateDays.Text = "Note";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Number of Late Days";
            // 
            // lblRetunDate
            // 
            this.lblRetunDate.AutoSize = true;
            this.lblRetunDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetunDate.Location = new System.Drawing.Point(254, 167);
            this.lblRetunDate.Name = "lblRetunDate";
            this.lblRetunDate.Size = new System.Drawing.Size(54, 24);
            this.lblRetunDate.TabIndex = 9;
            this.lblRetunDate.Text = "Note";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "ActualRetuenDate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "DueDate";
            // 
            // lblDuDate
            // 
            this.lblDuDate.AutoSize = true;
            this.lblDuDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuDate.Location = new System.Drawing.Point(254, 199);
            this.lblDuDate.Name = "lblDuDate";
            this.lblDuDate.Size = new System.Drawing.Size(54, 24);
            this.lblDuDate.TabIndex = 12;
            this.lblDuDate.Text = "Note";
            // 
            // frmReturnCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(606, 377);
            this.Controls.Add(this.lblDuDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRetunDate);
            this.Controls.Add(this.gbFeesInfo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBookTitle);
            this.Controls.Add(this.lblMemberName);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label1);
            this.Name = "frmReturnCopy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReturnCopy";
            this.Load += new System.EventHandler(this.frmReturnCopy_Load);
            this.gbFeesInfo.ResumeLayout(false);
            this.gbFeesInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbFeesInfo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblLateDays;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRetunDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDuDate;
    }
}