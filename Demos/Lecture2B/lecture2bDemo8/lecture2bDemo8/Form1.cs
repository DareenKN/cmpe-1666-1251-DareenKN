using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lecture2bDemo8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_ClickMe_Btn_Click(object sender, EventArgs e)
        {
            string color="";
            int engineCapacity=0;

            //Assigning Color based on Color Radio Button
            if (UI_Red_Radio.Checked)
                color = "Red";
            else if (UI_Blue_Radio.Checked)
                color = "Blue";
            else color = "Green";


            if (UI_1500_Radio.Checked)
                engineCapacity = 1500;
            else if (UI_2000_Radio.Checked)
                engineCapacity = 2000;
            else
                engineCapacity = 2500;

            MessageBox.Show($"You wish to have a car with Color {color} and Engine Capacity {engineCapacity}");


        }
    }
}
