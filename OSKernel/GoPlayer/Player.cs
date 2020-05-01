using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSKernel.GoPlayer
{
    [Serializable]
    public class Player
    {
        public Player()
        {

        }

        public Player(string name, string kgsName, int pinCode, string city, string club)
        {
            Name = name;
            KGSName = kgsName;
            EGDPinCode = pinCode;
            City = city;
            Club = club;
        }

        public string Name { get; set; }

        public string KGSName { get; set; }

        public int EGDPinCode { get; set; }

        public string City { get; set; }

        public string Club { get; set; }

    } 
}
