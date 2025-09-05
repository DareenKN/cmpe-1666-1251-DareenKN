/* CMPE 1666 - Intermediate Programming
 * Lecture 1 Demo 2 - Working with GDI Drawer
 * 
 * Author: Dareen Kinga Njatou
 * Date: September 5, 2025
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace Lecture1Demo2
{
    internal class Program
    {
        public struct Circle
        {
            public Point _center;
            public int _diameter;
            public Color _color;
        }
        static void Main(string[] args)
        {
            CDrawer canvas = new CDrawer();

            int count = 0; // To keep coun of the number of circle in the array

            // Adding an array
            Circle[] circleArray = new Circle[50];

            // We create an object of type random
            // To be used to generate random diameter
            Random rand = new Random();


            // 

            // The progam continously checks for a left mouse click
            // on the canvas
            while (true)
            {
                if(canvas.GetLastMouseLeftClick(out Point P))
                {
                    int randDiametr = rand.Next(25, 75);
                    Color randColor = RandColor.GetColor();

                    Circle newCicle = new Circle { _center = P, _diameter = randDiametr, _color = randColor };

                    circleArray[count++] = newCicle;


                    canvas.AddCenteredEllipse(newCicle._center, newCicle._diameter, newCicle._diameter, newCicle._color);
                }
            }



        }
    }
}
