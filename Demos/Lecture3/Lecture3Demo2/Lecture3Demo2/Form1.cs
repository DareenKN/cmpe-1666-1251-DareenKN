using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lecture3Demo2
{
    public partial class Form1 : Form
    {
        private List<string> list = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void UI_AddToList_Btn_Click(object sender, EventArgs e)
        { string value = UI_NewValue_Tbx.Text;
            
            //We verify that the textbox is not empty
            if (value.Length > 0)
            {
                list.Add(value);
                //We display the count in the Read-Only TextBox
                UI_Count_Tbx.Text = $"{list.Count}";
                //We also clear the input TextBox
                UI_NewValue_Tbx.Clear();

                //when we reach 10 values in the list
                //we disable the "Add To List" button
                //and enable the "Send To ListBox" button
                if (list.Count>=10)
                {
                    UI_AddToList_Btn.Enabled = false;
                    UI_SendToListBox_Btn.Enabled = true;
                }
            }
        }

        //In this event handler, we add all the values from the list
        //to the Listbox
        private void UI_SendToListBox_Btn_Click(object sender, EventArgs e)
        {
            foreach (string s in list)
                Ui_ValueList_Lbx.Items.Add(s);
        }
    }
}
