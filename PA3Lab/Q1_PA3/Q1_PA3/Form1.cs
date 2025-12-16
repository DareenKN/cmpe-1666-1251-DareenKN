using System;
using System.Collections.Generic;
using System.Diagnostics;
using GDIDrawer;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Q1_PA3
{
    public delegate void delVoidString(string s);

    public partial class Form1 : Form
    {
        // Variables
        Stopwatch sw = new Stopwatch();
        List<Thread> ThreadList = null;
        CDrawer canvas = null;
        Random randY = new Random();
        Random move = new Random();

        int threadCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (canvas == null) 
                canvas = new CDrawer();

            if (ThreadList == null)
                ThreadList = new List<Thread>();

            sw.Start();
        }

        private void UI_StartThread_Btn_Click(object sender, EventArgs e)
        {            
            Thread t = new Thread(AddBall);
            t.IsBackground = true;
            t.Name = $"Thread{++threadCount}";
            ThreadList.Add(t);

            Text = $"No. of Active Threads is: {ThreadList.Count}";

            t.Start();
        }

        private void AddBall()
        {
            int xPosn = 0;
            int yPosn = randY.Next(50, canvas.m_ciHeight - 50);
            Color c = RandColor.GetColor();


            while (xPosn < canvas.m_ciWidth + 100)
            {
                canvas.AddCenteredEllipse(new Point(xPosn, yPosn), 50, 50, c);

                string s = $"{Thread.CurrentThread.Name}  - Time: {sw.ElapsedMilliseconds}ms - ({xPosn},{yPosn})";
                try
                {
                    Invoke(new delVoidString(AddToListBox), s);
                }
                catch
                {
                    Console.WriteLine("Could not invoke delegate");
                }
                Thread.Sleep(100);

                canvas.AddCenteredEllipse(new Point(xPosn, yPosn), 50, 50, Color.Black);

                xPosn += move.Next(10, 41);
            }                      
        }

        private void AddToListBox(string s)
        {
            UI_DisplayThread_Lbx.Items.Add(s);
        }

        private void UI_Timer_Tick(object sender, EventArgs e)
        {
            for (int count = 0; count < ThreadList.Count; count++)
            {
                Thread t = ThreadList[count];

                if (t.ThreadState == System.Threading.ThreadState.Stopped)
                    ThreadList.Remove(t);
            }

            Text = $"No. of Active Threads is: {ThreadList.Count}";
        }
    }
}
