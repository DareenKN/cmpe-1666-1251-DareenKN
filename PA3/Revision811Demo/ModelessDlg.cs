using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revision811Demo
{    
    public delegate void delVoidVoid();

    // public delegate void delVoidString(string s);
    // public delegate void delVoidOp(int i);
    // public delegate void delVoidClr(Color c);

    public partial class ModelessDlg : Form
    {        
        public delVoidVoid _dFormClosing = null;
        // public delVoidString _dTextChanged = null;
        // public delVoidOp _dFormOpacity = null;
        // public delVoidClr _dFormColor = null;

        public Action<string> _dTextChanged = null;
        public Action<Color> _dFormColor = null;
        public Action<int> _dFormOpacity = null;

        public ModelessDlg()
        {
            InitializeComponent();
        }

        private void UI_Input_Tbx_TextChanged(object sender, EventArgs e)
        {
            if (_dTextChanged != null)            
                _dTextChanged(UI_Input_Tbx.Text);
            
        }

        private void ModelessDlg_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (_dFormClosing != null)
                    _dFormClosing();

                e.Cancel = true;
                Hide();
            }
        }

        private void UI_Opacity_Track_Scroll(object sender, EventArgs e)
        {
            if(_dFormOpacity != null)            
                _dFormOpacity(UI_Opacity_Track.Value);            
        }

        private void UI_BackColor_CheckedChanged(object sender, EventArgs e)
        {
            if (_dFormColor != null)
            {
                if (UI_None_Radio.Checked)
                    _dFormColor(Control.DefaultBackColor);

                if (UI_Red_Radio.Checked) 
                    _dFormColor(Color.Red);

                if (UI_Orange_Radio.Checked)
                    _dFormColor(Color.Orange);

                if (UI_Purple_Radio.Checked)
                    _dFormColor(Color.Purple);
            }            
        }
    }
}
