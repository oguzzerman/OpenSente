namespace OpenSente.UserControls
{
    partial class ucTournament
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
            this.hfBtnShowPlayers = new OpenSente.UserControls.HighlightFancyButton();
            this.hfBtnScores = new OpenSente.UserControls.HighlightFancyButton();
            this.hfBtnShowGames = new OpenSente.UserControls.HighlightFancyButton();
            this.hfBtnShowGamesForPlayer = new OpenSente.UserControls.HighlightFancyButton();
            this.SuspendLayout();
            // 
            // hfBtnShowPlayers
            // 
            this.hfBtnShowPlayers.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.hfBtnShowPlayers.FontSize = 14F;
            this.hfBtnShowPlayers.LabelText = "Oyuncuları Göster";
            this.hfBtnShowPlayers.Location = new System.Drawing.Point(103, 91);
            this.hfBtnShowPlayers.Margin = new System.Windows.Forms.Padding(6);
            this.hfBtnShowPlayers.Name = "hfBtnShowPlayers";
            this.hfBtnShowPlayers.Obj = null;
            this.hfBtnShowPlayers.ObjectType = OSKernel.Helper.eObjectType.Game;
            this.hfBtnShowPlayers.Size = new System.Drawing.Size(240, 120);
            this.hfBtnShowPlayers.TabIndex = 9;
            // 
            // hfBtnScores
            // 
            this.hfBtnScores.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.hfBtnScores.Enabled = false;
            this.hfBtnScores.FontSize = 14F;
            this.hfBtnScores.LabelText = "Puan Durumu";
            this.hfBtnScores.Location = new System.Drawing.Point(103, 223);
            this.hfBtnScores.Margin = new System.Windows.Forms.Padding(6);
            this.hfBtnScores.Name = "hfBtnScores";
            this.hfBtnScores.Obj = null;
            this.hfBtnScores.ObjectType = OSKernel.Helper.eObjectType.Game;
            this.hfBtnScores.Size = new System.Drawing.Size(240, 120);
            this.hfBtnScores.TabIndex = 10;
            // 
            // hfBtnShowGames
            // 
            this.hfBtnShowGames.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.hfBtnShowGames.FontSize = 14F;
            this.hfBtnShowGames.LabelText = "Oyunları Göster";
            this.hfBtnShowGames.Location = new System.Drawing.Point(355, 91);
            this.hfBtnShowGames.Margin = new System.Windows.Forms.Padding(6);
            this.hfBtnShowGames.Name = "hfBtnShowGames";
            this.hfBtnShowGames.Obj = null;
            this.hfBtnShowGames.ObjectType = OSKernel.Helper.eObjectType.Game;
            this.hfBtnShowGames.Size = new System.Drawing.Size(240, 120);
            this.hfBtnShowGames.TabIndex = 11;
            // 
            // hfBtnShowGamesForPlayer
            // 
            this.hfBtnShowGamesForPlayer.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.hfBtnShowGamesForPlayer.FontSize = 14F;
            this.hfBtnShowGamesForPlayer.LabelText = "Oyuncunun Oyunlarını Göster";
            this.hfBtnShowGamesForPlayer.Location = new System.Drawing.Point(355, 223);
            this.hfBtnShowGamesForPlayer.Margin = new System.Windows.Forms.Padding(6);
            this.hfBtnShowGamesForPlayer.Name = "hfBtnShowGamesForPlayer";
            this.hfBtnShowGamesForPlayer.Obj = null;
            this.hfBtnShowGamesForPlayer.ObjectType = OSKernel.Helper.eObjectType.Game;
            this.hfBtnShowGamesForPlayer.Size = new System.Drawing.Size(240, 120);
            this.hfBtnShowGamesForPlayer.TabIndex = 12;
            // 
            // ucTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hfBtnShowPlayers);
            this.Controls.Add(this.hfBtnScores);
            this.Controls.Add(this.hfBtnShowGames);
            this.Controls.Add(this.hfBtnShowGamesForPlayer);
            this.Name = "ucTournament";
            this.Size = new System.Drawing.Size(698, 434);
            this.ResumeLayout(false);

        }

        #endregion

        private HighlightFancyButton hfBtnShowPlayers;
        private HighlightFancyButton hfBtnScores;
        private HighlightFancyButton hfBtnShowGames;
        private HighlightFancyButton hfBtnShowGamesForPlayer;
    }
}
