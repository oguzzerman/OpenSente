using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSKernel.Helper
{
    public enum eGoCompetitionType
    {
        League = 0,
        Tournament = 1
    }

    public enum eObjectType
    {
        None = 0,
        Competition = 1,
        Game = 2,
        Player = 3
    }

    public enum eGameResult
    {
        BlackWins = 0,
        WhiteWins = 1,
        BlackWinsByDefault = 2,
        WhitekWinsByDefault = 3
    }
}
