using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Hotkeys
{
    class Hotkey
    {
        //fields
        public string Program { get; private set; }
        public string Category { get; private set; }
        public string Shortcut { get; private set; }
        public string Action { get; private set; }

        //constructor
        public Hotkey(string program, string category, string shortcut, string action)
        {
            Program = program;
            Category = category;
            Shortcut = shortcut;
            Action = action;
        }

        //static methods
        public static async Task<Hotkey> RandomHotkey()
        {
            dynamic json = JsonConvert.DeserializeObject(await HotkeyHttpClient.GetRandomHotkey());
            return new Hotkey(json.Program.ToString(), json.Category.ToString(), json.Shortcut.ToString(), json.Action.ToString());
        }
    }

    public class HotkeyHttpClient
    {
        const string URL_CONFIG_KEY = "endpoint";

        const string DEFAULT_URL = "http://localhost:8080/";
        const int DEFAULT_PORT = 8080;

        static HttpClient client = new HttpClient();

        static HotkeyHttpClient()
        {

            //initialize stuff
            string url = ConfigurationManager.AppSettings[URL_CONFIG_KEY];
            if (url == null)
            {
                url = DEFAULT_URL;
            }

            //create the client
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<string> GetRandomHotkey()
        {
            HttpResponseMessage response = await client.GetAsync("");
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                return data;
            }
            else
            {
                MessageBox.Show(response.ReasonPhrase, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }
    }
}
