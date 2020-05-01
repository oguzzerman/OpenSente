namespace OpenSente.UserControls
{
    partial class ucEGDPlayerInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpEGDInfo = new System.Windows.Forms.GroupBox();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblDateTimeLabel = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.txtTotalTournaments = new System.Windows.Forms.TextBox();
            this.txtGoR = new System.Windows.Forms.TextBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblTotalTournaments = new System.Windows.Forms.Label();
            this.lblGoR = new System.Windows.Forms.Label();
            this.txtEGDUserName = new System.Windows.Forms.TextBox();
            this.lblEGDUserName = new System.Windows.Forms.Label();
            this.grpEGDInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEGDInfo
            // 
            this.grpEGDInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpEGDInfo.Controls.Add(this.txtEGDUserName);
            this.grpEGDInfo.Controls.Add(this.lblEGDUserName);
            this.grpEGDInfo.Controls.Add(this.lblDateTime);
            this.grpEGDInfo.Controls.Add(this.lblDateTimeLabel);
            this.grpEGDInfo.Controls.Add(this.txtGrade);
            this.grpEGDInfo.Controls.Add(this.txtTotalTournaments);
            this.grpEGDInfo.Controls.Add(this.txtGoR);
            this.grpEGDInfo.Controls.Add(this.lblGrade);
            this.grpEGDInfo.Controls.Add(this.lblTotalTournaments);
            this.grpEGDInfo.Controls.Add(this.lblGoR);
            this.grpEGDInfo.Location = new System.Drawing.Point(0, 0);
            this.grpEGDInfo.Name = "grpEGDInfo";
            this.grpEGDInfo.Size = new System.Drawing.Size(364, 153);
            this.grpEGDInfo.TabIndex = 6;
            this.grpEGDInfo.TabStop = false;
            this.grpEGDInfo.Text = "EGD Bilgisi";
            // 
            // lblDateTime
            // 
            this.lblDateTime.Location = new System.Drawing.Point(137, 122);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(209, 23);
            this.lblDateTime.TabIndex = 14;
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDateTimeLabel
            // 
            this.lblDateTimeLabel.Location = new System.Drawing.Point(7, 122);
            this.lblDateTimeLabel.Name = "lblDateTimeLabel";
            this.lblDateTimeLabel.Size = new System.Drawing.Size(124, 23);
            this.lblDateTimeLabel.TabIndex = 13;
            this.lblDateTimeLabel.Text = "EGD Bilgi Alma Zamanı:";
            this.lblDateTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGrade
            // 
            this.txtGrade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGrade.Enabled = false;
            this.txtGrade.Location = new System.Drawing.Point(137, 99);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(209, 20);
            this.txtGrade.TabIndex = 9;
            // 
            // txtTotalTournaments
            // 
            this.txtTotalTournaments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalTournaments.Enabled = false;
            this.txtTotalTournaments.Location = new System.Drawing.Point(137, 73);
            this.txtTotalTournaments.Name = "txtTotalTournaments";
            this.txtTotalTournaments.Size = new System.Drawing.Size(209, 20);
            this.txtTotalTournaments.TabIndex = 11;
            // 
            // txtGoR
            // 
            this.txtGoR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGoR.Enabled = false;
            this.txtGoR.Location = new System.Drawing.Point(137, 47);
            this.txtGoR.Name = "txtGoR";
            this.txtGoR.Size = new System.Drawing.Size(209, 20);
            this.txtGoR.TabIndex = 12;
            // 
            // lblGrade
            // 
            this.lblGrade.Location = new System.Drawing.Point(7, 97);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(124, 23);
            this.lblGrade.TabIndex = 5;
            this.lblGrade.Text = "Seviye:";
            this.lblGrade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalTournaments
            // 
            this.lblTotalTournaments.Location = new System.Drawing.Point(7, 71);
            this.lblTotalTournaments.Name = "lblTotalTournaments";
            this.lblTotalTournaments.Size = new System.Drawing.Size(124, 23);
            this.lblTotalTournaments.TabIndex = 7;
            this.lblTotalTournaments.Text = "Toplam Turnuvalar:";
            this.lblTotalTournaments.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGoR
            // 
            this.lblGoR.Location = new System.Drawing.Point(7, 45);
            this.lblGoR.Name = "lblGoR";
            this.lblGoR.Size = new System.Drawing.Size(124, 23);
            this.lblGoR.TabIndex = 3;
            this.lblGoR.Text = "GoR:";
            this.lblGoR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEGDUserName
            // 
            this.txtEGDUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEGDUserName.Enabled = false;
            this.txtEGDUserName.Location = new System.Drawing.Point(137, 19);
            this.txtEGDUserName.Name = "txtEGDUserName";
            this.txtEGDUserName.Size = new System.Drawing.Size(209, 20);
            this.txtEGDUserName.TabIndex = 16;
            // 
            // lblEGDUserName
            // 
            this.lblEGDUserName.Location = new System.Drawing.Point(7, 17);
            this.lblEGDUserName.Name = "lblEGDUserName";
            this.lblEGDUserName.Size = new System.Drawing.Size(124, 23);
            this.lblEGDUserName.TabIndex = 15;
            this.lblEGDUserName.Text = "Isim:";
            this.lblEGDUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ucEGDPlayerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpEGDInfo);
            this.Name = "ucEGDPlayerInfo";
            this.Size = new System.Drawing.Size(364, 153);
            this.grpEGDInfo.ResumeLayout(false);
            this.grpEGDInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEGDInfo;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblDateTimeLabel;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.TextBox txtTotalTournaments;
        private System.Windows.Forms.TextBox txtGoR;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblTotalTournaments;
        private System.Windows.Forms.Label lblGoR;
        private System.Windows.Forms.TextBox txtEGDUserName;
        private System.Windows.Forms.Label lblEGDUserName;
    }
}
