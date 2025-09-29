using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventConsolidationDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_Red_Radio_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_Red_Radio.Checked)
                UI_Color_Tbx.BackColor = Color.Red;
        }

        private void UI_Green_Radio_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_Green_Radio.Checked)
                UI_Color_Tbx.BackColor = Color.Green;
        }

        private void UI_Blue_Radio_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_Blue_Radio.Checked)
                UI_Color_Tbx.BackColor = Color.Blue;
        }
    }
}
