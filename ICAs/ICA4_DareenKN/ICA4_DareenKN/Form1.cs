/* CMPE1666 - Intermediate Programming   
 * 
 * Name: Dareen Kinga Njatou
 * Description: Calculates the total rental cost based on user inputs including vehicle type,
 *              number of rental days, optional insurance, and applicable discounts.
 * 
 * Date: September 23, 2025
 */
using System;
using System.Windows.Forms;

namespace ICA4_DareenKN
{
    public partial class Form1 : Form
    {
        // Constructor
        public Form1()
        {
            InitializeComponent();

            // Attach event handler to NumericUpDown value change to update total
            UI_NumDays_Nud.ValueChanged += (s, e) => CalculateTotal();

            // Attach event handlers to checkboxes to recalculate total on change
            UI_AMADiscount_Cbx.CheckedChanged += (s, e) => CalculateTotal();
            UI_Insurance_Cbx.CheckedChanged += (s, e) => CalculateTotal();
        }

        /// <summary>
        /// If the name textbox is not empty, enable the controls panel and calculate the total.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_InputName_Tbx_TextChanged(object sender, EventArgs e)
        {
            // Enable the controls panel only if the name textbox is not empty
            if (!string.IsNullOrEmpty(UI_InputName_Tbx.Text))
            {
                UI_Controls_Panel.Enabled = true;

                // Forces update of total when name is entered
                UI_Radio_CheckedChanged(null, null); 
            }

            // Disable the controls panel and reset total if the name textbox is empty
            else
            {
                UI_Controls_Panel.Enabled = false;
                UI_TotalOutput_Lbl.Text = $"{0:C}";
            }                
        }

        /// <summary>
        /// Event handler for radio button checked change to recalculate total.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_Radio_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        /// <summary>
        /// Calculates the total rental cost based on the selected vehicle type, number of rental days,  optional
        /// insurance, and applicable discounts.
        /// </summary>
        /// <remarks>This method determines the total cost by considering the selected vehicle type,  the
        /// number of rental days, whether insurance is included, and whether an AMA discount is applied.  The
        /// calculated total is displayed in the user interface.</remarks>
        private void CalculateTotal()
        {
            int numDays = 0;            // Number of rental days
            double amount = 0.00;       // Base rental amount
            double insurance = 0.00;    // Insurance cost
            double AMADiscount = 0.10;  // AMA discount rate
            double totalAmount = 0.00;  // Total rental cost

            // Get the number of rental days from the numeric up-down control
            numDays = (int)UI_NumDays_Nud.Value;

            // Determine the base rental amount based on the selected vehicle type
            if (UI_Small_Radio.Checked)
                amount = 40.00 * numDays;
            else if (UI_Midsize_Radio.Checked)
                amount = 50.00 * numDays;
            else if (UI_Sports_Radio.Checked)
                amount = 60.00 * numDays;

            // Calculate insurance cost if the insurance checkbox is checked
            if (UI_Insurance_Cbx.Checked)
                insurance = 15.00 * numDays;

            // Calculate the total amount
            totalAmount = amount + insurance;

            // Apply AMA discount if the AMA discount checkbox is checked
            if (UI_AMADiscount_Cbx.Checked)
                totalAmount -= totalAmount * AMADiscount;

            // Update the total output label with the formatted total amount
            UI_TotalOutput_Lbl.Text = $"{totalAmount:C}";
        }
    }
}
