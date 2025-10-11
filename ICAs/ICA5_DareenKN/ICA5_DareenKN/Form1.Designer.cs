namespace ICA5_DareenKN
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
            this.UI_State_Lbl = new System.Windows.Forms.Label();
            this.UI_Poll_Tmr = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // UI_State_Lbl
            // 
            this.UI_State_Lbl.AutoSize = true;
            this.UI_State_Lbl.Location = new System.Drawing.Point(88, 35);
            this.UI_State_Lbl.Name = "UI_State_Lbl";
            this.UI_State_Lbl.Size = new System.Drawing.Size(35, 13);
            this.UI_State_Lbl.TabIndex = 0;
            this.UI_State_Lbl.Text = "label1";
            // 
            // UI_Poll_Tmr
            // 
            this.UI_Poll_Tmr.Enabled = true;
            this.UI_Poll_Tmr.Interval = 50;
            this.UI_Poll_Tmr.Tick += new System.EventHandler(this.UI_Poll_Tmr_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 91);
            this.Controls.Add(this.UI_State_Lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UI_State_Lbl;
        private System.Windows.Forms.Timer UI_Poll_Tmr;
    }
}

