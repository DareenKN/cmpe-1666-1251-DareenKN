namespace lecture3Demo2
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
            this.Ui_ValueList_Lbx = new System.Windows.Forms.ListBox();
            this.UI_AddToList_Btn = new System.Windows.Forms.Button();
            this.UI_SendToListBox_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UI_NewValue_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Count_Tbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Ui_ValueList_Lbx
            // 
            this.Ui_ValueList_Lbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ui_ValueList_Lbx.FormattingEnabled = true;
            this.Ui_ValueList_Lbx.ItemHeight = 18;
            this.Ui_ValueList_Lbx.Location = new System.Drawing.Point(45, 67);
            this.Ui_ValueList_Lbx.Name = "Ui_ValueList_Lbx";
            this.Ui_ValueList_Lbx.Size = new System.Drawing.Size(235, 220);
            this.Ui_ValueList_Lbx.TabIndex = 0;
            // 
            // UI_AddToList_Btn
            // 
            this.UI_AddToList_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_AddToList_Btn.Location = new System.Drawing.Point(558, 121);
            this.UI_AddToList_Btn.Name = "UI_AddToList_Btn";
            this.UI_AddToList_Btn.Size = new System.Drawing.Size(169, 66);
            this.UI_AddToList_Btn.TabIndex = 1;
            this.UI_AddToList_Btn.Text = "Add To List";
            this.UI_AddToList_Btn.UseVisualStyleBackColor = true;
            this.UI_AddToList_Btn.Click += new System.EventHandler(this.UI_AddToList_Btn_Click);
            // 
            // UI_SendToListBox_Btn
            // 
            this.UI_SendToListBox_Btn.Enabled = false;
            this.UI_SendToListBox_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_SendToListBox_Btn.Location = new System.Drawing.Point(558, 257);
            this.UI_SendToListBox_Btn.Name = "UI_SendToListBox_Btn";
            this.UI_SendToListBox_Btn.Size = new System.Drawing.Size(169, 66);
            this.UI_SendToListBox_Btn.TabIndex = 2;
            this.UI_SendToListBox_Btn.Text = "Send To ListBox";
            this.UI_SendToListBox_Btn.UseVisualStyleBackColor = true;
            this.UI_SendToListBox_Btn.Click += new System.EventHandler(this.UI_SendToListBox_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "List of Values";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(460, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "New Value:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(463, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "List Count:";
            // 
            // UI_NewValue_Tbx
            // 
            this.UI_NewValue_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_NewValue_Tbx.Location = new System.Drawing.Point(558, 76);
            this.UI_NewValue_Tbx.Name = "UI_NewValue_Tbx";
            this.UI_NewValue_Tbx.Size = new System.Drawing.Size(168, 24);
            this.UI_NewValue_Tbx.TabIndex = 6;
            // 
            // UI_Count_Tbx
            // 
            this.UI_Count_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Count_Tbx.Location = new System.Drawing.Point(559, 221);
            this.UI_Count_Tbx.Name = "UI_Count_Tbx";
            this.UI_Count_Tbx.ReadOnly = true;
            this.UI_Count_Tbx.Size = new System.Drawing.Size(168, 24);
            this.UI_Count_Tbx.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_Count_Tbx);
            this.Controls.Add(this.UI_NewValue_Tbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_SendToListBox_Btn);
            this.Controls.Add(this.UI_AddToList_Btn);
            this.Controls.Add(this.Ui_ValueList_Lbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Ui_ValueList_Lbx;
        private System.Windows.Forms.Button UI_AddToList_Btn;
        private System.Windows.Forms.Button UI_SendToListBox_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UI_NewValue_Tbx;
        private System.Windows.Forms.TextBox UI_Count_Tbx;
    }
}

