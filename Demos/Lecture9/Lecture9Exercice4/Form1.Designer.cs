namespace Lecture9Exercice4
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
            this.UI_Show_Btn = new System.Windows.Forms.Button();
            this.UI_Hide_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI_Show_Btn
            // 
            this.UI_Show_Btn.Location = new System.Drawing.Point(212, 168);
            this.UI_Show_Btn.Name = "UI_Show_Btn";
            this.UI_Show_Btn.Size = new System.Drawing.Size(75, 23);
            this.UI_Show_Btn.TabIndex = 0;
            this.UI_Show_Btn.Text = "Show Dialog";
            this.UI_Show_Btn.UseVisualStyleBackColor = true;
            this.UI_Show_Btn.Click += new System.EventHandler(this.UI_Show_Btn_Click);
            // 
            // UI_Hide_Btn
            // 
            this.UI_Hide_Btn.Location = new System.Drawing.Point(369, 168);
            this.UI_Hide_Btn.Name = "UI_Hide_Btn";
            this.UI_Hide_Btn.Size = new System.Drawing.Size(75, 23);
            this.UI_Hide_Btn.TabIndex = 1;
            this.UI_Hide_Btn.Text = "Hide Dialog";
            this.UI_Hide_Btn.UseVisualStyleBackColor = true;
            this.UI_Hide_Btn.Click += new System.EventHandler(this.UI_Hide_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_Hide_Btn);
            this.Controls.Add(this.UI_Show_Btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UI_Show_Btn;
        private System.Windows.Forms.Button UI_Hide_Btn;
    }
}

