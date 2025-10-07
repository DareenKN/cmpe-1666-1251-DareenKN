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


namespace Lecture4Demo1
{
    public partial class Form1 : Form
    {
        List<string> textList = new List<string> { };
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_AddToList_Btn_Click(object sender, EventArgs e)
        {
            // We verify if the textbox is not empty
            if (UI_Input_Tbx.Text.Length > 0)
            {
                // Enable Add to List Button
                UI_AddToList_Btn.Enabled = true;

                // Adds value to textList
                textList.Add(UI_Input_Tbx.Text);

                // Adds value to listbox
                UI_Display_Lbx.Items.Add(UI_Input_Tbx.Text);

                // Clears Textbox
                UI_Input_Tbx.Clear();
            }
            if(textList.Count == 5)
            {
                UI_AddToList_Btn.Enabled = false;
                UI_SaveToFile_Btn.Enabled = true;
            }
        }

        private void UI_SaveToFile_Btn_Click(object sender, EventArgs e)
        {
            //We write the list in the file "filel.txt" in the default folder
            File.WriteAllLines("file1.txt ", textList);
            File.WriteAllLines("../../file1.txt", textList);
            MessageBox.Show ("Data has been saved to the file \"file1.txt\" ");
        }
    }
}
