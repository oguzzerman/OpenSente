using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OSKernel.Game;
using OSKernel.Competation.League;
using OSKernel.Helper;
using OSKernel.Competation;

namespace OpenSente.UserControls
{
    public partial class ucGames : UserControl
    {
        #region Ctor

        public ucGames()
        {
            InitializeComponent();
        }

        #endregion

        #region Private Fields

        private List<GoGame> _Games;

        #endregion

        #region Public Fields

        #endregion

        #region Private Methods

        private void SubscribeToEvents()
        {
            listboxPlayers.SelectedIndexChanged += ListboxPlayers_SelectedIndexChanged;
        }

        private void UnsubscribeFromEvents()
        {
            listboxPlayers.SelectedIndexChanged += ListboxPlayers_SelectedIndexChanged;
        }

        #endregion

        #region Public Methods

        public void InitializeUC(AGoCompetition league)
        {
            _Games = league.Games;

            listboxPlayers.Items.Clear();
            for (int i = 0; i < _Games.Count(); i++)
            {
                listboxPlayers.Items.Add(_Games[i].ShortGameLabel);
            }

            listboxPlayers.SelectedIndex = 0;

            ucGame1.InitializeUC(_Games[listboxPlayers.SelectedIndex]);

            SubscribeToEvents();
        }

        public void InitializeUC(List<GoGame> games)
        {
            _Games = games;

            listboxPlayers.Items.Clear();
            for (int i = 0; i < _Games.Count(); i++)
            {
                listboxPlayers.Items.Add(_Games[i].ShortGameLabel);
            }

            listboxPlayers.SelectedIndex = 0;

            ucGame1.InitializeUC(_Games[listboxPlayers.SelectedIndex]);

            SubscribeToEvents();
   
        }

        #endregion

        #region Events

        private void ListboxPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucGame1.InitializeUC(_Games[listboxPlayers.SelectedIndex]);
        }

        #endregion

    }
}
