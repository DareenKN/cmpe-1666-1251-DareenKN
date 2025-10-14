using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture4Demo5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_LoadData_Btn_Click(object sender, EventArgs e)
        {
            // The ShowDiatogC) causes the dialog to open
            // When the user clicks on 0k or Cancel,
            // the dialog wilt clause and return a value of DialogResult.OK
            // if the user clicked on 0k or it witt return DiatogResutt.Cancet
            // if the user clicks on Cancel
            if (UI_MainFile_Dlg.ShowDialog() == DialogResult.OK) 
            {
                // We need to obtain the file name
                string fileName = UI_MainFile_Dlg.FileName;
                Console.WriteLine($"The file name is: {fileName}");

                // Now we can process the file. just like we do for Darg & Drop

                string[] data = File.ReadAllLines(fileName);
                foreach (string line in data)
                    UI_Display_Lbx.Items.Add(line);                
            }
        }
    }
}
