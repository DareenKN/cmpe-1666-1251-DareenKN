using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICA11_DareenKN
{
    public partial class Form1 : Form
    {
        List<string> names = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for Add Name button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_AddName_Btn_Click(object sender, EventArgs e)
        {
            // Add name to the list and update the ListBoxes
            if (UI_InputName_Tbx.Text.Length > 0)
            {
                // Add name to the list
                names.Add(UI_InputName_Tbx.Text);

                // Update the ListBoxes
                UI_OrdersOfEntry_Lbx.Items.Add(UI_InputName_Tbx.Text);

                // Sort the names for the sorted ListBox
                names.Sort();

                // Update the sorted ListBox 
                UI_SortedNames_Lbx.Items.Clear();
                foreach (string name in names)                   
                    UI_SortedNames_Lbx.Items.Add(name);

                // Clear the input TextBox
                UI_InputName_Tbx.Clear();
            }
        }

        /// <summary>
        /// Event handler for Search Name button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_Searchname_Btn_Click(object sender, EventArgs e)
        {
            // Search for the name using Recursive Binary Search
            if (UI_InputName_Tbx.Text.Length > 0)
            {
                // Perform Recursive Binary Search and store the result in flag
                int flag = RBinarySearch(names, 0, names.Count - 1, UI_InputName_Tbx.Text);

                // If flag is not -1, the name was found
                if (flag != -1)
                    MessageBox.Show($"{names.ElementAt(flag)} found at index {flag}.");

                // Otherwise, the name was not found
                else
                    MessageBox.Show($"{UI_InputName_Tbx.Text} not found.");

                // Clear the input TextBox
                UI_InputName_Tbx.Clear();
            }
        }

        /// <summary>
        /// Recursive Binary Search Algorithm
        /// The method RBinarySearch searches a list of int for a value val between
        /// the indices low and high. It finds the value at the mid index
        /// If the value matches the search value, the mid index is returnes
        /// Otherwise it recursively searches the lower half ot the upper half
        /// based on wether the search value is lower than the one at middle index
        /// or higher than it
        /// </summary>
        /// <param name="L"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        static int RBinarySearch(List<string> L, int low, int high, string val)
        {
            // The algorithm stops and returns -1 if low becomes > high
            if (high >= low)
            {
                // Calculate the middle index
                int mid = (low + high) / 2;
                // Verifiy if the value at the middle index et what we are searching for
                // If so, return the middle index
                if (val.CompareTo(L[mid]) == 0)
                    return mid;
                else if (val.CompareTo(L[mid]) < 0)
                    return RBinarySearch(L, low, mid - 1, val);
                else 
                    return RBinarySearch(L, mid + 1, high, val);

            }
            return -1;// If we arrive here, it means low>high. Value not found
        }

    }
}
