namespace Q1_PA3
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
            this.UI_DisplayThread_Lbx = new System.Windows.Forms.ListBox();
            this.UI_StartThread_Btn = new System.Windows.Forms.Button();
            this.UI_Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // UI_DisplayThread_Lbx
            // 
            this.UI_DisplayThread_Lbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_DisplayThread_Lbx.FormattingEnabled = true;
            this.UI_DisplayThread_Lbx.Location = new System.Drawing.Point(12, 12);
            this.UI_DisplayThread_Lbx.Name = "UI_DisplayThread_Lbx";
            this.UI_DisplayThread_Lbx.Size = new System.Drawing.Size(414, 381);
            this.UI_DisplayThread_Lbx.TabIndex = 0;
            // 
            // UI_StartThread_Btn
            // 
            this.UI_StartThread_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_StartThread_Btn.Location = new System.Drawing.Point(432, 72);
            this.UI_StartThread_Btn.Name = "UI_StartThread_Btn";
            this.UI_StartThread_Btn.Size = new System.Drawing.Size(152, 52);
            this.UI_StartThread_Btn.TabIndex = 1;
            this.UI_StartThread_Btn.Text = "Start Thread";
            this.UI_StartThread_Btn.UseVisualStyleBackColor = true;
            this.UI_StartThread_Btn.Click += new System.EventHandler(this.UI_StartThread_Btn_Click);
            // 
            // UI_Timer
            // 
            this.UI_Timer.Enabled = true;
            this.UI_Timer.Tick += new System.EventHandler(this.UI_Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 402);
            this.Controls.Add(this.UI_StartThread_Btn);
            this.Controls.Add(this.UI_DisplayThread_Lbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox UI_DisplayThread_Lbx;
        private System.Windows.Forms.Button UI_StartThread_Btn;
        private System.Windows.Forms.Timer UI_Timer;
    }
}

