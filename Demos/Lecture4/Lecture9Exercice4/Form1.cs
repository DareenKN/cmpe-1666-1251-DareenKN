using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture9Exercice4
{
    public partial class Form1 : Form
    {
       ModelessDialog dlg = null;


        public Form1()
        {
            InitializeComponent();
           
        }

        private void UI_Show_Btn_Click(object sender, EventArgs e)
        {
            if (dlg == null)
            {
                dlg = new ModelessDialog();
                dlg.Show();
                this.BackColor = Color.Red;
                dlg._dcol = new delColor(ChangeColor);
                dlg._dOpacity = new delOpacity(ChangeOpacity);
            }
            else
                dlg.Hide();
            
           
        }

        private void UI_Hide_Btn_Click(object sender, EventArgs e)
        {
            dlg.Hide();
        }

        private void ChangeColor(Color c)
        {
            BackColor = c;
        }
        private void ChangeOpacity(float i)
        {
            this.Opacity = i/25;
        }
    }
}
