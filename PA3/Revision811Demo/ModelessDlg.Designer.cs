namespace Revision811Demo
{
    partial class ModelessDlg
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
            this.UI_Input_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Opacity_Track = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UI_Red_Radio = new System.Windows.Forms.RadioButton();
            this.UI_Orange_Radio = new System.Windows.Forms.RadioButton();
            this.UI_Purple_Radio = new System.Windows.Forms.RadioButton();
            this.UI_None_Radio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.UI_Opacity_Track)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_Input_Tbx
            // 
            this.UI_Input_Tbx.Location = new System.Drawing.Point(9, 10);
            this.UI_Input_Tbx.Name = "UI_Input_Tbx";
            this.UI_Input_Tbx.Size = new System.Drawing.Size(280, 20);
            this.UI_Input_Tbx.TabIndex = 0;
            this.UI_Input_Tbx.TextChanged += new System.EventHandler(this.UI_Input_Tbx_TextChanged);
            // 
            // UI_Opacity_Track
            // 
            this.UI_Opacity_Track.Location = new System.Drawing.Point(12, 60);
            this.UI_Opacity_Track.Name = "UI_Opacity_Track";
            this.UI_Opacity_Track.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UI_Opacity_Track.Size = new System.Drawing.Size(277, 45);
            this.UI_Opacity_Track.TabIndex = 1;
            this.UI_Opacity_Track.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.UI_Opacity_Track.Value = 10;
            this.UI_Opacity_Track.Scroll += new System.EventHandler(this.UI_Opacity_Track_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Opacity of the main form";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.UI_None_Radio);
            this.groupBox1.Controls.Add(this.UI_Purple_Radio);
            this.groupBox1.Controls.Add(this.UI_Orange_Radio);
            this.groupBox1.Controls.Add(this.UI_Red_Radio);
            this.groupBox1.Location = new System.Drawing.Point(9, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 50);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form Back Color";
            // 
            // UI_Red_Radio
            // 
            this.UI_Red_Radio.AutoSize = true;
            this.UI_Red_Radio.Location = new System.Drawing.Point(72, 27);
            this.UI_Red_Radio.Name = "UI_Red_Radio";
            this.UI_Red_Radio.Size = new System.Drawing.Size(45, 17);
            this.UI_Red_Radio.TabIndex = 0;
            this.UI_Red_Radio.Text = "Red";
            this.UI_Red_Radio.UseVisualStyleBackColor = true;
            this.UI_Red_Radio.CheckedChanged += new System.EventHandler(this.UI_BackColor_CheckedChanged);
            // 
            // UI_Orange_Radio
            // 
            this.UI_Orange_Radio.AutoSize = true;
            this.UI_Orange_Radio.Location = new System.Drawing.Point(138, 27);
            this.UI_Orange_Radio.Name = "UI_Orange_Radio";
            this.UI_Orange_Radio.Size = new System.Drawing.Size(60, 17);
            this.UI_Orange_Radio.TabIndex = 1;
            this.UI_Orange_Radio.Text = "Orange";
            this.UI_Orange_Radio.UseVisualStyleBackColor = true;
            this.UI_Orange_Radio.CheckedChanged += new System.EventHandler(this.UI_BackColor_CheckedChanged);
            // 
            // UI_Purple_Radio
            // 
            this.UI_Purple_Radio.AutoSize = true;
            this.UI_Purple_Radio.Location = new System.Drawing.Point(219, 27);
            this.UI_Purple_Radio.Name = "UI_Purple_Radio";
            this.UI_Purple_Radio.Size = new System.Drawing.Size(55, 17);
            this.UI_Purple_Radio.TabIndex = 2;
            this.UI_Purple_Radio.Text = "Purple";
            this.UI_Purple_Radio.UseVisualStyleBackColor = true;
            this.UI_Purple_Radio.CheckedChanged += new System.EventHandler(this.UI_BackColor_CheckedChanged);
            // 
            // UI_None_Radio
            // 
            this.UI_None_Radio.AutoSize = true;
            this.UI_None_Radio.Checked = true;
            this.UI_None_Radio.Location = new System.Drawing.Point(6, 27);
            this.UI_None_Radio.Name = "UI_None_Radio";
            this.UI_None_Radio.Size = new System.Drawing.Size(51, 17);
            this.UI_None_Radio.TabIndex = 3;
            this.UI_None_Radio.TabStop = true;
            this.UI_None_Radio.Text = "None";
            this.UI_None_Radio.UseVisualStyleBackColor = true;
            this.UI_None_Radio.CheckedChanged += new System.EventHandler(this.UI_BackColor_CheckedChanged);
            // 
            // ModelessDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 173);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_Opacity_Track);
            this.Controls.Add(this.UI_Input_Tbx);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModelessDlg";
            this.Text = "ModelessDlg";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModelessDlg_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.UI_Opacity_Track)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UI_Input_Tbx;
        private System.Windows.Forms.TrackBar UI_Opacity_Track;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton UI_Purple_Radio;
        private System.Windows.Forms.RadioButton UI_Orange_Radio;
        private System.Windows.Forms.RadioButton UI_Red_Radio;
        private System.Windows.Forms.RadioButton UI_None_Radio;
    }
}