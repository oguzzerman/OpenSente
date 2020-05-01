namespace OpenSente.UserControls
{
    partial class ucPlayerList
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
            this.ucPlayerInfo1 = new OpenSente.UserControls.ucPlayerInfo();
            this.listPlayers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ucPlayerInfo1
            // 
            this.ucPlayerInfo1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucPlayerInfo1.Location = new System.Drawing.Point(255, 3);
            this.ucPlayerInfo1.Name = "ucPlayerInfo1";
            this.ucPlayerInfo1.Size = new System.Drawing.Size(483, 290);
            this.ucPlayerInfo1.TabIndex = 4;
            // 
            // listPlayers
            // 
            this.listPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listPlayers.FormattingEnabled = true;
            this.listPlayers.Location = new System.Drawing.Point(3, 3);
            this.listPlayers.Name = "listPlayers";
            this.listPlayers.Size = new System.Drawing.Size(245, 290);
            this.listPlayers.TabIndex = 3;
            // 
            // ucPlayerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucPlayerInfo1);
            this.Controls.Add(this.listPlayers);
            this.Name = "ucPlayerList";
            this.Size = new System.Drawing.Size(738, 299);
            this.ResumeLayout(false);

        }

        #endregion

        private ucPlayerInfo ucPlayerInfo1;
        private System.Windows.Forms.ListBox listPlayers;
    }
}
