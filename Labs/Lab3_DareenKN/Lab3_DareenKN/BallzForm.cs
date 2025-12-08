/* CMPE1666 - Intermediate Programming
 * Name: Dareen Kinga Njatou
 * 
 * Description: Lab 3 - Ballz
 * Thid Lab focuses on creating a ball game using windows forms, 
 * Modals, Modaless, Delegates, Events and Multithreading.
 *
 * Date: November 27, 2025
 */
using GDIDrawer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace Lab3_DareenKN
{

    // Delegates declarations
    public delegate void delVoidVoid();
    public delegate void delVoidInt(int score);

    public partial class BallzForm : Form
    {        
        Random rand = new Random();     // Random class for random variables
        
        // Instances of the Modaless Dialog in the main form
        private ModelessScore scoreDlg = new ModelessScore();   // Score
        private ModelessAnimationSpeed AnimationSpeedDlg = new ModelessAnimationSpeed();// Animation Speed

        List<int> Scores = new List<int>();
        List<string> highScorers = new List<string>();  // List to hold names of High Scorers

        // Costant Values
        private const int WIDTH = 800;      // Width of canvas
        private const int HEIGTH = 600;     // Height of canvas
        private const int ballSize = 50;    // Size of balls

        int rowCount;       // Number of rows in the canvas
        int columnCount;    // Number of columns in the canvas

        int animationSpeedVal = 0;  // To control the speed at which balls are falling

        // Enumeration for ball state
        private enum ballState { State_Alive, State_Dead };

        // Struct for balls
        private struct Ball
        {
            public Color _ballColor;    // Color of the ball
            public ballState _state;    // State of the ball
        }
                
        Ball[,] ballGrid;   // Grid of balls || Array of balls

        private int totalScore; // Holds the total score

        CDrawer canvas = new CDrawer(); // Create the canvas for the game

        Thread anim = null;  // Seperate thread on the FallDown Method while game is running

        Thread beep = null;  // Seperate thread on the Beep Method while game is running

        // Constuctor
        public BallzForm()
        {
            InitializeComponent();

            rowCount = HEIGTH / ballSize;   // Initialise number of rows
            columnCount = WIDTH / ballSize; // Initialise number of columns

            // Create an instance of the array of balls
            ballGrid = new Ball[rowCount, columnCount];

            // Update score on the modeless
            scoreDlg._dScoreChanged = scoreDlg.CallBackTextChanged;

            // Initialise animation speed
            animationSpeedVal = AnimationSpeedDlg.GetAnimationSpeed();
        }

        /// <summary>
        /// Display the select dificulty dialog, starts Timer when game starts and 
        /// decides the current mode of the game from the selected Dificulty Modal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_Play_Btn_Click(object sender, EventArgs e)
        {
            // Clearing the canvas
            canvas.Clear();

            // Setting the score to 0
            totalScore = 0;

            // Create an instance of the Select Property Modal
            ModalSelectDifficulty dialog = new ModalSelectDifficulty();
                        
            // If user clicks OK, Show Modal 
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                UI_GameOn_Tmr.Start();              // Starts Game Timer
                UI_Play_Btn.Enabled = false;        // Disable the Play Button
                Randomize(dialog.SelectedMode());   // Returns the mode selected to the Game
                Display();                          // Renders the Balls.Alive on the canvas
            }               
            
            else
                // Informs the user when he closes the Select difficulty modal
                MessageBox.Show("Select Dificulty Box was closed by X or Cancel");
        }

        // Methods used in the project for GameON
        /// <summary>
        /// Mix up the grid state, preparing the beginning of the game
        /// </summary>
        /// <param name="mode"></param>
        private void Randomize(int mode)
        {
            // List of colors picked randomly
            List<Color> clrList = RandColorList(mode);

            for (int row = 0; row < rowCount; row++)
            {
                for (int col = 0; col < columnCount; col++)
                {
                    ballGrid[row,col]._ballColor = clrList[rand.Next(clrList.Count)];
                    ballGrid[row, col]._state = ballState.State_Alive;
                }
            }            
        }

        /// <summary>
        /// Show the 2D array of balls in the canvas
        /// </summary>
        private void Display()
        {
            canvas.Clear();

            for (int row = 0; row < rowCount; row++)
            {
                for (int col = 0; col < columnCount; col++)
                {
                    if (ballGrid[row, col]._state == ballState.State_Alive)
                        canvas.AddCenteredEllipse(col * ballSize + ballSize / 2, 
                                                  row * ballSize + ballSize / 2, 
                                                  ballSize, ballSize, 
                                                  ballGrid[row, col]._ballColor);
                }
            }
            canvas.Render();
        }

        /// <summary>
        /// A worker method that counts balls that are alive
        /// </summary>
        /// <returns></returns>
        private int BallsAlive()
        {
            int count = 0;  // Stores the number of balls still alive
            for (int row = 0; row < rowCount; row++)
            {
                for (int col = 0; col < columnCount; col++)
                {
                    if (ballGrid[row, col]._state == ballState.State_Alive)
                        count++;
                }
            }
            return count;
        }

        /// <summary>
        /// Recursive function to change state of killed balls
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="toCompareAgainst"></param>
        /// <returns></returns>
        private int CheckBalls(int row, int col, Color toCompareAgainst)
        {
            // Is the row/column valid
            if (row < 0 || row >= rowCount || col < 0 || col >= columnCount)
                return 0;

            // Is the ball already dead
            if (ballGrid[row, col]._state == ballState.State_Dead)
                return 0;

            // Is the eleent a different color
            if (ballGrid[row, col]._ballColor != toCompareAgainst)
                return 0;

            // Set state to Dead and number of balls killed to 1
            ballGrid[row, col]._state = ballState.State_Dead;
            int killed = 1;

            // Recursive call to neighbor
            killed += CheckBalls(row - 1, col, toCompareAgainst);
            killed += CheckBalls(row + 1, col, toCompareAgainst);
            killed += CheckBalls(row, col - 1, toCompareAgainst);
            killed += CheckBalls(row, col + 1, toCompareAgainst);

            return killed;
        }

        /// <summary>
        /// Returns an integer representing the score obtained for that pick
        /// </summary>
        /// <returns></returns>
        private int Pick()
        {            
            if (!canvas.GetLastMouseLeftClick(out Point Click))
                return 0;
            int row = Click.Y / ballSize;
            int col = Click.X / ballSize;

            if (ballGrid[row, col]._state == ballState.State_Dead) 
            {
                Console.Beep(800, 200);  // frequency, duration
                return 0;
            }

            beep = new Thread(Beep);
            beep.IsBackground = true;
            beep.Start();

            int killed = CheckBalls(row, col, ballGrid[row, col]._ballColor);            

            int score = ScoreCalc(killed);

            // Ensure that multiply threads are nt spawned 
            if(anim == null || !anim.IsAlive)
            {
                // Start animation Thread
                anim = new Thread(Delay);
                anim.IsBackground = true;
                anim.Start();
            } 

            return score;
        }

        private void Beep() 
        {
            new SoundPlayer(@"C:\Windows\Media\Windows Ding.wav").Play();

        }

        /// <summary>
        /// Passed the FallDown funtion in the void function because thread wont take him
        /// </summary>
        private void Delay()
        {
            FallDown();
        }

        private int ScoreCalc(int killed)
        {
            if (killed <= 0)
                return 0;

            return (killed == 1) ? killed * 10 : killed * 50;
        }

        /// <summary>
        /// “Drop” all the balls in our grid by one level
        /// </summary>
        /// <returns></returns>
        private int StepDown() 
        {
            int dropped = 0;

            for (int row = 1; row < rowCount; row++)
            {
                for (int col = 0; col < columnCount; col++)
                {
                    if (ballGrid[row,col]._state == ballState.State_Dead)
                    {
                        if (ballGrid[row - 1, col]._state == ballState.State_Alive)
                        {
                            ballGrid[row, col] = ballGrid[row - 1, col];
                            ballGrid[row - 1, col]._state = ballState.State_Dead;
                            dropped++;
                        }
                    }                    
                }                
            }

            return dropped;
        }

        /// <summary>
        /// Uses StepDown() to drop all our balls until they stop
        /// </summary>
        /// <returns></returns>
        private int FallDown()
        {
            int dropped;
            int totalCount = 0;

            do
            {
                dropped = StepDown();
                totalCount += dropped;

                this.Invoke(new delVoidVoid(Display));
                Thread.Sleep(animationSpeedVal);
            } while (dropped > 0);

            return totalCount;
        }
                

        /// <summary>
        /// Returns a list of colors trimmed to match the selected difficulty
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        private List<Color> RandColorList(int mode)
        {
            List<Color> Colors = new List<Color> {
                                                    Color.FromArgb(255, 105, 180),  // Hot Pink
                                                    Color.FromArgb(138, 43, 226),   // Purple-ish
                                                    Color.FromArgb(102, 255, 255),  // Aqua / Teal
                                                    Color.FromArgb(255, 182, 193),  // Light Pink
                                                    Color.FromArgb(255, 255, 102)   // Soft Yellow Pop
                                                 };

            List<Color> randColors = new List<Color>(); // Stores the colors to be used in the Game
            List<Color> copy = new List<Color>(Colors); // New list to remove from as a color is picked

            // Add the number of randm colors based on the mode selected
            for (int i = 0; i < mode; i++)
            {
                // Ensure NO duplicates of colors in the list
                int index = rand.Next(copy.Count);
                randColors.Add(copy[index]);
                copy.RemoveAt(index);
            }
            return randColors;
        }

        /// <summary>
        /// Shows and Hides the Score Modeless based on the checked property of 
        /// the Show Score Check box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_ShowScore_Cbx_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_ShowScore_Cbx.Checked)
            {
                // Make the modeless dialog appear                
                scoreDlg._dFormClosing = CallBackScoreFormClosing;
                    
                scoreDlg.Show();
            }

            else
                scoreDlg.Hide();
        }

        /// <summary>
        /// Shows and Hides the Animation Speed Modeless based on the 
        /// checked property of the Show animation speed Check box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_ShowAnimationSpeed_Cbx_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_ShowAnimationSpeed_Cbx.Checked)
            {
                // Make the modeless dialog appear
                AnimationSpeedDlg._dFormClosing = CallBackAnimationSpeedFormClosing;

                // Update the game speed
                AnimationSpeedDlg._dSpeedChanged = CallBackNewAnimationSpeed;
                
                AnimationSpeedDlg.Show();
            }

            else
                AnimationSpeedDlg.Hide();
        }

        // Callbacks to update Main Form checkboxes
        /// <summary>
        /// Updates the ShowScore checkbox when user closes modeless
        /// </summary>
        private void CallBackScoreFormClosing()
        {
            UI_ShowScore_Cbx.Checked = false;
        }

        /// <summary>
        /// Updates the Animation Speed checkbox when user closes modaless
        /// </summary>
        private void CallBackAnimationSpeedFormClosing()
        {
            UI_ShowAnimationSpeed_Cbx.Checked = false;
        }

        private void CallBackNewAnimationSpeed(int speed)
        {
            animationSpeedVal = speed;
        }

        /// <summary>
        /// Stores all the scores in a list of int for comparison later on
        /// </summary>
        private void CollectScores()
        {
            Scores.Add(totalScore);
        }

        /// <summary>
        /// Calling the high score modal with a click event to easily code it
        /// </summary>
        private void DisplayHighScoreDlg()
        {
            // Create an instance of the high score modal Dialog
            ModalHighScore highScoreDlg = new ModalHighScore();

            if (highScoreDlg.ShowDialog() == DialogResult.OK)
            {
                string name = highScoreDlg.InputName();

                string entry = $"{name}|{totalScore}";
                highScorers.Add(entry);

                File.WriteAllLines("../../../High Score Players.txt", highScorers);
                MessageBox.Show($"\"{name}\" with a High Score of ✨{totalScore}✨ has been added to the \"High Score Players.txt\" File");                
            }
            else
                MessageBox.Show("High Score Dialog was closed by X or cancel");
        }

        private void UI_GameOn_Tmr_Tick(object sender, EventArgs e)
        {
            if (BallsAlive() == 0)
            {
                UI_GameOn_Tmr.Stop();   // Stop the timer
                canvas.Clear();         // Clear the canvas

                // Display Game Over in the canvas
                canvas.AddText("Game Over", 50, Color.Gray);

                // Stores the current game score in the List of scores
                CollectScores();

                if (totalScore == Scores.Max()) 
                    DisplayHighScoreDlg();

                //Enable the play button
                UI_Play_Btn.Enabled = true;
            }

            // Kepp playing till no more balls in the cavas            
            int gain = Pick();
            totalScore += gain;
                
            Display();

            // Update score
            try 
            {
                scoreDlg._dScoreChanged(totalScore);
            } 
            catch { }
             
        }
    }
}


