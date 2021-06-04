using Newtonsoft.Json;
using System.Threading.Tasks;

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
}
