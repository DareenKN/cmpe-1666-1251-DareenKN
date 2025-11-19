namespace ModalsRevision
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
            this.UI_Login_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI_Login_Btn
            // 
            this.UI_Login_Btn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.UI_Login_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Login_Btn.Location = new System.Drawing.Point(217, 152);
            this.UI_Login_Btn.Name = "UI_Login_Btn";
            this.UI_Login_Btn.Size = new System.Drawing.Size(364, 115);
            this.UI_Login_Btn.TabIndex = 0;
            this.UI_Login_Btn.Text = "LOGIN";
            this.UI_Login_Btn.UseVisualStyleBackColor = false;
            this.UI_Login_Btn.Click += new System.EventHandler(this.UI_Login_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_Login_Btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UI_Login_Btn;
    }
}

