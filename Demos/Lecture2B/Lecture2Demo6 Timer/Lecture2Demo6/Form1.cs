/*CMPE 1666- Intermediate Programming
 * Lecture2B- Working with Timers
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lecture2Demo6
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
            Text = $"count is: {++count} - No. of Milliseconds: {sw.ElapsedMilliseconds}";
            //Add mutiples of 20 to the listbox
            if (count % 20 == 0)
                UI_DisplayCount_ListBox.Items.Add($"Count is: {count}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //We start the stopwatch at Form-load
            sw.Start();
        }

        private void UI_Stop_Btn_Click(object sender, EventArgs e)
        { //Stop the stopwatch
            sw.Stop();
        }
    }
}
