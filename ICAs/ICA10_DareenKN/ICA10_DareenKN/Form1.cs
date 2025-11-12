/* CMPE1600 - Intermediate Programming
 * Name: Dareen Kinga Njatou
 *
 * Description: CMPE 1666-ICA10 – FloodFill Algorithm
 *              Applying recursion to performing a flood fill on a graphical object.
 *  
 * Date: November 7, 2025
 */
using GDIDrawer;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ICA10_DareenKN
{
    public partial class Form1 : Form
    {
        int SCALE = 10; // Scale factor for the canvas

        // Create a new GDIDrawer window with the specified 80 and 60
        CDrawer canvas = new CDrawer(800, 600);

        // Create a 2D array to hold the squares
        Color[,] pixels = new Color[80, 60];

        public Form1()
        {
            InitializeComponent();

            // Assigning a default color to the panel
            UI_ColorPanel_Pnl.BackColor = Color.SkyBlue;
        }

        /// <summary>
        /// Initializes the canvas with random blocks and a red boundary
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_Generate_Btn_Click(object sender, EventArgs e)
        {
            // Clear canvas and set scale
            canvas.Clear();
            canvas.Scale = SCALE;

            // Reset array to black
            for (int x = 0; x < 80; x++)
                for (int y = 0; y < 60; y++)
                    pixels[x, y] = Color.Black;

            // Draw red boundary
            for (int x = 0; x < 80; x++)
            {
                pixels[x, 0] = Color.Red;
                pixels[x, 59] = Color.Red;
            }

            for (int y = 0; y < 60; y++)
            {
                pixels[0, y] = Color.Red;
                pixels[79, y] = Color.Red;
            }

            // Fill random blocks
            int numBlocks = (int)UI_NumberOfBlocks_Tbr.Value * 100;
            Random rand = new Random();

            for (int i = 0; i < numBlocks; i++)
            {
                int x, y;
                do
                {
                    x = rand.Next(80);
                    y = rand.Next(60);
                } while (pixels[x, y] == Color.Red);

                pixels[x, y] = Color.Red;
            }

            // display pixels
            DisplayPixels();
        }

        /// <summary>
        /// Dispay the pixels on the canvas
        /// </summary>
        void DisplayPixels()
        {
            for (int x = 0; x < 80; x++)
                for (int y = 0; y < 60; y++)
                    canvas.SetBBScaledPixel(x, y, pixels[x, y]);

            canvas.Render();
        }

        /// <summary>
        /// Assigns the selected color from the color dialog to the panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_FillColor_Btn_Click(object sender, EventArgs e)
        {
            // Assigning the color of the color dialog to the panel
            if (UI_FillColor_Cdg.ShowDialog() == DialogResult.OK)
                UI_ColorPanel_Pnl.BackColor = UI_FillColor_Cdg.Color;
        }

        /// <summary>
        /// Starts the tick event of the fill timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_Fill_Btn_Click(object sender, EventArgs e)
        {
            // Clear any old stored click before fill button is pressed
            canvas.GetLastMouseLeftClick(out Point dump);

            // Start timer
            UI_Fill_Tmr.Start();
        }

        private void UI_Fill_Tmr_Tick(object sender, EventArgs e)
        {
            // Event when Mouse is clicked in the canvas
            if (canvas.GetLastMouseLeftClick(out Point p))
            {
                // Get the point clicked by user
                int gx = p.X / SCALE;
                int gy = p.Y / SCALE;

                // Setting the target color to be replaced
                Color target = Color.Black;
                Color replacement = UI_ColorPanel_Pnl.BackColor;

                // Recursive FloodFill function
                FloodFill(gx, gy, target, replacement);

                // Stop timer
                UI_Fill_Tmr.Stop();

                // Displaying the pixels
                DisplayPixels();
            }            
        }

        /// <summary>
        /// Fills the surrounding squares with target color to replacement color
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="target"></param>
        /// <param name="replacement"></param>
        void FloodFill(int x, int y, Color target, Color replacement)
        {
            // boundaries and base cases
            if (x < 0 || x >= 80 || y < 0 || y >= 60)
                return;

            if (pixels[x, y] == replacement)
                return;

            if (pixels[x, y] != target)
                return;


            // replace color
            pixels[x, y] = replacement;



            // recursive calls to neighbors
            FloodFill(x - 1, y, target, replacement);
            FloodFill(x + 1, y, target, replacement);
            FloodFill(x, y - 1, target, replacement);
            FloodFill(x, y + 1, target, replacement);
        }
    }
}
