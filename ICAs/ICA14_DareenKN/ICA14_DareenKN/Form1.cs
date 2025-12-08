/* CMPE1666 – Intermediate Programming
 * Name: Dareen Kinga Njatou
 *
 * Description: ICA 14 – StringBender (Early Delegates)
 * A Windows Forms app that manipulates an input string using Uppercase, 
 * Lowercase, or Flipcase. Uses event consolidation and a delegate to 
 * dynamically select the manipulation method.
 *
 * Date: November 22, 2025
 */

using System;
using System.Windows.Forms;

namespace ICA14_DareenKN
{
    // Interface for string modification delegate
    public delegate string delStringMod(string s);

    public partial class Form1 : Form
    {
        // delegate instance initailized to null
        private delStringMod _modifier = null;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Radio Event Handler - Consolidated for all 3 Radio Buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_InputAndCaseRadio_CheckChanged(object sender, EventArgs e)
        {
            if (UI_Uppercase_RadioBtn.Checked)
                _modifier = ToUppercase;

            else if (UI_Lowercase_RadioBtn.Checked)
                _modifier = ToLowercase;

            else if (UI_Flipcase_RadioBtn.Checked)
                _modifier = ToFlipcase;

            if (_modifier != null)
                UI_OutputString_Tbx.Text = _modifier(UI_InputString_Tbx.Text);
        }

        // String Manipulation Functions

        /// <summary>
        /// Inputs a string and returns it in uppercase
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private string ToUppercase(string s)
        {
            return s.ToUpper();
        }

        /// <summary>
        /// Inputs a string and returns it in lowercase
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private string ToLowercase(string s)
        {
            return s.ToLower();
        }

        /// <summary>
        /// Inputs a string and returns it with flipped case
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private string ToFlipcase(string s)
        {
            string result = "";

            foreach (char ch in s)
            {
                if (char.IsLetter(ch))
                {
                    if (char.IsUpper(ch))
                        result += char.ToLower(ch);
                    else
                        result += char.ToUpper(ch);
                }
                else
                    result += ch;
            }
            return result;
        }
    }
}
