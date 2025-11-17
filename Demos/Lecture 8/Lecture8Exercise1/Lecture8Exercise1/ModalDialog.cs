using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture8Exercise1
{
    public partial class ModalDialog : Form
    {
        public ModalDialog()
        {
            InitializeComponent();
        }

        public int getInput1()
        {
            int.TryParse(UI_Input1_Tbx.Text, out int value1);
            return value1;
        }

        public int getInput2()
        {
            int.TryParse(UI_Input2_Tbx.Text, out int value1);
            return value1;
        }

        // Two public methods to obtain external values and place them in the text boxes
        public void setInput1(int val1)
        {
            UI_Input1_Tbx.Text = $"{val1}";
        }

        public void setInput2(int val2)
        {
            UI_Input2_Tbx.Text = $"{val2}";
        }

        private void UI_OK_Btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void UI_Cancel_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
