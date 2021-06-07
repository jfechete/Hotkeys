using System;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;
using System.Configuration;

namespace Hotkeys
{

    public partial class Form1 : Form
    {
        static bool DEFAULT_SHOW_WARNING = false;
        static string SHOW_WARNING_CONFIG_KEY = "warning";
        //main methods/events
        public Form1()
        {
            InitializeComponent();
            RandomHotkey();
            HideWarning();
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
            try
            {
                Hotkey random = await Hotkey.RandomHotkey();
                ApplyHotkey(random);
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("Failed to connect to server", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            catch (WebException err)
            {
                MessageBox.Show(err.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void ApplyHotkey(Hotkey showing)
        {
            dispProgram.Text = showing.Program;
            dispCategory.Text = showing.Category;
            dispHotkey.Text = showing.Shortcut;
            dispDescription.Text = showing.Action;
        }

        void HideWarning()
        {
            string showWarning = ConfigurationManager.AppSettings[SHOW_WARNING_CONFIG_KEY];
            if (showWarning == null)
            {
                showWarning = DEFAULT_SHOW_WARNING.ToString();
            }
            if (!bool.Parse(showWarning))
            {
                Size = new System.Drawing.Size(Size.Width, Size.Height-ClientSize.Height + lblNotice.Top);
                lblNotice.Visible = false;
            }
        }
    }
}
