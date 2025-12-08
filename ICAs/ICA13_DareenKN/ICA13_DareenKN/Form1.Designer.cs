namespace ICA13_DareenKN
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
            this.UI_DisplayFont_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_DisplayFont_Lbl
            // 
            this.UI_DisplayFont_Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_DisplayFont_Lbl.BackColor = System.Drawing.SystemColors.Menu;
            this.UI_DisplayFont_Lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UI_DisplayFont_Lbl.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_DisplayFont_Lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            this.UI_DisplayFont_Lbl.Location = new System.Drawing.Point(12, 9);
            this.UI_DisplayFont_Lbl.Margin = new System.Windows.Forms.Padding(3);
            this.UI_DisplayFont_Lbl.Name = "UI_DisplayFont_Lbl";
            this.UI_DisplayFont_Lbl.Size = new System.Drawing.Size(260, 240);
            this.UI_DisplayFont_Lbl.TabIndex = 0;
            this.UI_DisplayFont_Lbl.Text = "This is the selected font!";
            this.UI_DisplayFont_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UI_DisplayFont_Lbl.Click += new System.EventHandler(this.UI_DisplayFont_Lbl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.UI_DisplayFont_Lbl);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form1";
            this.Text = "ICA13_DareenKN: Fontify";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label UI_DisplayFont_Lbl;
    }
}

