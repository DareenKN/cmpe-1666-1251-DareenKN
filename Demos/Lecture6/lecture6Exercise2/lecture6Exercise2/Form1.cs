using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lecture6Exercise2
{
    public partial class Form1 : Form
    {
        private Random rnd = new Random();
        private List<int> intList = new List<int>();

        public Form1()
        {
            InitializeComponent();
            UI_RecursiveSum_Btn.Enabled = false;
            UI_DivideAndSum_Btn.Enabled = false;
        }

        /// <summary>
        /// RecursiveSum calculates the sum by adding the value at the current index to the 
        /// recursive sum comming from the next index. We stop when the index is the same as 
        /// the number of elements in the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private int RecursiveSum(List<int> list, int index)
        {
            if (index == list.Count)
                return 0;
            else
                return list[index] + RecursiveSum(list, index + 1);
        }

        /// <summary>
        /// Recursive sum button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_RecursiveSum_Btn_Click(object sender, EventArgs e)
        {
            int result = RecursiveSum(intList, 0);
            UI_RecursiveSum_Tbx.Text = $"{result}";
        }

        private int RecursiveSumEven(List<int> list, int index)
        {
            if (index == list.Count)
                return 0;
            else if (list[index] % 2 == 0) 
                    return list[index] + RecursiveSumEven(list, index + 1);
            else
                return RecursiveSumEven(list, index + 1);
        }

        /// <summary>
        /// DivideAndSum find the sum of a list of values by continuously diving the list into 
        /// half, recursively calling the method on the 2 halves, and adding the 2 returned values.
        /// When we pass only th one vlue (minIndex ==  maxIndex), we return the value at that index
        /// </summary>
        /// <param name="list"></param>
        /// <param name="minIndex"></param>
        /// <param name="maxIndex"></param>
        /// <returns></returns>
        private int DivideAndSum(List<int> list, int minIndex, int maxIndex)
        {
            if (minIndex == maxIndex)
                return list[minIndex];
            else
            {
                int midIndex = (minIndex + maxIndex) / 2;
                return DivideAndSum(list, minIndex, midIndex) + DivideAndSum(list, midIndex + 1, maxIndex);
            }

        }

        private void UI_GenerateValues_Btn_Click(object sender, EventArgs e)
        {
            bool success = int.TryParse(UI_NumValues_Tbx.Text, out int numValues);

            if (!success)
                MessageBox.Show("Value given not a valid integer");
            else if ((numValues < 1) || (numValues > 50))
                MessageBox.Show("Value out of Range");

            else
            {
                intList.Clear();
                UI_DisplayValues_Tbx.Clear();

                for (int count = 0; count < numValues; count++)
                {
                    intList.Add(rnd.Next(1, 1000));
                }
                // Finallywe place the values in the textbox
                UI_DisplayValues_Tbx.Text = string.Join(", ", intList);

                UI_RecursiveSum_Btn.Enabled = true;
                UI_DivideAndSum_Btn.Enabled = true;
                UI_GenerateValues_Btn.Enabled = false;
            }            
        }

        private void UI_DivideAndSum_Btn_Click(object sender, EventArgs e)
        {
            int result = DivideAndSum(intList, 0, intList.Count - 1);
            UI_DivideAndSum_Tbx.Text = $"{result}";
        }
    }
}
