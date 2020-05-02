namespace OpenSente.UserControls
{
    partial class ucGame
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
            this.components = new System.ComponentModel.Container();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.cmbResult = new System.Windows.Forms.ComboBox();
            this.lblGameName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpHandicap = new System.Windows.Forms.GroupBox();
            this.txtHandicap = new System.Windows.Forms.TextBox();
            this.lblHandicap = new System.Windows.Forms.Label();
            this.hfBtnCalculate = new OpenSente.UserControls.HighlightFancyButton();
            this.grpTableName = new System.Windows.Forms.GroupBox();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.lblTableName = new System.Windows.Forms.Label();
            this.hfBtnCopyTableName = new OpenSente.UserControls.HighlightFancyButton();
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.cmbPlayer1Color = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hfBtnPrepareGameResult = new OpenSente.UserControls.HighlightFancyButton();
            this.ucPlayerInfo2 = new OpenSente.UserControls.ucPlayerInfo();
            this.ucPlayerInfo1 = new OpenSente.UserControls.ucPlayerInfo();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.grpHandicap.SuspendLayout();
            this.grpTableName.SuspendLayout();
            this.grpResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.Location = new System.Drawing.Point(154, 46);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(100, 23);
            this.lblPlayer1.TabIndex = 2;
            this.lblPlayer1.Text = "Oyuncu 1";
            this.lblPlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.Location = new System.Drawing.Point(530, 48);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(100, 23);
            this.lblPlayer2.TabIndex = 4;
            this.lblPlayer2.Text = "Oyuncu 2";
            this.lblPlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbResult
            // 
            this.cmbResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbResult.FormattingEnabled = true;
            this.cmbResult.Items.AddRange(new object[] {
            "Siyah Kazandı",
            "Beyaz Kazandı",
            "Siyah (Hükmen)",
            "Beyaz (Hükmen)"});
            this.cmbResult.Location = new System.Drawing.Point(113, 51);
            this.cmbResult.Name = "cmbResult";
            this.cmbResult.Size = new System.Drawing.Size(122, 21);
            this.cmbResult.TabIndex = 6;
            // 
            // lblGameName
            // 
            this.lblGameName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameName.Location = new System.Drawing.Point(0, 2);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(786, 33);
            this.lblGameName.TabIndex = 7;
            this.lblGameName.Text = "TGOD Online Go Ligi Tur 1";
            this.lblGameName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sonuç:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpHandicap
            // 
            this.grpHandicap.Controls.Add(this.txtHandicap);
            this.grpHandicap.Controls.Add(this.lblHandicap);
            this.grpHandicap.Controls.Add(this.hfBtnCalculate);
            this.grpHandicap.Location = new System.Drawing.Point(398, 411);
            this.grpHandicap.Name = "grpHandicap";
            this.grpHandicap.Size = new System.Drawing.Size(113, 115);
            this.grpHandicap.TabIndex = 10;
            this.grpHandicap.TabStop = false;
            this.grpHandicap.Text = "Avans Hesapla";
            // 
            // txtHandicap
            // 
            this.txtHandicap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHandicap.Location = new System.Drawing.Point(75, 26);
            this.txtHandicap.Name = "txtHandicap";
            this.txtHandicap.Size = new System.Drawing.Size(32, 20);
            this.txtHandicap.TabIndex = 12;
            // 
            // lblHandicap
            // 
            this.lblHandicap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHandicap.Location = new System.Drawing.Point(6, 23);
            this.lblHandicap.Name = "lblHandicap";
            this.lblHandicap.Size = new System.Drawing.Size(61, 23);
            this.lblHandicap.TabIndex = 11;
            this.lblHandicap.Text = "Avans:";
            this.lblHandicap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hfBtnCalculate
            // 
            this.hfBtnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hfBtnCalculate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.hfBtnCalculate.FontSize = 8.5F;
            this.hfBtnCalculate.LabelText = "Hesapla";
            this.hfBtnCalculate.Location = new System.Drawing.Point(9, 83);
            this.hfBtnCalculate.Margin = new System.Windows.Forms.Padding(6);
            this.hfBtnCalculate.Name = "hfBtnCalculate";
            this.hfBtnCalculate.Obj = null;
            this.hfBtnCalculate.ObjectType = OSKernel.Helper.eObjectType.Game;
            this.hfBtnCalculate.Size = new System.Drawing.Size(98, 20);
            this.hfBtnCalculate.TabIndex = 10;
            // 
            // grpTableName
            // 
            this.grpTableName.Controls.Add(this.txtTableName);
            this.grpTableName.Controls.Add(this.lblTableName);
            this.grpTableName.Controls.Add(this.hfBtnCopyTableName);
            this.grpTableName.Location = new System.Drawing.Point(22, 411);
            this.grpTableName.Name = "grpTableName";
            this.grpTableName.Size = new System.Drawing.Size(365, 114);
            this.grpTableName.TabIndex = 11;
            this.grpTableName.TabStop = false;
            this.grpTableName.Text = "Masa İsmi";
            // 
            // txtTableName
            // 
            this.txtTableName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTableName.Location = new System.Drawing.Point(102, 26);
            this.txtTableName.Multiline = true;
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(257, 48);
            this.txtTableName.TabIndex = 14;
            this.txtTableName.Text = "TGOD Avanslı Go Turnuvası Tur 1 Servet Dasdemir vs Oğuz Zerman";
            // 
            // lblTableName
            // 
            this.lblTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableName.Location = new System.Drawing.Point(6, 25);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(90, 23);
            this.lblTableName.TabIndex = 13;
            this.lblTableName.Text = "Masa İsmi:";
            this.lblTableName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hfBtnCopyTableName
            // 
            this.hfBtnCopyTableName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.hfBtnCopyTableName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.hfBtnCopyTableName.FontSize = 8.5F;
            this.hfBtnCopyTableName.LabelText = "Masa İsmini Kopyala";
            this.hfBtnCopyTableName.Location = new System.Drawing.Point(9, 83);
            this.hfBtnCopyTableName.Margin = new System.Windows.Forms.Padding(6);
            this.hfBtnCopyTableName.Name = "hfBtnCopyTableName";
            this.hfBtnCopyTableName.Obj = null;
            this.hfBtnCopyTableName.ObjectType = OSKernel.Helper.eObjectType.Game;
            this.hfBtnCopyTableName.Size = new System.Drawing.Size(350, 20);
            this.hfBtnCopyTableName.TabIndex = 12;
            // 
            // grpResult
            // 
            this.grpResult.Controls.Add(this.cmbPlayer1Color);
            this.grpResult.Controls.Add(this.label1);
            this.grpResult.Controls.Add(this.cmbResult);
            this.grpResult.Controls.Add(this.hfBtnPrepareGameResult);
            this.grpResult.Controls.Add(this.label3);
            this.grpResult.Location = new System.Drawing.Point(517, 413);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(244, 112);
            this.grpResult.TabIndex = 13;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "Maç Sonucu";
            // 
            // cmbPlayer1Color
            // 
            this.cmbPlayer1Color.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPlayer1Color.FormattingEnabled = true;
            this.cmbPlayer1Color.Items.AddRange(new object[] {
            "Siyah",
            "Beyaz"});
            this.cmbPlayer1Color.Location = new System.Drawing.Point(113, 24);
            this.cmbPlayer1Color.Name = "cmbPlayer1Color";
            this.cmbPlayer1Color.Size = new System.Drawing.Size(122, 21);
            this.cmbPlayer1Color.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Oyuncu 1 Renk:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hfBtnPrepareGameResult
            // 
            this.hfBtnPrepareGameResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hfBtnPrepareGameResult.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.hfBtnPrepareGameResult.FontSize = 8.5F;
            this.hfBtnPrepareGameResult.LabelText = "Maç Sonucu Oluştur";
            this.hfBtnPrepareGameResult.Location = new System.Drawing.Point(3, 81);
            this.hfBtnPrepareGameResult.Margin = new System.Windows.Forms.Padding(6);
            this.hfBtnPrepareGameResult.Name = "hfBtnPrepareGameResult";
            this.hfBtnPrepareGameResult.Obj = null;
            this.hfBtnPrepareGameResult.ObjectType = OSKernel.Helper.eObjectType.Game;
            this.hfBtnPrepareGameResult.Size = new System.Drawing.Size(232, 20);
            this.hfBtnPrepareGameResult.TabIndex = 5;
            // 
            // ucPlayerInfo2
            // 
            this.ucPlayerInfo2.Location = new System.Drawing.Point(395, 74);
            this.ucPlayerInfo2.Name = "ucPlayerInfo2";
            this.ucPlayerInfo2.Size = new System.Drawing.Size(370, 331);
            this.ucPlayerInfo2.TabIndex = 3;
            // 
            // ucPlayerInfo1
            // 
            this.ucPlayerInfo1.Location = new System.Drawing.Point(19, 72);
            this.ucPlayerInfo1.Name = "ucPlayerInfo1";
            this.ucPlayerInfo1.Size = new System.Drawing.Size(370, 333);
            this.ucPlayerInfo1.TabIndex = 0;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // ucGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpResult);
            this.Controls.Add(this.grpTableName);
            this.Controls.Add(this.grpHandicap);
            this.Controls.Add(this.lblGameName);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.ucPlayerInfo2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.ucPlayerInfo1);
            this.Name = "ucGame";
            this.Size = new System.Drawing.Size(786, 534);
            this.grpHandicap.ResumeLayout(false);
            this.grpHandicap.PerformLayout();
            this.grpTableName.ResumeLayout(false);
            this.grpTableName.PerformLayout();
            this.grpResult.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ucPlayerInfo ucPlayerInfo1;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private ucPlayerInfo ucPlayerInfo2;
        private HighlightFancyButton hfBtnPrepareGameResult;
        private System.Windows.Forms.ComboBox cmbResult;
        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpHandicap;
        private HighlightFancyButton hfBtnCalculate;
        private System.Windows.Forms.TextBox txtHandicap;
        private System.Windows.Forms.Label lblHandicap;
        private System.Windows.Forms.GroupBox grpTableName;
        private HighlightFancyButton hfBtnCopyTableName;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.ComboBox cmbPlayer1Color;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}
