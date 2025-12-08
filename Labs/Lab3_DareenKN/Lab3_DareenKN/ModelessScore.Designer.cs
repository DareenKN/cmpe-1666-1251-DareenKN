namespace Lab3_DareenKN
{
    partial class ModelessScore
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
            this.UI_Score_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score:";
            // 
            // UI_Score_Lbl
            // 
            this.UI_Score_Lbl.AutoSize = true;
            this.UI_Score_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Score_Lbl.Location = new System.Drawing.Point(167, 36);
            this.UI_Score_Lbl.Name = "UI_Score_Lbl";
            this.UI_Score_Lbl.Size = new System.Drawing.Size(50, 24);
            this.UI_Score_Lbl.TabIndex = 1;
            this.UI_Score_Lbl.Text = "0000";
            // 
            // ModelessScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 100);
            this.Controls.Add(this.UI_Score_Lbl);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(299, 139);
            this.MinimumSize = new System.Drawing.Size(299, 139);
            this.Name = "ModelessScore";
            this.Text = "Score";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModelessScore_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UI_Score_Lbl;
    }
}