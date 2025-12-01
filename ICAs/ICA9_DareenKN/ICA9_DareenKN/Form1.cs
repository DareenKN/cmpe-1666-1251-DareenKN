/* CMPE1600 - Intermediate Programming
 * Name: Dareen Kinga Njatou
 * 
 * Description: CMPE 1666-ICA09 – Basic forms of Recursion 
 *              This application demonstrates various recursion techniques: 
 *              the PreOrder and PostOrder string recursion, as well as 
 *              Factor Finding and Uppercase Letter Counting.
 * 
 * Date: November 3, 2025
 */
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ICA9_DareenKN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// PreOrder Recursion Function for the RecShow Button
        /// </summary>
        /// <param name="sString"></param>
        /// <param name="iPosition"></param>
        /// <returns></returns>
        public static string RecShow(string sString, int iPosition)
        {
            // Base Case
            if (iPosition >= sString.Length)
                return "";

            // Word is assigned the character at the current position
            string word = sString[iPosition].ToString();
            Console.Write(sString[iPosition]);

            // Word is concatenated with the result of the next recursive call
            word += RecShow(sString, iPosition + 1);

            // Return the constructed word
            return word;

        }

        /// <summary>
        /// PostOrder Recursion Function for the RecReverse Button
        /// </summary>
        /// <param name="sString"></param>
        /// <param name="iPosition"></param>
        /// <returns></returns>
        public static string RecReverse(string sString, int iPosition)
        {
            // Base Case
            if (iPosition >= sString.Length)
                return "";

            // Word is assigned the result of the next recursive call
            // concatenated with the character at the current position
            string word = RecReverse(sString, iPosition + 1) + sString[iPosition];

            // Print after recursion
            Console.Write(sString[iPosition]);

            // Return the constructed word
            return word;
        }

        /// <summary>
        /// FactorFinder Function for the Find Factor Button
        /// </summary>
        /// <param name="number"></param>
        /// <param name="i"></param>
        /// <param name="Factors"></param>
        public static void FactorFinder(int number, int i, List<int> Factors)
        {
            // Factors finder number = number % i == 0
            //In short no remainder when it is been divided by the number
            if (i > number)
                return;

            // If i is a factor of number, add it to the list
            if (number % i == 0)
                Factors.Add(i);

            // Recursive call to check the next number
            FactorFinder(number, i + 1, Factors);

        }

        /// <summary>
        /// Bnary Search function to locate Upper case letters
        /// </summary>
        /// <param name="s"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <returns></returns>
        public static int FindUppercase(string s, int low, int high)
        {
            // Error Checking
            if (string.IsNullOrEmpty(s))
                return 0; // nothing to search

            if (low < 0 || high >= s.Length || low > high)
                return 0; // invalid bounds

            // Base Case 
            if (low == high)
                // Check if the single character is uppercase
                return char.IsUpper(s[low]) ? 1 : 0;


            // Divide the string into two halves 
            int mid = (low + high) / 2;

            // Conquer each half recursively
            int leftCount = FindUppercase(s, low, mid);
            int rightCount = FindUppercase(s, mid + 1, high);

            // Sum the counts from both halves
            return leftCount + rightCount;
        }

        /// <summary>
        /// RecShow Button Click Event Handler collects the input 
        /// string and displays the result of the RecShow function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_RecShow_Btn_Click(object sender, EventArgs e)
        {
            // Collect input string from TextBox
            string input = "";
            input = UI_StringRecursion_Tbx.Text;

            // Display the result of RecShow function
            UI_DisplayStringRecursion_Tbx.Text = $"{RecShow(input, 0)}";
        }

        /// <summary>
        /// RecReverse Button Click Event Handler collects the input
        /// string and displays the result of the RecReverse function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_RecReverse_Btn_Click(object sender, EventArgs e)
        {
            // Collect input string from TextBox
            string input = "";
            input = UI_StringRecursion_Tbx.Text;

            // Display the result of RecReverse function
            UI_DisplayStringRecursion_Tbx.Text = $"{RecReverse(input, 0)}";
        }

        /// <summary>
        /// Find Factors Button Click Event Handler collects the input
        /// and displays the result of the FactorFinder function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_FindFactors_Btn_Click(object sender, EventArgs e)
        {
            // Collect input number from NumericUpDown
            int number = (int)UI_FactorFinder_Nud.Value;

            // List to store factors
            List<int> Factors = new List<int>();

            // Call FactorFinder to populate the Factors list
            FactorFinder(number, 1, Factors);

            // Display the factors in the TextBox
            UI_DisplayFactors_Tbx.Text = $"{string.Join(" ", Factors)}";
        }

        /// <summary>
        /// Find Uppercase Button Click Event Handler collects the input
        /// and displays the result of the FindUppercase function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_FindUppercase_Btn_Click(object sender, EventArgs e)
        {
            // Collect input string from TextBox
            string sentence = UI_BinayHunterInput_Tbx.Text;

            // Call FindUppercase to count uppercase letters
            int UpperOccurences = FindUppercase(sentence, 0, sentence.Length - 1);

            // Display the count of uppercase letters
            UI_DisplayBinary_Tbx.Text = $"There are {UpperOccurences} uppercase letters!";
        }
    }
}
