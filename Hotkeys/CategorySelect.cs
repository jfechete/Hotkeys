using System;
using System.Windows.Forms;

namespace Hotkeys
{
    public partial class CategorySelect : Form
    {
        //fields
        const int DROPDOWN_EXTRA_SPACE = 20;
        public Form1 HotkeyDisplay { private get; set; }

        //events
        public CategorySelect()
        {
            InitializeComponent();
            RefreshPrograms();
        }

        private void slctProgram_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            RefreshCategories();
        }

        private void slctCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshHotkeys();
        }

        private void listTips_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayHotkey();
        }

        //main methods
        async void RefreshPrograms()
        {
            UpdateComboBox(slctProgram, await HotkeyHttpClient.GetPrograms(),true);
        }

        async void RefreshCategories()
        {
            UpdateComboBox(slctCategory, await HotkeyHttpClient.GetCategories(slctProgram.SelectedItem.ToString()),true);
        }

        async void RefreshHotkeys()
        {
            UpdateListBox(listHotkeys, await Hotkey.AllCategoryHotkeys(slctProgram.SelectedItem.ToString(), slctCategory.SelectedItem.ToString()),false);
        }

        void DisplayHotkey()
        {
            HotkeyDisplay.ApplyHotkey((Hotkey)listHotkeys.SelectedItem);
            Close();
        }

        //helper methods
        void UpdateComboBox(ComboBox box, object[] values, bool resize)
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
                    box.Width = maxWidth + DROPDOWN_EXTRA_SPACE;
                }
            }
        }

        //thought Items would be a property of ListControl but it isn't. Is there something I'm missing?
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
