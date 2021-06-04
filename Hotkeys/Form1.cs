using System;
using System.Windows.Forms;

namespace Hotkeys
{
    public partial class Form1 : Form
    {
        //main methods/events
        public Form1()
        {
            InitializeComponent();
            RandomHotkey();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            RandomHotkey();
        }

        private void btnFromCategory_Click(object sender, EventArgs e)
        {
            CategorySelect categoryChoose = new CategorySelect();
            categoryChoose.HotkeyDisplay = this;
            categoryChoose.Show();
        }

        private void btnFromKeys_Click(object sender, EventArgs e)
        {
            HotkeySearch searchFrom = new HotkeySearch();
            searchFrom.HotkeyDisplay = this;
            searchFrom.Show();
        }

        //helper methods
        private async void RandomHotkey()
        {
            Hotkey random = await Hotkey.RandomHotkey();
            ApplyHotkey(random);
        }

        internal void ApplyHotkey(Hotkey showing)
        {
            dispProgram.Text = showing.Program;
            dispCategory.Text = showing.Category;
            dispHotkey.Text = showing.Shortcut;
            dispDescription.Text = showing.Action;
        }
    }
}
