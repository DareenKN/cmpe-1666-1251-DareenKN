/**CMPE 1666- Intermediate programming
 * 
 * Lecture 3 - Demo5- Working with a list of structs
 * 
 * 
 */
using Microsoft.SqlServer.Server;
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

        //3 lists containing values to be used for constructing Student Structs
        List<int> studentIDs = new List<int> { 126, 39, 143, 255, 43, 31, 189, 157, 79, 182 };
        List<string> firstNames = new List<string> {"Harry", "Sheldon", "Mary", "Jaimie", "Marie",
                                                     "Michael", "Isaac", "James", "Liz", "Phoebe"};
        List<string> lastnames = new List<string> {"Potter", "Cooper", "Lamb", "Sommer", "Curie",
                                                   "Faraday", "Newton", "Watt", "Taylor", "Kates"  };


        private struct Student
        {
            public int _studentID;
            public string _firstName;
            public string _lastName;
        }


        public Form1()
        {
            InitializeComponent();
        }


        //StudentToString() method returns the student info in the form of 
        //a string
        private string StudentToString(Student stud)
        {
            return $"{stud._studentID}, {stud._firstName} {stud._lastName}";
        }


        /*MaxId() has as parameter a list of Student structs
         * and it returns the student struct with the maximum Id value
         * 
         * 
         * 
         */
        private Student MaxId(List<Student> list)
        {
            int maxValue = list[0]._studentID;
            int maxPosn = 0;

            for(int count=1; count<list.Count; count++)
            {
                if (list[count]._studentID > maxValue)
                {
                    maxValue = list[count]._studentID;
                    maxPosn = count;
                }
            }

            return list[maxPosn];
        }


        /*MinId() has as parameter a list of Student structs
         * and it returns the student struct with the minimum Id value
         * 
         * 
         * 
         */

        private Student MinId(List<Student> list)
        {
            int minValue = list[0]._studentID;
            int minPosn = 0;

            for (int count = 1; count < list.Count; count++)
            {
                if (list[count]._studentID < minValue)
                {
                    minValue = list[count]._studentID;
                    minPosn = count;
                }
            }

            return list[minPosn];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Create 10 student objects and add them to the list
            for (int counter=0; counter<studentIDs.Count; counter++)
            {
                students.Add(new Student { _studentID = studentIDs[counter], 
                                           _firstName = firstNames[counter], 
                                           _lastName = lastnames[counter] });
            }

            //Adding students structs to the ListBox
            foreach (Student s in students)
                UI_Display_Lbx.Items.Add(StudentToString(s));

        }

        private void UI_MaxID_Btn_Click(object sender, EventArgs e)
        {
            Student maxIDStudent = MaxId(students);

            UI_MaxID_Tbx.Text = StudentToString(maxIDStudent);
        }

        private void UI_MinID_Btn_Click(object sender, EventArgs e)
        {
            Student minIDStudent = MinId(students);

            UI_MinID_Tbx.Text = StudentToString(minIDStudent);
        }

        private void UI_Display_Lbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index= UI_Display_Lbx.SelectedIndex;

            UI_StudentID_Tbx.Text = $"{students[index]._studentID}";
            UI_FirstName_Tbx.Text = students[index]._firstName;
            UI_LastName_Tbx.Text = students[index]._lastName;

        }

        private void UI_ModifyStudent_Btn_Click(object sender, EventArgs e)
        {
            int index = UI_Display_Lbx.SelectedIndex;
            Student newStudent = new Student { _studentID=students[index]._studentID,
                                              _firstName=UI_FirstName_Tbx.Text,
                                              _lastName= UI_LastName_Tbx.Text};
            students[index] = newStudent;

            UI_Display_Lbx.Items.Clear();
            //Adding students structs to the ListBox
            foreach (Student s in students)
                UI_Display_Lbx.Items.Add(StudentToString(s));

        }
    }
}
