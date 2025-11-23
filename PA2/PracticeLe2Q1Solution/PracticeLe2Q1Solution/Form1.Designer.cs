namespace PracticeLe2Q1Solution
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
            this.UI_LoadFile_Btn = new System.Windows.Forms.Button();
            this.UI_TextInput_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Roll_Count = new System.Windows.Forms.Button();
            this.UI_SearchItem_Tbx = new System.Windows.Forms.TextBox();
            this.UI_DataFile_OFD = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // UI_LoadFile_Btn
            // 
            this.UI_LoadFile_Btn.Location = new System.Drawing.Point(81, 45);
            this.UI_LoadFile_Btn.Name = "UI_LoadFile_Btn";
            this.UI_LoadFile_Btn.Size = new System.Drawing.Size(198, 60);
            this.UI_LoadFile_Btn.TabIndex = 0;
            this.UI_LoadFile_Btn.Text = "Load File";
            this.UI_LoadFile_Btn.UseVisualStyleBackColor = true;
            this.UI_LoadFile_Btn.Click += new System.EventHandler(this.UI_LoadFile_Btn_Click);
            // 
            // UI_TextInput_Tbx
            // 
            this.UI_TextInput_Tbx.Location = new System.Drawing.Point(86, 136);
            this.UI_TextInput_Tbx.Name = "UI_TextInput_Tbx";
            this.UI_TextInput_Tbx.Size = new System.Drawing.Size(430, 26);
            this.UI_TextInput_Tbx.TabIndex = 1;
            // 
            // UI_Roll_Count
            // 
            this.UI_Roll_Count.Location = new System.Drawing.Point(106, 275);
            this.UI_Roll_Count.Name = "UI_Roll_Count";
            this.UI_Roll_Count.Size = new System.Drawing.Size(239, 67);
            this.UI_Roll_Count.TabIndex = 2;
            this.UI_Roll_Count.Text = "Roll Count";
            this.UI_Roll_Count.UseVisualStyleBackColor = true;
            this.UI_Roll_Count.Click += new System.EventHandler(this.UI_Roll_Count_Click);
            // 
            // UI_SearchItem_Tbx
            // 
            this.UI_SearchItem_Tbx.Location = new System.Drawing.Point(86, 380);
            this.UI_SearchItem_Tbx.Name = "UI_SearchItem_Tbx";
            this.UI_SearchItem_Tbx.Size = new System.Drawing.Size(430, 26);
            this.UI_SearchItem_Tbx.TabIndex = 3;
            // 
            // UI_DataFile_OFD
            // 
            this.UI_DataFile_OFD.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_SearchItem_Tbx);
            this.Controls.Add(this.UI_Roll_Count);
            this.Controls.Add(this.UI_TextInput_Tbx);
            this.Controls.Add(this.UI_LoadFile_Btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UI_LoadFile_Btn;
        private System.Windows.Forms.TextBox UI_TextInput_Tbx;
        private System.Windows.Forms.Button UI_Roll_Count;
        private System.Windows.Forms.TextBox UI_SearchItem_Tbx;
        private System.Windows.Forms.OpenFileDialog UI_DataFile_OFD;
    }
}

