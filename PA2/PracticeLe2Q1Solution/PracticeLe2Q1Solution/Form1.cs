using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PracticeLe2Q1Solution
{
    public partial class Form1 : Form   
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_Roll_Count_Click(object sender, EventArgs e)
        {
            string[] stringArray= UI_TextInput_Tbx.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int result=RecursiveSearch2(stringArray,UI_SearchItem_Tbx.Text,0, stringArray.Length-1);
            Text = $"Found {result} instances of the word";
        }

        private int RecursiveSearch(string[] stringArray, string searchString, int startIndex, int endIndex) { 
           
            if (startIndex == endIndex)
            {
                if (stringArray[startIndex] == searchString)
                    return 1;
                else 
                    return 0;
            }
            else
            {
                int mid= (startIndex+endIndex)/2;
                return RecursiveSearch(stringArray, searchString, startIndex, mid)
                      + RecursiveSearch(stringArray, searchString, mid+1, endIndex);
            }

        }

        private int RecursiveSearch2(string[] stringArray, string searchString, int startIndex, int endIndex)
        {

            if (startIndex > endIndex)
            {
                return 0;
            }
            else if (stringArray[startIndex] == searchString)
                return 1 + RecursiveSearch2(stringArray, searchString, startIndex + 1, endIndex);

            else
                return RecursiveSearch2(stringArray, searchString, startIndex + 1, endIndex);

        }

        private void UI_LoadFile_Btn_Click(object sender, EventArgs e)
        {
            if (UI_DataFile_OFD.ShowDialog() == DialogResult.OK)
            {
                string fileName=UI_DataFile_OFD.FileName;
                UI_TextInput_Tbx.Text=File.ReadAllText(fileName);
            }
        }
    }
}
