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
    public partial class ModalDialogUserForm : Form
    {
        public ModalDialogUserForm()
        {
            InitializeComponent();
            
        }

        public void UI_OK_Btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;                 
        }

        public string getUserName()
        {
            return UI_UserName_Tbx.Text;
        }

        public string getPassword()
        {
            return UI_Password_Tbx.Text;
        }

        private void UI_Cancel_Btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
