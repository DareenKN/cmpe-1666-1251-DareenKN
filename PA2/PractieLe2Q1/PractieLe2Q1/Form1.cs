/* CMPE 1666 - Intermediate Pogramming
 * Name: Dareen Kinga NJatou
 * 
 * Description: Lab Exam 2 - Q1 - Found 3 Instances of that Word!
 * This poject....
 * 
 * Date: 23 November 2025
 */
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

namespace PractieLe2Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_LoadFile_Btn_Click(object sender, EventArgs e)
        {
            if (UI_DataFile_OFD.ShowDialog() == DialogResult.OK)
            {
                string fileName = UI_DataFile_OFD.FileName;
                MessageBox.Show($"You have selected {fileName}");
                UI_TextInput_Tbx.Text = File.ReadAllText(fileName);
            }
        }
    }
}
