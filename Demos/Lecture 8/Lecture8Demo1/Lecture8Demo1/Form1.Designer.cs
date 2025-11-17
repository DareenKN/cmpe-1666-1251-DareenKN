namespace Lecture8Demo1
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
            this.UI_GetName_Btn = new System.Windows.Forms.Button();
            this.Ui_Result_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_GetName_Btn
            // 
            this.UI_GetName_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_GetName_Btn.Location = new System.Drawing.Point(47, 61);
            this.UI_GetName_Btn.Name = "UI_GetName_Btn";
            this.UI_GetName_Btn.Size = new System.Drawing.Size(162, 60);
            this.UI_GetName_Btn.TabIndex = 0;
            this.UI_GetName_Btn.Text = "Get Name";
            this.UI_GetName_Btn.UseVisualStyleBackColor = true;
            this.UI_GetName_Btn.Click += new System.EventHandler(this.UI_GetName_Btn_Click);
            // 
            // Ui_Result_Lbl
            // 
            this.Ui_Result_Lbl.AutoSize = true;
            this.Ui_Result_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ui_Result_Lbl.Location = new System.Drawing.Point(68, 176);
            this.Ui_Result_Lbl.Name = "Ui_Result_Lbl";
            this.Ui_Result_Lbl.Size = new System.Drawing.Size(237, 16);
            this.Ui_Result_Lbl.TabIndex = 1;
            this.Ui_Result_Lbl.Text = "Your name will be displayed here";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ui_Result_Lbl);
            this.Controls.Add(this.UI_GetName_Btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UI_GetName_Btn;
        private System.Windows.Forms.Label Ui_Result_Lbl;
    }
}

