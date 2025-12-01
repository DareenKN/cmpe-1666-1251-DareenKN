/*CMPE1666 - Intermediate Programming
 * Name:Dareen Kinga Njatou
 * Lecture 10 Exercise 2
 * 
 * Date: December 1, 2025
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lectur10Exercise2
{    
    public partial class Form1 : Form
    {
        // This variable will be used to control the thread that calculates sine
        private bool runSine;
        private bool runCos;

        Action<ListBox, string> delWriteToListBox = null;

        public Form1()
        {
            InitializeComponent();

            delWriteToListBox = new Action<ListBox, string>(WriteToListBox);
        }

        public void FindSine()
        {
            double x = 0;
            while ((x < 90) && runSine)
            {
                double rad = Math.PI * x / 180;
                double sineValue = Math.Sin(rad);
                string str = $"{x:F2} degrees = {rad:F4} radians. Sine={sineValue:F4}";

                // We need a delegate invokation here as the thread will need to get
                // something written in the UI - Delegate Invocation always require
                // try catch
                try
                {
                    Invoke(delWriteToListBox, UI_Sine_Lbx, str);
                }
                catch(Exception e)
                {
                    Console.WriteLine($"The following exeption occured: {e.Message}");
                }

                x += 0.1;
                Thread.Sleep(1);
            }
        }

        public void FindCos()
        {
            double x = 0;
            while ((x < 90) && runCos)
            {
                double rad = Math.PI * x / 180;
                double cosValue = Math.Cos(rad);
                string str = $"{x:F2} degrees = {rad:F4} radians. Cos={cosValue:F4}";
                try
                { 
                    Invoke(delWriteToListBox, UI_Cos_Lbx, str); 
                }
                catch (Exception e)
                {
                    Console.WriteLine($"The following exeption occured: {e.Message}");
                }
                x += 0.1;
                Thread.Sleep(1);
            }
        }

        private void WriteToListBox(ListBox LB, string str)
        {
            LB.Items.Add(str);
        }

        private void UI_StartSine_Btn_Click(object sender, EventArgs e)
        {
            runSine = true;
            UI_Sine_Lbx.Items.Clear();
            Thread sineThread = new Thread(FindSine);
            sineThread.IsBackground = true;
            sineThread.Start();
        }

        private void UI_StopSine_Btn_Click(object sender, EventArgs e)
        {
            runSine = false;
        }

        private void UI_StartCos_Btn_Click(object sender, EventArgs e)
        {
            runCos = true;
            UI_Cos_Lbx.Items.Clear();
            Thread cosThread = new Thread(FindCos);
            cosThread.IsBackground = true;
            cosThread.Start();
        }

        private void UI_StopCos_Btn_Click(object sender, EventArgs e)
        {
            runCos = false;
        }
    }
}
;