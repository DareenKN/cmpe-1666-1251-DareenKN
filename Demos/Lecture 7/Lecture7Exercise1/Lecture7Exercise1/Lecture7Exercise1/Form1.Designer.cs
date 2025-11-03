namespace Lecture4Exercise1
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
            this.UI_DataList_Lbx = new System.Windows.Forms.ListBox();
            this.UI_ValueToSearch_Tbx = new System.Windows.Forms.TextBox();
            this.UI_PerformSearch_Btn = new System.Windows.Forms.Button();
            this.UI_Result_Tbx = new System.Windows.Forms.TextBox();
            this.UI_DataList_Lbl = new System.Windows.Forms.Label();
            this.UI_ValueToSearch_Lbl = new System.Windows.Forms.Label();
            this.UI_Results_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_DataList_Lbx
            // 
            this.UI_DataList_Lbx.FormattingEnabled = true;
            this.UI_DataList_Lbx.ItemHeight = 20;
            this.UI_DataList_Lbx.Location = new System.Drawing.Point(36, 97);
            this.UI_DataList_Lbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UI_DataList_Lbx.Name = "UI_DataList_Lbx";
            this.UI_DataList_Lbx.Size = new System.Drawing.Size(330, 264);
            this.UI_DataList_Lbx.TabIndex = 0;
            // 
            // UI_ValueToSearch_Tbx
            // 
            this.UI_ValueToSearch_Tbx.Location = new System.Drawing.Point(566, 115);
            this.UI_ValueToSearch_Tbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UI_ValueToSearch_Tbx.Name = "UI_ValueToSearch_Tbx";
            this.UI_ValueToSearch_Tbx.Size = new System.Drawing.Size(183, 26);
            this.UI_ValueToSearch_Tbx.TabIndex = 2;
            // 
            // UI_PerformSearch_Btn
            // 
            this.UI_PerformSearch_Btn.Location = new System.Drawing.Point(431, 197);
            this.UI_PerformSearch_Btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UI_PerformSearch_Btn.Name = "UI_PerformSearch_Btn";
            this.UI_PerformSearch_Btn.Size = new System.Drawing.Size(318, 65);
            this.UI_PerformSearch_Btn.TabIndex = 5;
            this.UI_PerformSearch_Btn.Text = "Perform Search";
            this.UI_PerformSearch_Btn.UseVisualStyleBackColor = true;
            // 
            // UI_Result_Tbx
            // 
            this.UI_Result_Tbx.Location = new System.Drawing.Point(502, 321);
            this.UI_Result_Tbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UI_Result_Tbx.Name = "UI_Result_Tbx";
            this.UI_Result_Tbx.ReadOnly = true;
            this.UI_Result_Tbx.Size = new System.Drawing.Size(247, 26);
            this.UI_Result_Tbx.TabIndex = 6;
            // 
            // UI_DataList_Lbl
            // 
            this.UI_DataList_Lbl.AutoSize = true;
            this.UI_DataList_Lbl.Location = new System.Drawing.Point(165, 55);
            this.UI_DataList_Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UI_DataList_Lbl.Name = "UI_DataList_Lbl";
            this.UI_DataList_Lbl.Size = new System.Drawing.Size(73, 20);
            this.UI_DataList_Lbl.TabIndex = 7;
            this.UI_DataList_Lbl.Text = "Data List";
            // 
            // UI_ValueToSearch_Lbl
            // 
            this.UI_ValueToSearch_Lbl.AutoSize = true;
            this.UI_ValueToSearch_Lbl.Location = new System.Drawing.Point(427, 121);
            this.UI_ValueToSearch_Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UI_ValueToSearch_Lbl.Name = "UI_ValueToSearch_Lbl";
            this.UI_ValueToSearch_Lbl.Size = new System.Drawing.Size(131, 20);
            this.UI_ValueToSearch_Lbl.TabIndex = 9;
            this.UI_ValueToSearch_Lbl.Text = "Value To Search:";
            // 
            // UI_Results_Lbl
            // 
            this.UI_Results_Lbl.AutoSize = true;
            this.UI_Results_Lbl.Location = new System.Drawing.Point(427, 324);
            this.UI_Results_Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UI_Results_Lbl.Name = "UI_Results_Lbl";
            this.UI_Results_Lbl.Size = new System.Drawing.Size(67, 20);
            this.UI_Results_Lbl.TabIndex = 10;
            this.UI_Results_Lbl.Text = "Results:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 434);
            this.Controls.Add(this.UI_Results_Lbl);
            this.Controls.Add(this.UI_ValueToSearch_Lbl);
            this.Controls.Add(this.UI_DataList_Lbl);
            this.Controls.Add(this.UI_Result_Tbx);
            this.Controls.Add(this.UI_PerformSearch_Btn);
            this.Controls.Add(this.UI_ValueToSearch_Tbx);
            this.Controls.Add(this.UI_DataList_Lbx);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox UI_DataList_Lbx;
        private System.Windows.Forms.TextBox UI_ValueToSearch_Tbx;
        private System.Windows.Forms.Button UI_PerformSearch_Btn;
        private System.Windows.Forms.TextBox UI_Result_Tbx;
        private System.Windows.Forms.Label UI_DataList_Lbl;
        private System.Windows.Forms.Label UI_ValueToSearch_Lbl;
        private System.Windows.Forms.Label UI_Results_Lbl;
    }
}

