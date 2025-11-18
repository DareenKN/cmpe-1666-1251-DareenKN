namespace Lecture9Demo2
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
            this.UI_DialogText_Lbl = new System.Windows.Forms.Label();
            this.UI_ShowDialog_Cbx = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // UI_DialogText_Lbl
            // 
            this.UI_DialogText_Lbl.AutoSize = true;
            this.UI_DialogText_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_DialogText_Lbl.Location = new System.Drawing.Point(107, 152);
            this.UI_DialogText_Lbl.Name = "UI_DialogText_Lbl";
            this.UI_DialogText_Lbl.Size = new System.Drawing.Size(182, 16);
            this.UI_DialogText_Lbl.TabIndex = 0;
            this.UI_DialogText_Lbl.Text = "Your text will appear here";
            // 
            // UI_ShowDialog_Cbx
            // 
            this.UI_ShowDialog_Cbx.AutoSize = true;
            this.UI_ShowDialog_Cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_ShowDialog_Cbx.Location = new System.Drawing.Point(110, 103);
            this.UI_ShowDialog_Cbx.Name = "UI_ShowDialog_Cbx";
            this.UI_ShowDialog_Cbx.Size = new System.Drawing.Size(113, 20);
            this.UI_ShowDialog_Cbx.TabIndex = 1;
            this.UI_ShowDialog_Cbx.Text = "Show Dailog";
            this.UI_ShowDialog_Cbx.UseVisualStyleBackColor = true;
            this.UI_ShowDialog_Cbx.CheckedChanged += new System.EventHandler(this.UI_ShowDialog_Cbx_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_ShowDialog_Cbx);
            this.Controls.Add(this.UI_DialogText_Lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UI_DialogText_Lbl;
        private System.Windows.Forms.CheckBox UI_ShowDialog_Cbx;
    }
}

