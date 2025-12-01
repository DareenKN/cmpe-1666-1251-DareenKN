using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture4Exercise1
{
    public partial class Form1 : Form
    {    List<string> list = new List<string>() {"Adelaid","Bertrand","Bursar","Catherine", "Cesar","Davidson",
                                                 "Elizabeth", "Ester","Fidele", "Francesca","Giovani",
                                                  "Ivanov", "Jasmine", "Jupiter","Kepler", "Konsalic",
                                                  "Latour", "Levine", "Masson", "Nora", "Panos"};
        public Form1()
        {
            InitializeComponent();
        }

        // The method RBinarySearch searches a list of int for a value val between
        // the indices low and high. It finds the value at the mid index
        // If the value matches the search value, the mid index is returnes
        // Otherwise it recursively searches the lower half ot the upper half
        // based on wether the search value is lower than the one at middele index
        // or higher than it

        static private int RBinarySearch(List<string> L, int low, int high, string searchVal)
        {
            // The algorithm stops and returns -1 if low becomes > high
            if (high >= low)
            {
                // Calculate the middle index
                int mid = (low + high) / 2;
                // Verifiy if the value at the middle index et what we are searching for
                // If so, return the middle index
                if (L[mid] == searchVal)
                    return mid;
                else
                {
                    // Verify if val is < the value at the middle index. If so
                    // recursivly search the lower part of the list
                    // We have to compare our L[mid] with searchVal using compareTo
                    int compareResult = searchVal.CompareTo(L[mid]);

                    // If compare result is less than 0 => searchVal is Lower than L[mid]
                    if (compareResult < 0)
                        return RBinarySearch(L, low, mid - 1, searchVal);
                    else // 
                        RBinarySearch(L, mid + 1, high, searchVal); ;
                }
            }
            return -1;// If we arrive here, it means low>high. Value not found
        }

        private void UI_PerformSearch_Btn_Click(object sender, EventArgs e)
        {
            string value = UI_ValueToSearch_Tbx.Text;
            int P = RBinarySearch(list, 0, list.Count - 1, value);
            UI_Result_Tbx.Text = $"{P}";
        }
    }
}
