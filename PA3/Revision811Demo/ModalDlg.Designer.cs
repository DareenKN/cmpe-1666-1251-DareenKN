namespace Revision811Demo
{
    partial class ModalDlg
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
            this.UI_Text_Tbx = new System.Windows.Forms.TextBox();
            this.UI_OK_Btn = new System.Windows.Forms.Button();
            this.UI_Cancel_Btn = new System.Windows.Forms.Button();
            this.UI_Val2_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Val1_tbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UI_ProgressBar = new System.Windows.Forms.ProgressBar();
            this.UI_Timer = new System.Windows.Forms.Timer(this.components);
            this.UI_SelfDestruct_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_Text_Tbx
            // 
            this.UI_Text_Tbx.Location = new System.Drawing.Point(12, 12);
            this.UI_Text_Tbx.Name = "UI_Text_Tbx";
            this.UI_Text_Tbx.Size = new System.Drawing.Size(193, 20);
            this.UI_Text_Tbx.TabIndex = 0;
            // 
            // UI_OK_Btn
            // 
            this.UI_OK_Btn.Location = new System.Drawing.Point(15, 84);
            this.UI_OK_Btn.Name = "UI_OK_Btn";
            this.UI_OK_Btn.Size = new System.Drawing.Size(75, 23);
            this.UI_OK_Btn.TabIndex = 1;
            this.UI_OK_Btn.Text = "OK";
            this.UI_OK_Btn.UseVisualStyleBackColor = true;
            this.UI_OK_Btn.Click += new System.EventHandler(this.UI_OK_Btn_Click);
            // 
            // UI_Cancel_Btn
            // 
            this.UI_Cancel_Btn.Location = new System.Drawing.Point(133, 84);
            this.UI_Cancel_Btn.Name = "UI_Cancel_Btn";
            this.UI_Cancel_Btn.Size = new System.Drawing.Size(75, 23);
            this.UI_Cancel_Btn.TabIndex = 2;
            this.UI_Cancel_Btn.Text = "Cancel";
            this.UI_Cancel_Btn.UseVisualStyleBackColor = true;
            this.UI_Cancel_Btn.Click += new System.EventHandler(this.UI_Cancel_Btn_Click);
            // 
            // UI_Val2_Tbx
            // 
            this.UI_Val2_Tbx.Location = new System.Drawing.Point(111, 55);
            this.UI_Val2_Tbx.Name = "UI_Val2_Tbx";
            this.UI_Val2_Tbx.Size = new System.Drawing.Size(94, 20);
            this.UI_Val2_Tbx.TabIndex = 5;
            // 
            // UI_Val1_tbx
            // 
            this.UI_Val1_tbx.Location = new System.Drawing.Point(15, 55);
            this.UI_Val1_tbx.Name = "UI_Val1_tbx";
            this.UI_Val1_tbx.Size = new System.Drawing.Size(94, 20);
            this.UI_Val1_tbx.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter two integers below for an Operation";
            // 
            // UI_ProgressBar
            // 
            this.UI_ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UI_ProgressBar.Location = new System.Drawing.Point(15, 137);
            this.UI_ProgressBar.Name = "UI_ProgressBar";
            this.UI_ProgressBar.Size = new System.Drawing.Size(193, 23);
            this.UI_ProgressBar.Step = 1;
            this.UI_ProgressBar.TabIndex = 7;
            // 
            // UI_Timer
            // 
            this.UI_Timer.Tick += new System.EventHandler(this.UI_Timer_Tick);
            // 
            // UI_SelfDestruct_Lbl
            // 
            this.UI_SelfDestruct_Lbl.AutoSize = true;
            this.UI_SelfDestruct_Lbl.Location = new System.Drawing.Point(17, 121);
            this.UI_SelfDestruct_Lbl.Name = "UI_SelfDestruct_Lbl";
            this.UI_SelfDestruct_Lbl.Size = new System.Drawing.Size(0, 13);
            this.UI_SelfDestruct_Lbl.TabIndex = 8;
            // 
            // ModalDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 172);
            this.ControlBox = false;
            this.Controls.Add(this.UI_SelfDestruct_Lbl);
            this.Controls.Add(this.UI_ProgressBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_Val2_Tbx);
            this.Controls.Add(this.UI_Val1_tbx);
            this.Controls.Add(this.UI_Cancel_Btn);
            this.Controls.Add(this.UI_OK_Btn);
            this.Controls.Add(this.UI_Text_Tbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModalDlg";
            this.Text = "ModalDlg";
            this.Load += new System.EventHandler(this.ModalDlg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UI_Text_Tbx;
        private System.Windows.Forms.Button UI_OK_Btn;
        private System.Windows.Forms.Button UI_Cancel_Btn;
        private System.Windows.Forms.TextBox UI_Val2_Tbx;
        private System.Windows.Forms.TextBox UI_Val1_tbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar UI_ProgressBar;
        private System.Windows.Forms.Timer UI_Timer;
        private System.Windows.Forms.Label UI_SelfDestruct_Lbl;
    }
}