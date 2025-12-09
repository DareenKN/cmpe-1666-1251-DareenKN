namespace Revision811Demo
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
            this.UI_Modal_Btn = new System.Windows.Forms.Button();
            this.UI_ModalResult_Lbl = new System.Windows.Forms.Label();
            this.UI_BinOp_Lbl = new System.Windows.Forms.Label();
            this.UI_OpenModeless_Cbx = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UI_ModelessInput_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_Modal_Btn
            // 
            this.UI_Modal_Btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.UI_Modal_Btn.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Modal_Btn.Location = new System.Drawing.Point(105, 24);
            this.UI_Modal_Btn.Name = "UI_Modal_Btn";
            this.UI_Modal_Btn.Size = new System.Drawing.Size(175, 52);
            this.UI_Modal_Btn.TabIndex = 0;
            this.UI_Modal_Btn.Text = "Open Modal";
            this.UI_Modal_Btn.UseVisualStyleBackColor = false;
            this.UI_Modal_Btn.Click += new System.EventHandler(this.UI_Modal_Btn_Click);
            // 
            // UI_ModalResult_Lbl
            // 
            this.UI_ModalResult_Lbl.AutoSize = true;
            this.UI_ModalResult_Lbl.Location = new System.Drawing.Point(9, 96);
            this.UI_ModalResult_Lbl.Name = "UI_ModalResult_Lbl";
            this.UI_ModalResult_Lbl.Size = new System.Drawing.Size(97, 13);
            this.UI_ModalResult_Lbl.TabIndex = 1;
            this.UI_ModalResult_Lbl.Text = "Result from modal: ";
            // 
            // UI_BinOp_Lbl
            // 
            this.UI_BinOp_Lbl.AutoSize = true;
            this.UI_BinOp_Lbl.Location = new System.Drawing.Point(10, 120);
            this.UI_BinOp_Lbl.Name = "UI_BinOp_Lbl";
            this.UI_BinOp_Lbl.Size = new System.Drawing.Size(91, 13);
            this.UI_BinOp_Lbl.TabIndex = 2;
            this.UI_BinOp_Lbl.Text = "DelBinOp Result: ";
            // 
            // UI_OpenModeless_Cbx
            // 
            this.UI_OpenModeless_Cbx.AutoSize = true;
            this.UI_OpenModeless_Cbx.Location = new System.Drawing.Point(12, 151);
            this.UI_OpenModeless_Cbx.Name = "UI_OpenModeless_Cbx";
            this.UI_OpenModeless_Cbx.Size = new System.Drawing.Size(100, 17);
            this.UI_OpenModeless_Cbx.TabIndex = 3;
            this.UI_OpenModeless_Cbx.Text = "Open Modeless";
            this.UI_OpenModeless_Cbx.UseVisualStyleBackColor = true;
            this.UI_OpenModeless_Cbx.CheckedChanged += new System.EventHandler(this.UI_OpenModeless_Cbx_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "This is the text entered from the modeless dialog!";
            // 
            // UI_ModelessInput_Lbl
            // 
            this.UI_ModelessInput_Lbl.AutoSize = true;
            this.UI_ModelessInput_Lbl.Location = new System.Drawing.Point(12, 195);
            this.UI_ModelessInput_Lbl.Name = "UI_ModelessInput_Lbl";
            this.UI_ModelessInput_Lbl.Size = new System.Drawing.Size(0, 13);
            this.UI_ModelessInput_Lbl.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 450);
            this.Controls.Add(this.UI_ModelessInput_Lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_OpenModeless_Cbx);
            this.Controls.Add(this.UI_BinOp_Lbl);
            this.Controls.Add(this.UI_ModalResult_Lbl);
            this.Controls.Add(this.UI_Modal_Btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UI_Modal_Btn;
        private System.Windows.Forms.Label UI_ModalResult_Lbl;
        private System.Windows.Forms.Label UI_BinOp_Lbl;
        private System.Windows.Forms.CheckBox UI_OpenModeless_Cbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UI_ModelessInput_Lbl;
    }
}

