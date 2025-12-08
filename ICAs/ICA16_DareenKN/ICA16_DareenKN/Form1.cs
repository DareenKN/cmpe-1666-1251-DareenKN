/* CMPE1666 - Intermediate Programming
 * Name: DareenKinga NJatou
 * 
 * Description: ICA 16 -Pally Hunter - This form check if a word is a palindrome
 *              Later, it reads a list of words from a text file and finds all palindromes
 * 
 * Date: December 3, 2025
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace ICA16_DareenKN
{
    public partial class Form1 : Form
    {
        List<string> _lines = null;     // To store lines read from the file
        Stopwatch sw = new Stopwatch(); // Stopwatch to measure time taken
        Thread SearchingPalindrome;     // Thread for searching palindromes

        // Delegate to represent the method that will run when the thread is done
        private delegate void DoneHandler(List<string> palindromes);

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initialize file dialog and load lines from selected file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_LoadFile_Btn_Click(object sender, EventArgs e)
        {
            // Open file dialog to select a text file
            if (UI_OFD.ShowDialog() == DialogResult.OK)
            {
                // Read all lines from the selected file
                try
                {
                    _lines = new List<string>(File.ReadAllLines(UI_OFD.FileName));
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Error reading data from file: {ex.Message}", "Load Error");
                }

                // Display number of words loaded
                UI_FileOutput_Tbx.Text = $"Loaded {_lines.Count} words";
            }
        }

        /// <summary>
        /// Initiate palindrome search on a separate thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_Find_Btn_Click(object sender, EventArgs e)
        {
            // Check if lines are loaded
            if (_lines == null)
            {
                Console.WriteLine("Inside if find");
                MessageBox.Show("Load a file first");
                return;
            }

            // Clear text box
            UI_FileOutput_Tbx.Clear();

            // Restart stopwatch
            sw.Restart();

            //Pushing the search for palindromes to another thread
            SearchingPalindrome = new Thread(ProcessPalindromes);
            SearchingPalindrome.IsBackground = true;

            // Start the thread
            SearchingPalindrome.Start();            
        }

        /// <summary>
        /// Function happening in a background thread
        /// </summary>
        private void ProcessPalindromes()
        {
            // Create a new list to store the palindromes found
            List<string> Palindromes = new List<string>();

            // Finding the palindromes
            for (int i = 0; i < _lines.Count; i++)
            {
                // Check if the current line is a palindrome and add to the list if it is
                if (IsPalindrome(_lines[i], 0, _lines[i].Length - 1))                
                    Palindromes.Add(_lines[i]);                
            }

            // Thread is done, callback to UI Thread
            try
            {
                this.Invoke(new DoneHandler(ShowResults), Palindromes);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Couldn't call the method. Message: {ex.Message}");
            }   
        }

        /// <summary>
        /// Displaying the results
        /// </summary>
        /// <param name="palindromes"></param>
        private void ShowResults(List<string> palindromes)
        {
            // Stop the stopwatch
            sw.Stop();

            // Clear Text box
            UI_FileOutput_Tbx.Clear();

            // Display the found palindromes
            UI_FileOutput_Tbx.Text = $"{String.Join(", ", palindromes)}";

            // Display the umber of found palindromes and times ellapsed
            UI_FileOutput_Tbx.Text += $"  ------ Found {palindromes.Count} palindromes in {sw.ElapsedMilliseconds}ms!";
        }

        /// <summary>
        /// Simple test for a single word
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_SimpleTest_Btn_Click(object sender, EventArgs e)
        {
            string test = UI_InputTest_Tbx.Text; // Get the input text

            // Check if input is empty and inform the user
            if (test.Length == 0)
            {
                MessageBox.Show("Enter a word in the text box first");
                return;
            }

            // Check if the input word is a palindrome
            else
            {
                bool pallyFound = IsPalindrome(test, 0, test.Length - 1);

                // Display the result to the user
                if (pallyFound)
                    UI_InputTest_Tbx.Text = $"\'{test}\' is a Palindrome 😊";

                else
                    UI_InputTest_Tbx.Text = $"\'{test}\' is not a Palindrome!";
            }
        }

        /// <summary>
        /// Recursive function to check if a string is a palindrome
        /// </summary>
        /// <param name="test"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        private bool IsPalindrome(string test, int left, int right)
        {
            // Base case: If left index crosses right, it's  palindrome
            if (left >= right)
                return true;

            // If mismatch is found, it's not a palindrome
            if (test[left] != test[right])
                return false;

            // Move inward and check the next pair
            return IsPalindrome(test, left + 1, right - 1);
        }
    }
}
