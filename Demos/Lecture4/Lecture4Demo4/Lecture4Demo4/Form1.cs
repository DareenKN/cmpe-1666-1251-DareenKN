using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Lecture4Demo4
{
    public partial class Form1 : Form
    {
        string fileName;

        public Form1()
        {
            InitializeComponent();
        }

        private void Ui_DragAndDrop_Lbl_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;

        }

        private void Ui_DragAndDrop_Lbl_DragDrop(object sender, DragEventArgs e)
        {
             fileName = ((string[])e.Data.GetData(DataFormats.FileDrop)).First();
            
        }

        private void UI_DisplayData_Btn_Click(object sender, EventArgs e)
        {
            string[] strArray = File.ReadAllLines(fileName);
            foreach (string s in strArray)
                UI_DisplayData_Lbx.Items.Add(s);
        }
    }
}
