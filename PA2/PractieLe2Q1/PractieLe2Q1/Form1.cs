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

        private void UI_RollUpCount_Btn_Click(object sender, EventArgs e)
        {
            string[] strArr = UI_TextInput_Tbx.Text.Split(' ');

            foreach (string data in strArr)
                Console.WriteLine(data);

            string searchedItem = UI_SearchItem_Tbx.Text;
            int result = RecursiveSearch(strArr, searchedItem, 0, strArr.Length - 1);

            this.Text = $"Found {result} of the word \"{searchedItem}\"!";
        }


        private int RecursiveSearch(string[] data, string searchedItem, int low, int high)
        {
            if (low > high)
                return 0;

            else if (data[low] == searchedItem)
                return 1 + RecursiveSearch(data, searchedItem, low + 1, high);

            else
                return RecursiveSearch(data, searchedItem, low + 1, high);
        }

        private void UI_NoRollUpCount_Btn_Click(object sender, EventArgs e)
        {
            string[] strArr = UI_TextInput_Tbx.Text.Split(' ');

            foreach (string data in strArr)
                Console.WriteLine(data);

            string searchedItem = UI_SearchItem_Tbx.Text;
            int result = RecursiveBinSearch(strArr, searchedItem, 0, strArr.Length - 1);

            this.Text = $"Found {result} of the word \"{searchedItem}\"!";
        }

        private int RecursiveBinSearch(string[] data , string searchedItem, int low, int high)
        {
            if (high == low)
            {
                if (data[low] == searchedItem)
                    return 1;
                else
                    return 0;
            }

            else
            {
                int mid = (low + high) / 2;
                return RecursiveBinSearch(data, searchedItem, low, mid)
                    + RecursiveBinSearch(data, searchedItem, mid + 1, high);
            }
        }
    }
}
