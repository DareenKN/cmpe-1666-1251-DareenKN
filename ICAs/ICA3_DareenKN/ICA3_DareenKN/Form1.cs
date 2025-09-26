/* CMPE1666 - Intermediate Programming
 * 
 * Name: Dareen Kinga Njatou
 * Description: This is a stopwatch application that allows users 
 *              to start, stop, reset, and record split times.
 * 
 * Date: September 19, 2025 
 */
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ICA3_DareenKN
{
    public partial class Form1 : Form
    {
        private Stopwatch sw = new Stopwatch(); // Class-level Stopwatch instance
        private int runIndex = 0;               // To track the number of splits

        // Constructor
        public Form1()
        {
            InitializeComponent();
        }

        // Timer tick event to update the UI
        private void UI_Update_Timer_Tick(object sender, EventArgs e)
        {
            long ms = sw.ElapsedMilliseconds;            
            UI_DisplayTime_Lbl.Text = FormatTime(ms, runIndex);
        }

        // Start button click event
        private void UI_Start_Btn_Click(object sender, EventArgs e)
        {
            sw.Start(); // Start or resume the stopwatch           
        }

        // Stop button click event
        private void UI_Stop_Btn_Click(object sender, EventArgs e)
        {
            sw.Stop();  // Stop the stopwatch
        }

        // Reset button click event
        private void UI_Reset_Btn_Click(object sender, EventArgs e)
        {
            sw.Reset();     // Reset the stopwatch
            runIndex = 0;   // Reset the run index

            // Clear the list box and reset the display label
            UI_DisplayOnSplit_ListBox.Items.Clear();
            UI_DisplayTime_Lbl.Text = "(0) 00:00:00.00";
        }

        // Split button click event
        private void UI_Split_Btn_Click(object sender, EventArgs e)
        {
            // Get the current elapsed time
            long ms = sw.ElapsedMilliseconds;

            // Avoid duplicates and add to the list box
            if (!UI_DisplayOnSplit_ListBox.Items.Contains(FormatTime(ms, runIndex - 1)))
            {                
                UI_DisplayOnSplit_ListBox.Items.Add(FormatTime(ms, runIndex));
                runIndex++; // Increment the run index for each split
            }                
        }

        /// <summary>
        /// Convert milliseconds to (index) HH:MM:SS.HH format
        /// </summary>
        /// <param name="milliseconds"></param>
        /// <param name="runIndex"></param>
        /// <returns></returns>
        private string FormatTime(long milliseconds, int runIndex)
        {
            long hours = milliseconds / (1000 * 60 * 60);
            long minutes = (milliseconds / (1000 * 60)) % 60;
            long seconds = (milliseconds / 1000) % 60;
            long hundredths = (milliseconds / 10) % 100; // 2 decimal places

            return $"({runIndex}) {hours:00}:{minutes:00}:{seconds:00}.{hundredths:00}";
        }

    }
}
