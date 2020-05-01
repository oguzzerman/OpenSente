namespace OpenSente.UserControls
{
    partial class ucSelectTournament
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
            this.fLPanelCompetitions = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // fLPanelCompetitions
            // 
            this.fLPanelCompetitions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fLPanelCompetitions.Location = new System.Drawing.Point(0, 0);
            this.fLPanelCompetitions.Name = "fLPanelCompetitions";
            this.fLPanelCompetitions.Size = new System.Drawing.Size(498, 325);
            this.fLPanelCompetitions.TabIndex = 0;
            // 
            // ucSelectTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fLPanelCompetitions);
            this.Name = "ucSelectTournament";
            this.Size = new System.Drawing.Size(498, 325);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fLPanelCompetitions;
    }
}
