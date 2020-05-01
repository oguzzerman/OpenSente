using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OSKernel.Competation;
using OSKernel.GoPlayer;
using OSKernel.Game;

namespace OpenSente.UserControls
{
    public partial class ucSelectPlayer : UserControl
    {
        #region Ctor
        public ucSelectPlayer()
        {
            InitializeComponent();
        }

        #endregion

        #region Private Fields

        private AGoCompetition _Competition;
        private List<Player> _Players;

        #endregion

        #region Public Fields

        #endregion

        #region Private Methods

        private HighlightFancyButton GenerateFancyButtonForPlayer(Player player)
        {
            HighlightFancyButton ret = new HighlightFancyButton();
            ret.Size = new Size(400, 50);
            ret.Obj = player;
            ret.ObjectType = OSKernel.Helper.eObjectType.Player;
            ret.LabelText = player.Name;
            ret.Click += CompetitionFB_Click;
            return ret;
        }

        #endregion

        #region Public Methods

        public void InitializeUC(AGoCompetition competition)
        {
            _Competition = competition;
            _Players = competition.Players;

            flowPanelMain.Controls.Clear();

            for (int i = 0; i < _Players.Count(); i++)
            {
                flowPanelMain.Controls.Add(GenerateFancyButtonForPlayer(_Players[i]));
            }

        }

        #endregion

        #region Events

        private void CompetitionFB_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            HighlightFancyButton hf = (HighlightFancyButton)lbl.Parent;
            flowPanelMain.SendToBack();
            Player selectedPlayer = (Player) hf.Obj;
            List<GoGame> games = _Competition.Games.Where((x) => x.Player1.Name == selectedPlayer.Name || x.Player2.Name == selectedPlayer.Name).ToList();
            ucGames ucGms = new ucGames();
            ucGms.InitializeUC(games);
            ucGms.Dock = DockStyle.Fill;
            this.Controls.Add(ucGms);
            ucGms.BringToFront();
        }

        #endregion
    }
}
