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

namespace OpenSente.UserControls
{
    public partial class ucPlayerInfo : UserControl
    {
        #region Ctor

        public ucPlayerInfo()
        {
            InitializeComponent();
        }

        #endregion

        #region Private Fields

        private Player _SelectedPlayer;
        private EGDPlayer _SelectedEGDPlayer;

        #endregion

        #region Public Fields

        #endregion

        #region Private Methods

        private void Rec2Form()
        {
            if (_SelectedPlayer != null)
            {
                txtPlayerName.Text = _SelectedPlayer.Name;
                txtKGSName.Text = _SelectedPlayer.KGSName;

                if (_SelectedPlayer.EGDPinCode == -1)
                {
                    txtEGDPin.Text = _SelectedPlayer.EGDPinCode.ToString();
                }
                else
                {
                    txtEGDPin.Text = "-";
                }

                txtCity.Text = _SelectedPlayer.City;
                txtClub.Text = _SelectedPlayer.Club;
            }

            ucEGDPlayerInfo1.InitializeUC(_SelectedEGDPlayer);
        }

        #endregion

        #region Public Methods

        public void InitializeUC(Player player, EGDPlayer eGDPlayer)
        {
            _SelectedPlayer = player;
            _SelectedEGDPlayer = eGDPlayer;
            Rec2Form();
        }

        #endregion

        #region Events

        #endregion
    }
}
