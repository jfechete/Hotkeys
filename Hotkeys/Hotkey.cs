using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotkeys
{
    class Hotkey
    {
    }

    public class HotkeyHttpClient
    {
        const string DEFAULT_URL = "http://localhost:8080/";
        const int DEFAULT_PORT = 8080;

        static HttpClient client = new HttpClient();

        static HotkeyHttpClient()
        {

            //initialize stuff


            //create the client
            client.BaseAddress = new Uri(DEFAULT_URL);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<String> GetRandomHotkey()
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
