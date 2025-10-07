using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture4Demo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_SaveToFile_Btn_Click(object sender, EventArgs e)
        {
            string text = UI_Input_Tbx.Text;

            if (text.Length > 0)
            {
                //We write the list in the file "filel.txt" in the default folder
                File.WriteAllText("../../../../file2.txt", text);
                MessageBox.Show("Data has been saved to the file \"file2.txt\" ");
            }
        }
    }
}
