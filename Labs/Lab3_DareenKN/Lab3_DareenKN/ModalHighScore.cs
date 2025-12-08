/* CMPE1666 - Intemediate Programming
 * Name: Dareen Kinga Njatou
 * 
 * Description: This modal dialogs appears at the end of the game when the
 *              current user has made a high score in the selected difficulty
 *              and asks his name which will then be stored in a file
 *              
 * Date: November 29, 2025
 */
using System;
using System.Windows.Forms;

namespace Lab3_DareenKN
{
    public partial class ModalHighScore : Form
    {
        public ModalHighScore()
        {
            InitializeComponent();
        }

        private void UI_OK_Btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void UI_Cancel_Btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public string InputName()
        {
            string name = UI_InputName_Tbx.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a name.");
                return "";  // or return null
            }

            return name;
        }

    }
}
