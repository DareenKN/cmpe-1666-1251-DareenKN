namespace Lab3_DareenKN
{
    partial class ModelessAnimationSpeed
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
            this.UI_AnimationSpeed_Track = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UI_AnimationSpeed_Track)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_AnimationSpeed_Track
            // 
            this.UI_AnimationSpeed_Track.Location = new System.Drawing.Point(12, 20);
            this.UI_AnimationSpeed_Track.Maximum = 20;
            this.UI_AnimationSpeed_Track.Minimum = 1;
            this.UI_AnimationSpeed_Track.Name = "UI_AnimationSpeed_Track";
            this.UI_AnimationSpeed_Track.Size = new System.Drawing.Size(293, 45);
            this.UI_AnimationSpeed_Track.TabIndex = 0;
            this.UI_AnimationSpeed_Track.Value = 10;
            this.UI_AnimationSpeed_Track.Scroll += new System.EventHandler(this.UI_AnimationSpeed_Track_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "10 ms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "200 ms";
            // 
            // ModelessAnimationSpeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 86);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_AnimationSpeed_Track);
            this.MaximumSize = new System.Drawing.Size(333, 125);
            this.MinimumSize = new System.Drawing.Size(333, 125);
            this.Name = "ModelessAnimationSpeed";
            this.Text = "Animation Speed";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModelessAnimationSpeed_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.UI_AnimationSpeed_Track)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar UI_AnimationSpeed_Track;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}