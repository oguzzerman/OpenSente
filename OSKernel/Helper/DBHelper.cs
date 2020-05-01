using Newtonsoft.Json;
using OSKernel.GoPlayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OSKernel.Helper
{
    public class DBHelper
    {
        public DBHelper()
        {

        }

        public static async Task<EGDPlayer> GetPlayerByIDUsingHttpClient(int pinCode)
        {
            string link = "https://www.europeangodatabase.eu/EGD/GetPlayerDataByPIN.php?pin=" + pinCode.ToString();

            EGDPlayer ret = new EGDPlayer();

            try
            {
                using (var client = new HttpClient())
                {
                    //client.DefaultRequestHeaders.Add("Accept", "application/json");
                    var response = await client.GetAsync(link).ConfigureAwait(false);
                    var content = response.Content.ReadAsStringAsync().Result;
                    ret = JsonConvert.DeserializeObject<EGDPlayer>(content);
                    ret.Last_Appearance = DateTime.Now.ToLongDateString() + " - " + DateTime.Now.ToLongTimeString();
                }
            }
            catch (Exception)
            {
                // No internet connection
            }

            if (ret == null)
            {
                ret = new EGDPlayer();
            }

            return ret;
        }

        public static EGDPlayer GetPlayerByIDUsingWebRequest(int pinCode)
        {
            string link = "https://www.europeangodatabase.eu/EGD/GetPlayerDataByPIN.php?pin=" + pinCode.ToString();

            EGDPlayer ret;

            WebRequest myWebRequest = WebRequest.Create(link);

            // Assign the response object of 'WebRequest' to a 'WebResponse' variable.
            WebResponse myWebResponse = myWebRequest.GetResponse();

            Stream streamResponse = myWebResponse.GetResponseStream();
            StreamReader reader = new StreamReader(streamResponse);

            // Read the content.
            string responseFromServer = reader.ReadToEnd();

            ret = JsonConvert.DeserializeObject<EGDPlayer>(responseFromServer);

            if (ret == null)
            {
                ret = new EGDPlayer();
            }

            return ret;
        }

        public static async Task<List<EGDPlayer>> GetAllPlayersUsingHttpClient(List<Player> players)
        {
            List<EGDPlayer> ret = new List<EGDPlayer>();

            try
            {
                for (int i = 0; i < players.Count; i++)
                {
                    var player = players[i];
                    string link = "https://www.europeangodatabase.eu/EGD/GetPlayerDataByPIN.php?pin=" + player.EGDPinCode.ToString();


                    using (var client = new HttpClient())
                    {
                        //client.DefaultRequestHeaders.Add("Accept", "application/json");
                        var response = await client.GetAsync(link).ConfigureAwait(false);
                        var content = response.Content.ReadAsStringAsync().Result;
                        EGDPlayer egdPlayer = JsonConvert.DeserializeObject<EGDPlayer>(content);
                        if (egdPlayer != null)
                        {
                            ret.Add(egdPlayer);
                        }
                    }
                }
            }
            catch (Exception)
            {
                // No internet connection
            }


            return ret;
        }

    }
}
