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
    public delegate void delColor(Color s);
    public delegate void delOpacity(float op);
    public partial class ModelessDialog : Form
    {
        public delColor _dcol = null;
        public delOpacity _dOpacity = null;
        public ModelessDialog()
        {
            InitializeComponent();

        }

        private void ModelessDialog_Load(object sender, EventArgs e)
        {

        }

        private void UI_Colors_Rbtn(object sender, EventArgs e)
        {
            if (_dcol != null)
            {
                if (UI_Red_Rbtn.Checked)
                    _dcol(Color.Red);
                if (UI_Purple_Rbtn.Checked)
                    _dcol(Color.Purple);
                if (UI_Yellow_Rbtn.Checked)
                    _dcol(Color.Yellow);
            }   
           
        }

        private void UI_OP_Ttrack_Scroll(object sender, EventArgs e)
        {
            if (_dOpacity != null)
            {
                _dOpacity(UI_OP_Ttrack.Value);
            }
        }

        //private void ModelessDialog_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (e.CloseReason == CloseReason.UserClosing)
        //    {
        //        e.Cancel = true;
        //        this.Hide();
        //    }
        //}
    }
}
