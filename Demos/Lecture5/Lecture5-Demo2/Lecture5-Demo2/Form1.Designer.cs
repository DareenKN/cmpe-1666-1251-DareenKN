namespace Lecture5_Demo2
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
            this.UI_InitialList_Lbx = new System.Windows.Forms.ListBox();
            this.UI_SortStudents_Btn = new System.Windows.Forms.Button();
            this.UI_SortedList_Lbx = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // UI_InitialList_Lbx
            // 
            this.UI_InitialList_Lbx.FormattingEnabled = true;
            this.UI_InitialList_Lbx.Location = new System.Drawing.Point(12, 30);
            this.UI_InitialList_Lbx.Name = "UI_InitialList_Lbx";
            this.UI_InitialList_Lbx.Size = new System.Drawing.Size(185, 238);
            this.UI_InitialList_Lbx.TabIndex = 0;
            // 
            // UI_SortStudents_Btn
            // 
            this.UI_SortStudents_Btn.Location = new System.Drawing.Point(265, 104);
            this.UI_SortStudents_Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_SortStudents_Btn.Name = "UI_SortStudents_Btn";
            this.UI_SortStudents_Btn.Size = new System.Drawing.Size(144, 29);
            this.UI_SortStudents_Btn.TabIndex = 15;
            this.UI_SortStudents_Btn.Text = "Sort Students";
            this.UI_SortStudents_Btn.UseVisualStyleBackColor = true;
            this.UI_SortStudents_Btn.Click += new System.EventHandler(this.UI_SortStudents_Btn_Click);
            // 
            // UI_SortedList_Lbx
            // 
            this.UI_SortedList_Lbx.FormattingEnabled = true;
            this.UI_SortedList_Lbx.Location = new System.Drawing.Point(477, 37);
            this.UI_SortedList_Lbx.Name = "UI_SortedList_Lbx";
            this.UI_SortedList_Lbx.Size = new System.Drawing.Size(185, 238);
            this.UI_SortedList_Lbx.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 301);
            this.Controls.Add(this.UI_SortedList_Lbx);
            this.Controls.Add(this.UI_SortStudents_Btn);
            this.Controls.Add(this.UI_InitialList_Lbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox UI_InitialList_Lbx;
        private System.Windows.Forms.Button UI_SortStudents_Btn;
        private System.Windows.Forms.ListBox UI_SortedList_Lbx;
    }
}

