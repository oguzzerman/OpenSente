using OSKernel.Competation;
using OSKernel.Game;
using OSKernel.GoPlayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSKernel.Helper
{
    public class TGODGoLeagueHelper
    {
        public static List<Player> GetLeaguePlayersFromPath(string fileName)
        {
            List<Player> players = new List<Player>();
            string Path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            Path += "\\" + fileName;

            using (StreamReader sr = new StreamReader(Path))
            {
                var line = "";
                while (true)
                {
                    line = sr.ReadLine();
                    if (line != null)
                    {
                        var split = line.Split(',');

                        int pinCode;

                        bool isNumeric = int.TryParse(split[2], out pinCode);

                        if (!isNumeric)
                        {
                            pinCode = -1;
                        }
                        var p = new Player()
                        {
                            Name = split[0],
                            KGSName = split[1], 
                            EGDPinCode = pinCode, 
                            City = split[3], 
                            Club = split[4] };
                        players.Add(p);
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return players;
        }

        public static List<Player> GetNormalLeaguePlayersPredefined()
        {
            List<Player> players = new List<Player>();

            players.Add(new Player("Ahmet Kemal Ökmen", "albiatros", 15413816, "Çanakkale", "Türkiye Go Oyuncuları Derneği"));
            players.Add(new Player("Ali Kulubecioğlu", "alii", 19250198, "Hatay", "–"));
            players.Add(new Player("Ali Yunus Emre Özköse", "yunusemre", 19549728, "Ankara", "–"));
            players.Add(new Player("Alpay Cemre Çam", "Tenebris", 18225273, "İzmir", "İzmir Go Oyuncuları Derneği"));
            players.Add(new Player("Alper Sulak", "alper", 18701034, "Ankara", "–"));
            players.Add(new Player("Altan Kuntay", "elohimmeth", 15025307, "Manisa", "Türkiye Go Oyuncuları Derneği"));
            players.Add(new Player("Ayşe TUGAN", "Aytu", 18633934, "Karaman", "Diğer"));
            players.Add(new Player("Berkant Aras", "berkant", 16825534, "Ankara", "Türkiye Go Oyuncuları Derneği"));
            players.Add(new Player("Bunyamin Ergen", "BE", 18486952, "İstanbul", "Diğer"));
            players.Add(new Player("Büke Tuncel", "RkC4", 16537950, "Girne", "Diğer"));
            players.Add(new Player("Cafer Yazıcı", "Dervish", 18698031, "Rize", "Diğer"));
            players.Add(new Player("Cihan Mert Deveden", "CihanMert", 19301183, "İzmir", "İzmir Go Oyuncuları Derneği"));
            players.Add(new Player("Çağatay Tavşanoğlu", "eko", 13650659, "Ankara", "Türkiye Go Oyuncuları Derneği"));
            players.Add(new Player("Çılga İşcan", "anneliisa", 19349957, "İzmir", "İzmir Go Oyuncuları Derneği"));
            players.Add(new Player("Çınar Çetin", "PRO9", 19237394, "İzmir", "İzmir Go Oyuncuları Derneği"));
            players.Add(new Player("Doğan Can Karataş", "Avernus", 18550653, "Ankara", "–"));
            players.Add(new Player("Doğukan Bora Alay", "Dogukan", 19501713, "Trabzon", "Ankara Go Oyuncuları Derneği"));
            players.Add(new Player("Elif Sarı", "sarielif66", 19533514, "İzmir", "–"));
            players.Add(new Player("Ertuğ Akkol", "ERTUG", 10633920, "İstanbul", "İstanbul Go Oyuncuları Derneği"));
            players.Add(new Player("Etkin Özgan", "keycard", 19513340, "İstanbul", "–"));
            players.Add(new Player("Firat Dulger", "fahrettin", 15398658, "Bruksel", "–"));
            players.Add(new Player("Gonca Kucukakin", "aviver", 18374950, "Townsville", "Diğer"));
            players.Add(new Player("Gündaş Alaşahan", "gundas", -1, "İzmir", "–"));
            players.Add(new Player("Hasan Hüseyin Çiçek", "Hzrbey", -1, "–", "–"));
            players.Add(new Player("Mehmethan Coşkun", "mehmethan", -1, "–", "–"));
            players.Add(new Player("Mert Bağcık", "Warhead", 17462159, "Aydın", "–"));
            players.Add(new Player("Merve Gürcan", "evrem", 16013536, "İstanbul", "İstanbul Go Oyuncuları Derneği"));
            players.Add(new Player("Mete Rıza Nemlioğlu", "moriago", 19301381, "İstanbul", "İstanbul Go Oyuncuları Derneği"));
            players.Add(new Player("Mustafa Talak", "Talak", 16998168, "Antalya", "Eskişehir Go Oyuncuları Derneği"));
            players.Add(new Player("Nevriye Çerçioğlu", "nevriye", -1, "Ankara", "–"));
            players.Add(new Player("Ogün Gökpınar", "ogun", 16750371, "İstanbul", "–"));
            players.Add(new Player("Oğulkan Bir", "Atababa", 19086463, "Ankara", "Ankara Go Oyuncuları Derneği"));
            players.Add(new Player("Oğuz Zerman", "zerman", 19537716, "Ankara", "–"));
            players.Add(new Player("Okan Kaynak", "okanyak", 16050540, "Denizli", "Türkiye Go Oyuncuları Derneği"));
            players.Add(new Player("Orhan Can Acar", "Askonsa", 15649810, "İstanbul", "İstanbul Go Oyuncuları Derneği"));
            players.Add(new Player("Övünç Balcı", "Comet", 16533209, "İzmir", "–"));
            players.Add(new Player("Özlem Ersoy", "Tuxedocat", 18201348, "İzmir", "İzmir Go Oyuncuları Derneği"));
            players.Add(new Player("Remzi öz", "remzioz", 19001037, "İstanbul", "İstanbul Go Oyuncuları Derneği"));
            players.Add(new Player("Selçuk Mola", "siyahbeyaz", 16937162, "Antalya", "–"));
            players.Add(new Player("Selçuk Toker", "Karga", 18450784, "Eskişehir", "Eskişehir Go Oyuncuları Derneği"));
            players.Add(new Player("Servet Daşdemir", "serbetoo", 17637367, "İstanbul", "İstanbul Go Oyuncuları Derneği"));
            players.Add(new Player("Uğur Arıkan", "tcorc", 17374423, "Ankara", "Türkiye Go Oyuncuları Derneği"));
            players.Add(new Player("Uygar Tavşanoğlu", "Strang3", 17598350, "Ankara", "Diğer"));
            players.Add(new Player("Yetkin Eser", "addict", 16598945, "İstanbul", "İstanbul Go Oyuncuları Derneği"));

            return players;
        }

        public static List<Player> GetHandicapLeaguePlayersPredefined()
        {
            List<Player> players = new List<Player>();

            players.Add(new Player("Ahmet Kemal Ökmen", "albiatros", 15413816, "Çanakkale", "Türkiye Go Oyuncuları Derneği"));
            players.Add(new Player("Ali Kulubecioğlu", "alii", 19250198, "Hatay", "–"));
            players.Add(new Player("Ali Yunus Emre Özköse", "yunusemre", 19549728, "Ankara", "–"));
            players.Add(new Player("Alpay Cemre Çam", "Tenebris", 18225273, "İzmir", "İzmir Go Oyuncuları Derneği"));
            players.Add(new Player("Alper Sulak", "alper", 18701034, "Ankara", "–"));
            players.Add(new Player("Altan Kuntay", "elohimmeth", 15025307, "Manisa", "Türkiye Go Oyuncuları Derneği"));
            players.Add(new Player("Ayşe TUGAN", "Aytu", 18633934, "Karaman", "Diğer"));
            players.Add(new Player("Berkant Aras", "berkant", 16825534, "Ankara", "Türkiye Go Oyuncuları Derneği"));
            players.Add(new Player("Bunyamin Ergen", "BE", 18486952, "İstanbul", "Diğer"));
            players.Add(new Player("Büke Tuncel", "RkC4", 16537950, "Girne", "Diğer"));
            players.Add(new Player("Cafer Yazıcı", "Dervish", 18698031, "Rize", "Diğer"));
            players.Add(new Player("Cihan Mert Deveden", "CihanMert", 19301183, "İzmir", "İzmir Go Oyuncuları Derneği"));
            players.Add(new Player("Çağatay Tavşanoğlu", "eko", 13650659, "Ankara", "Türkiye Go Oyuncuları Derneği"));
            players.Add(new Player("Çılga İşcan", "anneliisa", 19349957, "İzmir", "İzmir Go Oyuncuları Derneği"));
            players.Add(new Player("Çınar Çetin", "PRO9", 19237394, "İzmir", "İzmir Go Oyuncuları Derneği"));
            players.Add(new Player("Doğan Can Karataş", "Avernus", 18550653, "Ankara", "–"));
            players.Add(new Player("Doğukan Bora Alay", "Dogukan", 19501713, "Trabzon", "Ankara Go Oyuncuları Derneği"));
            players.Add(new Player("Elif Sarı", "sarielif66", 19533514, "İzmir", "–"));
            players.Add(new Player("Ertuğ Akkol", "ERTUG", 10633920, "İstanbul", "İstanbul Go Oyuncuları Derneği"));
            players.Add(new Player("Etkin Özgan", "keycard", 19513340, "İstanbul", "–"));
            players.Add(new Player("Firat Dulger", "fahrettin", 15398658, "Bruksel", "–"));
            players.Add(new Player("Gonca Kucukakin", "aviver", 18374950, "Townsville", "Diğer"));
            players.Add(new Player("Gündaş Alaşahan", "gundas",-1, "İzmir", "–"));
            players.Add(new Player("Hasan Hüseyin Çiçek", "Hzrbey", -1, "–", "–"));
            players.Add(new Player("Mehmethan Coşkun", "mehmethan", -1, "–", "–"));
            players.Add(new Player("Mert Bağcık", "Warhead", 17462159, "Aydın", "–"));
            players.Add(new Player("Merve Gürcan", "evrem", 16013536, "İstanbul", "İstanbul Go Oyuncuları Derneği"));
            players.Add(new Player("Mete Rıza Nemlioğlu", "moriago", 19301381, "İstanbul", "İstanbul Go Oyuncuları Derneği"));
            players.Add(new Player("Mustafa Talak", "Talak", 16998168, "Antalya", "Eskişehir Go Oyuncuları Derneği"));
            players.Add(new Player("Nevriye Çerçioğlu", "nevriye", -1, "Ankara", "–"));
            players.Add(new Player("Ogün Gökpınar", "ogun", 16750371, "İstanbul", "–"));
            players.Add(new Player("Oğulkan Bir", "Atababa", 19086463, "Ankara", "Ankara Go Oyuncuları Derneği"));
            players.Add(new Player("Oğuz Zerman", "zerman", 19537716, "Ankara", "–"));
            players.Add(new Player("Okan Kaynak", "okanyak", 16050540, "Denizli", "Türkiye Go Oyuncuları Derneği"));
            players.Add(new Player("Orhan Can Acar", "Askonsa", 15649810, "İstanbul", "İstanbul Go Oyuncuları Derneği"));
            players.Add(new Player("Övünç Balcı", "Comet", 16533209, "İzmir", "–"));
            players.Add(new Player("Özlem Ersoy", "Tuxedocat", 18201348, "İzmir", "İzmir Go Oyuncuları Derneği"));
            players.Add(new Player("Remzi öz", "remzioz", 19001037, "İstanbul", "İstanbul Go Oyuncuları Derneği"));
            players.Add(new Player("Selçuk Mola", "siyahbeyaz", 16937162, "Antalya", "–"));
            players.Add(new Player("Selçuk Toker", "Karga", 18450784, "Eskişehir", "Eskişehir Go Oyuncuları Derneği"));
            players.Add(new Player("Servet Daşdemir", "serbetoo", 17637367, "İstanbul", "İstanbul Go Oyuncuları Derneği"));
            players.Add(new Player("Uğur Arıkan", "tcorc", 17374423, "Ankara", "Türkiye Go Oyuncuları Derneği"));
            players.Add(new Player("Uygar Tavşanoğlu", "Strang3", 17598350, "Ankara", "Diğer"));
            players.Add(new Player("Yetkin Eser", "addict", 16598945, "İstanbul", "İstanbul Go Oyuncuları Derneği"));


            return players;
        }

        public static List<GoGame> GetHandicapGroupAGames(AGoCompetition goCompetition)
        {
            List<GoGame> Games = new List<GoGame>();

            string Path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            Path += "\\AvansliAGrubuFikstur.txt";

            Games = GetGoGames(goCompetition,"A Grubu", Path);

            return Games;
        }

        public static List<GoGame> GetHandicapGroupBGames(AGoCompetition goCompetition)
        {
            List<GoGame> Games = new List<GoGame>();

            string Path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            Path += "\\AvansliBGrubuFikstur.txt";

            Games = GetGoGames(goCompetition, "B Grubu", Path);

            return Games;
        }

        public static List<GoGame> GetNoHandicapGroupAGames(AGoCompetition goCompetition)
        {
            List<GoGame> Games = new List<GoGame>();

            string Path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            Path += "\\AGrubuFikstur.txt";

            Games = GetGoGames(goCompetition, "A Grubu", Path);

            return Games;
        }

        public static List<GoGame> GetNoHandicapGroupBGames(AGoCompetition goCompetition)
        {
            List<GoGame> Games = new List<GoGame>();

            string Path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            Path += "\\BGrubuFikstur.txt";

            Games = GetGoGames(goCompetition, "B Grubu", Path);

            return Games;
        }

        private static Player GetGoPlayerByName(List<Player> playerList, string name)
        {
            if (playerList.Any((x) => x.Name == name))
            {
                return playerList.FirstOrDefault((x) => x.Name == name);
            }

            return null;
        }

        private static List<GoGame> GetGoGames(AGoCompetition goCompetition, string groupName, string Path)
        {
            List<GoGame> Games = new List<GoGame>();

            using (StreamReader sr = new StreamReader(Path))
            {
                var line = "";
                int stage = 1;
                while (true)
                {
                    line = sr.ReadLine();
                    if (line != null)
                    {
                        var split = line.Split(',');
                        if (split.Count() == 1)
                        {
                            stage = Convert.ToInt32(split[0].Replace("Maç ", string.Empty));
                        }
                        else if (split.Count() == 2)
                        {
                            Player player1 = GetGoPlayerByName(goCompetition.Players, split[0]);
                            Player player2 = GetGoPlayerByName(goCompetition.Players, split[1]);
                            GoGame game = new GoGame(goCompetition, groupName, stage, player1, player2);

                            Games.Add(game);
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return Games;
        }

    }
}
