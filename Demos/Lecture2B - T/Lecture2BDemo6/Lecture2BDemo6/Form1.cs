using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture2BDemo6
{
    public partial class Form1 : Form
    {
        private Stopwatch sw = new Stopwatch();
        private int count;
        
        public Form1()
        {
            InitializeComponent();
            count = 0;
        }

        private void UI_Test_Timer_Tick(object sender, EventArgs e)
        {
            Text = $"count is: {++count} - No of miliseconds: {sw.ElapsedMilliseconds}";

            // Add multiples of 20 to the listbox
            if (count % 20 == 0)
                UI_DisplayCount_ListBox.Items.Add($"Count is: {count}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // We start the stop watch at Form Load
            sw.Start();
        }

        private void UI_Stop_Btn_Click(object sender, EventArgs e)
        {
            // Stop the watch
            sw.Stop();
        }
    }
}
