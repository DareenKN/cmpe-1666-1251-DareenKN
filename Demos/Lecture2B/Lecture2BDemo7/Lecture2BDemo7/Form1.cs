/*CMPE 1666-Intermediate Programming
 * 
 * Lecture 2B- Demo7- working with Checkboxes
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

namespace Lecture2BDemo7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         /// <summary>
         /// CalulateTotalCost - has as parameters 2 string values representing
         /// the costs of 2 items as obtained from textboxes. It converts the value
         /// to numerical, and performs the sum.
         /// It also has a boolean paramter flag representing the checked sate of a checkbox.
         /// If the flag is true, it calculates and adds the GSt assuming 5% GST rate
         /// </summary>
         /// <param name="val1">string parameter representing cost of first item</param>
         /// <param name="val2">string parameter representing cost of a second item</param>
         /// <param name="flag">boolean representing a checked state</param>
         /// <returns></returns>
        private decimal CalculateTotalCosts(string val1, string val2, bool flag)
        {
            //convert the 2 string values to decimal
            decimal.TryParse(val1, out decimal cost1);
            decimal.TryParse(val2, out decimal cost2);
            decimal sum = cost1 + cost2;
            if (flag)// we add the GST value
            {
                sum *= 1.05m; //Assuming a GST value of 5%
            }

            return sum;

        }

        private void UI_TotalCost_btn_Click(object sender, EventArgs e)
        {
            string costValue1 = UI_Item1Cost_Tbx.Text;
            string costValue2 = UI_Item2Cost_Tbx.Text;

            decimal totalCost = CalculateTotalCosts(costValue1,costValue2,UI_GST_Cbx.Checked);
            UI_TotalCost_Tbx.Text = $"{totalCost:F2}";
        }

        private void UI_GST_Cbx_CheckedChanged(object sender, EventArgs e)
        {
            string costValue1 = UI_Item1Cost_Tbx.Text;
            string costValue2 = UI_Item2Cost_Tbx.Text;

            decimal totalCost = CalculateTotalCosts(costValue1, costValue2, UI_GST_Cbx.Checked);
            UI_TotalCost_Tbx.Text = $"{totalCost:F2}";
        }
    }
}
