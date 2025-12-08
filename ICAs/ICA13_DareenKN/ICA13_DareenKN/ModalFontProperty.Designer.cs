namespace ICA13_DareenKN
{
    partial class ModalFontProperty
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
            this.UI_SelectFont_Btn = new System.Windows.Forms.Button();
            this.UI_OK_Btn = new System.Windows.Forms.Button();
            this.UI_SelectedFont_Tbx = new System.Windows.Forms.TextBox();
            this.UI_SelectedColour_Tbx = new System.Windows.Forms.TextBox();
            this.UI_SelectColor_Btn = new System.Windows.Forms.Button();
            this.UI_SelectFont_FontDlg = new System.Windows.Forms.FontDialog();
            this.UI_SelectColor_ColorDlg = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // UI_SelectFont_Btn
            // 
            this.UI_SelectFont_Btn.Location = new System.Drawing.Point(12, 10);
            this.UI_SelectFont_Btn.Name = "UI_SelectFont_Btn";
            this.UI_SelectFont_Btn.Size = new System.Drawing.Size(98, 28);
            this.UI_SelectFont_Btn.TabIndex = 0;
            this.UI_SelectFont_Btn.Text = "Select Font";
            this.UI_SelectFont_Btn.UseVisualStyleBackColor = true;
            this.UI_SelectFont_Btn.Click += new System.EventHandler(this.UI_SelectFont_Btn_Click);
            // 
            // UI_OK_Btn
            // 
            this.UI_OK_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_OK_Btn.Location = new System.Drawing.Point(259, 75);
            this.UI_OK_Btn.Name = "UI_OK_Btn";
            this.UI_OK_Btn.Size = new System.Drawing.Size(98, 29);
            this.UI_OK_Btn.TabIndex = 2;
            this.UI_OK_Btn.Text = "OK";
            this.UI_OK_Btn.UseVisualStyleBackColor = true;
            this.UI_OK_Btn.Click += new System.EventHandler(this.UI_OK_Btn_Click);
            // 
            // UI_SelectedFont_Tbx
            // 
            this.UI_SelectedFont_Tbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_SelectedFont_Tbx.Location = new System.Drawing.Point(116, 14);
            this.UI_SelectedFont_Tbx.Name = "UI_SelectedFont_Tbx";
            this.UI_SelectedFont_Tbx.Size = new System.Drawing.Size(484, 20);
            this.UI_SelectedFont_Tbx.TabIndex = 3;
            this.UI_SelectedFont_Tbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UI_SelectedColour_Tbx
            // 
            this.UI_SelectedColour_Tbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_SelectedColour_Tbx.Location = new System.Drawing.Point(116, 49);
            this.UI_SelectedColour_Tbx.Name = "UI_SelectedColour_Tbx";
            this.UI_SelectedColour_Tbx.Size = new System.Drawing.Size(484, 20);
            this.UI_SelectedColour_Tbx.TabIndex = 4;
            this.UI_SelectedColour_Tbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UI_SelectColor_Btn
            // 
            this.UI_SelectColor_Btn.Location = new System.Drawing.Point(12, 44);
            this.UI_SelectColor_Btn.Name = "UI_SelectColor_Btn";
            this.UI_SelectColor_Btn.Size = new System.Drawing.Size(98, 28);
            this.UI_SelectColor_Btn.TabIndex = 5;
            this.UI_SelectColor_Btn.Text = "Select Colour";
            this.UI_SelectColor_Btn.UseVisualStyleBackColor = true;
            this.UI_SelectColor_Btn.Click += new System.EventHandler(this.UI_SelectColor_Btn_Click);
            // 
            // UI_SelectFont_FontDlg
            // 
            this.UI_SelectFont_FontDlg.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.UI_SelectFont_FontDlg.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // UI_SelectColor_ColorDlg
            // 
            this.UI_SelectColor_ColorDlg.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            // 
            // ModalFontProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 116);
            this.Controls.Add(this.UI_SelectColor_Btn);
            this.Controls.Add(this.UI_SelectedColour_Tbx);
            this.Controls.Add(this.UI_SelectedFont_Tbx);
            this.Controls.Add(this.UI_OK_Btn);
            this.Controls.Add(this.UI_SelectFont_Btn);
            this.MinimumSize = new System.Drawing.Size(623, 155);
            this.Name = "ModalFontProperty";
            this.Text = "Select Font/Colour";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UI_SelectFont_Btn;
        private System.Windows.Forms.Button UI_OK_Btn;
        private System.Windows.Forms.TextBox UI_SelectedFont_Tbx;
        private System.Windows.Forms.TextBox UI_SelectedColour_Tbx;
        private System.Windows.Forms.Button UI_SelectColor_Btn;
        private System.Windows.Forms.FontDialog UI_SelectFont_FontDlg;
        private System.Windows.Forms.ColorDialog UI_SelectColor_ColorDlg;
    }
}