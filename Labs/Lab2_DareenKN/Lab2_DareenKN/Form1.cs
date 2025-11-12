/* CMPE1600 - Intermediate Programming
 * Name: Dareen Kinga Njatou
 * 
 * Description: CMPE 1666-Lab02- Creating and Sorting lists of structs 
 *                create a simple list of structs from a provided data 
 *                table to test your algorithm then construct a similar 
 *                but longer list from data read from a provided text 
 *                file. Once you are confident that the sorting algorithm 
 *                is working properly, you’ll apply it to the longer list 
 *                created from the file.
 * 
 * Date: October 10, 2025
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Lab2_DareenKN
{
    public partial class Form1 : Form
    {
        // Declaring a Struct for Employee
        private struct Employee
        {
            public int _employeeID;     // Stores the employees IDs
            public string _firstName;   // Stores the employees First names
            public string _lastName;    // Stores the employess Last Names
        }


        // Adding all the Informations in the required Array
        int[] EmployeeID = { 28, 53, 12, 18, 8, 2, 19, 57, 62, 34, 23, 14, 48, 35, 55, 22, 26, 15, 7, 9, 32, 43, 41, 51 };
        string[] FirstName = { "Emily", "Micheal", "Olivia", "Daniel", "Sophia", "Ethan", "Ava", "Benjamin", "Isabella", "Jacob", "Mia", "William", "Emma", "Alexander", "Charlotte", "James", "Amelia", "Logan", "Harper", "Elijah", "Grace", "Noah", "Lily", "Lucas" };
        string[] LastName = { "Johnson", "Smith", "Williams", "Browns", "Jones", "Davis", "Miller", "Wilson", "Moore", "Taylor", "Anderson", "Thomas", "Jackson", "Moore", "Harris", "Martin", "Thompson", "Garcia", "Martinez", "Robnson", "Smith", "Rodriguez", "Lewis", "Clark" };

        // Creating a List to hold Employee Structs
        List<Employee> Employees = new List<Employee>();

        // Creating a Stopwatch to measure time taken to sort
        Stopwatch sw = new Stopwatch();

        string fileName;    // String to hold the name of the file
        string[] strData;   // String aray to hold data read from file

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method to create an Employee Struct
        /// </summary>
        /// <param name="employeeID"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns></returns>
        private Employee CreateEmployee(int employeeID, string firstName, string lastName)
        {

            Employee emp = new Employee();

            emp._employeeID = employeeID;
            emp._firstName = firstName;
            emp._lastName = lastName;

            return emp;
        }

        private void UI_OpenFileThroughOFD_Btn_Click(object sender, EventArgs e)
        {
            // Clearing existing data found in the DataGridView
            UI_UnsortedData_Dgv.Rows.Clear();

            //The ShowDialog() causes the dialog to open
            //When the user clicks on Ok or Cancel,
            //the dialog will clause and return a value of DialogResult.OK
            //if the user clicked on Ok or it will return DialogResult.Cancel
            //if the user clicks on Cancel
            if (UI_MainFile_Dlg.ShowDialog() == DialogResult.OK)
            {
                // Obtain File Name
                string fileName = UI_MainFile_Dlg.FileName;

                // Letting the user know which file was selected
                MessageBox.Show($"You selected the file: {fileName}", "File Selected");
                Console.WriteLine($"The file name is: {fileName}");


                //Now we can process the file, just like we do for Drag & Drop
                try
                {
                    //Reading the data found in the file and storing it in a string
                    string[] strData = File.ReadAllLines(fileName);

                    // New arrays to hold thne data read from the file
                    int[] EmployeeID_File = new int[strData.Length];
                    string[] FirstName_File = new string[strData.Length];
                    string[] LastName_File = new string[strData.Length];

                    for (int i = 0; i < strData.Length; i++)
                    {
                        string[] parts = strData[i].Split(',');

                        int.TryParse(parts[0], out EmployeeID_File[i]);
                        FirstName_File[i] = parts[1];
                        LastName_File[i] = parts[2];

                        Employee emp = CreateEmployee(EmployeeID_File[i], FirstName_File[i], LastName_File[i]);
                        Employees.Add(emp);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show($"Error reading data from file: {ex.Message}", "Load Error");
                }

                // Displaying the newly loaded data in the DataGridView
                foreach (var emp in Employees)
                    UI_UnsortedData_Dgv.Rows.Add(emp._employeeID, emp._firstName, emp._lastName);
            }
        }

        /// <summary>
        /// Displays the unsorted list of employees in the DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_DisplayUnsortedList_Btn_Click(object sender, EventArgs e)
        {
            // Resetting the Employees List
            Employees.Clear();

            // Clearing existing data found in the DataGridView
            UI_UnsortedData_Dgv.Rows.Clear();

            // Displaying data from the provided List if the radio button is checked
            if (UI_ProvidedList_RadioBtn.Checked)
            {
                // Display unsorted list of employees in the data grid view
                for (int i = 0; i < EmployeeID.Length; i++)
                {
                    Employee emp = CreateEmployee(EmployeeID[i], FirstName[i], LastName[i]);
                    Employees.Add(emp);
                    UI_UnsortedData_Dgv.Rows.Add(emp._employeeID, emp._firstName, emp._lastName);
                }
            }
        }

        /// <summary>
        /// Deletes all data found in the Unsorted Data DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_ClearUnsortedDataGrid_Btn_Click(object sender, EventArgs e)
        {
            // Clearing existing data found in the DataGridView
            UI_UnsortedData_Dgv.Rows.Clear();

            // Clearing the Employees List
            Employees.Clear();
        }

        /// <summary>
        /// Sorts the list of employees by Employee IDs using the Selection Sort Algorithm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_SortByEmployee_Btn_Click(object sender, EventArgs e)
        {
            //Check if list is empty 
            if (Employees.Count() == 0)
            {
                MessageBox.Show("Please give me data first");
                return;
            }

            // Enabling the Timer
            UI_EllapsedTicks_Tmr.Enabled = true;
                        
            // Reseting and Starting the stop watch
            sw.Restart();

            // Perform the Insertion Sort
            SortData(Employees, 1);

            //Stop the stop watch
            sw.Stop();

            // Clearing the Sorted Data DataGridView
            UI_SortedData_Dgv.Rows.Clear();

            // Displaying the newly sorted data in the DataGridView
            foreach (var emp in Employees)
                UI_SortedData_Dgv.Rows.Add(emp._employeeID, emp._firstName, emp._lastName);

        }

        /// <summary>
        /// If the Data Source Radio Button is changed, enable or disable the Open File Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_DataSource_CheckedChanged(object sender, EventArgs e)
        {
            //// Displaying data from the file if the radio button is checked
            //if (UI_FileData_RadioBtn.Checked)
            //{
            //    // Enable the Open File through OFD Button
            //    UI_OpenFileThroughOFD_Btn.Enabled = true;
            //}

            //else
            //{
            //    // Disable the Open File through OFD Button
            //    UI_OpenFileThroughOFD_Btn.Enabled = false;
            //}

            // Cleaner version of the above code I think
            UI_OpenFileThroughOFD_Btn.Enabled = UI_FileData_RadioBtn.Checked;

        }

        /// <summary>
        /// Implements Drag Enter functionality to load data from a file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_UnsortedData_Dgv_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        /// <summary>
        /// Implements Drag & Drop functionality to load data from a file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_UnsortedData_Dgv_DragDrop(object sender, DragEventArgs e)
        {
            // Clearing existing data found in the DataGridView
            UI_UnsortedData_Dgv.Rows.Clear();

            // Obtain File Name
            fileName = ((string[])e.Data.GetData(DataFormats.FileDrop)).First();
            // Letting the user know which file was selected
            MessageBox.Show($"You selected the file: {fileName}", "File Selected");
            Console.WriteLine($"The file name is {fileName}");

            try
            {
                //Reading the data found in the file and storing it in a string
                string[] strData = File.ReadAllLines(fileName);

                // New arrays to hold thne data read from the file
                int[] EmployeeID_File = new int[strData.Length];
                string[] FirstName_File = new string[strData.Length];
                string[] LastName_File = new string[strData.Length];

                for (int i = 0; i < strData.Length; i++)
                {
                    string[] parts = strData[i].Split(',');

                    int.TryParse(parts[0], out EmployeeID_File[i]);
                    FirstName_File[i] = parts[1];
                    LastName_File[i] = parts[2];

                    Employee emp = CreateEmployee(EmployeeID_File[i], FirstName_File[i], LastName_File[i]);
                    Employees.Add(emp);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error reading data from file: {ex.Message}", "Load Error");
            }

            // Displaying the newly loaded data in the DataGridView
            foreach (var emp in Employees)
                UI_UnsortedData_Dgv.Rows.Add(emp._employeeID, emp._firstName, emp._lastName);
            
        }

        private void UI_SortByLastNames_Btn_Click(object sender, EventArgs e)
        {
            //Check if list is empty 
            if (Employees.Count() == 0)
            {
                MessageBox.Show("Please give me data first");
                return;
            }

            // Enabling the Timer
            UI_EllapsedTicks_Tmr.Enabled = true;

            // Reseting and Starting the stop watch
            sw.Restart();

            // Perform the Insertion Sort
            SortData(Employees, 2); ;

            //Stop the stop watch
            sw.Stop();

            // Clearing the Sorted Data DataGridView
            UI_SortedData_Dgv.Rows.Clear();

            // Displaying the newly sorted data in the DataGridView
            foreach (var emp in Employees)
                UI_SortedData_Dgv.Rows.Add(emp._employeeID, emp._firstName, emp._lastName);
        }

        private void UI_ClearSortedDataGrid_Btn_Click(object sender, EventArgs e)
        {
            UI_SortedData_Dgv.Rows.Clear();
        }

        private void UI_EllapsedTicks_Tmr_Tick(object sender, EventArgs e)
        {
            UI_TimeTaken_Tbx.Text = $"{sw.ElapsedTicks}";
        }

        private static void SortData(List<Employee> list, int type)
        {
            switch (type)
            {
                // Sorts the list based on the ID's
                case 1: SelectionSortForIDs(list);      break;

                // Sorts the list based on the Last Names
                case 2: InsertionSortForLatNames(list); break;
            }
        }        

        /// <summary>
        /// Sorts a list based on the IDs
        /// </summary>
        /// <param name="list"></param>
        static void SelectionSortForIDs(List<Employee> list)
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
                    if (list[j]._employeeID > list[max_posn]._employeeID)
                    {
                        max_posn = j;
                    }
                }

                // Perform Swapping
                Employee temp = list[max_posn];
                list[max_posn] = list[last_posn];
                list[last_posn] = temp;
            }
        }

        /// <summary>
        /// Sorts a list based on the Last Names
        /// </summary>
        /// <param name="list"></param>
        static void InsertionSortForLatNames(List<Employee> list)
        {
            // n is the number of element in the list
            int n = list.Count;

            // We use p for the pass number and we
            // start with 1 as the first pass number
            for (int p = 1; p < n; p++)
            {
                Employee temp = list[p];   // We store the value at position P in a 
                                           // temporary variable "temp"
                int j = p - 1;  // j will be our iteration variable starting wih p
                                // and moving backwards

                // We keep looking at the previous position as long

                while ((j >= 0) && (list[j]._lastName.CompareTo(temp._lastName) > 0))
                {
                    // As long as we obtain values bigger than temp, we shift them to the right
                    list[j + 1] = list[j];
                    j = j - 1; // After shifing the value, we again move back one position
                }

                // When we come out of the loop, we have already moved one step to far.
                // So we move one postion to the right and store our value there
                list[j + 1] = temp;
            }
        }
        
    } 
}

