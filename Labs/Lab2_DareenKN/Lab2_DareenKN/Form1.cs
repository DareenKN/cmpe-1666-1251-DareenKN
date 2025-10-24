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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_DareenKN
{
    public partial class Form1 : Form
    {
        // Declaring a Struct for Employee
        private struct Employee
        {
            public int _employeeID;
            public string _firstName;
            public string _lastName;
        }

        int[] EmployeeID = { 28, 53, 12, 18, 8, 2, 19, 57, 62, 34, 23, 14, 48, 35, 55, 22, 26, 15, 7, 9, 32, 43, 41, 51 };
        string[] FirstName = { "Emily", "Micheal", "Olivia", "Daniel", "Sophia", "Ethan", "Ava", "Benjamin", "Isabella", "Jacob", "Mia", "William", "Emma", "Alexander", "Charlotte", "James", "Amelia", "Logan", "Harper", "Elijah", "Grace", "Noah", "Lily", "Lucas" };
        string[] LastName = { "Johnson", "Smith", "Williams", "Browns", "Jones", "Davis", "Miller", "Wilson", "Moore", "Taylor", "Anderson", "Thomas", "Jackson", "Moore", "Harris", "Martin", "Thompson", "Garcia", "Martinez", "Robnson", "Smith", "Rodriguez", "Lewis", "Clark"};

        List<Employee> employees = new List<Employee>();

        public Form1()
        {
            InitializeComponent();
        }

        private Employee CreateEmployee(int employeeID, string firstname, string lastName,)
        {
            Employee emp = new Employee();

            for (int i = 0; i < EmployeeID.Length; i++)
            {                
                emp._employeeID = EmployeeID[i];
                emp._firstName = FirstName[i];
                emp._lastName = LastName[i];
            }

            return emp;
        }


        private void UI_OpenFileThroughOFD_Btn_Click(object sender, EventArgs e)
        {
            //The ShowDialog() causes the dialog to open
            //When the user clicks on Ok or Cancel,
            //the dialog will clause and return a value of DialogResult.OK
            //if the user clicked on Ok or it will return DialogResult.Cancel
            //if the user clicks on Cancel

            if (UI_MainFile_Dlg.ShowDialog() == DialogResult.OK)
            {
                // Obtain File Name
                string fileName = UI_MainFile_Dlg.FileName;
                Console.WriteLine($"The file name is: {fileName}");

            }
        }

    }
}
