using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace lecture4Demo3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_LoadFile1_Btn_Click(object sender, EventArgs e)
        {
            string[] strArr = File.ReadAllLines("../../../../file1.txt");
            foreach (string s in strArr)
                Ui_DisplayFile1_Lbx.Items.Add(s);
        }

        private void UI_LoadFile2_btn_Click(object sender, EventArgs e)
        {
            string fileData = File.ReadAllText("../../../../file2.txt");
            UI_DisplayFile2_Tbx.Text = fileData;
        }
    }
}
