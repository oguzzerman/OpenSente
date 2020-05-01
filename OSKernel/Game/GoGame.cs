using OSKernel.Competation;
using OSKernel.GoPlayer;
using OSKernel.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSKernel.Game
{
    [Serializable]
    public class GoGame
    {
        #region Ctor

        public GoGame()
        {

        }

        public GoGame(AGoCompetition comp, string groupName, int stage, Player player1, Player player2)
        {
            GoCompetition = comp;
            Stage = stage;
            Player1 = player1;
            Player2 = player2;

            _GameLabel = comp.Name + " " + groupName + " Tur: " + stage.ToString() + " " + player1.Name + " - " + player2.Name;
            _ShortGameLabel = groupName + " Tur: " + stage.ToString() + " " + player1.Name + " - " + player2.Name;
            _GroupName = groupName;
        }

        #endregion

        #region Private Fields

        private AGoCompetition _GoCompetition;
        private int _Stage;
        private Player _Player1;
        private Player _Player2;
        private bool _IsGamePlayed;
        private eGameResult _Result;
        private string _GameLabel;
        private string _ShortGameLabel;
        private string _GroupName;

        #endregion

        #region Public Fields

        public AGoCompetition GoCompetition { get => _GoCompetition; set => _GoCompetition = value; }

        public int Stage { get => _Stage; set => _Stage = value; }

        public Player Player1 { get => _Player1; set => _Player1 = value; }

        public Player Player2 { get => _Player2; set => _Player2 = value; }

        public bool IsGamePlayed { get => _IsGamePlayed; set => _IsGamePlayed = value; }

        public eGameResult Result { get => _Result; set => _Result = value; }

        public string GameLabel { get => _GameLabel; set => _GameLabel = value; }

        public string ShortGameLabel { get => _ShortGameLabel; set => _ShortGameLabel = value; }

        public string GroupName { get => _GroupName; set => _GroupName = value; }

        #endregion

        #region Private Methods

        #endregion

        #region Public Methods

        #endregion

        #region Events

        #endregion
    }


}
