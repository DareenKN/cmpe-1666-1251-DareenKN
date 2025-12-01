using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture8Demo1
{
    public partial class ModalDialogForm : Form
    {
        public ModalDialogForm()
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

        //Making the method public will make it accessible in the Main Form
        public string getUserName()
        {
            return UI_Input_Tbx.Text;
        }

        /*
         * This method will assign the value of its parameter to the
         * Text property of the textbox
         * 
         */
        public void setUserName(string name)
        {
            UI_Input_Tbx.Text = name;
        }
    }
}
