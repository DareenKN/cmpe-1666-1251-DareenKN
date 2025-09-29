namespace Lecture2BDemo6
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
            this.UI_Test_Timer = new System.Windows.Forms.Timer(this.components);
            this.UI_Stop_Btn = new System.Windows.Forms.Button();
            this.UI_DisplayCount_ListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // UI_Test_Timer
            // 
            this.UI_Test_Timer.Enabled = true;
            this.UI_Test_Timer.Interval = 200;
            this.UI_Test_Timer.Tick += new System.EventHandler(this.UI_Test_Timer_Tick);
            // 
            // UI_Stop_Btn
            // 
            this.UI_Stop_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Stop_Btn.Location = new System.Drawing.Point(268, 160);
            this.UI_Stop_Btn.Name = "UI_Stop_Btn";
            this.UI_Stop_Btn.Size = new System.Drawing.Size(234, 116);
            this.UI_Stop_Btn.TabIndex = 0;
            this.UI_Stop_Btn.Text = "Stop The Watch";
            this.UI_Stop_Btn.UseVisualStyleBackColor = true;
            this.UI_Stop_Btn.Click += new System.EventHandler(this.UI_Stop_Btn_Click);
            // 
            // UI_DisplayCount_ListBox
            // 
            this.UI_DisplayCount_ListBox.FormattingEnabled = true;
            this.UI_DisplayCount_ListBox.Location = new System.Drawing.Point(31, 25);
            this.UI_DisplayCount_ListBox.Name = "UI_DisplayCount_ListBox";
            this.UI_DisplayCount_ListBox.Size = new System.Drawing.Size(215, 381);
            this.UI_DisplayCount_ListBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_DisplayCount_ListBox);
            this.Controls.Add(this.UI_Stop_Btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer UI_Test_Timer;
        private System.Windows.Forms.Button UI_Stop_Btn;
        private System.Windows.Forms.ListBox UI_DisplayCount_ListBox;
    }
}

