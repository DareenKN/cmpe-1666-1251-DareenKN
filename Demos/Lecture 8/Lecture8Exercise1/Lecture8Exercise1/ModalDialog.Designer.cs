namespace Lecture8Exercise1
{
    partial class ModalDialog
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
            this.UI_Input1_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Input2_Tbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UI_OK_Btn = new System.Windows.Forms.Button();
            this.UI_Cancel_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI_Input1_Tbx
            // 
            this.UI_Input1_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Input1_Tbx.Location = new System.Drawing.Point(315, 118);
            this.UI_Input1_Tbx.Name = "UI_Input1_Tbx";
            this.UI_Input1_Tbx.Size = new System.Drawing.Size(226, 26);
            this.UI_Input1_Tbx.TabIndex = 0;
            // 
            // UI_Input2_Tbx
            // 
            this.UI_Input2_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Input2_Tbx.Location = new System.Drawing.Point(315, 181);
            this.UI_Input2_Tbx.Name = "UI_Input2_Tbx";
            this.UI_Input2_Tbx.Size = new System.Drawing.Size(226, 26);
            this.UI_Input2_Tbx.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Input 2:";
            // 
            // UI_OK_Btn
            // 
            this.UI_OK_Btn.Location = new System.Drawing.Point(102, 279);
            this.UI_OK_Btn.Name = "UI_OK_Btn";
            this.UI_OK_Btn.Size = new System.Drawing.Size(199, 46);
            this.UI_OK_Btn.TabIndex = 4;
            this.UI_OK_Btn.Text = "OK";
            this.UI_OK_Btn.UseVisualStyleBackColor = true;
            this.UI_OK_Btn.Click += new System.EventHandler(this.UI_OK_Btn_Click);
            // 
            // UI_Cancel_Button
            // 
            this.UI_Cancel_Button.Location = new System.Drawing.Point(459, 279);
            this.UI_Cancel_Button.Name = "UI_Cancel_Button";
            this.UI_Cancel_Button.Size = new System.Drawing.Size(199, 46);
            this.UI_Cancel_Button.TabIndex = 5;
            this.UI_Cancel_Button.Text = "Cancel";
            this.UI_Cancel_Button.UseVisualStyleBackColor = true;
            this.UI_Cancel_Button.Click += new System.EventHandler(this.UI_Cancel_Button_Click);
            // 
            // ModalDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.UI_Cancel_Button);
            this.Controls.Add(this.UI_OK_Btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_Input2_Tbx);
            this.Controls.Add(this.UI_Input1_Tbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModalDialog";
            this.Text = "ModalDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UI_Input1_Tbx;
        private System.Windows.Forms.TextBox UI_Input2_Tbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UI_OK_Btn;
        private System.Windows.Forms.Button UI_Cancel_Button;
    }
}