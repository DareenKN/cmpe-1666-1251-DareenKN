/* CMPE1600 - Intermediate Programming
 * Name: Dareen Kinga Njatou
 * 
 * Description: CMPE 1666-ICA07- File Processing 
 *                Read data from a text file. You will use drag 
 *                and drop to add a file to your application, 
 *                read the data from the file, extract the data 
 *                and add to a List. You will then apply a few in 
 *                built List method 
 * 
 * Date: October 8, 2025
 */
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ICA7_DareenKN
{
    public partial class Form1 : Form
    {
        string fileName;        // The file's Name
        string strData = "";    // The data in the file
        string[] ArrData;       // The data in an array
        int[] data;             // The data in an integer array

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// If the data being dragged is a file, then allow the copy
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
        /// If a file is dropped, read the data from the file and display it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_DragAndDrop_Lbl_DragDrop(object sender, DragEventArgs e)
        {
            UI_DisplayData_Tbx.Clear();

            fileName = ((string[])e.Data.GetData(DataFormats.FileDrop)).First();
            Console.WriteLine($"The file name is {fileName}");

            strData = File.ReadAllText(fileName);
            UI_DisplayData_Tbx.Text = strData;
        }


        /// <summary>
        /// Display the number of values in the data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_DisplayCount_Btn_Click(object sender, EventArgs e)
        {
            ArrData = strData.Split(',');
            UI_NumOfVal_Tbx.Text = $"{ArrData.Length}";
        }

        /// <summary>
        /// Initialize the integer array and display the minimum value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_DisplayMin_Btn_Click(object sender, EventArgs e)
        {
            // Split the data into an array
            ArrData = strData.Split(',');

            // Initialize the integer array
            data = new int[ArrData.Length];

            // Convert the string array to an integer array
            for (int i = 0; i < ArrData.Length; i++)
                int.TryParse(ArrData[i], out data[i]);

            // Display the minimum value
            UI_MinVal_Tbx.Text = $"{data.Min()}";
        }

        /// <summary>
        /// Initialize the integer array and display the maximum value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_DisplayMax_Btn_Click(object sender, EventArgs e)
        {
            // Split the data into an array
            ArrData = strData.Split(',');

            // Initialize the integer array
            data = new int[ArrData.Length];

            // Convert the string array to an integer array
            for (int i = 0; i < ArrData.Length; i++)
                int.TryParse(ArrData[i], out data[i]);

            // Display the maximum value
            UI_MaxVal_Tbx.Text = $"{data.Max()}";
        }
    }
}
