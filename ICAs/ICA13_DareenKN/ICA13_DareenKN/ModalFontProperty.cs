/* CMPE1666 - Intermediate Programming
 * Name: Dareen Kinga Njatou
 *
 * Description: CMPE 1666-ICA13 – Fontify
 *               Creating and using support dialogs and public methods
 *               to change the font color and font of a label's text.
 *  
 * Date: November 20, 2025
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ICA13_DareenKN
{
    public partial class ModalFontProperty : Form
    {
        public ModalFontProperty()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the Font in the Font TextBox and Font Dialog
        /// </summary>
        /// <param name="Font"></param>
        public void SetFont(Font Font)
        {
            UI_SelectedFont_Tbx.Text = Font.ToString();
            UI_SelectFont_FontDlg.Font = Font;
        }

        /// <summary>
        /// Sets the Color in the Color TextBox and Color Dialog
        /// </summary>
        /// <param name="Color"></param>
        public void SetColor(Color Color)
        {
            UI_SelectedColour_Tbx.Text = Color.ToString();
            UI_SelectColor_ColorDlg.Color = Color;
        }

        /// <summary>
        /// If OK button is clicked, set the DialogResult to OK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_OK_Btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Select Font button click event to show Font Dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_SelectFont_Btn_Click(object sender, EventArgs e)
        {
            if (UI_SelectFont_FontDlg.ShowDialog() == DialogResult.OK)
                UI_SelectedFont_Tbx.Text = $"{UI_SelectFont_FontDlg.Font}";
        }

        /// <summary>
        /// Select Color button click event to show Color Dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_SelectColor_Btn_Click(object sender, EventArgs e)
        {
            if (UI_SelectColor_ColorDlg.ShowDialog() == DialogResult.OK)
                UI_SelectedColour_Tbx.Text = $"{UI_SelectColor_ColorDlg.Color}";
        }

        /// <summary>
        /// Returns the selected Font from the Font Dialog
        /// </summary>
        /// <returns></returns>
        public Font FontSelected()
        {
                return UI_SelectFont_FontDlg.Font;
        }

        /// <summary>
        /// Returns the selected Color from the Color Dialog
        /// </summary>
        /// <returns></returns>
        public Color ColorSelected()
        {
                return UI_SelectColor_ColorDlg.Color;
        }
    }
}
