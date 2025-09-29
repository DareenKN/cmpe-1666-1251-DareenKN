namespace Lecture3Demo2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UI_NewValue_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Count_Tbx = new System.Windows.Forms.TextBox();
            this.UI_AddToList_Btn = new System.Windows.Forms.Button();
            this.UI_SendToList_Btn = new System.Windows.Forms.Button();
            this.UI_ValueList_ListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of Values";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(282, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Value:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(282, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "List Count:";
            // 
            // UI_NewValue_Tbx
            // 
            this.UI_NewValue_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_NewValue_Tbx.Location = new System.Drawing.Point(387, 74);
            this.UI_NewValue_Tbx.Name = "UI_NewValue_Tbx";
            this.UI_NewValue_Tbx.Size = new System.Drawing.Size(129, 26);
            this.UI_NewValue_Tbx.TabIndex = 3;
            // 
            // UI_Count_Tbx
            // 
            this.UI_Count_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Count_Tbx.Location = new System.Drawing.Point(387, 180);
            this.UI_Count_Tbx.Name = "UI_Count_Tbx";
            this.UI_Count_Tbx.ReadOnly = true;
            this.UI_Count_Tbx.Size = new System.Drawing.Size(129, 26);
            this.UI_Count_Tbx.TabIndex = 5;
            // 
            // UI_AddToList_Btn
            // 
            this.UI_AddToList_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_AddToList_Btn.Location = new System.Drawing.Point(387, 106);
            this.UI_AddToList_Btn.Name = "UI_AddToList_Btn";
            this.UI_AddToList_Btn.Size = new System.Drawing.Size(129, 46);
            this.UI_AddToList_Btn.TabIndex = 7;
            this.UI_AddToList_Btn.Text = "Add To List";
            this.UI_AddToList_Btn.UseVisualStyleBackColor = true;
            this.UI_AddToList_Btn.Click += new System.EventHandler(this.UI_AddToList_Btn_Click);
            // 
            // UI_SendToList_Btn
            // 
            this.UI_SendToList_Btn.Enabled = false;
            this.UI_SendToList_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_SendToList_Btn.Location = new System.Drawing.Point(387, 212);
            this.UI_SendToList_Btn.Name = "UI_SendToList_Btn";
            this.UI_SendToList_Btn.Size = new System.Drawing.Size(129, 48);
            this.UI_SendToList_Btn.TabIndex = 8;
            this.UI_SendToList_Btn.Text = "Send To ListBox";
            this.UI_SendToList_Btn.UseVisualStyleBackColor = true;
            this.UI_SendToList_Btn.Click += new System.EventHandler(this.UI_SendToList_Btn_Click);
            // 
            // UI_ValueList_ListBox
            // 
            this.UI_ValueList_ListBox.FormattingEnabled = true;
            this.UI_ValueList_ListBox.Location = new System.Drawing.Point(46, 74);
            this.UI_ValueList_ListBox.Name = "UI_ValueList_ListBox";
            this.UI_ValueList_ListBox.Size = new System.Drawing.Size(175, 186);
            this.UI_ValueList_ListBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 327);
            this.Controls.Add(this.UI_ValueList_ListBox);
            this.Controls.Add(this.UI_SendToList_Btn);
            this.Controls.Add(this.UI_AddToList_Btn);
            this.Controls.Add(this.UI_Count_Tbx);
            this.Controls.Add(this.UI_NewValue_Tbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UI_NewValue_Tbx;
        private System.Windows.Forms.TextBox UI_Count_Tbx;
        private System.Windows.Forms.Button UI_AddToList_Btn;
        private System.Windows.Forms.Button UI_SendToList_Btn;
        private System.Windows.Forms.ListBox UI_ValueList_ListBox;
    }
}

