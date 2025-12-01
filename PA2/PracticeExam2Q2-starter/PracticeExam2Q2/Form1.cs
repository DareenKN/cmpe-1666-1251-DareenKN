/* CMPE 1666 - Intermediate Progamming
 * Name: Dareen Kinga Njatou
 * 
 * Description: Lab Exam 2 - Q2 - Searching and Sorting
 * This poject....
 * 
 * Date: 21 November 2025 
 */
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeExam2Q2
{
    public partial class Form1 : Form
    {
        // List of int for part A
        List<int> dataList = new List<int>();
        Random rand = new Random();

        List<int> searchList = new List<int>() { 23, 24, 45, 54, 59, 67, 92, 95, 102, 105, 110 };
        //You can include any required class-level variable declaration here

        public Form1()
        {
            InitializeComponent();
        }

        private void UI_GenValues_Btn_Click(object sender, EventArgs e)
        {
            // Clear dataList
            dataList.Clear();

            // Generate 20 random values in the list
            for (int i = 0; i < 20; i++)
                dataList.Add(rand.Next(1, 100));

            // Clear the TextBox
            UI_Unsorted_Tbx.Clear();

            // Display the gereated random values
            foreach (int data in dataList)
                UI_Unsorted_Tbx.Text = string.Join(", ", dataList);

        }

        private void UI_DisplayList_Btn_Click(object sender, EventArgs e)
        {
            foreach (int i in searchList)
                UI_SearchList_Tbx.Text = string.Join(", ", searchList);

        }

        private void UI_SortTechnique_Radio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SortData(List<int> list, int mode)
        {
            switch (mode)
            {
                case 1: BubbleSort(list); break;
                case 2: SelectionSort(list); break;
                case 3: QuickSort(list, 0, list.Count - 1); break;
            }
        }


        //Write your code here
        private void Swap(List<int> list, int posn1, int posn2)
        {
            int temp = list[posn1];
            list[posn1] = list[posn2];
            list[posn2] = temp;
        }

        private void BubbleSort(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - (i + 1); j++)
                {
                    if (list[j] < list[j + 1])
                        Swap(list, j, j + 1);
                }
            }
        }

        private void SelectionSort(List<int> list)
        {
            for (int pass = 0; pass < list.Count; pass++)
            {
                int max_posn = 0;
                int last_posn = list.Count - 1 - pass;

                for (int j = 0; j <= last_posn; j++)
                {
                    if (list[j] > list[max_posn])
                        max_posn = j;
                }
                Swap(list, max_posn, last_posn);
            }
        }

        private void QuickSort(List<int> list, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(list, low, high);
                QuickSort(list, low, pi - 1);
                QuickSort(list, pi + 1, high);
            }
        }

        private int Partition(List<int> list, int low, int high)
        {
            double pivot = list[high];
            int i = low - 1;

            for (int j = low; j <= high; j++)
            {
                if (list[j] < pivot)
                {
                    i++;
                    Swap(list, i, j);
                }
            }
            Swap(list, i + 1, high);
            return i + 1;
        }

        private void UI_Sort_btn_Click(object sender, EventArgs e)
        {
            // Check if the data list is empty
            if (dataList.Count == 0)
            {
                MessageBox.Show("Give me some data first");
                return;
            }

            // Sort base on the radio buttonns
            if (UI_BubbleSort_Radio.Checked)
                SortData(dataList, 1);
            if (UI_SelectionSort_Radio.Checked)
                SortData(dataList, 2);
            if (UI_QuickSort_Radio.Checked)
                SortData(dataList, 3);

            // Display the sorted data
            foreach (int data in dataList)
                UI_Sorted_Tbx.Text = string.Join(", ", dataList);
        }
    
    // Binary Search
    private int BinarySearch(List<int> list, int searchItem, int low, int high)
        {
            if (high < low)
                return -1;

            else
            {
                int mid = (low + high) / 2;
                if (searchItem == list[mid])
                    return mid;
                else if (searchItem < list[mid])
                    return BinarySearch(list, searchItem, low, mid - 1);
                else
                    return BinarySearch(list, searchItem, mid + 1, high);
            }
        }

        private void UI_PerformSearch_Btn_Click(object sender, EventArgs e)
        {
            int searchItem;
            int.TryParse(UI_SearchValue_Tbx.Text, out searchItem);

            int searchIndex = BinarySearch(searchList, searchItem, 0, searchList.Count - 1);

            if (searchIndex >= 0)
                UI_SearchResults_Lbx.Items.Add($"{searchItem} found at index {searchIndex}");
            else
                UI_SearchResults_Lbx.Items.Add($"{searchItem} not found");

        }
    }
}

