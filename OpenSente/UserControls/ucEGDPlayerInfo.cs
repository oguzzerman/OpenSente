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
    public partial class ucEGDPlayerInfo : UserControl
    {

        #region Ctor

        public ucEGDPlayerInfo()
        {
            InitializeComponent();
        }

        #endregion

        #region Private Fields

        private EGDPlayer _SelectedEGDPlayer;

        #endregion

        #region Public Fields

        #endregion

        #region Private Methods

        private void Rec2Form()
        {
            if (_SelectedEGDPlayer != null)
            {
                txtGoR.Text = _SelectedEGDPlayer.Gor;
                txtGrade.Text = _SelectedEGDPlayer.Grade;
                txtTotalTournaments.Text = _SelectedEGDPlayer.Tot_Tournaments;
                txtEGDUserName.Text = _SelectedEGDPlayer.Name + " " + _SelectedEGDPlayer.Last_Name;
                lblDateTime.Text = _SelectedEGDPlayer.Last_Appearance;
            }
        }

        #endregion

        #region Public Methods

        public void InitializeUC(EGDPlayer eGDPlayer)
        {
            _SelectedEGDPlayer = eGDPlayer;
            Rec2Form();
        }

        #endregion

        #region Events

        #endregion
    }
}
