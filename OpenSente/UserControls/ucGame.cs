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
using OSKernel.Helper;
using OSKernel.GoPlayer;

namespace OpenSente.UserControls
{
    public partial class ucGame : UserControl
    {
        #region Ctor

        public ucGame()
        {
            InitializeComponent();
        }

        #endregion

        #region Private Fields

        private GoGame _Game;
        private EGDPlayer _EGDPlayer1;
        private EGDPlayer _EGDPlayer2;

        #endregion

        #region Public Fields

        #endregion

        #region Private Methods

        private void PrepareUI()
        {
            cmbPlayer1Color.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbResult.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbPlayer1Color.SelectedIndex = 0;
            cmbResult.SelectedIndex = 0;
            txtHandicap.Enabled = false;
            txtTableName.Enabled = false;
        }

        #endregion

        #region Public Methods

        public void InitializeUC(GoGame game)
        {
            PrepareUI();

            _Game = game;

            if (game.IsGamePlayed)
            {
                grpResult.Enabled = false;
                cmbResult.SelectedIndex = (int)game.Result;
            }

            _EGDPlayer1 = DBHelper.GetPlayerByIDUsingHttpClient(game.Player1.EGDPinCode).Result;
            _EGDPlayer2 = DBHelper.GetPlayerByIDUsingHttpClient(game.Player2.EGDPinCode).Result;
            ucPlayerInfo1.InitializeUC(game.Player1, _EGDPlayer1);
            ucPlayerInfo2.InitializeUC(game.Player2, _EGDPlayer2);
            lblGameName.Text = game.GameLabel;
            txtTableName.Text = game.GameLabel;
            txtHandicap.Text = "";

            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            hfBtnCalculate.Click += HfBtnCalculate_Click;
            hfBtnCopyTableName.Click += HfBtnCopyTableName_Click;
            hfBtnPrepareGameResult.Click += HfBtnPrepareGameResult_Click;
        }

        private void HfBtnPrepareGameResult_Click(object sender, EventArgs e)
        {
            string resultText = ""; // "Avanslı B Grubu 1.Tur 28.04.2020 Berkant Aras (Beyaz) Büke Tuncel (Siyah) Avans: 4 Kazanan: Siyah";

            string tournamentName = _Game.GoCompetition.Name;
            string stage = _Game.Stage.ToString();
            string player1Color = cmbPlayer1Color.Text;
            string player2Color = cmbPlayer1Color.SelectedIndex == 0 ? "Beyaz" : "Siyah";
            string handicap = txtHandicap.Text;
            string result = cmbResult.Text;

            resultText += tournamentName + " " + Environment.NewLine;
            resultText +=  stage + ". Tur " + DateTime.Now.ToLongDateString() + Environment.NewLine;
            resultText += _Game.Player1.Name + " (" + player1Color +  ")" + Environment.NewLine;
            resultText += _Game.Player2.Name + " (" + player2Color + ")" + Environment.NewLine;

            if (handicap != "")
            {
                resultText += "Avans: " + handicap + Environment.NewLine;
            }

            resultText += "Kazanan: " + result;

            System.Windows.Forms.Clipboard.SetText(resultText);

            notifyIcon1.Visible = true;
            SetBalloonTipResult();
            notifyIcon1.ShowBalloonTip(10000);
        }
        private void SetBalloonTipResult()
        {

            notifyIcon1.Icon = SystemIcons.Exclamation;

            notifyIcon1.BalloonTipTitle = "Tebrikler!";
            notifyIcon1.BalloonTipText = "Maç sonucu kopyalandı. Her iki tarafı da tebrik ederiz.";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
        }
        private void SetBalloonTipTableName()
        {

            notifyIcon1.Icon = SystemIcons.Exclamation;

            notifyIcon1.BalloonTipTitle = "Başarılar!";
            notifyIcon1.BalloonTipText = "Masa ismi kopyalandı. Her iki tarafa da başarılar dileriz.";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
        }

        private void HfBtnCopyTableName_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(_Game.GameLabel);
            SetBalloonTipTableName();
            notifyIcon1.ShowBalloonTip(10000);
        }

        private void HfBtnCalculate_Click(object sender, EventArgs e)
        {
            int handicap = 0;
            int GorDifference = Math.Abs(Convert.ToInt32(_EGDPlayer1.Gor) - Convert.ToInt32(_EGDPlayer2.Gor));

            if (GorDifference < 50)
            {
                handicap = 0;
            }
            else if (GorDifference < 150)
            {
                handicap = 1;
            }
            else if (GorDifference < 250)
            {
                handicap = 2;
            }
            else if (GorDifference < 350)
            {
                handicap = 3;
            }
            else if (GorDifference < 450)
            {
                handicap = 4;
            }
            else if (GorDifference < 550)
            {
                handicap = 5;
            }
            else if (GorDifference < 650)
            {
                handicap = 6;
            }
            else if (GorDifference < 750)
            {
                handicap = 7;
            }
            else if (GorDifference < 850)
            {
                handicap = 8;
            }
            else
            {
                handicap = 9;
            }

            txtHandicap.Text = handicap.ToString();
        }

        #endregion

        #region Events

        #endregion

    }
}
