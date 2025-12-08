namespace ICA17_DareenKN
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
            this.components = new System.ComponentModel.Container();
            this.UI_ClrScanner_Lbx = new System.Windows.Forms.ListBox();
            this.UI_Go_Btn = new System.Windows.Forms.Button();
            this.UI_OFD = new System.Windows.Forms.OpenFileDialog();
            this.UI_Scanning_Tmr = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // UI_ClrScanner_Lbx
            // 
            this.UI_ClrScanner_Lbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_ClrScanner_Lbx.FormattingEnabled = true;
            this.UI_ClrScanner_Lbx.Location = new System.Drawing.Point(12, 12);
            this.UI_ClrScanner_Lbx.Name = "UI_ClrScanner_Lbx";
            this.UI_ClrScanner_Lbx.Size = new System.Drawing.Size(694, 160);
            this.UI_ClrScanner_Lbx.TabIndex = 0;
            // 
            // UI_Go_Btn
            // 
            this.UI_Go_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_Go_Btn.Location = new System.Drawing.Point(631, 181);
            this.UI_Go_Btn.Name = "UI_Go_Btn";
            this.UI_Go_Btn.Size = new System.Drawing.Size(75, 23);
            this.UI_Go_Btn.TabIndex = 1;
            this.UI_Go_Btn.Text = "Go!";
            this.UI_Go_Btn.UseVisualStyleBackColor = true;
            this.UI_Go_Btn.Click += new System.EventHandler(this.UI_Go_Btn_Click);
            // 
            // UI_OFD
            // 
            this.UI_OFD.Filter = " All File (Images) | *.*";
            this.UI_OFD.Multiselect = true;
            // 
            // UI_Scanning_Tmr
            // 
            this.UI_Scanning_Tmr.Tick += new System.EventHandler(this.UI_Scanning_Tmr_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 216);
            this.Controls.Add(this.UI_Go_Btn);
            this.Controls.Add(this.UI_ClrScanner_Lbx);
            this.Name = "Form1";
            this.Text = "ICA17_DareenKN -Image Info Scanner";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox UI_ClrScanner_Lbx;
        private System.Windows.Forms.Button UI_Go_Btn;
        private System.Windows.Forms.OpenFileDialog UI_OFD;
        private System.Windows.Forms.Timer UI_Scanning_Tmr;
    }
}

