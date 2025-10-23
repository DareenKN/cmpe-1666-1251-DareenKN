using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lectur4Demo2
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
            //We verify if the textbox is not empty, we 
            //write into the file
            if (text.Length > 0)
            {
                File.WriteAllText("../../../../file2.txt",text);
                MessageBox.Show("The text has been written to the file");
            }
        }
    }
}
