/*CMPE 1666- Intermediate Programming
 * 
 * Lecture 2B- Event-Consolidation Demo
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
using System.Windows.Forms;

namespace eventConsolidationDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
       
        /*This is event consolidation. Instead of writing code for 3 event handlers,
         * we link the CheckChanged event of all 3 buttons to 
         * one event-handler. 
         * 
         * 
         */
        private void UI_Radio_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_Red_Radio.Checked)
                UI_Color_Tbx.BackColor = Color.Red;
            else if (UI_Green_Radio.Checked)
                UI_Color_Tbx.BackColor = Color.Green;
            else UI_Color_Tbx.BackColor = Color.Blue;
        }
    }
}
