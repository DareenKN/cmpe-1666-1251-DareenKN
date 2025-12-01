using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture9Exercise2
{
    public partial class Form1 : Form
    {  //Creating the delegate type
        public delegate int delBinaryOp(int x, int y);

        private delBinaryOp _delOp = null;
        public Form1()
        {
            InitializeComponent();
        }



        private int Addition(int val1, int val2)
        {
            return val1 + val2;
        }

        private int Multiplication(int val1, int val2)
        {
            return val1 * val2;
        }

         private int Division(int val1, int val2)
        {
            return val1 / val2;
        }

        private void UI_Recalculate(object sender, EventArgs e)
        {   //This is a consolidated Event handler for all radio buttons CheckChanged
            // and both textBoxes TextChanged

            //We first verify that both textboxes have valid int values
            bool success1 = int.TryParse(UI_Num1_Tbx.Text, out int val1);
            bool success2 = int.TryParse(UI_Num2_Tbx.Text, out int val2);
             
            //if both are valid then we proceed to perform the calculation based on the radio button checked
            if (success1 && success2)
            {
                if (UI_Add_Radio.Checked)
                    _delOp = new delBinaryOp(Addition);
                else if (UI_Mult_Radio.Checked)
                    _delOp = new delBinaryOp(Multiplication);
                else _delOp = new delBinaryOp(Division);

                UI_Result_Lbl.Text = $"Result is: {_delOp.Invoke(val1,val2)}";
            }
        }
    }


}
