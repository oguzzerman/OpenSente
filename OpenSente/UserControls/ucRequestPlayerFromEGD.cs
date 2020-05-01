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
    public partial class ucRequestPlayerFromEGD : UserControl
    {
        #region Ctor

        public ucRequestPlayerFromEGD()
        {
            InitializeComponent();
        }

        #endregion

        #region Private Fields

        private int _UserPIN;

        private EGDPlayer _EGDPlayer;

        #endregion

        #region Public Properties

        public void InitializeUC()
        {
            SubscribeToEvents();
        }

        #endregion

        #region Private Methods

        private void Form2Rec()
        {
            if (txtEGDPin.Text != "")
            {
                _UserPIN = Convert.ToInt32(txtEGDPin.Text);
            }
            else
            {
                _UserPIN = 0;
            }
        }

        private void Rec2Form()
        {
            ucEGDPlayerInfo1.InitializeUC(_EGDPlayer);
        }

        private void SubscribeToEvents()
        {
            hfbRequestPlayer.Click += HfbRequestPlayer_Click;
            txtEGDPin.KeyPress += TxtEGDPin_KeyPress;
        }

        private void UnsubscriveFromEvents()
        {
            hfbRequestPlayer.Click -= HfbRequestPlayer_Click;
            txtEGDPin.KeyPress -= TxtEGDPin_KeyPress;
        }

        #endregion

        #region Events

        private void TxtEGDPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char) 13)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                               (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
            }
            else
            {
                UnsubscriveFromEvents();
                Form2Rec();
                _EGDPlayer = DBHelper.GetPlayerByIDUsingHttpClient(_UserPIN).Result;
                Rec2Form();
                SubscribeToEvents();
            }
        }

        private void HfbRequestPlayer_Click(object sender, EventArgs e)
        {
            UnsubscriveFromEvents();
            Form2Rec();
            _EGDPlayer = DBHelper.GetPlayerByIDUsingHttpClient(_UserPIN).Result;
            Rec2Form();
            SubscribeToEvents();
        }

        #endregion

        #region Public Methods

        #endregion

    }
}
