using System.Windows.Forms;

namespace Hotkeys
{
    public partial class CategorySelect : Form
    {
        const int DROPDOWN_EXTRA_SPACE = 20;
        public CategorySelect()
        {
            InitializeComponent();
            SetPrograms();
        }
        
        async void SetPrograms()
        {
            //add all programs
            foreach (string program in await HotkeyHttpClient.GetPrograms())
            {
                slctProgram.Items.Add(program);
            }
            //resize box
            int maxWidth = 0, temp = 0;
            foreach (var obj in slctProgram.Items)
            {
                temp = TextRenderer.MeasureText(obj.ToString(), slctProgram.Font).Width;
                if (temp > maxWidth)
                {
                    maxWidth = temp;
                }
            }
            slctProgram.Width = maxWidth + DROPDOWN_EXTRA_SPACE;
        }
    }
}
