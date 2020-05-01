namespace OpenSente
{
    partial class MainForm
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.pbMaximize = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pbRedo = new System.Windows.Forms.PictureBox();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.pbUndo = new System.Windows.Forms.PictureBox();
            this.pbOSFull = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.hfBtnSelectTournament = new OpenSente.UserControls.HighlightFancyButton();
            this.hfBtnCheckPlayer = new OpenSente.UserControls.HighlightFancyButton();
            this.hfBtnImportTournament = new OpenSente.UserControls.HighlightFancyButton();
            this.hfBtnAbout = new OpenSente.UserControls.HighlightFancyButton();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRedo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUndo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOSFull)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeader.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelHeader.Controls.Add(this.pbMinimize);
            this.panelHeader.Controls.Add(this.pbMaximize);
            this.panelHeader.Controls.Add(this.pbClose);
            this.panelHeader.Controls.Add(this.pbRedo);
            this.panelHeader.Controls.Add(this.pbHome);
            this.panelHeader.Controls.Add(this.pbUndo);
            this.panelHeader.Controls.Add(this.pbOSFull);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1000, 41);
            this.panelHeader.TabIndex = 0;
            // 
            // pbMinimize
            // 
            this.pbMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMinimize.Image = global::OpenSente.Properties.Resources.icons8_minimize_window_32;
            this.pbMinimize.Location = new System.Drawing.Point(883, 3);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(34, 35);
            this.pbMinimize.TabIndex = 10;
            this.pbMinimize.TabStop = false;
            // 
            // pbMaximize
            // 
            this.pbMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMaximize.Image = global::OpenSente.Properties.Resources.icons8_maximize_window_32png;
            this.pbMaximize.Location = new System.Drawing.Point(923, 3);
            this.pbMaximize.Name = "pbMaximize";
            this.pbMaximize.Size = new System.Drawing.Size(34, 35);
            this.pbMaximize.TabIndex = 9;
            this.pbMaximize.TabStop = false;
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.Image = global::OpenSente.Properties.Resources.icons8_close_window_32;
            this.pbClose.Location = new System.Drawing.Point(963, 3);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(34, 35);
            this.pbClose.TabIndex = 8;
            this.pbClose.TabStop = false;
            // 
            // pbRedo
            // 
            this.pbRedo.Image = global::OpenSente.Properties.Resources.icons8_redo_32;
            this.pbRedo.Location = new System.Drawing.Point(201, 6);
            this.pbRedo.Name = "pbRedo";
            this.pbRedo.Size = new System.Drawing.Size(34, 35);
            this.pbRedo.TabIndex = 7;
            this.pbRedo.TabStop = false;
            // 
            // pbHome
            // 
            this.pbHome.Image = global::OpenSente.Properties.Resources.icons8_home_page_32;
            this.pbHome.Location = new System.Drawing.Point(121, 6);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(34, 35);
            this.pbHome.TabIndex = 2;
            this.pbHome.TabStop = false;
            // 
            // pbUndo
            // 
            this.pbUndo.Image = global::OpenSente.Properties.Resources.icons8_undo_32;
            this.pbUndo.Location = new System.Drawing.Point(161, 6);
            this.pbUndo.Name = "pbUndo";
            this.pbUndo.Size = new System.Drawing.Size(34, 35);
            this.pbUndo.TabIndex = 2;
            this.pbUndo.TabStop = false;
            // 
            // pbOSFull
            // 
            this.pbOSFull.Image = global::OpenSente.Properties.Resources.OpenSenteFull;
            this.pbOSFull.Location = new System.Drawing.Point(3, 6);
            this.pbOSFull.Name = "pbOSFull";
            this.pbOSFull.Size = new System.Drawing.Size(112, 30);
            this.pbOSFull.TabIndex = 6;
            this.pbOSFull.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.Controls.Add(this.hfBtnSelectTournament);
            this.panelMain.Controls.Add(this.hfBtnCheckPlayer);
            this.panelMain.Controls.Add(this.hfBtnImportTournament);
            this.panelMain.Controls.Add(this.hfBtnAbout);
            this.panelMain.Location = new System.Drawing.Point(11, 41);
            this.panelMain.Margin = new System.Windows.Forms.Padding(2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(978, 548);
            this.panelMain.TabIndex = 1;
            // 
            // hfBtnSelectTournament
            // 
            this.hfBtnSelectTournament.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.hfBtnSelectTournament.FontSize = 14F;
            this.hfBtnSelectTournament.LabelText = "Turnuva Seç";
            this.hfBtnSelectTournament.Location = new System.Drawing.Point(234, 171);
            this.hfBtnSelectTournament.Margin = new System.Windows.Forms.Padding(6);
            this.hfBtnSelectTournament.Name = "hfBtnSelectTournament";
            this.hfBtnSelectTournament.Obj = null;
            this.hfBtnSelectTournament.ObjectType = OSKernel.Helper.eObjectType.None;
            this.hfBtnSelectTournament.Size = new System.Drawing.Size(240, 120);
            this.hfBtnSelectTournament.TabIndex = 5;
            // 
            // hfBtnCheckPlayer
            // 
            this.hfBtnCheckPlayer.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.hfBtnCheckPlayer.FontSize = 14F;
            this.hfBtnCheckPlayer.LabelText = "EGD\'den Oyuncu Sorgula";
            this.hfBtnCheckPlayer.Location = new System.Drawing.Point(234, 303);
            this.hfBtnCheckPlayer.Margin = new System.Windows.Forms.Padding(6);
            this.hfBtnCheckPlayer.Name = "hfBtnCheckPlayer";
            this.hfBtnCheckPlayer.Obj = null;
            this.hfBtnCheckPlayer.ObjectType = OSKernel.Helper.eObjectType.None;
            this.hfBtnCheckPlayer.Size = new System.Drawing.Size(240, 120);
            this.hfBtnCheckPlayer.TabIndex = 6;
            // 
            // hfBtnImportTournament
            // 
            this.hfBtnImportTournament.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.hfBtnImportTournament.Enabled = false;
            this.hfBtnImportTournament.FontSize = 14F;
            this.hfBtnImportTournament.LabelText = "Turnuva Yükle";
            this.hfBtnImportTournament.Location = new System.Drawing.Point(486, 171);
            this.hfBtnImportTournament.Margin = new System.Windows.Forms.Padding(6);
            this.hfBtnImportTournament.Name = "hfBtnImportTournament";
            this.hfBtnImportTournament.Obj = null;
            this.hfBtnImportTournament.ObjectType = OSKernel.Helper.eObjectType.None;
            this.hfBtnImportTournament.Size = new System.Drawing.Size(240, 120);
            this.hfBtnImportTournament.TabIndex = 7;
            // 
            // hfBtnAbout
            // 
            this.hfBtnAbout.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.hfBtnAbout.FontSize = 14F;
            this.hfBtnAbout.LabelText = "Hakkında";
            this.hfBtnAbout.Location = new System.Drawing.Point(486, 303);
            this.hfBtnAbout.Margin = new System.Windows.Forms.Padding(6);
            this.hfBtnAbout.Name = "hfBtnAbout";
            this.hfBtnAbout.Obj = null;
            this.hfBtnAbout.ObjectType = OSKernel.Helper.eObjectType.None;
            this.hfBtnAbout.Size = new System.Drawing.Size(240, 120);
            this.hfBtnAbout.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "OpenSente";
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRedo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUndo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOSFull)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pbUndo;
        private System.Windows.Forms.Panel panelMain;
        private UserControls.HighlightFancyButton hfBtnSelectTournament;
        private UserControls.HighlightFancyButton hfBtnCheckPlayer;
        private UserControls.HighlightFancyButton hfBtnImportTournament;
        private UserControls.HighlightFancyButton hfBtnAbout;
        private System.Windows.Forms.PictureBox pbOSFull;
        private System.Windows.Forms.PictureBox pbRedo;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.PictureBox pbMaximize;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.PictureBox pbHome;
    }
}

