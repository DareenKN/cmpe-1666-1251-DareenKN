namespace Lecture8Exercise1
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
            this.UI_ObtainValues_Btn = new System.Windows.Forms.Button();
            this.UI_FirstValue_Tbx = new System.Windows.Forms.TextBox();
            this.UI_SecondValue_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Sum_Tbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_ObtainValues_Btn
            // 
            this.UI_ObtainValues_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_ObtainValues_Btn.Location = new System.Drawing.Point(112, 55);
            this.UI_ObtainValues_Btn.Name = "UI_ObtainValues_Btn";
            this.UI_ObtainValues_Btn.Size = new System.Drawing.Size(257, 72);
            this.UI_ObtainValues_Btn.TabIndex = 0;
            this.UI_ObtainValues_Btn.Text = "Obtain Values And Calculate";
            this.UI_ObtainValues_Btn.UseVisualStyleBackColor = true;
            this.UI_ObtainValues_Btn.Click += new System.EventHandler(this.UI_ObtainValues_Btn_Click);
            // 
            // UI_FirstValue_Tbx
            // 
            this.UI_FirstValue_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_FirstValue_Tbx.Location = new System.Drawing.Point(227, 170);
            this.UI_FirstValue_Tbx.Name = "UI_FirstValue_Tbx";
            this.UI_FirstValue_Tbx.ReadOnly = true;
            this.UI_FirstValue_Tbx.Size = new System.Drawing.Size(204, 22);
            this.UI_FirstValue_Tbx.TabIndex = 1;
            // 
            // UI_SecondValue_Tbx
            // 
            this.UI_SecondValue_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_SecondValue_Tbx.Location = new System.Drawing.Point(227, 213);
            this.UI_SecondValue_Tbx.Name = "UI_SecondValue_Tbx";
            this.UI_SecondValue_Tbx.ReadOnly = true;
            this.UI_SecondValue_Tbx.Size = new System.Drawing.Size(204, 22);
            this.UI_SecondValue_Tbx.TabIndex = 2;
            // 
            // UI_Sum_Tbx
            // 
            this.UI_Sum_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Sum_Tbx.Location = new System.Drawing.Point(227, 261);
            this.UI_Sum_Tbx.Name = "UI_Sum_Tbx";
            this.UI_Sum_Tbx.ReadOnly = true;
            this.UI_Sum_Tbx.Size = new System.Drawing.Size(204, 22);
            this.UI_Sum_Tbx.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Value: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Second Value: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sum:  ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_Sum_Tbx);
            this.Controls.Add(this.UI_SecondValue_Tbx);
            this.Controls.Add(this.UI_FirstValue_Tbx);
            this.Controls.Add(this.UI_ObtainValues_Btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UI_ObtainValues_Btn;
        private System.Windows.Forms.TextBox UI_FirstValue_Tbx;
        private System.Windows.Forms.TextBox UI_SecondValue_Tbx;
        private System.Windows.Forms.TextBox UI_Sum_Tbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

