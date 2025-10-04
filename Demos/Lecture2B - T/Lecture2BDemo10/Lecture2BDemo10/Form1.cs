using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture2BDemo10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            UI_Enrolled_Cbx.CheckedChanged += UI_Enrolled_Cbx_CheckedChanged;
        }

        private void UI_Enrolled_Cbx_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();

            string name = UI_Name_Tbx.Text;

            string course = UI_Course_Tbx.Text;

            if (name.Length == 0)
                MessageBox.Show("Name must not be empty");
            if (course.Length == 0)
                MessageBox.Show("Course must not be empty");




        }
    }
}
