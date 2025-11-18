using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture9Demo2
{
    // We create the delegate type here for communication
    // between this form and the main form - Our DelType
    // will have a single parameter and returns nothing
    public delegate void delVoidString(string s);

    public partial class ModelessDialogForm : Form
    {
        // We create a delegate object to execute a call back on the main form
        // The invocation will occur when the text in the textbox changes
        public delVoidString _dTextChanged = null;

        public ModelessDialogForm()
        {
            InitializeComponent();
        }

        private void UI_Input_Tbx_TextChanged(object sender, EventArgs e)
        {
            if(_dTextChanged != null)                
                _dTextChanged(UI_Input_Tbx.Text);
            
            // MessageBox.Show($"Error can't read the text");

        }
    }
}
