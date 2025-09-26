/* CMPE1666 - Intermediate Programming
 * 
 * Name: Dareen Kinga Njatou
 * Description: This program converts a user-inputted currency value into 
 *              the least number of Canadian denominations (bills and coins).
 * 
 * Date:September 11, 2025
 */
using System;
using System.Drawing;
using GDIDrawer;

namespace Lab1_DareenKN
{

    class Program
    {
        // Denominations available
        static double[] denominations = { 50, 20, 10, 5, 2, 1, 0.25, 0.10, 0.05 };

        static void Main()
        {
            //Title of program
            Console.Title = "Lab 1 - Dareen K. N. - Dinero Fácil";

            // Creating a GDIDrawer with standard size (800,600)
            CDrawer canvas = new CDrawer(800, 600);

            Title(); // Display title

            // Loop until user decides to stop
            do
            {
                // Get user input
                double value = GetCurrencyInput();

                // Round to nearest nickel
                double rounded = RoundToNickel(value);

                // Calculate counts of each denomination
                int[] counts = CalculateDenominations(rounded);

                // Display results in console
                DisplayResults(value, rounded, counts);

                // Draw results graphically in GDIDrawer
                DrawResults(canvas, counts, rounded);

            } while (TestAgain("Do you wish to test another value?")); 
        }

        /// <summary>
        /// Title of the program
        /// </summary>
        static void Title()
        {
            string title = "LAB 1 - Dareen K. N. - Dinero Fácil";
            Console.CursorLeft = (Console.WindowWidth - title.Length) / 2;
            Console.WriteLine(title);
            Console.Title = title;
        }

        /// <summary>
        /// Prompts the user to enter a currency value and returns the parsed result as a double.
        /// </summary>
        /// <remarks>The method reads user input, removes any leading dollar sign ('$'), and extracts
        /// numeric characters and a single decimal point. It validates the input to ensure it represents a non-negative
        /// currency value. If the input is invalid, the user is prompted to try again until a valid value is entered.
        /// The returned value is truncated to two decimal places.</remarks>
        /// <returns>A non-negative double representing the entered currency value, truncated to two decimal places.</returns>
        static double GetCurrencyInput()
        {        
            bool valid = false; // flag to track valid input
            double result = 0;  // variable to hold the parsed result

            bool success = false;   // flag for successful parsing
            string numericPart;     // Storing digits from input 
            bool hasMinus;          // Flag for negative sign

            do
            {
                // Prompt user for input
                Console.Write("\nHow much money do you wish to convert?: ");
                string input = Console.ReadLine().Trim();

                numericPart = "";   // Reset numeric part               
                hasMinus = false;   // Reset negative sign flag

                // Check for negative sign anywhere in the input
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == '-')
                        hasMinus = true;
                }

                // Extract numeric characters and decimal point
                foreach (char c in input)
                {
                    // Ignore leading spaces
                    if (char.IsWhiteSpace(c)) { }

                    // skip dollar sign
                    if (c == '$') { }

                    // Collect digits and decimal point
                    else if (char.IsDigit(c) || c == '.')                    
                        numericPart += c;

                    // Stop if more than 2 decimal places
                    if(numericPart.Split('.').Length > 1 && numericPart.Split('.')[1].Length > 2)
                        break;
                }        

                // Try to parse the collected numeric part
                success = double.TryParse(numericPart, out double value);

                // If negative sign is present, reject input
                if (hasMinus && success)                
                    Console.WriteLine("Please enter a non-negative value.");

                // If parsing is successful and value is non-negative, truncate to 2 decimal places
                else if (success && value >= 0)
                {
                    // Multiply to shift decimal, floor to truncate, then divide back
                    result = Math.Floor(value * 100) / 100;
                    valid = true;
                }

                // Invalid input 
                else
                    Console.WriteLine("Invalid entry. Please try again.");
                
            } while (!valid);

