using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture2BDemo5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_ClickMe_Btn_Click(object sender, EventArgs e)
        {
            // We obtain the value from the textbox
            string name = UI_Input_Tbx.Text;

            // We build the string and display it in the message box
            string displayString = $"The name given was: {name}";

            //MessageBox.Show(displayString);

            MessageBox.Show($"The name given was: {name}");
        }
    }
}
