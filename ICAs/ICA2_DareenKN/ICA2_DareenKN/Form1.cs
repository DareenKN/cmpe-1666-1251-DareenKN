/* CMPE1666 - Intermediate Programming
 * 
 * Name: Dareen Kinga Njatou
 * Description: An application that clearly demonstrates the order in which some 
 *              events/methods occur 
 * 
 * Date: September 19, 2025 
 */
using System;
using System.Windows.Forms;

namespace ICA2_DareenKN
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Form constructor occurs when the form object is created in memory
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("Form Constructor");
        }

        /// <summary>
        /// Form Load Event occurs after constructor and just before the form is displayed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Form Load Event");
        }

        /// <summary>
        /// Form Closing Event occurs whenever the form is drawn or resized on the screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine("Form Closing Event");
        }

        /// <summary>
        /// Form Activated Event occurs when the form becomes active and ready for input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Activated(object sender, EventArgs e)
        {
            Console.WriteLine("Form Activated Event");
        }

        /// <summary>
        /// Form Paint Event occurs whenever the form is drawn or resized on the screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine("Form Paint Event");
        }

        /// <summary>
        /// Form Closed Event occurs after the form has closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Console.WriteLine("Form Closed Event");
        }

        /// <summary>
        /// Form Deactivate Event occurs when the form loses focus or another form becomes active
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Deactivate(object sender, EventArgs e)
        {
            Console.WriteLine("Form Deactivate Event");
        }

        /// <summary>
        /// Form Shown Event occurs when the form is first displayed on the screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Shown(object sender, EventArgs e)
        {
            Console.WriteLine("Form Shown Event");
        }
    }
}
