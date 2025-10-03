/* CMPE1666 - Intermediate C# Programming
 * Lecture 3 Demo 5 - Windows Forms Application
 * 
 * Name: Dareen Kinga Njatou
 * 
 * Description: add a struct Student having as members a student id
(an integer) a string for the student first name and a string for the
student’s last name.

The program must also contain the following methods:
 A method StudentToString(). It has as parameter a student struct and it
returns a string containing the student data as follows: <studentId>,
<firstName> <lastName>
 A method MaxId() that has as parameter a list of Student structs and it returns
the Student struct having the highest ID value
 A method MinId() that has a parameter a list of Student structs and it returns
the Student struct with the minimum Id Value
 In the Form class, create an empty List of Student structs.
 In the form class create 3 Lists each containing 10 values. One must be for
student Ids, one for first names and one for last names.
 Add event handlers as per the next slide.

The Form_Load event handler must create 10 Student structs, from the 3 class-
level lists and add them to the list of structs. It must then display them in the
listbox using the StudentToString() method.
 The click event handlers for the “Find Max Id Student” and “Find Min Id Student”
buttons must respectively display all information for the student with maximum
and minimum id in read-only textboxes next to the button.

 * Date: October 5, 2025
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

namespace Lecture3Demo5
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();

        // 3 List containg values for student Ids, first names and last names
        // The declaration has to be done at the form level at the top not in the constructor         
        List<int> StudentIDs = new List<int> { 126, 39, 143, 255, 43, 31, 189, 157, 98, 201 };
        List<string> FirstNames = new List<string> { "Dareen", "John", "Alice", "Bob", "Cathy", "David", "Eva", "Frank", "Grace", "Hank" };
        List<string> LastNames = new List<string> { "Njatou", "Smith", "Johnson", "Brown", "Davis", "Miller", "Wilson", "Moore", "Taylor", "Anderson" };

        // Class-level list of Student structs
        private struct Student
        {
            public int _studentId;
            public string _firstName;
            public string _lastName;
        }
        public Form1()
        {
            InitializeComponent();            
        }

        // Methods
        /// <summary>
        /// Returns a Student struct infos as a string
        /// </summary>
        /// <param name="stud"></param>
        /// <returns></returns>
        private string StudentToString(Student stud)
        {
            string result = $"{stud._studentId}, {stud._firstName} {stud._lastName}";
            return result;
        }
        private Student MaxId(List<Student> list)
        {
            int maxId = list[0]._studentId; 
            int maxPosn = 0;

            for (int count = 0; count < list.Count; count++)
            {
                if (list[count]._studentId > maxId)
                {
                    maxId = list[count]._studentId;
                    maxPosn = count;
                }
            }
            return list[maxPosn];
        }

        private Student MinId(List<Student> list)
        {
            int minId = list[0]._studentId;
            int minPosn = 0;

            for (int count = 1; count < list.Count; count++)
            {
                if (list[count]._studentId < minId)
                {
                    minId = list[count]._studentId;
                    minPosn = count;
                }                
            }
            return list[minPosn];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Creat 10 student objects and add them to the list
            for(int counter = 0; counter < StudentIDs.Count; counter++)
            {
                students.Add(new Student
                {
                    _studentId = StudentIDs[counter],
                    _firstName = FirstNames[counter],
                    _lastName = LastNames[counter]
                });
            }

            // Adding students struct to the listbox
            foreach (Student s in students)            
                UI_Display_Lbx.Items.Add(StudentToString(s));            
        }

        private void UI_MaxID_Btn_Click(object sender, EventArgs e)
        {
            Student maxStudent = MaxId(students);

            UI_MaxID_Tbx.Text = StudentToString(maxStudent);
        }

        private void UI_MinID_Btn_Click(object sender, EventArgs e)
        {
            Student minStudent = MinId(students);
            UI_MinID_Tbx.Text = StudentToString(minStudent);
        }

        private void UI_Display_Lbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = UI_Display_Lbx.SelectedIndex;

            UI_StudentID_Tbx.Text = $"{students[index]._studentId}";
            UI_FirstName_Tbx.Text = students[index]._firstName;
            UI_LastName_Tbx.Text = students[index]._lastName;
        }

        // Modifies a student info in the list box
        private void UI_ModifyStudent_Btn_Click(object sender, EventArgs e)
        {
            int index = UI_Display_Lbx.SelectedIndex;
            Student modifiedStudent = new Student
            {
                _studentId = students[index]._studentId,
                _firstName = UI_FirstName_Tbx.Text,
                _lastName = UI_LastName_Tbx.Text
            };
            students[index] = modifiedStudent;
            UI_Display_Lbx.Items.Clear();

            // Adding students struct to the listbox
            foreach (Student s in students)            
                UI_Display_Lbx.Items.Add(StudentToString(s));            
        }
    }
}
