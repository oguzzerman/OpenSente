using OSKernel.Game;
using OSKernel.GoPlayer;
using OSKernel.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSKernel.Competation
{
    [Serializable]
    public abstract class AGoCompetition
    {
        public string Name { get; set; }
        public List<Player> Players { get; set; }
        public List<GoGame> Games { get; set; }
        public eGoCompetitionType Type { get; set; }

    }
}
