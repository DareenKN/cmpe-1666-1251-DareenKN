namespace PractieLe2Q1
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
            this.UI_SearchItem_Tbx = new System.Windows.Forms.TextBox();
            this.UI_RollUpCount_Btn = new System.Windows.Forms.Button();
            this.UI_TextInput_Tbx = new System.Windows.Forms.TextBox();
            this.UI_LoadFile_Btn = new System.Windows.Forms.Button();
            this.UI_DataFile_OFD = new System.Windows.Forms.OpenFileDialog();
            this.UI_NoRollUpCount_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI_SearchItem_Tbx
            // 
            this.UI_SearchItem_Tbx.Location = new System.Drawing.Point(57, 229);
            this.UI_SearchItem_Tbx.Margin = new System.Windows.Forms.Padding(2);
            this.UI_SearchItem_Tbx.Name = "UI_SearchItem_Tbx";
            this.UI_SearchItem_Tbx.Size = new System.Drawing.Size(288, 20);
            this.UI_SearchItem_Tbx.TabIndex = 8;
            // 
            // UI_RollUpCount_Btn
            // 
            this.UI_RollUpCount_Btn.Location = new System.Drawing.Point(57, 174);
            this.UI_RollUpCount_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.UI_RollUpCount_Btn.Name = "UI_RollUpCount_Btn";
            this.UI_RollUpCount_Btn.Size = new System.Drawing.Size(129, 34);
            this.UI_RollUpCount_Btn.TabIndex = 7;
            this.UI_RollUpCount_Btn.Text = "Rollup Count!";
            this.UI_RollUpCount_Btn.UseVisualStyleBackColor = true;
            this.UI_RollUpCount_Btn.Click += new System.EventHandler(this.UI_RollUpCount_Btn_Click);
            // 
            // UI_TextInput_Tbx
            // 
            this.UI_TextInput_Tbx.Location = new System.Drawing.Point(57, 70);
            this.UI_TextInput_Tbx.Margin = new System.Windows.Forms.Padding(2);
            this.UI_TextInput_Tbx.Name = "UI_TextInput_Tbx";
            this.UI_TextInput_Tbx.Size = new System.Drawing.Size(288, 20);
            this.UI_TextInput_Tbx.TabIndex = 6;
            // 
            // UI_LoadFile_Btn
            // 
            this.UI_LoadFile_Btn.Location = new System.Drawing.Point(54, 11);
            this.UI_LoadFile_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.UI_LoadFile_Btn.Name = "UI_LoadFile_Btn";
            this.UI_LoadFile_Btn.Size = new System.Drawing.Size(132, 39);
            this.UI_LoadFile_Btn.TabIndex = 5;
            this.UI_LoadFile_Btn.Text = "Load File";
            this.UI_LoadFile_Btn.UseVisualStyleBackColor = true;
            this.UI_LoadFile_Btn.Click += new System.EventHandler(this.UI_LoadFile_Btn_Click);
            // 
            // UI_DataFile_OFD
            // 
            this.UI_DataFile_OFD.FileName = "openFileDialog1";
            // 
            // UI_NoRollUpCount_Btn
            // 
            this.UI_NoRollUpCount_Btn.Location = new System.Drawing.Point(216, 174);
            this.UI_NoRollUpCount_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.UI_NoRollUpCount_Btn.Name = "UI_NoRollUpCount_Btn";
            this.UI_NoRollUpCount_Btn.Size = new System.Drawing.Size(129, 34);
            this.UI_NoRollUpCount_Btn.TabIndex = 9;
            this.UI_NoRollUpCount_Btn.Text = "No Rollup Count!";
            this.UI_NoRollUpCount_Btn.UseVisualStyleBackColor = true;
            this.UI_NoRollUpCount_Btn.Click += new System.EventHandler(this.UI_NoRollUpCount_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 267);
            this.Controls.Add(this.UI_SearchItem_Tbx);
            this.Controls.Add(this.UI_RollUpCount_Btn);
            this.Controls.Add(this.UI_TextInput_Tbx);
            this.Controls.Add(this.UI_LoadFile_Btn);
            this.Controls.Add(this.UI_NoRollUpCount_Btn);
            this.Name = "Form1";
            this.Text = "Finding Instances of words";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UI_SearchItem_Tbx;
        private System.Windows.Forms.Button UI_RollUpCount_Btn;
        private System.Windows.Forms.TextBox UI_TextInput_Tbx;
        private System.Windows.Forms.Button UI_LoadFile_Btn;
        private System.Windows.Forms.OpenFileDialog UI_DataFile_OFD;
        private System.Windows.Forms.Button UI_NoRollUpCount_Btn;
    }
}

