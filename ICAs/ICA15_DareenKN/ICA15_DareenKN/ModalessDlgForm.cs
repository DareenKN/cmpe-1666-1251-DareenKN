/* CMPE1666 – Intermediate Programming
 * Name: Dareen Kinga Njatou
 *
 * Description: CMPE1666 – ICA 15 – Color This!
 * A Windows Forms app that uses a modeless dialog to control the main form’s
 * background color and opacity. Clicking the form opens the dialog, which
 * contains RGB and opacity track bars. Changing any value updates the form
 * immediately through delegate callbacks. The dialog only hides when closed,
 * and its track bars are synced using public methods.
 *
 * Date: 22 November 2025
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ICA15_DareenKN
{
    public delegate void delRGB(Color c);
    public delegate void delOpacity(float op);


    public partial class ModalessDlgForm : Form
    {
        public delRGB _dRGB = null;
        public delOpacity _dOpacity = null;


        public ModalessDlgForm()
        {
            InitializeComponent();
        }

        public void SetRGB(Color c)
        {
            UI_Red_Track.Value = c.R / 8;
            UI_Green_Track.Value = c.G / 8;
            UI_Blue_Track.Value = c.B / 8;
        }
        
        public void SetOpacity(float op)   // op = 0–100
        {
            UI_Opacity_Track.Value = (int)op;
        }

        private void UI_Opacity_Track_Scroll(object sender, EventArgs e)
        {
            if (_dOpacity != null)
                _dOpacity(UI_Opacity_Track.Value);
        }

        private void UI_RGB_Track_Scroll(object sender, EventArgs e)
        {
            if (_dRGB != null)
            {
                int red= UI_Red_Track.Value * 8;
                int green= UI_Green_Track.Value * 8;
                int blue= UI_Blue_Track.Value * 8;

                red = (red < 256) ? red : 255;
                green = (green < 256) ? green : 255;
                blue = (blue < 256) ? blue : 255;


                Color c = Color.FromArgb(red, green, blue);

                _dRGB(c);
            }
        }

        // HIDE INSTEAD OF CLOSE
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void ModalessDlgForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }
    }
}
