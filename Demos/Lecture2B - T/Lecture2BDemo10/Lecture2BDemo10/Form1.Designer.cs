namespace Lecture2BDemo10
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
            this.UI_Enrolled_Cbx = new System.Windows.Forms.CheckBox();
            this.UI_Name_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Course_Tbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course";
            // 
            // UI_Enrolled_Cbx
            // 
            this.UI_Enrolled_Cbx.AutoSize = true;
            this.UI_Enrolled_Cbx.Location = new System.Drawing.Point(195, 220);
            this.UI_Enrolled_Cbx.Name = "UI_Enrolled_Cbx";
            this.UI_Enrolled_Cbx.Size = new System.Drawing.Size(64, 17);
            this.UI_Enrolled_Cbx.TabIndex = 2;
            this.UI_Enrolled_Cbx.Text = "Enrolled";
            this.UI_Enrolled_Cbx.UseVisualStyleBackColor = true;
            // 
            // UI_Name_Tbx
            // 
            this.UI_Name_Tbx.Location = new System.Drawing.Point(263, 118);
            this.UI_Name_Tbx.Name = "UI_Name_Tbx";
            this.UI_Name_Tbx.Size = new System.Drawing.Size(235, 20);
            this.UI_Name_Tbx.TabIndex = 4;
            // 
            // UI_Course_Tbx
            // 
            this.UI_Course_Tbx.Location = new System.Drawing.Point(263, 166);
            this.UI_Course_Tbx.Name = "UI_Course_Tbx";
            this.UI_Course_Tbx.Size = new System.Drawing.Size(235, 20);
            this.UI_Course_Tbx.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UI_Course_Tbx);
            this.Controls.Add(this.UI_Name_Tbx);
            this.Controls.Add(this.UI_Enrolled_Cbx);
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
        private System.Windows.Forms.CheckBox UI_Enrolled_Cbx;
        private System.Windows.Forms.TextBox UI_Name_Tbx;
        private System.Windows.Forms.TextBox UI_Course_Tbx;
        private System.Windows.Forms.Label label3;
    }
}

