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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_ObtainValues_Btn_Click(object sender, EventArgs e)
        {
            ModalDialog dialog = new ModalDialog();
            dialog.setInput1(0);
            dialog.setInput2(0);

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                int val1 = dialog.getInput1();
                int val2 = dialog.getInput2();

                UI_FirstValue_Tbx.Text = $"{val1}";
                UI_SecondValue_Tbx.Text = $"{val2}";

                UI_Sum_Tbx.Text = $"{val1 + val2}";
            }

        }
    }
}