            return result;
        }

        /// <summary>
        /// Converts a value to the nearest nickel
        /// </summary>
        /// <param name="value"></param>
        /// <returns>A value rounded to the nearest nickel</returns>
        static double RoundToNickel(double value)
        {
            // Multiply by 20 to convert to nickels
            // MidpointRounding.AwayFromZero ensures .025 rounds up to .05
            // Divide back by 20 to get the rounded value
            return Math.Round(value * 20, MidpointRounding.AwayFromZero) / 20.0;
        }

        /// <summary>
        /// Calculates the counts of each denomination needed to make up the specified monetary value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Number of counts for a monetary value</returns>
        static int[] CalculateDenominations(double value)
        {            
            int[] counts = new int[denominations.Length]; // counts for each denomination
            double remainder = value;                     // remaining amount to be converted

            // Calculate counts for each denomination
            for (int i = 0; i < denominations.Length; i++)
            {
                counts[i] = (int)(remainder / denominations[i]); 
                remainder %= denominations[i];

                // Maintaining the remainder to 2dps
                remainder = Math.Round(remainder, 2); 
            }

            return counts;
        }

        /// <summary>
        /// Displays the results of the currency conversion, including the original and rounded values
        /// </summary>
        /// <param name="initial"></param>
        /// <param name="rounded"></param>
        /// <param name="counts"></param>
        static void DisplayResults(double initial, double rounded, int[] counts)
        {
            Console.WriteLine($"User entry of {initial} interpreted and rounded to ${rounded}");

            // Parallel array for denomination names           
            String[] name = {  "Fifty", "Twenty", "Ten", "Five", "Toonie", "Loonie", "Quarter", "Dime", "Nickel"};

            Console.WriteLine($"\n{"Name",-10} {"Value",10} {"Count",10}");
            Console.WriteLine("--------------------------------");

            // Display the counts for each denomination
            for (int i = 0; i < denominations.Length; i++)
            {
                // Only display denominations that are used
                //if (counts[i] > 0)
                Console.WriteLine($"{name[i],-10} - {denominations[i],10:C} : {counts[i],5}");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Draws a graphical representation of the denominations used to make up the specified monetary value.
        /// </summary>
        /// <param name="counts"></param>
        /// <param name="value"></param>
        static void DrawResults(CDrawer canvas,int[] counts, double value)
        {
            
            int x = 100, y = 100;

            canvas.Clear();
            canvas.AddText($"{value:C}", 20, 330, 20, 150, 75, Color.Yellow);
            canvas.Render();

            // Parallel arrays: one for colors, one for shapes            
            Color[] colors = {  Color.LightPink, Color.LightGreen, Color.Lavender,
                                Color.LightBlue, Color.LightYellow, Color.Gold,
                                Color.LightGray, Color.LightGray, Color.LightGray };
            bool[] isRectangle = { true, true, true, true, false, false, false, false, false };

            // Display counts of used moneytory denominations
            for (int i = 0; i < denominations.Length; i++)
            {
                if (counts[i] > 0)
                {
                    if (y >= 600) { y = 100; x += 400; } // next column

                    // Display note banks as rectangles and coins as circles
                    if (isRectangle[i])
                        canvas.AddRectangle(x, y, 200, 90, colors[i], 3, Color.DarkGray);
                    else
                        canvas.AddEllipse(x + 60, y, 90, 90, colors[i], 3, Color.DarkGray);

                    canvas.AddText($"{denominations[i]:C} x {counts[i]}", 15, x + 5, y, 200, 90);
                    y += 100;
                }
                canvas.Render();
            }
        }

        /// <summary>
        /// Prompts the user with a yes/no question and returns true for 'y' and false for 'n'.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        static bool TestAgain(string message)
        {
            string response;
            do
            {
                Console.Write($"{message} (y/n): ");
                response = Console.ReadLine().ToLower().Trim();

                if (response != "y" && response != "n")                
                    Console.WriteLine("Please answer with 'y' or 'n'.");                

            } while (response != "y" && response != "n");

            if(response == "y")               
                return true;                     
            else
                return false;
        }

    }
}

