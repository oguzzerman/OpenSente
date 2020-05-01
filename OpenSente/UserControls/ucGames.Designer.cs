namespace OpenSente.UserControls
{
    partial class ucGames
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
            this.listboxPlayers = new System.Windows.Forms.ListBox();
            this.ucGame1 = new OpenSente.UserControls.ucGame();
            this.SuspendLayout();
            // 
            // listboxPlayers
            // 
            this.listboxPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listboxPlayers.FormattingEnabled = true;
            this.listboxPlayers.Location = new System.Drawing.Point(8, 10);
            this.listboxPlayers.Name = "listboxPlayers";
            this.listboxPlayers.Size = new System.Drawing.Size(196, 459);
            this.listboxPlayers.TabIndex = 3;
            // 
            // ucGame1
            // 
            this.ucGame1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucGame1.Location = new System.Drawing.Point(197, -1);
            this.ucGame1.Name = "ucGame1";
            this.ucGame1.Size = new System.Drawing.Size(772, 482);
            this.ucGame1.TabIndex = 2;
            // 
            // ucGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listboxPlayers);
            this.Controls.Add(this.ucGame1);
            this.Name = "ucGames";
            this.Size = new System.Drawing.Size(972, 484);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listboxPlayers;
        private ucGame ucGame1;
    }
}
