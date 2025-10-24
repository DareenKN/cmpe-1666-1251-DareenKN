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
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ICA8_DareenKN
{
    public partial class Form1 : Form
    {
        string fileName;        // The file's Name

        string strData = "";    // The data in the file
        string[] ArrData;       // The data in an array
        
        List<int> intList = new List<int>();    // List containing the integers

        private Stopwatch sw = new Stopwatch(); // Stopwatch to count the ellapsed ticks

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Drag and Drop Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_DragAndDrop_Lbl_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        /// <summary>
        /// Displays the data in the unsorted textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_DragAndDrop_Lbl_DragDrop(object sender, DragEventArgs e)
        {
            UI_DisplayData_Tbx.Clear();

            fileName = ((string[])e.Data.GetData(DataFormats.FileDrop)).First();
            Console.WriteLine($"The file name is {fileName}");

            // Reading the data found in the file and storing it in a string
            strData = File.ReadAllText(fileName);

            // Spliting the data from the string at the commas and storing in an array
            ArrData = strData.Split(',');
            
            // Converting each string in the array to an integer and adding them in the list of int
            foreach (string str in ArrData)
                intList.Add(int.Parse(str));

            // Displaying the data from the list in the unsorted textbox
            UI_DisplayData_Tbx.Text = string.Join(", ", intList);
        }

        /// <summary>
        /// Sorting values using insertion or selection sorting
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_SortValues_Btn_Click(object sender, EventArgs e)
        {            
            // Enabling the timer
            UI_SortingTime_Tmr.Enabled = true;
            
            // What happens when selection sorting is selected
            if (UI_SelectionSort_RadioBtn.Checked)
            {
                // Reseting and Starting the stop watch
                sw.Restart();

                // Perform the Selection Sort
                SelectionSort(intList);

                //Stop the stop watch
                sw.Stop();
                
                // Clearing the Sorted Data textbox
                UI_DisplaySortedData_Tbx.Clear();

                // Displaying the newly sorted data Textbox
                UI_DisplaySortedData_Tbx.Text = String.Join(", ", intList);
            }

            // What happens when insertion sorting is selected
            else if (UI_InsertionSort_RadioBtn.Checked)
            {
                // Reseting and Starting the stop watch
                sw.Restart();

                // Perform the Insertion Sort
                InsertionSort(intList);

                //Stop the stop watch
                sw.Stop();

                // Clearing the Sorted Data textbox
                UI_DisplaySortedData_Tbx.Clear();

                // Displaying the newly sorted data Textbox
                UI_DisplaySortedData_Tbx.Text = String.Join(", ", intList);
            }

        }

        private static void SelectionSort(List<int> list)
        {
            // n is the number of element in the list
            int n = list.Count;

            // We have n-1 passes - we number them from 0 to n-2
            for (int pass = 0; pass < n - 1; pass++)
            {
                // We first set max_posn to 0
                int max_posn = 0;   // This variable will keep track
                                    // of the position of the maximum value
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

                // Perform Swapping
                Swap(list, max_posn, last_posn);

            }
        }

        /// <summary>
        /// Swapping the maximum position with the minimum position from the selection sorting
        /// </summary>
        /// <param name="myList"></param>
        /// <param name="posn1"></param>
        /// <param name="posn2"></param>
        private static void Swap(List<int> myList, int posn1, int posn2)
        {
            int temp = myList[posn1];
            myList[posn1] = myList[posn2];
            myList[posn2] = temp;
        }

        // Performing the insertion sorting
        private static void InsertionSort(List<int> list)
        {
            for (int passNum = 0; passNum < list.Count; passNum++)
            {
                //in each pass, we pick the value at position p in the list
                int temp = list[passNum];

                //We compare it with values behind it until fall out 
                //of list or we obtain a value less than temp
                int j = passNum - 1;

                while ((j >= 0) && list[j] > temp)
                {
                    list[j + 1] = list[j];
                    j--;
                    
                }
                //When we leave the loop, j is either pointing to a 
                //value less than temp or we have fallen out of the list
                //i.e j is -1. In any of these cases we have to place our temp value at position j+1
                list[j + 1] = temp;
            }
        }

        // Clearing the Sorted Data textbox
        private void UI_ClearSorted_Btn_Click(object sender, EventArgs e)
        {
            UI_DisplaySortedData_Tbx.Clear();
        }

        // Displaying the ellapsed ticks after each sorting
        private void UI_SortingTime_Tmr_Tick(object sender, EventArgs e)
        {
            UI_SortingTime_Tbx.Text = $"{sw.ElapsedTicks}";
        }
    }
}
