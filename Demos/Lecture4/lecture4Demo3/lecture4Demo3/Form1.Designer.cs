namespace lecture4Demo3
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
            this.Ui_DisplayFile1_Lbx = new System.Windows.Forms.ListBox();
            this.UI_DisplayFile2_Tbx = new System.Windows.Forms.TextBox();
            this.UI_LoadFile2_btn = new System.Windows.Forms.Button();
            this.UI_LoadFile1_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ui_DisplayFile1_Lbx
            // 
            this.Ui_DisplayFile1_Lbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ui_DisplayFile1_Lbx.FormattingEnabled = true;
            this.Ui_DisplayFile1_Lbx.ItemHeight = 16;
            this.Ui_DisplayFile1_Lbx.Location = new System.Drawing.Point(79, 31);
            this.Ui_DisplayFile1_Lbx.Name = "Ui_DisplayFile1_Lbx";
            this.Ui_DisplayFile1_Lbx.Size = new System.Drawing.Size(225, 276);
            this.Ui_DisplayFile1_Lbx.TabIndex = 0;
            // 
            // UI_DisplayFile2_Tbx
            // 
            this.UI_DisplayFile2_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_DisplayFile2_Tbx.Location = new System.Drawing.Point(418, 85);
            this.UI_DisplayFile2_Tbx.Multiline = true;
            this.UI_DisplayFile2_Tbx.Name = "UI_DisplayFile2_Tbx";
            this.UI_DisplayFile2_Tbx.ReadOnly = true;
            this.UI_DisplayFile2_Tbx.Size = new System.Drawing.Size(259, 166);
            this.UI_DisplayFile2_Tbx.TabIndex = 1;
            // 
            // UI_LoadFile2_btn
            // 
            this.UI_LoadFile2_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_LoadFile2_btn.Location = new System.Drawing.Point(475, 291);
            this.UI_LoadFile2_btn.Name = "UI_LoadFile2_btn";
            this.UI_LoadFile2_btn.Size = new System.Drawing.Size(201, 58);
            this.UI_LoadFile2_btn.TabIndex = 2;
            this.UI_LoadFile2_btn.Text = "Load File2 Data";
            this.UI_LoadFile2_btn.UseVisualStyleBackColor = true;
            this.UI_LoadFile2_btn.Click += new System.EventHandler(this.UI_LoadFile2_btn_Click);
            // 
            // UI_LoadFile1_Btn
            // 
            this.UI_LoadFile1_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_LoadFile1_Btn.Location = new System.Drawing.Point(92, 340);
            this.UI_LoadFile1_Btn.Name = "UI_LoadFile1_Btn";
            this.UI_LoadFile1_Btn.Size = new System.Drawing.Size(201, 58);
            this.UI_LoadFile1_Btn.TabIndex = 3;
            this.UI_LoadFile1_Btn.Text = "Load File1 Data";
            this.UI_LoadFile1_Btn.UseVisualStyleBackColor = true;
            this.UI_LoadFile1_Btn.Click += new System.EventHandler(this.UI_LoadFile1_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_LoadFile1_Btn);
            this.Controls.Add(this.UI_LoadFile2_btn);
            this.Controls.Add(this.UI_DisplayFile2_Tbx);
            this.Controls.Add(this.Ui_DisplayFile1_Lbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Ui_DisplayFile1_Lbx;
        private System.Windows.Forms.TextBox UI_DisplayFile2_Tbx;
        private System.Windows.Forms.Button UI_LoadFile2_btn;
        private System.Windows.Forms.Button UI_LoadFile1_Btn;
    }
}

