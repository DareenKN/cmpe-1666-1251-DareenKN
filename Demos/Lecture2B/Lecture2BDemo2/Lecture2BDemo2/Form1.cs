/*
 * CMPE 1666 - Intermediate Programming
 * 
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

namespace Lecture2BDemo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_TransferToLabel_Btn_Click(object sender, EventArgs e)
        {
            UI_Output_Lbl.Text = UI_Input_Tbx.Text;
            UI_Input_Tbx.Clear();
        }
    }
}
