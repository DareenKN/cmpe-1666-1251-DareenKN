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
        //We create an instance of the Modeless Dialog Form in the main form
        private ModelessDialogForm dlg = null;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void UI_ShowDialog_Cbx_CheckedChanged(object sender, EventArgs e)
        {

            if (UI_ShowDialog_Cbx.Checked) //When we check the checkbox, we want the dialog to appear
            {
                if (dlg == null)
                {  //Here we create the modeless dialog form
                    dlg = new ModelessDialogForm();
                    //we assign the method CAllBackTextChanged to the delegate _dTextChanged of the modeless dialog
                    dlg._dTextChanged = CallBackTextChanged;
                }
                dlg.Show();
            }
            else// When we uncheck the checkbox, we want the dialog to disappear
                dlg.Hide();
                
            
        }

        //In the main form we need callback method that will be called from the
        //Modeless Dialog when the text in the textbox of the latter changes
        private void CallBackTextChanged(string str)
        {
            UI_DialogText_Lbl.Text = str;
        }
    }
}
