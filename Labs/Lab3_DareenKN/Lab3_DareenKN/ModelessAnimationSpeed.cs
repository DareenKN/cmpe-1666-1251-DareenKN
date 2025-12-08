/* CMPE1666 - Intermediate Programming
 * Name: Dareen Kinga Njatou
 * 
 * Description: Animation Speed Modaless dialog shows up to
 *              let the user determine the delay to be used 
 *              when balls are dropping in the GDIDrawer window.
 * 
 * Date: November 29, 2025
 */
using System;
using System.Windows.Forms;

namespace Lab3_DareenKN
{
    public partial class ModelessAnimationSpeed : Form
    {
        public delVoidVoid _dFormClosing = null;
        public delVoidInt _dSpeedChanged = null;

        public ModelessAnimationSpeed()
        {
            InitializeComponent();

            int speed = UI_AnimationSpeed_Track.Value * 10;
            Text = $"Animation Speed: {speed}ms";
        }

        private void ModelessAnimationSpeed_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Is it the user that closed the dialog
            if(e.CloseReason == CloseReason.UserClosing)
            {
                if (null != _dFormClosing)                     
                    _dFormClosing();    // Call delegate as a method


                // Stop the closing from happening
                e.Cancel = true;

                // Hide the dialog
                Hide();
            }            
        }

        private void UI_AnimationSpeed_Track_Scroll(object sender, EventArgs e)
        {
            int speed = UI_AnimationSpeed_Track.Value * 10;
            Text = $"Animation Speed: {speed}ms";

            if(null!=_dSpeedChanged)
                _dSpeedChanged(speed);
        }

        public int GetAnimationSpeed()
        {
            return UI_AnimationSpeed_Track.Value * 10;
        }
    }
}
