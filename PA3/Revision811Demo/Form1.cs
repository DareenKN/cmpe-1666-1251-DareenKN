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
    delegate int delIntVoid();
    // delegate int delBinOp(int x, int y);

    public partial class Form1 : Form
    {
        Action<string> delStr1 = null;

        // delBinOp delObject = delegate (int x, int y) { return x * y; };
        Func<int,int, int> delObject = delegate (int x, int y) { return x * y; };

        ModalDlg dlg = new ModalDlg();
        ModelessDlg modDlg = null;
        public Form1()
        {
            InitializeComponent();
            delStr1 = dlg.SetString;           
        }

        private void UI_Modal_Btn_Click(object sender, EventArgs e)
        {            
            delStr1("Default");
            delStr1($"{delObject(6, 7)}");

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                UI_ModalResult_Lbl.Text = "Result from modal: OK";
                UI_ModalResult_Lbl.Text = $"Result from modal: {dlg.GetString()}";
                UI_BinOp_Lbl.Text = $"{dlg.GetVal1()} * {dlg.GetVal2()} = {delObject(dlg.GetVal1(), dlg.GetVal2())}";
            }
            else
                MessageBox.Show("Dialog was closed with cancel");
        }

        private void UI_OpenModeless_Cbx_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_OpenModeless_Cbx.Checked)
            {
                if (modDlg == null)                
                    modDlg = new ModelessDlg();                   
                
                modDlg._dTextChanged = CallBackTextChanged;
                modDlg._dFormClosing = CallBackFormClosing;
                modDlg._dFormOpacity = CallBackFormOpacity;
                modDlg._dFormColor = CallBackFormColor;

                modDlg.Show();
            }
            else
                modDlg.Hide();
        }

        private void CallBackTextChanged(string s)
        {
            UI_ModelessInput_Lbl.Text = s;
        }

        private void CallBackFormClosing()
        {
            UI_OpenModeless_Cbx.Checked = false;
        }

        private void CallBackFormOpacity(int i)
        {
            this.Opacity = i / 10f;
        }

        private void CallBackFormColor(Color c)
        {
            this.BackColor = c;
        }
    }
}
