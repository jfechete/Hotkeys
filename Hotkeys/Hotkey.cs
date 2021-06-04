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
            return JsonToHotkey(json);
        }

        public static async Task<Hotkey[]> AllCategoryHotkeys(string program, string category)
        {
            dynamic json = JsonConvert.DeserializeObject(await HotkeyHttpClient.GetCategoryHotkeys(program, category));
            Hotkey[] returnValue = new Hotkey[json.Count];
            for (int i = 0; i < returnValue.Length; i++)
            {
                returnValue[i] = JsonToHotkey(json[i]);
            }
            return returnValue;
        }

        //instance methods
        public override string ToString()
        {
            return string.Format("{0}, {1}: {2}", Program, Category, Shortcut);
        }

        //helper methods
        static Hotkey JsonToHotkey(dynamic json)
        {
            return new Hotkey(json.Program.ToString(), json.Category.ToString(), json.Shortcut.ToString(), json.Action.ToString());
        }
    }
}
