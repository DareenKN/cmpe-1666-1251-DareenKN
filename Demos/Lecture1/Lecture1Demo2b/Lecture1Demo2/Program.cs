/*CMPE 1666- Intermediate Programming
 * 
 * lecture 1- Demo2- Working with GDI Drawer
 * 
 * Author: Oveeyen Moonian
 * Date: September 25, 2025
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;
using System.Drawing.Text;

namespace Lecture1Demo2
{
    internal class Program
    {  

        //Defining our Circle as a struct type
        private struct Circle
        {
            public Point _center;
            public int _diameter;
            public Color _color;
        }


        static void Main(string[] args)
        {
            //creating an array of the struct type
            Circle[] circlesArray = new Circle[50];

            int count = 0; //to keep count of the number of circles in the array

            //we create an object of type Random
            //to be used to generate random diameters
            Random rand = new Random();

            CDrawer canvas = new CDrawer();

            //The program continuously checks for a left-mouse click
            //on the CDrawer window
            while (true)
            {
                if (canvas.GetLastMouseLeftClick(out Point P))
                {
                    //Generate a random diameter
                    int randDiameter = rand.Next(25, 75);
                    //Generate a random color
                    Color randColor = RandColor.GetColor();
                    //create the circle with the random diameter and random color
                    Circle newCircle = new Circle { _center = P, _diameter = randDiameter, _color = randColor };
                    //Place the new circle at position count in the circles array
                    //then increment count- note that both are being done in the
                    //one statement
                    circlesArray[count++] = newCircle;
                    canvas.AddCenteredEllipse(newCircle._center, newCircle._diameter, newCircle._diameter, newCircle._color);
                }

                if (canvas.GetLastMouseRightClick(out Point p1))
                {
                    for (int i=0; i<count; i++)
                    {
                        if (circlesArray[i]._diameter >= 50)
                            circlesArray[i]._color = Color.Blue;
                    }

                    Render(canvas, circlesArray, count);
                }

            }

         }

        //counter will represent the number of structs that have been assigned in the array
        private static void Render(CDrawer drawer,Circle[] circles, int counter)
        {
            drawer.Clear();
            for (int i = 0; i < counter; i++)
                drawer.AddCenteredEllipse(circles[i]._center, circles[i]._diameter, circles[i]._diameter, circles[i]._color);
        }
    }
}
