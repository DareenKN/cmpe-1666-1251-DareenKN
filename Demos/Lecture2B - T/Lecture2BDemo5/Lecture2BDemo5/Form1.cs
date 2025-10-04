/*CMPE 1666- Intermediate Programming
 * 
 * Lecture2B-Demo5- Working with MessageBox
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

namespace Lecture2BDemo5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_ClickMe_Btn_Click(object sender, EventArgs e)
        {
            //We obtain the value from the textbox
            string name = UI_Input_Tbx.Text;

            //We build a string and display it in a Message box
            string displayString = $"The name given was: {name}";
            MessageBox.Show(displayString);

            //Alternatively, we can build the string directly as argument
            //in the Show() method as below.
            //MessageBox.Show($"The name given was: {name}");
        }
    }
}
