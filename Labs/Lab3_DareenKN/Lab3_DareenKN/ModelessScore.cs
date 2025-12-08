/* CMPE1666 - Intermdiate Programming
 * Name: Dareen Kinga Njatou
 * 
 * Description: Modeless dialog to display the user score
 *              while the game is on going. Called through 
 *              the show score checkbox checked value.
 *              
 * Date: November 29, 2025
 */
using System.Windows.Forms;

namespace Lab3_DareenKN
{
    public partial class ModelessScore : Form
    {
        // Delegates initialisation
        public delVoidVoid _dFormClosing = null;
        public delVoidInt _dScoreChanged;

        public ModelessScore()
        {
            InitializeComponent();
        }

        private void ModelessScore_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Is the dialog being closed by the user
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Checking to ensure that the delegate reference has been initialised
                if (null != _dFormClosing)
                    // Invoke the delegate as a method
                    _dFormClosing();

                // Stop the closing from happening
                e.Cancel = true;

                // Hide the dialog
                Hide();
            }
        }

        public void CallBackTextChanged(int score)
        {
            UI_Score_Lbl.Text = $"{score}";
        }

    }
}
