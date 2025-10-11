/* CMPE1666 - Intermediate Programming
 * Name: Dareen Kinga Njatou
 * 
 * Description: Operate a List of user-defined struct to draw and manipulate some lines.
 * 
 * Date: October 4, 2025
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;

namespace ICA5_DareenKN
{
    public partial class Form1 : Form
    {
        // Struct definition for a line
        private struct Sline
        {
            public Point _start;     // Starting point of the line
            public Point _end;       // Ending point of the line
            public Color _lineColor; // Color of the line
            public byte _thickness;  // Thickness of the line
        }

        // CDrawer variable
        private CDrawer canvas = new CDrawer(800, 800, false);

        // Point variable to capture line Starting position
        private Point startPosn;

        // List to hold all lines
        List<Sline> lines = new List<Sline>();

        // Enumeration to manage application states
        private enum eState { Idle, Armed };

        public Form1()
        {
            InitializeComponent();

            // Initial Render
            Render();

            // Set initial state to Idle
            UI_State_Lbl.Text = $"{eState.Idle}";
        }

        /// <summary>
        /// Render a single line on the canvas
        /// </summary>
        /// <param name="line"></param>
        private void Render(Sline line)
        {
            canvas.AddLine(line._start.X, line._start.Y, line._end.X, line._end.Y, line._lineColor, line._thickness);
        }

        /// <summary>
        /// Initial Render of all lines in the list
        /// </summary>
        private void Render()
        {
            canvas.Clear();
            foreach (Sline line in lines)
            {
                Render(line);
            }
            canvas.Render();
        }

        /// <summary>
        /// Interval timer to poll for mouse clicks and manage state transitions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_Poll_Tmr_Tick(object sender, EventArgs e)
        {
            // Point to capture click position
            Point clickPosn;

            // Poll for the left-click event
            // In Idle state, capture the starting position of the line
            if (canvas.GetLastMouseLeftClick(out clickPosn))
            {
                if (UI_State_Lbl.Text == $"{eState.Idle}")
                {
                    startPosn = clickPosn;
                    UI_State_Lbl.Text = $"{eState.Armed}";
                }

                // In Armed state, capture the end position of the line and draw it
                else if (UI_State_Lbl.Text == $"{eState.Armed}")
                {
                    Sline newline = new Sline
                    {
                        _start = startPosn,
                        _end = clickPosn,
                        _lineColor = Color.Red,
                        _thickness = 5
                    };
                    lines.Add(newline);
                    Render(newline);
                    canvas.Render();
                    UI_State_Lbl.Text = $"{eState.Idle}";
                }
            }

            // Poll for the right-click event
            if (canvas.GetLastMouseRightClick(out clickPosn))
            {
                // Random Class for color and thickness change
                Random rand = new Random();

                // Temporary list to hold modified lines
                List<Sline> newLines = new List<Sline>();

                // Change color and thickness of lines on right click
                foreach(Sline line in lines)
                {
                    Sline modifiedLine = line;
                    modifiedLine._lineColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
                    modifiedLine._thickness = (byte)rand.Next(1, 16);
                    newLines.Add(modifiedLine);
                }
                lines = newLines;
                Render();
            }
        }
    }
}
