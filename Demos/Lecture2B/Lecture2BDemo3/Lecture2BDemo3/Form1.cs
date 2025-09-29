/*CMPE 1666- Intermediate Programming
 * 
 * Lecture 2B- Demo 3
 * 
 * Performing inputs and sum for numerical values
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

namespace Lecture2BDemo3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_CalculateSum_Btn_Click(object sender, EventArgs e)
        {

            int.TryParse(UI_Value1_Tbx.Text, out int val1);
            int.TryParse(UI_Value2_Tbx.Text, out int val2);
            UI_Sum_Tbx.Text = $"{ val1 + val2}";
        }
    }
}
