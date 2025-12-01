namespace Lectur10Exercise2
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
            this.UI_Sine_Lbx = new System.Windows.Forms.ListBox();
            this.UI_Cos_Lbx = new System.Windows.Forms.ListBox();
            this.UI_StartSine_Btn = new System.Windows.Forms.Button();
            this.UI_StopSine_Btn = new System.Windows.Forms.Button();
            this.UI_StartCos_Btn = new System.Windows.Forms.Button();
            this.UI_StopCos_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI_Sine_Lbx
            // 
            this.UI_Sine_Lbx.FormattingEnabled = true;
            this.UI_Sine_Lbx.Location = new System.Drawing.Point(12, 23);
            this.UI_Sine_Lbx.Name = "UI_Sine_Lbx";
            this.UI_Sine_Lbx.Size = new System.Drawing.Size(202, 290);
            this.UI_Sine_Lbx.TabIndex = 0;
            // 
            // UI_Cos_Lbx
            // 
            this.UI_Cos_Lbx.FormattingEnabled = true;
            this.UI_Cos_Lbx.Location = new System.Drawing.Point(298, 23);
            this.UI_Cos_Lbx.Name = "UI_Cos_Lbx";
            this.UI_Cos_Lbx.Size = new System.Drawing.Size(202, 290);
            this.UI_Cos_Lbx.TabIndex = 1;
            // 
            // UI_StartSine_Btn
            // 
            this.UI_StartSine_Btn.Location = new System.Drawing.Point(12, 332);
            this.UI_StartSine_Btn.Name = "UI_StartSine_Btn";
            this.UI_StartSine_Btn.Size = new System.Drawing.Size(202, 42);
            this.UI_StartSine_Btn.TabIndex = 2;
            this.UI_StartSine_Btn.Text = "Start Sine Calculation";
            this.UI_StartSine_Btn.UseVisualStyleBackColor = true;
            this.UI_StartSine_Btn.Click += new System.EventHandler(this.UI_StartSine_Btn_Click);
            // 
            // UI_StopSine_Btn
            // 
            this.UI_StopSine_Btn.Location = new System.Drawing.Point(12, 380);
            this.UI_StopSine_Btn.Name = "UI_StopSine_Btn";
            this.UI_StopSine_Btn.Size = new System.Drawing.Size(202, 42);
            this.UI_StopSine_Btn.TabIndex = 3;
            this.UI_StopSine_Btn.Text = "Stop Sine Calculation";
            this.UI_StopSine_Btn.UseVisualStyleBackColor = true;
            this.UI_StopSine_Btn.Click += new System.EventHandler(this.UI_StopSine_Btn_Click);
            // 
            // UI_StartCos_Btn
            // 
            this.UI_StartCos_Btn.Location = new System.Drawing.Point(298, 332);
            this.UI_StartCos_Btn.Name = "UI_StartCos_Btn";
            this.UI_StartCos_Btn.Size = new System.Drawing.Size(202, 42);
            this.UI_StartCos_Btn.TabIndex = 4;
            this.UI_StartCos_Btn.Text = "Start Cos Calculation";
            this.UI_StartCos_Btn.UseVisualStyleBackColor = true;
            this.UI_StartCos_Btn.Click += new System.EventHandler(this.UI_StartCos_Btn_Click);
            // 
            // UI_StopCos_Btn
            // 
            this.UI_StopCos_Btn.Location = new System.Drawing.Point(298, 380);
            this.UI_StopCos_Btn.Name = "UI_StopCos_Btn";
            this.UI_StopCos_Btn.Size = new System.Drawing.Size(202, 42);
            this.UI_StopCos_Btn.TabIndex = 5;
            this.UI_StopCos_Btn.Text = "Stop Cos Calculation";
            this.UI_StopCos_Btn.UseVisualStyleBackColor = true;
            this.UI_StopCos_Btn.Click += new System.EventHandler(this.UI_StopCos_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 450);
            this.Controls.Add(this.UI_StopCos_Btn);
            this.Controls.Add(this.UI_StartCos_Btn);
            this.Controls.Add(this.UI_StopSine_Btn);
            this.Controls.Add(this.UI_StartSine_Btn);
            this.Controls.Add(this.UI_Cos_Lbx);
            this.Controls.Add(this.UI_Sine_Lbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox UI_Sine_Lbx;
        private System.Windows.Forms.ListBox UI_Cos_Lbx;
        private System.Windows.Forms.Button UI_StartSine_Btn;
        private System.Windows.Forms.Button UI_StopSine_Btn;
        private System.Windows.Forms.Button UI_StartCos_Btn;
        private System.Windows.Forms.Button UI_StopCos_Btn;
    }
}

