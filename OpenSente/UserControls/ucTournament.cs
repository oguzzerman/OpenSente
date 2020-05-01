using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OSKernel.Helper;
using OSKernel.GoPlayer;
using OSKernel.Competation;
using OSKernel.Game;

namespace OpenSente.UserControls
{
    public partial class ucTournament : UserControl
    {
        #region Ctor

        public ucTournament()
        {
            InitializeComponent();
            SubscribeToEvents();
        }

        #endregion

        #region Private Fields

        private AGoCompetition _Tournament;

        #endregion

        #region Public Fields

        #endregion

        #region Private Methods

        private void SubscribeToEvents()
        {
            hfBtnShowPlayers.Click += HfBtnShowPlayers_Click;
            hfBtnShowGames.Click += HfBtnShowGames_Click;
            hfBtnShowGamesForPlayer.Click += HfBtnShowGamesForPlayer_Click;   
            this.SizeChanged += Uc_SizeChanged;
        }

        private void UnsubscribeFromEvents()
        {
            hfBtnShowPlayers.Click -= HfBtnShowPlayers_Click;
            hfBtnShowGames.Click -= HfBtnShowGames_Click;
            hfBtnShowGamesForPlayer.Click -= HfBtnShowGamesForPlayer_Click;  
            this.SizeChanged -= Uc_SizeChanged;
        }

        #endregion

        #region Public Methods

        public void InitializeUC(AGoCompetition tournament)
        {
            _Tournament = tournament;
        }

        #endregion

        #region Events

        private void HfBtnShowPlayers_Click(object sender, EventArgs e)
        {
            ucPlayerList ucPlayers = new ucPlayerList();
            ucPlayers.InitializeUC(_Tournament.Players);
            ucPlayers.Dock = DockStyle.Fill;
            this.Controls.Add(ucPlayers);
            ucPlayers.BringToFront();
        }

        private void HfBtnShowGames_Click(object sender, EventArgs e)
        {
            ucGames ucGms = new ucGames();
            ucGms.InitializeUC(_Tournament);
            ucGms.Dock = DockStyle.Fill;
            this.Controls.Add(ucGms);
            ucGms.BringToFront();
        }

        private void HfBtnShowGamesForPlayer_Click(object sender, EventArgs e)
        {
            ucSelectPlayer ucSelectPlayer = new ucSelectPlayer();
            ucSelectPlayer.InitializeUC(_Tournament);
            ucSelectPlayer.Dock = DockStyle.Fill;
            this.Controls.Add(ucSelectPlayer);
            ucSelectPlayer.BringToFront();
        }

        private void Uc_SizeChanged(object sender, EventArgs e)
        {
            hfBtnShowPlayers.Location = new Point(this.Size.Width / 2 - 235,
                                                       this.Size.Height / 2 - 141);

            hfBtnShowGames.Location = new Point(this.Size.Width / 2 + 17,
                                                       this.Size.Height / 2 - 141);

            hfBtnScores.Location = new Point(this.Size.Width / 2 - 235,
                                                  this.Size.Height / 2 - 9);

            hfBtnShowGamesForPlayer.Location = new Point(this.Size.Width / 2 + 17,
                                            this.Size.Height / 2 - 9);
        }

        #endregion


    }
}
