using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModalsRevision
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_Login_Btn_Click(object sender, EventArgs e)
        {
            // Create an object of Modal Dialog
            ModalDialogUserForm dialog = new ModalDialogUserForm();

            // Show dialog
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (dialog.getPassword() == "2005")
                {
                    UI_Login_Btn.Text = $"WELCOME {dialog.getUserName()}😊";
                }

                else
                {
                    MessageBox.Show("Password is incorrect");
                    return;
                }

                
            }
            else
            {
                MessageBox.Show("Dialog was closed with Cancel or X button");
            }
        }
    }
}


