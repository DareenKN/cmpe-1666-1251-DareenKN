namespace ICA15_DareenKN
{
    partial class ModalessDlgForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UI_Red_Track = new System.Windows.Forms.TrackBar();
            this.UI_Green_Track = new System.Windows.Forms.TrackBar();
            this.UI_Blue_Track = new System.Windows.Forms.TrackBar();
            this.UI_Opacity_Track = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UI_Red_Track)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_Green_Track)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_Blue_Track)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_Opacity_Track)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UI_Blue_Track);
            this.groupBox1.Controls.Add(this.UI_Green_Track);
            this.groupBox1.Controls.Add(this.UI_Red_Track);
            this.groupBox1.Location = new System.Drawing.Point(13, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(513, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Colour";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UI_Opacity_Track);
            this.groupBox2.Location = new System.Drawing.Point(12, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 74);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opacity";
            // 
            // UI_Red_Track
            // 
            this.UI_Red_Track.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.UI_Red_Track.LargeChange = 1;
            this.UI_Red_Track.Location = new System.Drawing.Point(6, 19);
            this.UI_Red_Track.Maximum = 33;
            this.UI_Red_Track.Name = "UI_Red_Track";
            this.UI_Red_Track.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UI_Red_Track.Size = new System.Drawing.Size(501, 45);
            this.UI_Red_Track.TabIndex = 0;
            this.UI_Red_Track.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.UI_Red_Track.Scroll += new System.EventHandler(this.UI_RGB_Track_Scroll);
            // 
            // UI_Green_Track
            // 
            this.UI_Green_Track.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.UI_Green_Track.LargeChange = 1;
            this.UI_Green_Track.Location = new System.Drawing.Point(6, 70);
            this.UI_Green_Track.Maximum = 33;
            this.UI_Green_Track.Name = "UI_Green_Track";
            this.UI_Green_Track.Size = new System.Drawing.Size(501, 45);
            this.UI_Green_Track.TabIndex = 1;
            this.UI_Green_Track.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.UI_Green_Track.Scroll += new System.EventHandler(this.UI_RGB_Track_Scroll);
            // 
            // UI_Blue_Track
            // 
            this.UI_Blue_Track.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.UI_Blue_Track.LargeChange = 1;
            this.UI_Blue_Track.Location = new System.Drawing.Point(6, 121);
            this.UI_Blue_Track.Maximum = 33;
            this.UI_Blue_Track.Name = "UI_Blue_Track";
            this.UI_Blue_Track.Size = new System.Drawing.Size(501, 45);
            this.UI_Blue_Track.TabIndex = 2;
            this.UI_Blue_Track.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.UI_Blue_Track.Scroll += new System.EventHandler(this.UI_RGB_Track_Scroll);
            // 
            // UI_Opacity_Track
            // 
            this.UI_Opacity_Track.BackColor = System.Drawing.Color.Silver;
            this.UI_Opacity_Track.LargeChange = 1;
            this.UI_Opacity_Track.Location = new System.Drawing.Point(6, 19);
            this.UI_Opacity_Track.Maximum = 100;
            this.UI_Opacity_Track.Name = "UI_Opacity_Track";
            this.UI_Opacity_Track.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UI_Opacity_Track.Size = new System.Drawing.Size(501, 45);
            this.UI_Opacity_Track.TabIndex = 3;
            this.UI_Opacity_Track.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.UI_Opacity_Track.Scroll += new System.EventHandler(this.UI_Opacity_Track_Scroll);
            // 
            // ModalessDlgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 281);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(550, 320);
            this.MinimumSize = new System.Drawing.Size(550, 320);
            this.Name = "ModalessDlgForm";
            this.Text = "Select Colour/ Opacity";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModalessDlgForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UI_Red_Track)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_Green_Track)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_Blue_Track)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_Opacity_Track)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar UI_Blue_Track;
        private System.Windows.Forms.TrackBar UI_Green_Track;
        private System.Windows.Forms.TrackBar UI_Red_Track;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar UI_Opacity_Track;
    }
}