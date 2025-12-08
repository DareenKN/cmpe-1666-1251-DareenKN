namespace Lab3_DareenKN
{
    partial class ModalHighScore
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
            this.UI_InputName_Tbx = new System.Windows.Forms.TextBox();
            this.UI_OK_Btn = new System.Windows.Forms.Button();
            this.UI_Cancel_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player Name: ";
            // 
            // UI_InputName_Tbx
            // 
            this.UI_InputName_Tbx.Location = new System.Drawing.Point(91, 29);
            this.UI_InputName_Tbx.Name = "UI_InputName_Tbx";
            this.UI_InputName_Tbx.Size = new System.Drawing.Size(191, 20);
            this.UI_InputName_Tbx.TabIndex = 1;
            // 
            // UI_OK_Btn
            // 
            this.UI_OK_Btn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.UI_OK_Btn.Location = new System.Drawing.Point(15, 74);
            this.UI_OK_Btn.Name = "UI_OK_Btn";
            this.UI_OK_Btn.Size = new System.Drawing.Size(75, 23);
            this.UI_OK_Btn.TabIndex = 2;
            this.UI_OK_Btn.Text = "OK";
            this.UI_OK_Btn.UseVisualStyleBackColor = false;
            this.UI_OK_Btn.Click += new System.EventHandler(this.UI_OK_Btn_Click);
            // 
            // UI_Cancel_Btn
            // 
            this.UI_Cancel_Btn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.UI_Cancel_Btn.Location = new System.Drawing.Point(207, 74);
            this.UI_Cancel_Btn.Name = "UI_Cancel_Btn";
            this.UI_Cancel_Btn.Size = new System.Drawing.Size(75, 23);
            this.UI_Cancel_Btn.TabIndex = 3;
            this.UI_Cancel_Btn.Text = "Cancel";
            this.UI_Cancel_Btn.UseVisualStyleBackColor = false;
            this.UI_Cancel_Btn.Click += new System.EventHandler(this.UI_Cancel_Btn_Click);
            // 
            // ModalHighScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 109);
            this.Controls.Add(this.UI_Cancel_Btn);
            this.Controls.Add(this.UI_OK_Btn);
            this.Controls.Add(this.UI_InputName_Tbx);
            this.Controls.Add(this.label1);
            this.Name = "ModalHighScore";
            this.Text = "High Score";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UI_InputName_Tbx;
        private System.Windows.Forms.Button UI_OK_Btn;
        private System.Windows.Forms.Button UI_Cancel_Btn;
    }
}