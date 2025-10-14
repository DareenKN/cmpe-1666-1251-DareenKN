namespace Lecture4Demo5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UI_MainFile_Dlg = new System.Windows.Forms.OpenFileDialog();
            this.UI_Display_Lbx = new System.Windows.Forms.ListBox();
            this.UI_LoadData_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI_MainFile_Dlg
            // 
            this.UI_MainFile_Dlg.FileName = "openFileDialog1";
            // 
            // UI_Display_Lbx
            // 
            this.UI_Display_Lbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Display_Lbx.FormattingEnabled = true;
            this.UI_Display_Lbx.ItemHeight = 16;
            this.UI_Display_Lbx.Location = new System.Drawing.Point(210, 12);
            this.UI_Display_Lbx.Name = "UI_Display_Lbx";
            this.UI_Display_Lbx.Size = new System.Drawing.Size(352, 260);
            this.UI_Display_Lbx.TabIndex = 0;
            // 
            // UI_LoadData_Btn
            // 
            this.UI_LoadData_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_LoadData_Btn.Location = new System.Drawing.Point(273, 299);
            this.UI_LoadData_Btn.Name = "UI_LoadData_Btn";
            this.UI_LoadData_Btn.Size = new System.Drawing.Size(216, 68);
            this.UI_LoadData_Btn.TabIndex = 1;
            this.UI_LoadData_Btn.Text = "Load Data";
            this.UI_LoadData_Btn.UseVisualStyleBackColor = true;
            this.UI_LoadData_Btn.Click += new System.EventHandler(this.UI_LoadData_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_LoadData_Btn);
            this.Controls.Add(this.UI_Display_Lbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog UI_MainFile_Dlg;
        private System.Windows.Forms.ListBox UI_Display_Lbx;
        private System.Windows.Forms.Button UI_LoadData_Btn;
    }
}

