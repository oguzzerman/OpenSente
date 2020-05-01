using OSKernel.Competation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSKernel
{
    [Serializable]
    public class CompetitionDocument
    {

        public CompetitionDocument()
        {
            Tournaments = new List<AGoCompetition>();
        }

        public CompetitionDocument(List<AGoCompetition> tournaments)
        {
            Tournaments = tournaments;
        }

        private List<AGoCompetition> _Tournaments;

        public List<AGoCompetition> Tournaments { get => _Tournaments; set => _Tournaments = value; }
    }
}
