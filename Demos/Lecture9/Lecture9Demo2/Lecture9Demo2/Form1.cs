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
    public partial class Form1 : Form
    {
        // We create an instance of the Modeless dialog Form
        // in the main form
        private ModelessDialogForm dlg = null;

        public Form1()
        {
            InitializeComponent();
        }


        private void UI_ShowDialog_Cbx_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_ShowDialog_Cbx.Checked)  // When we check the Cbx, we want the dlg 
                                            // to appear
            {
                if (dlg == null)
                {
                    // Here, we create the Modeless Dialog
                    dlg = new ModelessDialogForm();

                    // We assign the reference to the method CALLBackTextChanged
                    // to the delegate _dTextChanged of the Modeless Dialog
                    dlg._dTextChanged = CallBackTextChanged;
                }
                dlg.Show();
            }
            else  // When we uncheck the Cbx, we want the dialog to dissapear
                dlg.Hide();
            
        }

        // In the main form, we need a call back method that will
        // be called from the Modeless dialog when the text in the 
        // text box of the later changes
        private void CallBackTextChanged(string str)
        {
            UI_DialogText_Lbl.Text = str;
        }
    }
}
