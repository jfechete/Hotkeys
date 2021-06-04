﻿using System;
using System.Windows.Forms;

namespace Hotkeys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RandomHotkey();
        }

        internal void ApplyHotkey(Hotkey showing)
        {
            dispProgram.Text = showing.Program;
            dispCategory.Text = showing.Category;
            dispHotkey.Text = showing.Shortcut;
            dispDescription.Text = showing.Action;
        }

        private async void RandomHotkey()
        {
            Hotkey random = await Hotkey.RandomHotkey();
            ApplyHotkey(random);
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
    }
}
