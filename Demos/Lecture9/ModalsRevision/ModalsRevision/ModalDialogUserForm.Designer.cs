namespace ModalsRevision
{
    partial class ModalDialogUserForm
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
            this.UI_UserName_Lbl = new System.Windows.Forms.Label();
            this.UI_UserName_Tbx = new System.Windows.Forms.TextBox();
            this.UI_OK_Btn = new System.Windows.Forms.Button();
            this.UI_Cancel_Btn = new System.Windows.Forms.Button();
            this.UI_Password_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Password_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_UserName_Lbl
            // 
            this.UI_UserName_Lbl.AutoSize = true;
            this.UI_UserName_Lbl.Location = new System.Drawing.Point(58, 63);
            this.UI_UserName_Lbl.Name = "UI_UserName_Lbl";
            this.UI_UserName_Lbl.Size = new System.Drawing.Size(60, 13);
            this.UI_UserName_Lbl.TabIndex = 0;
            this.UI_UserName_Lbl.Text = "User Name";
            // 
            // UI_UserName_Tbx
            // 
            this.UI_UserName_Tbx.Location = new System.Drawing.Point(155, 57);
            this.UI_UserName_Tbx.Name = "UI_UserName_Tbx";
            this.UI_UserName_Tbx.Size = new System.Drawing.Size(333, 20);
            this.UI_UserName_Tbx.TabIndex = 1;
            // 
            // UI_OK_Btn
            // 
            this.UI_OK_Btn.Location = new System.Drawing.Point(78, 145);
            this.UI_OK_Btn.Name = "UI_OK_Btn";
            this.UI_OK_Btn.Size = new System.Drawing.Size(160, 45);
            this.UI_OK_Btn.TabIndex = 2;
            this.UI_OK_Btn.Text = "OK";
            this.UI_OK_Btn.UseVisualStyleBackColor = true;
            this.UI_OK_Btn.Click += new System.EventHandler(this.UI_OK_Btn_Click);
            // 
            // UI_Cancel_Btn
            // 
            this.UI_Cancel_Btn.Location = new System.Drawing.Point(316, 145);
            this.UI_Cancel_Btn.Name = "UI_Cancel_Btn";
            this.UI_Cancel_Btn.Size = new System.Drawing.Size(160, 45);
            this.UI_Cancel_Btn.TabIndex = 3;
            this.UI_Cancel_Btn.Text = "Cancel";
            this.UI_Cancel_Btn.UseVisualStyleBackColor = true;
            this.UI_Cancel_Btn.Click += new System.EventHandler(this.UI_Cancel_Btn_Click);
            // 
            // UI_Password_Tbx
            // 
            this.UI_Password_Tbx.Location = new System.Drawing.Point(155, 94);
            this.UI_Password_Tbx.Name = "UI_Password_Tbx";
            this.UI_Password_Tbx.Size = new System.Drawing.Size(333, 20);
            this.UI_Password_Tbx.TabIndex = 4;
            // 
            // UI_Password_Label
            // 
            this.UI_Password_Label.AutoSize = true;
            this.UI_Password_Label.Location = new System.Drawing.Point(58, 101);
            this.UI_Password_Label.Name = "UI_Password_Label";
            this.UI_Password_Label.Size = new System.Drawing.Size(53, 13);
            this.UI_Password_Label.TabIndex = 5;
            this.UI_Password_Label.Text = "Password";
            // 
            // ModalDialogUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 243);
            this.Controls.Add(this.UI_Password_Label);
            this.Controls.Add(this.UI_Password_Tbx);
            this.Controls.Add(this.UI_Cancel_Btn);
            this.Controls.Add(this.UI_OK_Btn);
            this.Controls.Add(this.UI_UserName_Tbx);
            this.Controls.Add(this.UI_UserName_Lbl);
            this.Name = "ModalDialogUserForm";
            this.Text = "ModalDialogUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UI_UserName_Lbl;
        private System.Windows.Forms.TextBox UI_UserName_Tbx;
        private System.Windows.Forms.Button UI_OK_Btn;
        private System.Windows.Forms.Button UI_Cancel_Btn;
        private System.Windows.Forms.TextBox UI_Password_Tbx;
        private System.Windows.Forms.Label UI_Password_Label;
    }
}