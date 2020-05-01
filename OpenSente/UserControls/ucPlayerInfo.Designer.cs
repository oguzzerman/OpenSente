namespace OpenSente.UserControls
{
    partial class ucPlayerInfo
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
            this.grpTournamentInfo = new System.Windows.Forms.GroupBox();
            this.txtClub = new System.Windows.Forms.TextBox();
            this.txtEGDPin = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtKGSName = new System.Windows.Forms.TextBox();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.lblClub = new System.Windows.Forms.Label();
            this.lblEGDPin = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblKGSName = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.ucEGDPlayerInfo1 = new OpenSente.UserControls.ucEGDPlayerInfo();
            this.grpTournamentInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTournamentInfo
            // 
            this.grpTournamentInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTournamentInfo.Controls.Add(this.txtClub);
            this.grpTournamentInfo.Controls.Add(this.txtEGDPin);
            this.grpTournamentInfo.Controls.Add(this.txtCity);
            this.grpTournamentInfo.Controls.Add(this.txtKGSName);
            this.grpTournamentInfo.Controls.Add(this.txtPlayerName);
            this.grpTournamentInfo.Controls.Add(this.lblClub);
            this.grpTournamentInfo.Controls.Add(this.lblEGDPin);
            this.grpTournamentInfo.Controls.Add(this.lblCity);
            this.grpTournamentInfo.Controls.Add(this.lblKGSName);
            this.grpTournamentInfo.Controls.Add(this.lblPlayerName);
            this.grpTournamentInfo.Location = new System.Drawing.Point(3, 3);
            this.grpTournamentInfo.Name = "grpTournamentInfo";
            this.grpTournamentInfo.Size = new System.Drawing.Size(364, 161);
            this.grpTournamentInfo.TabIndex = 4;
            this.grpTournamentInfo.TabStop = false;
            this.grpTournamentInfo.Text = "Kullanıcı Bilgisi";
            // 
            // txtClub
            // 
            this.txtClub.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClub.Enabled = false;
            this.txtClub.Location = new System.Drawing.Point(137, 125);
            this.txtClub.Name = "txtClub";
            this.txtClub.Size = new System.Drawing.Size(209, 20);
            this.txtClub.TabIndex = 2;
            // 
            // txtEGDPin
            // 
            this.txtEGDPin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEGDPin.Enabled = false;
            this.txtEGDPin.Location = new System.Drawing.Point(137, 73);
            this.txtEGDPin.Name = "txtEGDPin";
            this.txtEGDPin.Size = new System.Drawing.Size(209, 20);
            this.txtEGDPin.TabIndex = 2;
            // 
            // txtCity
            // 
            this.txtCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCity.Enabled = false;
            this.txtCity.Location = new System.Drawing.Point(137, 99);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(209, 20);
            this.txtCity.TabIndex = 2;
            // 
            // txtKGSName
            // 
            this.txtKGSName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKGSName.Enabled = false;
            this.txtKGSName.Location = new System.Drawing.Point(137, 47);
            this.txtKGSName.Name = "txtKGSName";
            this.txtKGSName.Size = new System.Drawing.Size(209, 20);
            this.txtKGSName.TabIndex = 2;
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlayerName.Enabled = false;
            this.txtPlayerName.Location = new System.Drawing.Point(137, 21);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(209, 20);
            this.txtPlayerName.TabIndex = 2;
            // 
            // lblClub
            // 
            this.lblClub.Location = new System.Drawing.Point(7, 122);
            this.lblClub.Name = "lblClub";
            this.lblClub.Size = new System.Drawing.Size(124, 23);
            this.lblClub.TabIndex = 1;
            this.lblClub.Text = "Topluluk/Dernek:";
            this.lblClub.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEGDPin
            // 
            this.lblEGDPin.Location = new System.Drawing.Point(7, 70);
            this.lblEGDPin.Name = "lblEGDPin";
            this.lblEGDPin.Size = new System.Drawing.Size(124, 23);
            this.lblEGDPin.TabIndex = 1;
            this.lblEGDPin.Text = "EGD Pin No:";
            this.lblEGDPin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCity
            // 
            this.lblCity.Location = new System.Drawing.Point(7, 96);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(124, 23);
            this.lblCity.TabIndex = 1;
            this.lblCity.Text = "Şehir:";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblKGSName
            // 
            this.lblKGSName.Location = new System.Drawing.Point(7, 44);
            this.lblKGSName.Name = "lblKGSName";
            this.lblKGSName.Size = new System.Drawing.Size(124, 23);
            this.lblKGSName.TabIndex = 1;
            this.lblKGSName.Text = "KGS Nicki:";
            this.lblKGSName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.Location = new System.Drawing.Point(7, 18);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(124, 23);
            this.lblPlayerName.TabIndex = 0;
            this.lblPlayerName.Text = "Ad Soyad:";
            this.lblPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ucEGDPlayerInfo1
            // 
            this.ucEGDPlayerInfo1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucEGDPlayerInfo1.Location = new System.Drawing.Point(4, 168);
            this.ucEGDPlayerInfo1.Name = "ucEGDPlayerInfo1";
            this.ucEGDPlayerInfo1.Size = new System.Drawing.Size(364, 135);
            this.ucEGDPlayerInfo1.TabIndex = 5;
            // 
            // ucPlayerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucEGDPlayerInfo1);
            this.Controls.Add(this.grpTournamentInfo);
            this.Name = "ucPlayerInfo";
            this.Size = new System.Drawing.Size(371, 308);
            this.grpTournamentInfo.ResumeLayout(false);
            this.grpTournamentInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpTournamentInfo;
        private System.Windows.Forms.TextBox txtClub;
        private System.Windows.Forms.TextBox txtEGDPin;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtKGSName;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label lblClub;
        private System.Windows.Forms.Label lblEGDPin;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblKGSName;
        private System.Windows.Forms.Label lblPlayerName;
        private ucEGDPlayerInfo ucEGDPlayerInfo1;
    }
}
