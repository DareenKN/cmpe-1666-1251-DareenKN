namespace ICA14_DareenKN
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
            this.label1 = new System.Windows.Forms.Label();
            this.UI_InputString_Tbx = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UI_Flipcase_RadioBtn = new System.Windows.Forms.RadioButton();
            this.UI_Lowercase_RadioBtn = new System.Windows.Forms.RadioButton();
            this.UI_Uppercase_RadioBtn = new System.Windows.Forms.RadioButton();
            this.UI_OutputString_Tbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input String:";
            // 
            // UI_InputString_Tbx
            // 
            this.UI_InputString_Tbx.Location = new System.Drawing.Point(23, 29);
            this.UI_InputString_Tbx.Name = "UI_InputString_Tbx";
            this.UI_InputString_Tbx.Size = new System.Drawing.Size(499, 20);
            this.UI_InputString_Tbx.TabIndex = 3;
            this.UI_InputString_Tbx.Text = "This is a TEST of the FlipPY Option!";
            this.UI_InputString_Tbx.TextChanged += new System.EventHandler(this.UI_InputAndCaseRadio_CheckChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.UI_Flipcase_RadioBtn);
            this.groupBox1.Controls.Add(this.UI_Lowercase_RadioBtn);
            this.groupBox1.Controls.Add(this.UI_Uppercase_RadioBtn);
            this.groupBox1.Location = new System.Drawing.Point(23, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 65);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modification Type:";
            // 
            // UI_Flipcase_RadioBtn
            // 
            this.UI_Flipcase_RadioBtn.AutoSize = true;
            this.UI_Flipcase_RadioBtn.Checked = true;
            this.UI_Flipcase_RadioBtn.Location = new System.Drawing.Point(408, 29);
            this.UI_Flipcase_RadioBtn.Name = "UI_Flipcase_RadioBtn";
            this.UI_Flipcase_RadioBtn.Size = new System.Drawing.Size(64, 17);
            this.UI_Flipcase_RadioBtn.TabIndex = 4;
            this.UI_Flipcase_RadioBtn.TabStop = true;
            this.UI_Flipcase_RadioBtn.Text = "Flipcase";
            this.UI_Flipcase_RadioBtn.UseVisualStyleBackColor = true;
            this.UI_Flipcase_RadioBtn.CheckedChanged += new System.EventHandler(this.UI_InputAndCaseRadio_CheckChanged);
            // 
            // UI_Lowercase_RadioBtn
            // 
            this.UI_Lowercase_RadioBtn.AutoSize = true;
            this.UI_Lowercase_RadioBtn.Location = new System.Drawing.Point(189, 29);
            this.UI_Lowercase_RadioBtn.Name = "UI_Lowercase_RadioBtn";
            this.UI_Lowercase_RadioBtn.Size = new System.Drawing.Size(77, 17);
            this.UI_Lowercase_RadioBtn.TabIndex = 3;
            this.UI_Lowercase_RadioBtn.TabStop = true;
            this.UI_Lowercase_RadioBtn.Text = "Lowercase";
            this.UI_Lowercase_RadioBtn.UseVisualStyleBackColor = true;
            this.UI_Lowercase_RadioBtn.CheckedChanged += new System.EventHandler(this.UI_InputAndCaseRadio_CheckChanged);
            // 
            // UI_Uppercase_RadioBtn
            // 
            this.UI_Uppercase_RadioBtn.AutoSize = true;
            this.UI_Uppercase_RadioBtn.Location = new System.Drawing.Point(15, 29);
            this.UI_Uppercase_RadioBtn.Name = "UI_Uppercase_RadioBtn";
            this.UI_Uppercase_RadioBtn.Size = new System.Drawing.Size(77, 17);
            this.UI_Uppercase_RadioBtn.TabIndex = 2;
            this.UI_Uppercase_RadioBtn.TabStop = true;
            this.UI_Uppercase_RadioBtn.Text = "Uppercase";
            this.UI_Uppercase_RadioBtn.UseVisualStyleBackColor = true;
            this.UI_Uppercase_RadioBtn.CheckedChanged += new System.EventHandler(this.UI_InputAndCaseRadio_CheckChanged);
            // 
            // UI_OutputString_Tbx
            // 
            this.UI_OutputString_Tbx.Location = new System.Drawing.Point(23, 149);
            this.UI_OutputString_Tbx.Name = "UI_OutputString_Tbx";
            this.UI_OutputString_Tbx.ReadOnly = true;
            this.UI_OutputString_Tbx.Size = new System.Drawing.Size(499, 20);
            this.UI_OutputString_Tbx.TabIndex = 5;
            this.UI_OutputString_Tbx.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output String:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 179);
            this.Controls.Add(this.UI_OutputString_Tbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UI_InputString_Tbx);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ICA14_DareenKN: StringBender (Early Delegates)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UI_InputString_Tbx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton UI_Uppercase_RadioBtn;
        private System.Windows.Forms.RadioButton UI_Flipcase_RadioBtn;
        private System.Windows.Forms.RadioButton UI_Lowercase_RadioBtn;
        private System.Windows.Forms.TextBox UI_OutputString_Tbx;
        private System.Windows.Forms.Label label2;
    }
}

