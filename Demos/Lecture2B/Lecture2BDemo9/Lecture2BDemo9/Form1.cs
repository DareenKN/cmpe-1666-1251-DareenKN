/*CMPE 1666- Intermediate Programming
 * 
 * Lecture2B- Demo9- Working with Event Consolidation
 * between events on 3 checkboxes and a textbox
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

namespace Lecture2BDemo9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //This method is actually an event handler
        //linked to the CheckChanged Event of the
        //3 radio buttons and the TextChanged event of the 
        //input TextBox
        private void UI_CalculateCost(object sender, EventArgs e)
        {
            if (double.TryParse(UI_Input_Tbx.Text,out double cost))
            { double taxRate = 0.0;
                if (UI_5Percent_Radio.Checked)
                    taxRate = 0.05;
                else if (UI_7Percent_Radio.Checked)
                    taxRate = 0.07;
                else
                    taxRate = 0.10;

                double totalCost = cost * (1 + taxRate);
                UI_TotalCost_Tbx.Text = $"{totalCost:F2}";
            }

            
        }
    }
}
