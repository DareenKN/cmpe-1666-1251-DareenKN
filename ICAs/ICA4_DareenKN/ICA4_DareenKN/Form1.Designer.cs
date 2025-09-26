namespace ICA4_DareenKN
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
            this.UI_Name_Lbl = new System.Windows.Forms.Label();
            this.UI_InputName_Tbx = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UI_Sports_Radio = new System.Windows.Forms.RadioButton();
            this.UI_Midsize_Radio = new System.Windows.Forms.RadioButton();
            this.UI_Small_Radio = new System.Windows.Forms.RadioButton();
            this.UI_Insurance_Cbx = new System.Windows.Forms.CheckBox();
            this.UI_AMADiscount_Cbx = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UI_TotalOutput_Lbl = new System.Windows.Forms.Label();
            this.UI_NumDays_Nud = new System.Windows.Forms.NumericUpDown();
            this.UI_Controls_Panel = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UI_NumDays_Nud)).BeginInit();
            this.UI_Controls_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_Name_Lbl
            // 
            this.UI_Name_Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_Name_Lbl.AutoSize = true;
            this.UI_Name_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Name_Lbl.Location = new System.Drawing.Point(65, 56);
            this.UI_Name_Lbl.Name = "UI_Name_Lbl";
            this.UI_Name_Lbl.Size = new System.Drawing.Size(44, 16);
            this.UI_Name_Lbl.TabIndex = 0;
            this.UI_Name_Lbl.Text = "Name";
            // 
            // UI_InputName_Tbx
            // 
            this.UI_InputName_Tbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_InputName_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_InputName_Tbx.Location = new System.Drawing.Point(115, 53);
            this.UI_InputName_Tbx.Name = "UI_InputName_Tbx";
            this.UI_InputName_Tbx.Size = new System.Drawing.Size(365, 22);
            this.UI_InputName_Tbx.TabIndex = 1;
            this.UI_InputName_Tbx.TextChanged += new System.EventHandler(this.UI_InputName_Tbx_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UI_Sports_Radio);
            this.groupBox1.Controls.Add(this.UI_Midsize_Radio);
            this.groupBox1.Controls.Add(this.UI_Small_Radio);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(6, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Car Type";
            // 
            // UI_Sports_Radio
            // 
            this.UI_Sports_Radio.AutoSize = true;
            this.UI_Sports_Radio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UI_Sports_Radio.Location = new System.Drawing.Point(15, 87);
            this.UI_Sports_Radio.Name = "UI_Sports_Radio";
            this.UI_Sports_Radio.Size = new System.Drawing.Size(132, 20);
            this.UI_Sports_Radio.TabIndex = 4;
            this.UI_Sports_Radio.TabStop = true;
            this.UI_Sports_Radio.Text = "Sports $60.00/day";
            this.UI_Sports_Radio.UseVisualStyleBackColor = true;
            this.UI_Sports_Radio.CheckedChanged += new System.EventHandler(this.UI_Radio_CheckedChanged);
            // 
            // UI_Midsize_Radio
            // 
            this.UI_Midsize_Radio.AutoSize = true;
            this.UI_Midsize_Radio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UI_Midsize_Radio.Location = new System.Drawing.Point(15, 61);
            this.UI_Midsize_Radio.Name = "UI_Midsize_Radio";
            this.UI_Midsize_Radio.Size = new System.Drawing.Size(139, 20);
            this.UI_Midsize_Radio.TabIndex = 3;
            this.UI_Midsize_Radio.TabStop = true;
            this.UI_Midsize_Radio.Text = "Midsize $50.00/day";
            this.UI_Midsize_Radio.UseVisualStyleBackColor = true;
            this.UI_Midsize_Radio.CheckedChanged += new System.EventHandler(this.UI_Radio_CheckedChanged);
            // 
            // UI_Small_Radio
            // 
            this.UI_Small_Radio.AutoSize = true;
            this.UI_Small_Radio.Checked = true;
            this.UI_Small_Radio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UI_Small_Radio.Location = new System.Drawing.Point(15, 35);
            this.UI_Small_Radio.Name = "UI_Small_Radio";
            this.UI_Small_Radio.Size = new System.Drawing.Size(127, 20);
            this.UI_Small_Radio.TabIndex = 2;
            this.UI_Small_Radio.TabStop = true;
            this.UI_Small_Radio.Text = "Small $40.00/day";
            this.UI_Small_Radio.UseVisualStyleBackColor = true;
            this.UI_Small_Radio.CheckedChanged += new System.EventHandler(this.UI_Radio_CheckedChanged);
            // 
            // UI_Insurance_Cbx
            // 
            this.UI_Insurance_Cbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_Insurance_Cbx.AutoSize = true;
            this.UI_Insurance_Cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Insurance_Cbx.Location = new System.Drawing.Point(327, 30);
            this.UI_Insurance_Cbx.Name = "UI_Insurance_Cbx";
            this.UI_Insurance_Cbx.Size = new System.Drawing.Size(152, 20);
            this.UI_Insurance_Cbx.TabIndex = 5;
            this.UI_Insurance_Cbx.Text = "Insurance $15.00/day";
            this.UI_Insurance_Cbx.UseVisualStyleBackColor = true;
            // 
            // UI_AMADiscount_Cbx
            // 
            this.UI_AMADiscount_Cbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_AMADiscount_Cbx.AutoSize = true;
            this.UI_AMADiscount_Cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_AMADiscount_Cbx.Location = new System.Drawing.Point(327, 56);
            this.UI_AMADiscount_Cbx.Name = "UI_AMADiscount_Cbx";
            this.UI_AMADiscount_Cbx.Size = new System.Drawing.Size(146, 20);
            this.UI_AMADiscount_Cbx.TabIndex = 6;
            this.UI_AMADiscount_Cbx.Text = "AMA Discount - 10%";
            this.UI_AMADiscount_Cbx.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(324, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of Days";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(188, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UI_TotalOutput_Lbl
            // 
            this.UI_TotalOutput_Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_TotalOutput_Lbl.AutoSize = true;
            this.UI_TotalOutput_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_TotalOutput_Lbl.Location = new System.Drawing.Point(274, 198);
            this.UI_TotalOutput_Lbl.Name = "UI_TotalOutput_Lbl";
            this.UI_TotalOutput_Lbl.Size = new System.Drawing.Size(87, 31);
            this.UI_TotalOutput_Lbl.TabIndex = 8;
            this.UI_TotalOutput_Lbl.Text = "$0.00";
            this.UI_TotalOutput_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UI_NumDays_Nud
            // 
            this.UI_NumDays_Nud.AllowDrop = true;
            this.UI_NumDays_Nud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_NumDays_Nud.Location = new System.Drawing.Point(434, 95);
            this.UI_NumDays_Nud.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.UI_NumDays_Nud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UI_NumDays_Nud.Name = "UI_NumDays_Nud";
            this.UI_NumDays_Nud.Size = new System.Drawing.Size(53, 20);
            this.UI_NumDays_Nud.TabIndex = 7;
            this.UI_NumDays_Nud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // UI_Controls_Panel
            // 
            this.UI_Controls_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_Controls_Panel.Controls.Add(this.UI_NumDays_Nud);
            this.UI_Controls_Panel.Controls.Add(this.UI_TotalOutput_Lbl);
            this.UI_Controls_Panel.Controls.Add(this.label3);
            this.UI_Controls_Panel.Controls.Add(this.label2);
            this.UI_Controls_Panel.Controls.Add(this.UI_AMADiscount_Cbx);
            this.UI_Controls_Panel.Controls.Add(this.UI_Insurance_Cbx);
            this.UI_Controls_Panel.Controls.Add(this.groupBox1);
            this.UI_Controls_Panel.Enabled = false;
            this.UI_Controls_Panel.Location = new System.Drawing.Point(16, 94);
            this.UI_Controls_Panel.Name = "UI_Controls_Panel";
            this.UI_Controls_Panel.Size = new System.Drawing.Size(499, 259);
            this.UI_Controls_Panel.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 369);
            this.Controls.Add(this.UI_Controls_Panel);
            this.Controls.Add(this.UI_InputName_Tbx);
            this.Controls.Add(this.UI_Name_Lbl);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Form1";
            this.Text = "Car Rental";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UI_NumDays_Nud)).EndInit();
            this.UI_Controls_Panel.ResumeLayout(false);
            this.UI_Controls_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UI_Name_Lbl;
        private System.Windows.Forms.TextBox UI_InputName_Tbx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton UI_Sports_Radio;
        private System.Windows.Forms.RadioButton UI_Midsize_Radio;
        private System.Windows.Forms.RadioButton UI_Small_Radio;
        private System.Windows.Forms.CheckBox UI_Insurance_Cbx;
        private System.Windows.Forms.CheckBox UI_AMADiscount_Cbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label UI_TotalOutput_Lbl;
        private System.Windows.Forms.NumericUpDown UI_NumDays_Nud;
        private System.Windows.Forms.Panel UI_Controls_Panel;
    }
}

