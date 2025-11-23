using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 * Author: Oveeyen Moonian
 * 
 * Lab Exam Question on Modal Dialog
 * 
 * 
 */

namespace PractLE2Q3_Solution
{     public enum Days { Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday};
    public partial class Form1 : Form
    {
        
        private ModalDlg dlg = null; //Reference for a modal dialog form object- Tobe created below
      
        //To store the temperature and Humidity obtained from the modal dialog
        private int recordedTemp = 0;
        private int recordedHumidity = 0;
        
        Days day=Days.Monday;//Initializing day from the list of enum values
        
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_GetData_Btn_Click(object sender, EventArgs e)
        {
            //If we haven't created the modal dialog form object yet, create it.
            //This will happen only the first time that we enter this event listener
            if (dlg == null)
            {
                dlg = new ModalDlg();
            }

            //When we open the modal dialog, we want the controls to be set to the values of the previous day
            //or initial values (if we are opening for the first time)
            dlg.SetTemperature(recordedTemp);
            dlg.SetHumidity(recordedHumidity);

            //We open the modal dialog
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                //When the dialog is closed with "OK", we obtain the previous values set
                recordedTemp = dlg.GetTemperature();
                recordedHumidity = dlg.GetHumidity();

                //Performing the display in the listbox
                UI_Display_LB.Items.Add($"{day}- Temperature: {recordedTemp} Celsius, Humidity: {recordedHumidity}%");
                if (day == Days.Sunday)
                    day = Days.Monday;
                else
                    day++;
            }
        }
    }
}
