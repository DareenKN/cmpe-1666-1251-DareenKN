/* CMPE1666 - Intermediate Programming
 * Name: Dareen Kinga Njatou
 * 
 * Description: Modal dialog in which the user selects the difficulty 
 *              level of the Game. Based on the, range of colours are
 *              initialised in the Game
 * 
 */
using System;
using System.Windows.Forms;

namespace Lab3_DareenKN
{
    public partial class ModalSelectDifficulty : Form
    {
        public ModalSelectDifficulty()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Will save what ever has been done in the dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_OK_Btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        // Cancels any action done in the dialog
        private void UI_Cancel_Btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Returns values based on radio buttons which will help in selecting the 
        /// mode of the game as well as the number of staters colours
        /// </summary>
        /// <returns></returns>
        public int SelectedMode()
        {
            if (UI_Easy_Radio.Checked)
                return 3;   // Selected values from 3 to 5 to fix also the random colours directly
            else if (UI_Medium_Radio.Checked)
                return 4;
            else if (UI_Hard_Radio.Checked)
                return 5;

            return 3;   // Return the easy mode by default
        }
    }
}
