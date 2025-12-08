/* CMPE1666 - Intermediate Programming
 * Name: Dareen Kinga Njatou
 *
 * Description: CMPE 1666-ICA13 – Fontify
 *               Creating and using support dialogs and public methods
 *               to change the font color and font of a label's text.
 *  
 * Date: November 20, 2025
 */
using System;
using System.Windows.Forms;

namespace ICA13_DareenKN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// if the Label is clicked, open the Modal Dialog to select Font and Color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_DisplayFont_Lbl_Click(object sender, EventArgs e)
        {
            // Create an object of the Modal Dialog
            ModalFontProperty dialog = new ModalFontProperty();

            // Set the initial Font and Color in the Dialog
            dialog.SetFont(UI_DisplayFont_Lbl.Font);
            dialog.SetColor(UI_DisplayFont_Lbl.ForeColor);

            // Show Dialog
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // Update the Label's Font and Color based on user selection
                UI_DisplayFont_Lbl.Font = dialog.FontSelected();
                UI_DisplayFont_Lbl.ForeColor = dialog.ColorSelected();
            }

            // If dialog was closed with Cancel or X button
            else
                MessageBox.Show("Dialog was closed with Cancel or X button");            
        }
    }
}
