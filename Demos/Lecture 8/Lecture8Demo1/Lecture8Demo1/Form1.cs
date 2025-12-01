using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture8Demo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_GetName_Btn_Click(object sender, EventArgs e)
        {
            //Create an object of the class ModalDialogForm
            ModalDialogForm dialog = new ModalDialogForm();
            dialog.setUserName("default");

            if (dialog.ShowDialog()== DialogResult.OK)
            {
                Ui_Result_Lbl.Text = $"The name given was: {dialog.getUserName()}" ;
            }
            else
            {
                MessageBox.Show("The Dialog Form was cancelled");
            }
        }
    }
}
