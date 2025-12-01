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
        List<int> data = null;
        List<int> searchList = new List<int>() { 23, 24, 45, 54, 59, 67, 92, 95, 102, 105, 110 };
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }


        private void Swap(List<int> myList,int posn1, int posn2)
        {
            int temp;
            temp = myList[posn1];
            myList[posn1] = myList[posn2];
            myList[posn2] = temp;
        }

        private void BubbleSort(List<int> list)
        {
            int n=list.Count;
            for (int i=0; i < n;i++)
            {
                for (int j=0; j < n - (i + 1); j++)
                {
                    if (list[j] < list[j + 1])
                        Swap(list, j, j + 1);
                }
            }
        }

        private void SelectionSort(List<int> list) {
              
            int n=list.Count;
            for (int pass=0; pass < n; pass++)
            {
                int max_posn = 0;
                int last_posn = n - 1 - pass;

                for (int j=0; j<=last_posn; j++)
                {
                    if (list[j] > list[max_posn])
                        max_posn= j;
                }

                Swap(list,max_posn,last_posn);
            }
        
        
        }

        private void QuickSort(List<int> list, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(list, low, high);
                QuickSort(list, low, pi-1);
                QuickSort(list, pi+1, high);
            }
        }

        private int Partition(List<int> myList, int low, int high)
        {
            double pivot = myList[high];

            int i = low - 1;

            for (int j=low; j<=high-1;j++) {
               
                 if (myList[j] < pivot)
                {
                    i++;
                    Swap(myList,i,j);
                }
            
            }
            Swap(myList,i+1,high);
            return i + 1;
        }

        private void UI_GenValues_Btn_Click(object sender, EventArgs e)
        {
            data = new List<int>();

            for (int count=0; count<20; count++) { 
               
                data.Add(random.Next(1,100));
            
            }

            UI_Unsorted_Tbx.Text = "";

            foreach(int value in data)
                UI_Unsorted_Tbx.Text+=$"{value},  ";
        }

        private void UI_Sort_btn_Click(object sender, EventArgs e)
        {
            if (UI_BubbleSort_Radio.Checked)
            {
                BubbleSort(data);
            }
            else if (UI_SelectionSort_Radio.Checked)
            {

                SelectionSort(data);
            }
            else
                QuickSort(data,0,data.Count-1);

            UI_Sorted_Tbx.Text = "";
            foreach(int value in data)
                UI_Sorted_Tbx.Text +=$"{value},  ";
        }

        private void UI_DisplayList_Btn_Click(object sender, EventArgs e)
        {
            UI_SearchList_Tbx.Text = "";

            foreach (int value in searchList)
                UI_SearchList_Tbx.Text += $"{value}, ";
        }

        private int BinarySearch(List<int> list, int start, int end, int val)
        {
            if (end<start)
                return -1 ;
            else
            {
                int mid=(start+end)/2;
                if (val== list[mid]) return mid ;
                else if (val < list[mid]) 
                    return BinarySearch(list, start, mid-1,val) ;
                else
                    return BinarySearch(list,mid+1,end,val) ;

            }
        }
        private void UI_PerformSearch_Btn_Click(object sender, EventArgs e)
        {
            int searchValue;
            int.TryParse(UI_SearchValue_Tbx.Text, out searchValue);

            int posn=BinarySearch(searchList,0,searchList.Count-1,searchValue);

            if (posn>=0)
            {
                UI_SearchResults_Lbx.Items.Add($"{searchValue} found at position {posn}");
            }
            else
                UI_SearchResults_Lbx.Items.Add($"{searchValue} not found");
        }

    }
    }

