using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Revision811Demo
{
    public partial class ModalDlg : Form
    {
        public ModalDlg()
        {
            InitializeComponent();
        }

        private void UI_OK_Btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void UI_Cancel_Btn_Click(object sender, EventArgs e)
        {
            UI_Timer.Enabled = false;
            DialogResult = DialogResult.Cancel;
        }

        public void SetString(string s)
        {
            UI_Text_Tbx.Text = s;
        }

        public string GetString()
        {
            return UI_Text_Tbx.Text;
        }

        public int GetVal1()
        {
            int.TryParse(UI_Val1_tbx.Text, out int val1);
            return val1;
        }

        public int GetVal2()
        {
            int.TryParse(UI_Val2_Tbx.Text, out int val2);
            return val2;
        }

        private void UI_Timer_Tick(object sender, EventArgs e)
        {
            UI_ProgressBar.PerformStep();
            UI_SelfDestruct_Lbl.Text = $"Dialog will SELF-DESTRUCT in {100 - UI_ProgressBar.Value} s...";

            if (UI_ProgressBar.Value == 100) 
            {
                UI_Timer.Enabled = false;
                DialogResult = DialogResult.Cancel;
            }
        }

        private void ModalDlg_Load(object sender, EventArgs e)
        {
            UI_Timer.Enabled = true;
        }
    }
}
