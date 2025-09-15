namespace Lecture2Demo2
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
            this.UI_Display_Lbl = new System.Windows.Forms.Label();
            this.UI_Change_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI_Display_Lbl
            // 
            this.UI_Display_Lbl.AutoSize = true;
            this.UI_Display_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Display_Lbl.Location = new System.Drawing.Point(323, 134);
            this.UI_Display_Lbl.Name = "UI_Display_Lbl";
            this.UI_Display_Lbl.Size = new System.Drawing.Size(131, 16);
            this.UI_Display_Lbl.TabIndex = 0;
            this.UI_Display_Lbl.Text = "Initial Label Value";
            this.UI_Display_Lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // UI_Change_Btn
            // 
            this.UI_Change_Btn.Location = new System.Drawing.Point(294, 194);
            this.UI_Change_Btn.Name = "UI_Change_Btn";
            this.UI_Change_Btn.Size = new System.Drawing.Size(187, 47);
            this.UI_Change_Btn.TabIndex = 1;
            this.UI_Change_Btn.Text = "Change Label Value";
            this.UI_Change_Btn.UseVisualStyleBackColor = true;
            this.UI_Change_Btn.Click += new System.EventHandler(this.UI_Change_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_Change_Btn);
            this.Controls.Add(this.UI_Display_Lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UI_Display_Lbl;
        private System.Windows.Forms.Button UI_Change_Btn;
    }
}

