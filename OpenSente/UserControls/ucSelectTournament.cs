using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OSKernel.Competation.Tournament;
using OSKernel.Competation;

namespace OpenSente.UserControls
{
    public partial class ucSelectTournament : UserControl
    {
        #region Ctor
        public ucSelectTournament()
        {
            InitializeComponent();
        }

        #endregion

        #region Private Fields

        private List<AGoCompetition> _Competitions;

        #endregion

        #region Public Fields

        #endregion

        #region Private Methods

        private HighlightFancyButton GenerateFancyButtonForCompetition(AGoCompetition competition)
        {
            HighlightFancyButton ret = new HighlightFancyButton();
            ret.Size = new Size(240, 120);
            ret.Obj = competition;
            ret.ObjectType = OSKernel.Helper.eObjectType.Competition;
            ret.LabelText = competition.Name;
            ret.Click += CompetitionFB_Click;
            return ret;
        }

        #endregion

        #region Public Methods

        public void InitializeUC(List<AGoCompetition> competitions)
        {
            _Competitions = competitions;

            fLPanelCompetitions.Controls.Clear();

            for (int i = 0; i < competitions.Count(); i++)
            {
                fLPanelCompetitions.Controls.Add(GenerateFancyButtonForCompetition(competitions[i]));
            }

        }

        #endregion

        #region Events

        private void CompetitionFB_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            HighlightFancyButton hf = (HighlightFancyButton)lbl.Parent;
            fLPanelCompetitions.SendToBack();
            ucTournament ucTournament = new ucTournament();
            ucTournament.InitializeUC((AGoCompetition)hf.Obj);
            ucTournament.Dock = DockStyle.Fill;
            this.Controls.Add(ucTournament);
            ucTournament.BringToFront();
        }

        #endregion

    }
}
