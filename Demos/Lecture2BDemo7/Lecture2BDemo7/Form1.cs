/* CMPE 1666 - Intermediate Programming
 * 
 * Name: Dareen Kinga Njatou
 * Description: For uniformity with my code, it's recommended that you name the
                textboxes Ul Item1Cost Tbx, Ul Item2Cost Tbx and Ul TotalCost Tbx
                Name the button Ul TotalCost Btn and the checkbox Ul GST Cbx
                Implement the method and event handler requested in the next slide.
 * 
 * Date: September 16, 2025 
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
            string item1 = UI_Item1Cost_Tbx.Text;
        }

        private void UI_TotalCost_Btn_Click(object sender, EventArgs e)
        {
            
            UI_TotalCost_Tbx.Text = $"{CalculateTotalCost(UI_Item1Cost_Tbx.Text, UI_Item2Cost_Tbx.Text, UI_GST_Cbx.Checked)}";
        }

        private void UI_GST_Cbx_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotalCost(UI_Item1Cost_Tbx.Text, UI_Item2Cost_Tbx.Text, UI_GST_Cbx.Checked);
        }

        static decimal CalculateTotalCost(string val1, string val2, bool addGST)
        {      
            decimal.TryParse(val1, out decimal item1);
            decimal.TryParse(val2, out decimal item2);

            decimal sum = item1 + item2;

            if (addGST == true)            
                sum = sum + (sum * 0.05m);

            return sum;
        }

        
    }
}
