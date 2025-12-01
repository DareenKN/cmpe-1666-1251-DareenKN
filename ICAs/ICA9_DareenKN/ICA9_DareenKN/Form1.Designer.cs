namespace ICA9_DareenKN
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UI_DisplayStringRecursion_Tbx = new System.Windows.Forms.TextBox();
            this.UI_RecReverse_Btn = new System.Windows.Forms.Button();
            this.UI_RecShow_Btn = new System.Windows.Forms.Button();
            this.UI_StringRecursion_Tbx = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UI_DisplayFactors_Tbx = new System.Windows.Forms.TextBox();
            this.UI_FindFactors_Btn = new System.Windows.Forms.Button();
            this.UI_FactorFinder_Nud = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.UI_DisplayBinary_Tbx = new System.Windows.Forms.TextBox();
            this.UI_FindUppercase_Btn = new System.Windows.Forms.Button();
            this.UI_BinayHunterInput_Tbx = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UI_FactorFinder_Nud)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UI_DisplayStringRecursion_Tbx);
            this.groupBox1.Controls.Add(this.UI_RecReverse_Btn);
            this.groupBox1.Controls.Add(this.UI_RecShow_Btn);
            this.groupBox1.Controls.Add(this.UI_StringRecursion_Tbx);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "String Recursion";
            // 
            // UI_DisplayStringRecursion_Tbx
            // 
            this.UI_DisplayStringRecursion_Tbx.Location = new System.Drawing.Point(9, 89);
            this.UI_DisplayStringRecursion_Tbx.Name = "UI_DisplayStringRecursion_Tbx";
            this.UI_DisplayStringRecursion_Tbx.ReadOnly = true;
            this.UI_DisplayStringRecursion_Tbx.Size = new System.Drawing.Size(418, 22);
            this.UI_DisplayStringRecursion_Tbx.TabIndex = 3;
            // 
            // UI_RecReverse_Btn
            // 
            this.UI_RecReverse_Btn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.UI_RecReverse_Btn.Location = new System.Drawing.Point(148, 55);
            this.UI_RecReverse_Btn.Name = "UI_RecReverse_Btn";
            this.UI_RecReverse_Btn.Size = new System.Drawing.Size(131, 27);
            this.UI_RecReverse_Btn.TabIndex = 2;
            this.UI_RecReverse_Btn.Text = "Rec Reverse";
            this.UI_RecReverse_Btn.UseVisualStyleBackColor = false;
            this.UI_RecReverse_Btn.Click += new System.EventHandler(this.UI_RecReverse_Btn_Click);
            // 
            // UI_RecShow_Btn
            // 
            this.UI_RecShow_Btn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.UI_RecShow_Btn.Location = new System.Drawing.Point(9, 55);
            this.UI_RecShow_Btn.Name = "UI_RecShow_Btn";
            this.UI_RecShow_Btn.Size = new System.Drawing.Size(131, 27);
            this.UI_RecShow_Btn.TabIndex = 1;
            this.UI_RecShow_Btn.Text = "Rec Show";
            this.UI_RecShow_Btn.UseVisualStyleBackColor = false;
            this.UI_RecShow_Btn.Click += new System.EventHandler(this.UI_RecShow_Btn_Click);
            // 
            // UI_StringRecursion_Tbx
            // 
            this.UI_StringRecursion_Tbx.Location = new System.Drawing.Point(9, 26);
            this.UI_StringRecursion_Tbx.Name = "UI_StringRecursion_Tbx";
            this.UI_StringRecursion_Tbx.Size = new System.Drawing.Size(418, 22);
            this.UI_StringRecursion_Tbx.TabIndex = 0;
            this.UI_StringRecursion_Tbx.Text = "Put your test string here!";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UI_DisplayFactors_Tbx);
            this.groupBox2.Controls.Add(this.UI_FindFactors_Btn);
            this.groupBox2.Controls.Add(this.UI_FactorFinder_Nud);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 128);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Factor Finder";
            // 
            // UI_DisplayFactors_Tbx
            // 
            this.UI_DisplayFactors_Tbx.Location = new System.Drawing.Point(9, 90);
            this.UI_DisplayFactors_Tbx.Name = "UI_DisplayFactors_Tbx";
            this.UI_DisplayFactors_Tbx.ReadOnly = true;
            this.UI_DisplayFactors_Tbx.Size = new System.Drawing.Size(418, 22);
            this.UI_DisplayFactors_Tbx.TabIndex = 5;
            // 
            // UI_FindFactors_Btn
            // 
            this.UI_FindFactors_Btn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.UI_FindFactors_Btn.Location = new System.Drawing.Point(9, 57);
            this.UI_FindFactors_Btn.Name = "UI_FindFactors_Btn";
            this.UI_FindFactors_Btn.Size = new System.Drawing.Size(131, 27);
            this.UI_FindFactors_Btn.TabIndex = 4;
            this.UI_FindFactors_Btn.Text = "Find Factors";
            this.UI_FindFactors_Btn.UseVisualStyleBackColor = false;
            this.UI_FindFactors_Btn.Click += new System.EventHandler(this.UI_FindFactors_Btn_Click);
            // 
            // UI_FactorFinder_Nud
            // 
            this.UI_FactorFinder_Nud.Location = new System.Drawing.Point(9, 29);
            this.UI_FactorFinder_Nud.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.UI_FactorFinder_Nud.Name = "UI_FactorFinder_Nud";
            this.UI_FactorFinder_Nud.Size = new System.Drawing.Size(131, 22);
            this.UI_FactorFinder_Nud.TabIndex = 0;
            this.UI_FactorFinder_Nud.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.UI_DisplayBinary_Tbx);
            this.groupBox3.Controls.Add(this.UI_FindUppercase_Btn);
            this.groupBox3.Controls.Add(this.UI_BinayHunterInput_Tbx);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(15, 298);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(440, 128);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Binary Hunter";
            // 
            // UI_DisplayBinary_Tbx
            // 
            this.UI_DisplayBinary_Tbx.Location = new System.Drawing.Point(9, 88);
            this.UI_DisplayBinary_Tbx.Name = "UI_DisplayBinary_Tbx";
            this.UI_DisplayBinary_Tbx.ReadOnly = true;
            this.UI_DisplayBinary_Tbx.Size = new System.Drawing.Size(418, 22);
            this.UI_DisplayBinary_Tbx.TabIndex = 6;
            // 
            // UI_FindUppercase_Btn
            // 
            this.UI_FindUppercase_Btn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.UI_FindUppercase_Btn.Location = new System.Drawing.Point(9, 52);
            this.UI_FindUppercase_Btn.Name = "UI_FindUppercase_Btn";
            this.UI_FindUppercase_Btn.Size = new System.Drawing.Size(131, 27);
            this.UI_FindUppercase_Btn.TabIndex = 5;
            this.UI_FindUppercase_Btn.Text = "Find Uppercase";
            this.UI_FindUppercase_Btn.UseVisualStyleBackColor = false;
            this.UI_FindUppercase_Btn.Click += new System.EventHandler(this.UI_FindUppercase_Btn_Click);
            // 
            // UI_BinayHunterInput_Tbx
            // 
            this.UI_BinayHunterInput_Tbx.Location = new System.Drawing.Point(9, 21);
            this.UI_BinayHunterInput_Tbx.Name = "UI_BinayHunterInput_Tbx";
            this.UI_BinayHunterInput_Tbx.Size = new System.Drawing.Size(418, 22);
            this.UI_BinayHunterInput_Tbx.TabIndex = 4;
            this.UI_BinayHunterInput_Tbx.Text = "This Is a Test of the EARLY warning system!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 449);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(488, 488);
            this.Name = "Form1";
            this.Text = "ICA9_Basic Recurson Sandbox";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UI_FactorFinder_Nud)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button UI_RecReverse_Btn;
        private System.Windows.Forms.Button UI_RecShow_Btn;
        private System.Windows.Forms.TextBox UI_StringRecursion_Tbx;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox UI_DisplayStringRecursion_Tbx;
        private System.Windows.Forms.NumericUpDown UI_FactorFinder_Nud;
        private System.Windows.Forms.TextBox UI_DisplayFactors_Tbx;
        private System.Windows.Forms.Button UI_FindFactors_Btn;
        private System.Windows.Forms.TextBox UI_DisplayBinary_Tbx;
        private System.Windows.Forms.Button UI_FindUppercase_Btn;
        private System.Windows.Forms.TextBox UI_BinayHunterInput_Tbx;
    }
}

