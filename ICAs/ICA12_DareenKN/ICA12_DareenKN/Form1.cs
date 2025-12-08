/* CMPE1666 - Intermediate Programming
 * Name: Dareen Kinga Njatou
 * 
 * Description: CMPE 1666-ICA 12- Sorting lists of structs using QuickSort
 * In this assignment, you are going to adapt the quick-sort algorithm to 
 * sort a list of structs. You are going to create a simple list of structs 
 * from a provided data table to test your algorithm then construct a longer 
 * list of structs from data read from the provided text file. Once you are 
 * confident that the sorting algorithm is working properly, you’ll apply it 
 * to the longer list created from the file.
 * 
 * Date: 14 November 2025
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace ICA12_DareenKN
{
    public partial class Form1 : Form
    {
        // Creating a Struct for Employee
        private struct Employee
        {
            public int _employeeID;
            public int _salary;
        }

        // Creating a List of Employees for the built in data
        List<Employee> EmployeesFrorBuiltInData = new List<Employee>();

        // Creating a List of Employees for the data provided from a file
        List<Employee> EmployeesFromDataFile = new List<Employee>();

        // Arrays of EmployeeID and Salaries to create the list of employees from data provided
        int[] EmployeeID = { 28, 53, 12, 18, 8, 2, 19, 57, 62, 34, 23, 14, 48, 35, 55, 22, 26, 15, 7, 9, 32, 43, 41, 51 };
        int[] Salary = { 4500, 200, 1900, 3100, 7000, 3500, 2200, 2800, 2850, 3150, 4000, 4500, 6000, 7200, 3700, 2100, 2450, 2500, 3250, 4700, 53800, 4200, 4100, 3900 };

        // Adding a Stopwatch to track the ticks of the timer
        Stopwatch sw = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
        }

        // Function to create an employee
        static Employee CreateEmployee(int employeeID, int salary)
        {
            Employee emp = new Employee();
            emp._employeeID = employeeID;
            emp._salary = salary;

            return emp;
        }

        // Function of Quick Sort to be used on the EmployeeID
        // The QuickSort Implementation
        private static void QuickSort(List<Employee> list, int low, int high)
        {
            // We don't say low <'=' high, because low == high,
            // means we are left with just one element
            if (low < high)
            {
                // Partition index at which we can divide the list
                int partitionIndex = Partition(list, low, high);

                // Recursive call for smaller elements
                QuickSort(list, low, partitionIndex - 1);
                // Recursive call for greater or equals elements
                QuickSort(list, partitionIndex + 1, high);
            }
        }

        // Partition function will return the partition index
        // Which is basically the final index of the pivot 
        // element in the list passed
        private static int Partition(List<Employee> list, int low, int high)
        {
            // Choose the pivot
            int pivot = list[high]._employeeID; // last element

            // Set all the pointers
            int i = low - 1;

            // Iterate the list and move all small elements to the left side
            // Elements from low to i are smaaller after every iterations
            for (int j = low; j < high; j++)
            {
                if (list[j]._employeeID < pivot)
                {
                    i++;
                    // swap element i with j
                    Swap(list, i, j);
                }
            }

            // Move pivot after smaller elements and return its position
            Swap(list, i + 1, high);

            return i + 1;   // Index position of pivot element
        }

        /// <summary>
        /// Function for swapping
        /// </summary>
        /// <param name="list"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        private static void Swap(List<Employee> list, int i, int j)
        {
            Employee temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }

        /// <summary>
        /// Displays the unsorted list in the unsorted listbox based on the radio buttons states
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_DisplayUnsortedList_Btn_Click(object sender, EventArgs e)
        {
            // Resseting EmployeeList
            EmployeesFrorBuiltInData.Clear();

            // Clearing existind Data in the Unsorted Data Listbox
            UI_UnsortedData_Lbx.Items.Clear();

            // Display data from the provided data
            if (UI_ProvidedList_RadioBtn.Checked)
            {
                // Create each employee from the data in the given arrays, add them in the list and display them
                for (int i = 0; i < EmployeeID.Length; i++)
                {
                    Employee emp = CreateEmployee(EmployeeID[i], Salary[i]);
                    EmployeesFrorBuiltInData.Add(emp);
                    UI_UnsortedData_Lbx.Items.Add($"{emp._employeeID}:\t{emp._salary}");
                }
            }

            // Displays data from a file dropped on the blue button
            else if (UI_FileData_RadioBtn.Checked)
            {
                // Ensure there are values in the file
                if(EmployeesFromDataFile.Count == 0)
                {
                    MessageBox.Show("Drop Data First from a file");
                    return;
                }

                // Display the unsorted list in the unsorted listbox
                foreach (Employee emp in EmployeesFromDataFile)
                    UI_UnsortedData_Lbx.Items.Add($"{emp._employeeID}:\t{emp._salary}");
            }
        }

        /// <summary>
        /// Clears the Unsorted List Box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_ClearUnsortedListBox_Btn_Click(object sender, EventArgs e)
        {
            // Clearing Unsorted List Box
            UI_UnsortedData_Lbx.Items.Clear();

            // Clearing the lists
            //EmployeesFromDataFile.Clear();
            EmployeesFrorBuiltInData.Clear();
        }

        /// <summary>
        /// Sorts the list based on the radio button state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_Sort_Btn_Click(object sender, EventArgs e)
        {
            // First Check if the list is empty based on the radio button
            if (UI_ProvidedList_RadioBtn.Checked)
            {
                if(EmployeesFrorBuiltInData.Count() == 0)
                {
                    MessageBox.Show("Please, Give me data first from the provided List !!!");
                    return;
                }

                // Enable the Timer
                UI_TimeTaken_Tmr.Enabled = true;

                // Resetting and Starting the Stopwatch 
                sw.Restart();

                QuickSort(EmployeesFrorBuiltInData, 0, EmployeesFrorBuiltInData.Count - 1);

                // Stoping the StopWatch
                sw.Stop();

                // Display the ellapsed ticks
                UI_TimeTaken_Tbx.Text = $"{sw.ElapsedTicks} ticks";

                // Clear the Sorted Data ListBox
                UI_SortedData_Lbx.Items.Clear();

                // Display the Sorted List in the listbox
                foreach (Employee emp in EmployeesFrorBuiltInData)
                    UI_SortedData_Lbx.Items.Add($"{emp._employeeID}:\t{emp._salary}");
            }

            // Sorts from the list dropped on the blue label
            else if (UI_FileData_RadioBtn.Checked)
            {
                // Verify if any data was dropped
                if (EmployeesFromDataFile.Count() == 0)
                {
                    MessageBox.Show("Please, Give me data first from the File !!!");
                    return;
                }

                // Enable the Timer
                UI_TimeTaken_Tmr.Enabled = true;

                // Resetting and Starting the Stopwatch 
                sw.Restart();

                QuickSort(EmployeesFromDataFile, 0, EmployeesFromDataFile.Count - 1);

                // Stoping the StopWatch
                sw.Stop();

                // Display the ellapsed ticks
                UI_TimeTaken_Tbx.Text = $"{sw.ElapsedTicks} ticks";

                // Clear the Sorted Data ListBox
                UI_SortedData_Lbx.Items.Clear();

                // Display the Sorted List in the listbox
                foreach (Employee emp in EmployeesFromDataFile)
                    UI_SortedData_Lbx.Items.Add($"{emp._employeeID}:\t{emp._salary}");
            }
        }

        /// <summary>
        /// Clears the sorted List box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_ClearSortedListBox_Btn_Click(object sender, EventArgs e)
        {
            // Clearing the Sorted ListBox
            UI_SortedData_Lbx.Items.Clear();
        }

        /// <summary>
        /// Displays the ticks passed during the sorting
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_TimeTaken_Tmr_Tick(object sender, EventArgs e)
        {
            //UI_TimeTaken_Tbx.Text = $"{sw.ElapsedTicks} ticks";
        }

        /// <summary>
        /// Drag enter event handler
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
        /// Drag and drop event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_DragAndDrop_Lbl_DragDrop(object sender, DragEventArgs e)
        {
            // Clearing existing data found in the ListBox
            UI_UnsortedData_Lbx.Items.Clear();

            // Obtain File Name
            string fileName = ((string[])e.Data.GetData(DataFormats.FileDrop)).First();
            // Letting the user know which file was selected
            MessageBox.Show($"You selected the file: {fileName}", "File Selected");
            Console.WriteLine($"The file name is {fileName}");

            try
            {
                // Read data from file
                string[] fileData = File.ReadAllLines(fileName);

                // Arrays to hold data read from fles
                int[] empIDsFromFile = new int[fileData.Length];
                int[] salariesFromFile = new int[fileData.Length];

                // Parsing the data read from the file into the arrays
                for (int i = 0; i < fileData.Length; i++)
                {
                    string[] parts = fileData[i].Split(',');

                    int.TryParse(parts[0], out empIDsFromFile[i]);
                    int.TryParse(parts[1], out salariesFromFile[i]);

                    // Create Employee from the data read from file
                    Employee emp = CreateEmployee(empIDsFromFile[i], salariesFromFile[i]);

                    EmployeesFromDataFile.Add(emp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while reading the file: {ex.Message}", "Load Error");
            }
        }
    }
}
