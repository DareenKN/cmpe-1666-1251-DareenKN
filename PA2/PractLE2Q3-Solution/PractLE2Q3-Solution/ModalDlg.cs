using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 * Author: Oveeyen Moonian
 * Lab Exam question on Modal Dialog
 * 
 * 
 */
namespace PractLE2Q3_Solution
{
   
    public partial class ModalDlg : Form
    {
       
        public ModalDlg()
        {
            InitializeComponent();
        }

        //Event handler for the OK button of the Modal Dialog
        //It simply sets the value of DialogResult of the Form
        //to the enum value DialogResult.OK
        private void UI_OK_Btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }


        //Event handler for the Cancel button of the Modal Dialog
        //It sets the value of DialogResult of the Form
        //to the enum value DialogResult.Cancel
        private void UI_Cancel_Btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        //To display a text value for the temperature as the user scrolls the trackbar
        private void UI_Temp_TrackBar_Scroll(object sender, EventArgs e)
        {
            UI_Temp_Label.Text = UI_Temp_TrackBar.Value.ToString() + " Celsius";
        }

        //To display a text value for the humidity as the user scrolls the trackbar
        private void UI_Hum_TrackBar_Scroll(object sender, EventArgs e)
        {
            UI_Hum_Label.Text = UI_Hum_TrackBar.Value.ToString() + "%";
        }

        // Public Methods for Temperature
        public int GetTemperature()
        {

            return UI_Temp_TrackBar.Value;
        }

        public void SetTemperature(int T)
           {
                UI_Temp_TrackBar.Value = T;
                UI_Temp_Label.Text = $"{T} Celsius";
           }
        
        //Public Methods for Humidity

        public int GetHumidity() {
        
            return UI_Hum_TrackBar.Value;
        
        }

        public void SetHumidity(int hum)
        {
            UI_Hum_TrackBar.Value =  hum;
            UI_Hum_Label.Text = $"{hum}%";
        }


    }
}
