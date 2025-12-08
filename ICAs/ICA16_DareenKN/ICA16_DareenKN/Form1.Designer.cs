namespace ICA16_DareenKN
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
            this.UI_Find_Btn = new System.Windows.Forms.Button();
            this.UI_SimpleTest_Btn = new System.Windows.Forms.Button();
            this.UI_FileOutput_Tbx = new System.Windows.Forms.TextBox();
            this.UI_InputTest_Tbx = new System.Windows.Forms.TextBox();
            this.UI_OFD = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // UI_LoadFile_Btn
            // 
            this.UI_LoadFile_Btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UI_LoadFile_Btn.Location = new System.Drawing.Point(12, 18);
            this.UI_LoadFile_Btn.Name = "UI_LoadFile_Btn";
            this.UI_LoadFile_Btn.Size = new System.Drawing.Size(83, 25);
            this.UI_LoadFile_Btn.TabIndex = 0;
            this.UI_LoadFile_Btn.Text = "Load File";
            this.UI_LoadFile_Btn.UseVisualStyleBackColor = false;
            this.UI_LoadFile_Btn.Click += new System.EventHandler(this.UI_LoadFile_Btn_Click);
            // 
            // UI_Find_Btn
            // 
            this.UI_Find_Btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UI_Find_Btn.Location = new System.Drawing.Point(101, 18);
            this.UI_Find_Btn.Name = "UI_Find_Btn";
            this.UI_Find_Btn.Size = new System.Drawing.Size(83, 25);
            this.UI_Find_Btn.TabIndex = 1;
            this.UI_Find_Btn.Text = "Find";
            this.UI_Find_Btn.UseVisualStyleBackColor = false;
            this.UI_Find_Btn.Click += new System.EventHandler(this.UI_Find_Btn_Click);
            // 
            // UI_SimpleTest_Btn
            // 
            this.UI_SimpleTest_Btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UI_SimpleTest_Btn.Location = new System.Drawing.Point(531, 18);
            this.UI_SimpleTest_Btn.Name = "UI_SimpleTest_Btn";
            this.UI_SimpleTest_Btn.Size = new System.Drawing.Size(83, 25);
            this.UI_SimpleTest_Btn.TabIndex = 2;
            this.UI_SimpleTest_Btn.Text = "Simple Test";
            this.UI_SimpleTest_Btn.UseVisualStyleBackColor = false;
            this.UI_SimpleTest_Btn.Click += new System.EventHandler(this.UI_SimpleTest_Btn_Click);
            // 
            // UI_FileOutput_Tbx
            // 
            this.UI_FileOutput_Tbx.Location = new System.Drawing.Point(12, 53);
            this.UI_FileOutput_Tbx.Multiline = true;
            this.UI_FileOutput_Tbx.Name = "UI_FileOutput_Tbx";
            this.UI_FileOutput_Tbx.Size = new System.Drawing.Size(602, 203);
            this.UI_FileOutput_Tbx.TabIndex = 3;
            // 
            // UI_InputTest_Tbx
            // 
            this.UI_InputTest_Tbx.Location = new System.Drawing.Point(323, 20);
            this.UI_InputTest_Tbx.Name = "UI_InputTest_Tbx";
            this.UI_InputTest_Tbx.Size = new System.Drawing.Size(202, 20);
            this.UI_InputTest_Tbx.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 268);
            this.Controls.Add(this.UI_InputTest_Tbx);
            this.Controls.Add(this.UI_FileOutput_Tbx);
            this.Controls.Add(this.UI_SimpleTest_Btn);
            this.Controls.Add(this.UI_Find_Btn);
            this.Controls.Add(this.UI_LoadFile_Btn);
            this.Name = "Form1";
            this.Text = "ICA16_DareenKN - Pally Hunter!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UI_LoadFile_Btn;
        private System.Windows.Forms.Button UI_Find_Btn;
        private System.Windows.Forms.Button UI_SimpleTest_Btn;
        private System.Windows.Forms.TextBox UI_FileOutput_Tbx;
        private System.Windows.Forms.TextBox UI_InputTest_Tbx;
        private System.Windows.Forms.OpenFileDialog UI_OFD;
    }
}

