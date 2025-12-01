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

namespace Exam_Preparation
{
    public partial class Form1 : Form
    {
        private List<string> textList = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void UI_AddToList_Btn_Click(object sender, EventArgs e)
        {
            if (UI_Input_Tbx.Text.Length > 0)
            {
                // Add values to the textList
                textList.Add(UI_Input_Tbx.Text);

                // Add values to the list box
                UI_Display_Lbx.Items.Add(UI_Input_Tbx.Text);

                // Clear the textbox
                UI_Input_Tbx.Clear();

                // If we have added 10 values to the textList
                // We disable the "Add to List" button and 
                // Enable to "Save to File" button
                if(textList.Count == 10)
                {
                    UI_AddToList_Btn.Enabled = false;
                    UI_SaveToFile_Btn.Enabled = true;
                }

            }
        }

        private void UI_SaveToFile_Btn_Click(object sender, EventArgs e)
        {
            // We'll write the list in the file "File1.txt" in the default folder
            File.WriteAllLines("../../../../file1.txt", textList);
            MessageBox.Show("Data has been saved to the fle \"File1.txt\""); 

        }
    }
}
