namespace Lecture9Exercice4
{
    partial class ModelessDialog
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
            this.UI_Red_Rbtn = new System.Windows.Forms.RadioButton();
            this.UI_Purple_Rbtn = new System.Windows.Forms.RadioButton();
            this.UI_Yellow_Rbtn = new System.Windows.Forms.RadioButton();
            this.UI_OP_Ttrack = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.UI_OP_Ttrack)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_Red_Rbtn
            // 
            this.UI_Red_Rbtn.AutoSize = true;
            this.UI_Red_Rbtn.Location = new System.Drawing.Point(358, 162);
            this.UI_Red_Rbtn.Name = "UI_Red_Rbtn";
            this.UI_Red_Rbtn.Size = new System.Drawing.Size(45, 17);
            this.UI_Red_Rbtn.TabIndex = 0;
            this.UI_Red_Rbtn.TabStop = true;
            this.UI_Red_Rbtn.Text = "Red";
            this.UI_Red_Rbtn.UseVisualStyleBackColor = true;
            this.UI_Red_Rbtn.CheckedChanged += new System.EventHandler(this.UI_Colors_Rbtn);
            // 
            // UI_Purple_Rbtn
            // 
            this.UI_Purple_Rbtn.AutoSize = true;
            this.UI_Purple_Rbtn.Location = new System.Drawing.Point(358, 217);
            this.UI_Purple_Rbtn.Name = "UI_Purple_Rbtn";
            this.UI_Purple_Rbtn.Size = new System.Drawing.Size(55, 17);
            this.UI_Purple_Rbtn.TabIndex = 1;
            this.UI_Purple_Rbtn.TabStop = true;
            this.UI_Purple_Rbtn.Text = "Purple";
            this.UI_Purple_Rbtn.UseVisualStyleBackColor = true;
            this.UI_Purple_Rbtn.CheckedChanged += new System.EventHandler(this.UI_Colors_Rbtn);
            // 
            // UI_Yellow_Rbtn
            // 
            this.UI_Yellow_Rbtn.AutoSize = true;
            this.UI_Yellow_Rbtn.Location = new System.Drawing.Point(358, 274);
            this.UI_Yellow_Rbtn.Name = "UI_Yellow_Rbtn";
            this.UI_Yellow_Rbtn.Size = new System.Drawing.Size(56, 17);
            this.UI_Yellow_Rbtn.TabIndex = 2;
            this.UI_Yellow_Rbtn.TabStop = true;
            this.UI_Yellow_Rbtn.Text = "Yellow";
            this.UI_Yellow_Rbtn.UseVisualStyleBackColor = true;
            this.UI_Yellow_Rbtn.CheckedChanged += new System.EventHandler(this.UI_Colors_Rbtn);
            // 
            // UI_OP_Ttrack
            // 
            this.UI_OP_Ttrack.Location = new System.Drawing.Point(141, 189);
            this.UI_OP_Ttrack.Maximum = 25;
            this.UI_OP_Ttrack.Name = "UI_OP_Ttrack";
            this.UI_OP_Ttrack.Size = new System.Drawing.Size(104, 45);
            this.UI_OP_Ttrack.TabIndex = 3;
            this.UI_OP_Ttrack.Value = 25;
            this.UI_OP_Ttrack.Scroll += new System.EventHandler(this.UI_OP_Ttrack_Scroll);
            // 
            // ModelessDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_OP_Ttrack);
            this.Controls.Add(this.UI_Yellow_Rbtn);
            this.Controls.Add(this.UI_Purple_Rbtn);
            this.Controls.Add(this.UI_Red_Rbtn);
            this.Name = "ModelessDialog";
            this.Text = "ModelessDialog";
    
            this.Load += new System.EventHandler(this.ModelessDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UI_OP_Ttrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton UI_Red_Rbtn;
        private System.Windows.Forms.RadioButton UI_Purple_Rbtn;
        private System.Windows.Forms.RadioButton UI_Yellow_Rbtn;
        private System.Windows.Forms.TrackBar UI_OP_Ttrack;
    }
}