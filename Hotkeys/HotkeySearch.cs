using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;

namespace Hotkeys
{
    public partial class HotkeySearch : Form
    {
        //fields 
        static Dictionary<Keys,string> keyMap = new Dictionary<Keys,string> {
            { Keys.D0, "0" }, { Keys.D1, "1" }, { Keys.D2, "2" }, { Keys.D3, "3" },
            { Keys.D4, "4" }, { Keys.D5, "5" }, { Keys.D6, "6" }, { Keys.D7, "7" },
            { Keys.D8, "8" }, { Keys.D9, "9" }, { Keys.A, "A" }, { Keys.Menu, "Alt" },
            { Keys.B, "B" }, { Keys.Back, "Backspace" }, { Keys.C, "C" },
            { Keys.Oemcomma, "Comma" }, { Keys.ControlKey, "Ctrl" }, { Keys.D, "D" }, { Keys.Delete, "Delete" },
            { Keys.Down, "Down arrow" }, { Keys.E, "E" }, { Keys.End, "End" }, { Keys.Enter, "Enter" },
            { Keys.Oemplus, "Equal sign" }, { Keys.Escape, "Esc" }, { Keys.F, "F" }, { Keys.F1, "F1" },
            { Keys.F2, "F2" }, { Keys.F3, "F3" }, { Keys.F4, "F4" }, { Keys.F5, "F5" },
            { Keys.F6, "F6" }, { Keys.F7, "F7" }, { Keys.F8, "F8" }, { Keys.F9, "F9" },
            { Keys.F10, "F10" }, { Keys.F11, "F11" }, { Keys.F12, "F12" }, { Keys.G, "G" },
            { Keys.Oem3, "Grave accent" }, { Keys.H, "H" }, { Keys.Home, "Home" }, { Keys.I, "I" },
            { Keys.Insert, "Insert" }, { Keys.J, "J" }, { Keys.K, "K" }, { Keys.L, "L" },
            { Keys.Left, "Left arrow" }, { Keys.OemOpenBrackets, "Left bracket" }, { Keys.M, "M" }, { Keys.OemMinus, "Minus sign" },
            { Keys.N, "N" }, { Keys.O, "O" }, { Keys.P, "P" }, { Keys.PageDown, "Page down" },
            { Keys.PageUp, "Page up" }, { Keys.OemPeriod, "Period" }, { Keys.Q, "Q" }, { Keys.OemQuotes, "Quote" },
            { Keys.R, "R" }, { Keys.Right, "Right arrow" }, { Keys.OemCloseBrackets, "Right bracket" }, { Keys.S, "S" },
            { Keys.Scroll, "Scroll lock" }, { Keys.OemSemicolon, "Semicolon" }, { Keys.ShiftKey, "Shift" }, { Keys.OemQuestion, "Slash" },
            { Keys.Space, "Space" }, { Keys.T, "T" }, { Keys.Tab, "Tab" }, { Keys.U, "U" },
            { Keys.Up, "Up arrow" }, { Keys.V, "V" }, { Keys.W, "W" }, { Keys.LWin, "Windows key" },
            { Keys.RWin, "Windows key" }, { Keys.X, "X" }, { Keys.Y, "Y" }, { Keys.Z, "Z" }
        };

        const string KEY_SEPARATOR = ",";
        const int DROPDOWN_EXTRA_SPACE = 20;

        public Form1 HotkeyDisplay { private get; set; }
        Guid _searchSession;

        //events and main methods
        public HotkeySearch()
        {
            InitializeComponent();
            dispKeys.Text = string.Empty;
        }

        private void HotkeySearch_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            e.Handled = true;
            if (keyMap.ContainsKey(e.KeyCode))
            {
                if (dispKeys.Text != string.Empty)
                {
                    dispKeys.Text += KEY_SEPARATOR;
                }
                dispKeys.Text += keyMap[e.KeyCode];
            }

            //do this in case they press A,B, and the api returns in order B,A
            _searchSession = Guid.NewGuid();
            UpdateKeys(_searchSession);
        }

        private void btnResetKeys_Click(object sender, EventArgs e)
        {
            dispKeys.Text = string.Empty;
        }

        private void listHotkeys_SelectedIndexChanged(object sender, EventArgs e)
        {
            HotkeyDisplay.ApplyHotkey((Hotkey)listHotkeys.SelectedItem);
            Close();
        }

        //helper methods
        async void UpdateKeys(Guid mySession)
        {
            if (dispKeys.Text != string.Empty)
            {
                try
                {
                    Hotkey[] hotkeys = await Hotkey.SearchHotkeys(dispKeys.Text);
                    if (_searchSession == mySession)
                    {
                        UpdateListBox(listHotkeys, hotkeys, false);
                    }
                }
                catch (WebException err)
                {
                    MessageBox.Show(err.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
        }

        void UpdateListBox(ListBox box, object[] values, bool resize)
        {
            //remove old values
            box.Items.Clear();

            //add all values
            foreach (object value in values)
            {
                box.Items.Add(value);
            }

            //resize box
            if (resize)
            {
                int maxWidth = 0, temp = 0;
                foreach (object obj in box.Items)
                {
                    temp = TextRenderer.MeasureText(obj.ToString(), box.Font).Width;
                    if (temp > maxWidth)
                    {
                        maxWidth = temp;
                    }
                }
                box.Width = maxWidth + DROPDOWN_EXTRA_SPACE;
            }
        }
    }
}
