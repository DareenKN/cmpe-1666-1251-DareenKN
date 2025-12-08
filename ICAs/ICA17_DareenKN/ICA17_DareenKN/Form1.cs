/* CMPE1666 - Intermediate Programming
 * Name: Dareen Kinga Njatou
 * 
 * Description: ICA 17 -  Thready Colour Analyzer - A Windows Forms application that
 *              allows users to select multiple image files and analyzes the color composition
 * 
 * Date: December 3, 2025
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace ICA17_DareenKN
{
    public partial class Form1 : Form
    {
        // List to store all threads
        List<Thread> Threads = new List<Thread>();

        // Delegate to report results back to the main thread
        public delegate void delReport(string file, double redP, double greenP, double BlueP);

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initiates the Colour Scanning Process
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_Go_Btn_Click(object sender, EventArgs e)
        {
            
            // Show the Open File Dialog
            if(UI_OFD.ShowDialog() == DialogResult.OK)
            {
                // Clear Listbox and Threads
                //UI_ClrScanner_Lbx.Items.Clear();
                Threads.Clear();

                // Inform the user that the process is about to start
                MessageBox.Show("Process is about to Start");
                UI_ClrScanner_Lbx.Items.Add("Starting...");

                // For each selected file, start a new thread to process it
                foreach (string file in UI_OFD.FileNames) 
                {
                    // Start a new thread for each files
                    Thread t = new Thread(ProcessFile);

                    // Set each thread to background threads
                    t.IsBackground = true;

                    // Add each Threads to the list of Threads
                    Threads.Add(t);

                    // Pass filename to the Thread
                    t.Start(file);
                }

                // Enable timer
                UI_Scanning_Tmr.Enabled = true;
            }
        }

        /// <summary>
        /// This method processes each file to calculate the RGB percentages
        /// </summary>
        /// <param name="obj"></param>
        private void ProcessFile(object obj)
        {
            // Collecting the filename from the object passed
            string fileName = (string)obj;

            Bitmap bm = null;

            /* In the processing thread (there will be one started for each file 
             * selected),attempt to open the passed file name as a bitmap: 
             * Bitmap bm = (Bitmap)Bitmap.FromFile(fname); 
             * If it fails, just return out of the threads (you won’t let the 
             * user know that the file was invalid... unless you want to...)
             */
            try
            {
                bm = (Bitmap)Bitmap.FromFile(fileName);
            }
            catch
            {
                return;
            }

            // Variables to store the total amount of each RGB colours
            long totalRed = 0, totalGreen = 0, totalBlue = 0;

            // Collecting the total amount of red blue and green in each picture
            for (int x = 0; x < bm.Width; x++)
            {
                for (int y = 0; y < bm.Height; y++)
                {
                    Color c = bm.GetPixel(x, y);
                    totalRed += c.R;
                    totalGreen += c.G;
                    totalBlue += c.B;
                }
            }

            // Stores the total value fOr the sum of the RGB colours
            double totalRGB = totalRed + totalBlue + totalGreen;

            // Calculate the percentage of each colour
            double redP = (totalRed / totalRGB) * 100.0;
            double greenP = (totalGreen / totalRGB) * 100.0;
            double BlueP = (totalBlue / totalRGB) * 100.0;

            //public delegate void delReport(string file, double redP, double greenP, double BlueP);
            // always invoke in try catch blocks
            try{
                Invoke(new delReport(ReportResults), fileName, redP, greenP, BlueP); }
            catch { }
        }

        /// <summary>
        /// Invoked to report results back to the main thread
        /// </summary>
        /// <param name="file"></param>
        /// <param name="r"></param>
        /// <param name="g"></param>
        /// <param name="b"></param>
        private void ReportResults(string file, double r, double g, double b)
        {
            string entry = $"(R:{r:F1}%, G:{g:F1}%, B:{b:F1}%) : {file}";
            UI_ClrScanner_Lbx.Items.Add(entry);
        }

        /// <summary>
        /// Is triggered periodically to check if all threads are done
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_Scanning_Tmr_Tick(object sender, EventArgs e)
        {
            bool allDone = true;    // Assume all threads are done

            // Checks if a thread is still ongoing
            foreach (Thread t in Threads)
            {
                if(t.ThreadState != ThreadState.Stopped)                
                    allDone = false;
                                  
            }

            // It disables the timer and informs the user when all threads are done
            if (allDone)
            {
                // Disable timer
                UI_Scanning_Tmr.Enabled = false;

                // Inform the user
                MessageBox.Show("The Scanning Process is done");
                UI_ClrScanner_Lbx.Items.Add("Done...");
            }
        }
    }
}
