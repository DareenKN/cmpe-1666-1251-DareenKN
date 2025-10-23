/* CMPE1600 - Intermediate Programming
 * Name: Dareen Kinga Njatou
 * 
 * Description: CMPE 1666-ICA08- File Processing And Sorting 
 *                 read data from a text file and sort them using the 
 *                 2 N2 Sorting techniques discussed in class. You 
 *                 will use drag and drop to add a file to your 
 *                 application, read the data from the file, and use 
 *                 any the sorting methods to sort the data.
 * 
 * Date: October 17, 2025
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICA8_DareenKN
{
    public partial class Form1 : Form
    {
        string fileName;        // The file's Name
        string strData = "";    // The data in the file

        string[] ArrData;       // The data in an array

        List<int> intList = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void UI_DragAndDrop_Lbl_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void UI_DragAndDrop_Lbl_DragDrop(object sender, DragEventArgs e)
        {
            UI_DisplayData_Tbx.Clear();

            fileName = ((string[])e.Data.GetData(DataFormats.FileDrop)).First();
            Console.WriteLine($"The file name is {fileName}");

            strData = File.ReadAllText(fileName);

            ArrData = strData.Split(',');
            intList = ArrData.Select(int.Parse).ToList();

            UI_DisplayData_Tbx.Text = string.Join(", ", intList);
        }

        private void UI_SortValues_Btn_Click(object sender, EventArgs e)
        {
            if (UI_SelectionSort_RadioBtn.Checked)
            {
                SelectionSort(intList);
                UI_DisplaySortedData_Tbx.Clear();



                UI_DisplaySortedData_Tbx.Text = string.Join(", ", intList);
            }
        }

        private static void SelectionSort(List<int> list)
        {
            // n is the number of element in the list
            int n = list.Count;

            // We have n-1 passes - we number them from 0 to n-2
            for (int pass = 0; pass < n - 1; pass++)
            {
                // We firt set max_posn to 0
                int max_posn = 0;   // This variable wil keep track
                                    // of the possition of the maximum value
                int last_posn = n - 1 - pass;   // This is the last position
                                                // of the still unsorted list

                // In each pass we iterate over the still unsorted pa
                // and fins the maximum value, which we send to the la
                // unsorted position
                for (int j = 0; j <= last_posn; j++)
                {
                    if (list[j] > list[max_posn])
                    {
                        max_posn = j;
                    }
                }

                Swap(list, max_posn, last_posn);

            }
        }

        private static void Swap(List<int> myList, int posn1, int posn2)
        {
            int temp = myList[posn1];
            myList[posn1] = myList[posn2];
            myList[posn2] = temp;
        }

        private void UI_ClearSorted_Btn_Click(object sender, EventArgs e)
        {
            UI_DisplaySortedData_Tbx.Clear();
        }
    }
}
