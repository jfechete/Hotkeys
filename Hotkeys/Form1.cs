using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotkeys
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            Console.Out.WriteLine();
        }

        private async void btnRandom_Click(object sender, EventArgs e)
        {
            string item = await HotkeyHttpClient.GetRandomHotkey();
            Console.WriteLine(item);
        }
    }
}
