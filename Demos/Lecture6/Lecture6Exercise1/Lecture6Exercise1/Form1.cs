/* CMPE 1666- Intermediate Programming
 * 
 * Lecture 6- Exercise1 - Implementation od Recurive Method for Factorial
 * 
 * 
 * 
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

namespace Lecture6Exercise1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void UI_CalculateFactorial_Btn_Click(object sender, EventArgs e)
        {
            int.TryParse(UI_Value_Tbx.Text, out int val);
            UI_Result_Tbx.Text = $"{Factorial(val)}";
        }

        static private long Factorial(int n)
        {
            if (n >= 1)
                return n * Factorial(n - 1);
            else
                return 1;
        }
    }
}
