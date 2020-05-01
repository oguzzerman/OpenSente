namespace OpenSente.UserControls
{
    partial class ucRequestPlayerFromEGD
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
            this.txtEGDPin = new System.Windows.Forms.TextBox();
            this.lblEGDPin = new System.Windows.Forms.Label();
            this.ucEGDPlayerInfo1 = new OpenSente.UserControls.ucEGDPlayerInfo();
            this.hfbRequestPlayer = new OpenSente.UserControls.HighlightFancyButton();
            this.SuspendLayout();
            // 
            // txtEGDPin
            // 
            this.txtEGDPin.Location = new System.Drawing.Point(62, 12);
            this.txtEGDPin.Name = "txtEGDPin";
            this.txtEGDPin.Size = new System.Drawing.Size(100, 20);
            this.txtEGDPin.TabIndex = 0;
            // 
            // lblEGDPin
            // 
            this.lblEGDPin.AutoSize = true;
            this.lblEGDPin.Location = new System.Drawing.Point(3, 15);
            this.lblEGDPin.Name = "lblEGDPin";
            this.lblEGDPin.Size = new System.Drawing.Size(53, 13);
            this.lblEGDPin.TabIndex = 3;
            this.lblEGDPin.Text = "Pin Kodu:";
            // 
            // ucEGDPlayerInfo1
            // 
            this.ucEGDPlayerInfo1.Location = new System.Drawing.Point(166, 5);
            this.ucEGDPlayerInfo1.Name = "ucEGDPlayerInfo1";
            this.ucEGDPlayerInfo1.Size = new System.Drawing.Size(364, 151);
            this.ucEGDPlayerInfo1.TabIndex = 2;
            // 
            // hfbRequestPlayer
            // 
            this.hfbRequestPlayer.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.hfbRequestPlayer.FontSize = 14F;
            this.hfbRequestPlayer.LabelText = "Sorgula";
            this.hfbRequestPlayer.Location = new System.Drawing.Point(62, 38);
            this.hfbRequestPlayer.Name = "hfbRequestPlayer";
            this.hfbRequestPlayer.Obj = null;
            this.hfbRequestPlayer.ObjectType = OSKernel.Helper.eObjectType.None;
            this.hfbRequestPlayer.Size = new System.Drawing.Size(100, 34);
            this.hfbRequestPlayer.TabIndex = 1;
            this.hfbRequestPlayer.Tag = "";
            // 
            // ucRequestPlayerFromEGD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEGDPin);
            this.Controls.Add(this.ucEGDPlayerInfo1);
            this.Controls.Add(this.hfbRequestPlayer);
            this.Controls.Add(this.txtEGDPin);
            this.Name = "ucRequestPlayerFromEGD";
            this.Size = new System.Drawing.Size(538, 164);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEGDPin;
        private HighlightFancyButton hfbRequestPlayer;
        private ucEGDPlayerInfo ucEGDPlayerInfo1;
        private System.Windows.Forms.Label lblEGDPin;
    }
}
