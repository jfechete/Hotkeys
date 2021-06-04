using System;
using System.Windows.Forms;

namespace Hotkeys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RandomTip();
        }

        private void ApplyHotkey(Hotkey showing)
        {
            dispProgram.Text = showing.Program;
            dispCategory.Text = showing.Category;
            dispHotkey.Text = showing.Shortcut;
            dispDescription.Text = showing.Action;
        }

        private async void RandomTip()
        {
            Hotkey random = await Hotkey.RandomHotkey();
            ApplyHotkey(random);
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            RandomTip();
        }
    }
}
