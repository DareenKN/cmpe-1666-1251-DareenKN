namespace Lecture2BDemo5
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
            this.UI_ClickMe_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI_Input_Tbx
            // 
            this.UI_Input_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Input_Tbx.Location = new System.Drawing.Point(282, 169);
            this.UI_Input_Tbx.Name = "UI_Input_Tbx";
            this.UI_Input_Tbx.Size = new System.Drawing.Size(154, 22);
            this.UI_Input_Tbx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "name:";
            // 
            // UI_ClickMe_Btn
            // 
            this.UI_ClickMe_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_ClickMe_Btn.Location = new System.Drawing.Point(234, 235);
            this.UI_ClickMe_Btn.Name = "UI_ClickMe_Btn";
            this.UI_ClickMe_Btn.Size = new System.Drawing.Size(211, 52);
            this.UI_ClickMe_Btn.TabIndex = 2;
            this.UI_ClickMe_Btn.Text = "Click Me";
            this.UI_ClickMe_Btn.UseVisualStyleBackColor = true;
            this.UI_ClickMe_Btn.Click += new System.EventHandler(this.UI_ClickMe_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_ClickMe_Btn);
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
        private System.Windows.Forms.Button UI_ClickMe_Btn;
    }
}

