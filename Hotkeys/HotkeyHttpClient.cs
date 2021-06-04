using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Newtonsoft.Json;

namespace Hotkeys
{
    public class HotkeyHttpClient
    {
        //fields
        const string URL_CONFIG_KEY = "endpoint";
        const string PORT_CONFIG_KEY = "port";

        const string RANDOM_HOTKEY_POINT = "";
        const string ALL_PROGRAMS_POINT = "/programs";

        const string DEFAULT_URL = "http://localhost/";
        const int DEFAULT_PORT = 8080;

        static HttpClient client = new HttpClient();

        //initial function
        static HotkeyHttpClient()
        {

            //get variables
            string url = ConfigurationManager.AppSettings[URL_CONFIG_KEY];
            if (url == null)
            {
                url = DEFAULT_URL;
            }
            string port = ConfigurationManager.AppSettings[PORT_CONFIG_KEY];
            if (port == null)
            {
                port = DEFAULT_PORT.ToString();
            }

            url = ChangePort(url,int.Parse(port));
            
            //create the client
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        //public methods
        public static async Task<string> GetRandomHotkey()
        {
            HttpResponseMessage response = await client.GetAsync(RANDOM_HOTKEY_POINT);
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                return data;
            }
            else
            {
                Console.Out.WriteLine(response.Headers);
                MessageBox.Show(response.ReasonPhrase, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        public static async Task<string[]> GetPrograms()
        {
            HttpResponseMessage response = await client.GetAsync(ALL_PROGRAMS_POINT);
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                dynamic json = JsonConvert.DeserializeObject(data);
                string[] returnValue = new string[json.Count];
                for (int i = 0; i < returnValue.Length; i++)
                {
                    returnValue[i] = json[i].ToString();
                }
                return returnValue;
            }
            else
            {
                MessageBox.Show(response.ReasonPhrase, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //helper methods
        static string ChangePort(string requestUrl, int port)
        {
            var uri = new UriBuilder(requestUrl);
            uri.Port = port;
            return uri.Uri.AbsoluteUri;
        }
    }
}
