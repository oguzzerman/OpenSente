using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OSKernel.GoPlayer;
using OSKernel.Helper;

namespace OpenSente.UserControls
{
    public partial class ucPlayerList : UserControl
    {
        #region Ctor

        public ucPlayerList()
        {
            InitializeComponent();
        }

        #endregion

        #region Private Fields

        private List<Player> _Players;
        private Player _SelectedPlayer;
        private EGDPlayer _SelectedEGDPlayer;

        #endregion

        #region Public Fields

        #endregion

        #region Private Methods

        private void SubscribeToEvents()
        {
            listPlayers.SelectedIndexChanged += ListPlayers_SelectedIndexChanged;
        }

        private void UnsubscribeFromEvents()
        {
            listPlayers.SelectedIndexChanged -= ListPlayers_SelectedIndexChanged;
        }

        private void Rec2Form()
        {
            ucPlayerInfo1.InitializeUC(_SelectedPlayer, _SelectedEGDPlayer);
        }

        private void PrepareUI()
        {
            listPlayers.Items.Clear();

            for (int i = 0; i < _Players.Count; i++)
            {
                Player player = _Players[i];
                listPlayers.Items.Add(player.Name);
            }

            listPlayers.SelectedIndex = 0;
            _SelectedPlayer = _Players[0];

            _SelectedEGDPlayer = DBHelper.GetPlayerByIDUsingHttpClient(_Players[0].EGDPinCode).Result;

        }

        #endregion

        #region Public Methods

        public void InitializeUC(List<Player> Players)
        {
            _Players = Players;

            PrepareUI();
            Rec2Form();
            SubscribeToEvents();
        }

        #endregion

        #region Events

        private void ListPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            UnsubscribeFromEvents();

            _SelectedPlayer = _Players[listPlayers.SelectedIndex];

            _SelectedEGDPlayer = DBHelper.GetPlayerByIDUsingHttpClient(_Players[listPlayers.SelectedIndex].EGDPinCode).Result;

            Rec2Form();

            SubscribeToEvents();
        }

        #endregion
    }
}
