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
    public partial class Form1 : Form
    {
        // Creating an instance of the Modaless Dialog in the main form
        ModalessDlgForm dlg = new ModalessDlgForm();
        public Form1()
        {
            InitializeComponent();

            dlg = new ModalessDlgForm();

            this.BackColor = Color.Red;

            dlg._dRGB = ChangeBGClr;
            dlg._dOpacity = ChangeOpacity;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            dlg.SetRGB(this.BackColor);
            dlg.SetOpacity((float)(this.Opacity * 100));

            dlg.Show();
        }

        private void ChangeBGClr(Color bgClr)
        {
            this.BackColor = bgClr;
        }

        private void ChangeOpacity(float i)
        {
            this.Opacity = i/100f;
        }

    }
}
