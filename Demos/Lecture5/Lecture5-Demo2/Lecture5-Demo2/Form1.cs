/*CMPE 1666- Intermediate Programming
 * 
 * Lecture5-Demo2- Sorting a list of structs using Selection Sort
 * 
 * Author: Oveeyen Moonian
 * 
 * Date: May 31, 2024
 * 
 * 
 * In this program we create a struct Student, we then create a list of such structs
 * and perform sorting of the list using the Selection Sort Technique
 * 
 */

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lecture5_Demo2
{
    public partial class Form1 : Form
    {  //Declaring a struct type for Student
        private struct Student
        {
            public int _studentId;
            public string _firstName;
            public string _lastName;
        }


        //StudentId Array
        int[] stdIdArr = { 28, 45, 72, 93, 15, 84, 40, 31, 25, 12, 40, 36, 10, 90, 75 };

        //First Names Array
        string[] firstNames = {"Jane", "Joseph", "Ferdinand", "Geraldine", "Mariam",
                               "Chistiano", "Alberto", "Mason", "Oliver", "Rachel",
                               "Isaac", "Jasmine","Samuel", "Victor", "Ursula"};

        string[] lastNames = {"Lee", "Johnson", "Adams", "Upton", "Vasquez",
                              "Patel", "Williams", "Martinez", "Haris", "Garcia",
                              "Rodriguez", "Turner", "Smith", "Foster", "Yang"};

        List<Student> Students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creates a  Student Struct, given the student Id, the first name and last name
        /// </summary>
        /// <param name="Id">The Student Id to be assigned</param>
        /// <param name="fName"> The first name to be assigned</param>
        /// <param name="lName">The last name to be assigned</param>
        /// <returns>The created Student struct</returns>
        private Student CreateStudent(int Id, string fName, string lName)
        {
            Student student;  //Declares a struct variable

            //Assigns the parameter values to memebers of the struct variable
            student._studentId = Id;
            student._firstName = fName;
            student._lastName = lName;

            //returns the struct variable.
            return student;
        }


        private string StudentToString(Student stud)
        {
            return $"{stud._studentId}-{stud._firstName} {stud._lastName}";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int count = 0; count < stdIdArr.Length; count++)
            {
                Student std = CreateStudent(stdIdArr[count], firstNames[count], lastNames[count]);
                Students.Add(std);
                UI_InitialList_Lbx.Items.Add(StudentToString(std));
            }
        }

        private static void SelectionSort(List<Student> list)
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
                    if (list[j]._studentId > list[max_posn]._studentId)
                    {
                        max_posn = j;
                    }
                }

                // Perform Swapping
                Student temp = list[max_posn];
                list[max_posn] = list[last_posn];
                list[last_posn] = temp;
            }

        }

        private void UI_SortStudents_Btn_Click(object sender, EventArgs e)
        {
            SelectionSort(Students);
            foreach(Student s in Students)
                UI_SortedList_Lbx.Items.Add(StudentToString(s));
        }
    }
}
