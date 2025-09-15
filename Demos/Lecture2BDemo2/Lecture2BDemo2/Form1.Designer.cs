namespace Lecture2BDemo2
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
            this.UI_Input_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Output_Lbl = new System.Windows.Forms.Label();
            this.UI_TransferToLabel_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI_Input_Tbx
            // 
            this.UI_Input_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Input_Tbx.Location = new System.Drawing.Point(221, 137);
            this.UI_Input_Tbx.Name = "UI_Input_Tbx";
            this.UI_Input_Tbx.Size = new System.Drawing.Size(295, 22);
            this.UI_Input_Tbx.TabIndex = 0;
            // 
            // UI_Output_Lbl
            // 
            this.UI_Output_Lbl.AutoSize = true;
            this.UI_Output_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Output_Lbl.Location = new System.Drawing.Point(218, 186);
            this.UI_Output_Lbl.Name = "UI_Output_Lbl";
            this.UI_Output_Lbl.Size = new System.Drawing.Size(131, 16);
            this.UI_Output_Lbl.TabIndex = 1;
            this.UI_Output_Lbl.Text = "Initial Label Value";
            // 
            // UI_TransferToLabel_Btn
            // 
            this.UI_TransferToLabel_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_TransferToLabel_Btn.Location = new System.Drawing.Point(221, 225);
            this.UI_TransferToLabel_Btn.Name = "UI_TransferToLabel_Btn";
            this.UI_TransferToLabel_Btn.Size = new System.Drawing.Size(295, 47);
            this.UI_TransferToLabel_Btn.TabIndex = 2;
            this.UI_TransferToLabel_Btn.Text = "Transfer To Label";
            this.UI_TransferToLabel_Btn.UseVisualStyleBackColor = true;
            this.UI_TransferToLabel_Btn.Click += new System.EventHandler(this.UI_TransferToLabel_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_TransferToLabel_Btn);
            this.Controls.Add(this.UI_Output_Lbl);
            this.Controls.Add(this.UI_Input_Tbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UI_Input_Tbx;
        private System.Windows.Forms.Label UI_Output_Lbl;
        private System.Windows.Forms.Button UI_TransferToLabel_Btn;
    }
}

