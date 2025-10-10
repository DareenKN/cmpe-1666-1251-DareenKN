namespace Lecture4Demo1
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
            this.UI_Input_Tbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UI_AddToList_Btn = new System.Windows.Forms.Button();
            this.UI_SaveToFile_Btn = new System.Windows.Forms.Button();
            this.UI_Display_Lbx = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // UI_Input_Tbx
            // 
            this.UI_Input_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Input_Tbx.Location = new System.Drawing.Point(157, 61);
            this.UI_Input_Tbx.Name = "UI_Input_Tbx";
            this.UI_Input_Tbx.Size = new System.Drawing.Size(152, 22);
            this.UI_Input_Tbx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text:";
            // 
            // UI_AddToList_Btn
            // 
            this.UI_AddToList_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_AddToList_Btn.Location = new System.Drawing.Point(139, 122);
            this.UI_AddToList_Btn.Name = "UI_AddToList_Btn";
            this.UI_AddToList_Btn.Size = new System.Drawing.Size(170, 66);
            this.UI_AddToList_Btn.TabIndex = 2;
            this.UI_AddToList_Btn.Text = "Add To List";
            this.UI_AddToList_Btn.UseVisualStyleBackColor = true;
            this.UI_AddToList_Btn.Click += new System.EventHandler(this.UI_AddToList_Btn_Click);
            // 
            // UI_SaveToFile_Btn
            // 
            this.UI_SaveToFile_Btn.Enabled = false;
            this.UI_SaveToFile_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_SaveToFile_Btn.Location = new System.Drawing.Point(139, 239);
            this.UI_SaveToFile_Btn.Name = "UI_SaveToFile_Btn";
            this.UI_SaveToFile_Btn.Size = new System.Drawing.Size(170, 66);
            this.UI_SaveToFile_Btn.TabIndex = 3;
            this.UI_SaveToFile_Btn.Text = "Save To Files";
            this.UI_SaveToFile_Btn.UseVisualStyleBackColor = true;
            this.UI_SaveToFile_Btn.Click += new System.EventHandler(this.UI_SaveToFile_Btn_Click);
            // 
            // UI_Display_Lbx
            // 
            this.UI_Display_Lbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Display_Lbx.FormattingEnabled = true;
            this.UI_Display_Lbx.ItemHeight = 16;
            this.UI_Display_Lbx.Location = new System.Drawing.Point(464, 71);
            this.UI_Display_Lbx.Name = "UI_Display_Lbx";
            this.UI_Display_Lbx.Size = new System.Drawing.Size(229, 292);
            this.UI_Display_Lbx.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_Display_Lbx);
            this.Controls.Add(this.UI_SaveToFile_Btn);
            this.Controls.Add(this.UI_AddToList_Btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_Input_Tbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UI_Input_Tbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UI_AddToList_Btn;
        private System.Windows.Forms.Button UI_SaveToFile_Btn;
        private System.Windows.Forms.ListBox UI_Display_Lbx;
    }
}

