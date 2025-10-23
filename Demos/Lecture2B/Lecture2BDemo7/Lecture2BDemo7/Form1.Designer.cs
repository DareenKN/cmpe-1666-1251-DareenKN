namespace Lecture2BDemo7
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
            this.UI_Item1Cost_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Item2Cost_Tbx = new System.Windows.Forms.TextBox();
            this.UI_TotalCost_Tbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UI_GST_Cbx = new System.Windows.Forms.CheckBox();
            this.UI_TotalCost_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI_Item1Cost_Tbx
            // 
            this.UI_Item1Cost_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Item1Cost_Tbx.Location = new System.Drawing.Point(375, 106);
            this.UI_Item1Cost_Tbx.Name = "UI_Item1Cost_Tbx";
            this.UI_Item1Cost_Tbx.Size = new System.Drawing.Size(149, 22);
            this.UI_Item1Cost_Tbx.TabIndex = 0;
            // 
            // UI_Item2Cost_Tbx
            // 
            this.UI_Item2Cost_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Item2Cost_Tbx.Location = new System.Drawing.Point(375, 151);
            this.UI_Item2Cost_Tbx.Name = "UI_Item2Cost_Tbx";
            this.UI_Item2Cost_Tbx.Size = new System.Drawing.Size(149, 22);
            this.UI_Item2Cost_Tbx.TabIndex = 1;
            // 
            // UI_TotalCost_Tbx
            // 
            this.UI_TotalCost_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_TotalCost_Tbx.Location = new System.Drawing.Point(375, 324);
            this.UI_TotalCost_Tbx.Name = "UI_TotalCost_Tbx";
            this.UI_TotalCost_Tbx.ReadOnly = true;
            this.UI_TotalCost_Tbx.Size = new System.Drawing.Size(149, 22);
            this.UI_TotalCost_Tbx.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Item 1 Cost ($):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Item 2 Cost($):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(264, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total Cost($):";
            // 
            // UI_GST_Cbx
            // 
            this.UI_GST_Cbx.AutoSize = true;
            this.UI_GST_Cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_GST_Cbx.Location = new System.Drawing.Point(285, 198);
            this.UI_GST_Cbx.Name = "UI_GST_Cbx";
            this.UI_GST_Cbx.Size = new System.Drawing.Size(115, 20);
            this.UI_GST_Cbx.TabIndex = 6;
            this.UI_GST_Cbx.Text = " Include GST";
            this.UI_GST_Cbx.UseVisualStyleBackColor = true;
            this.UI_GST_Cbx.CheckedChanged += new System.EventHandler(this.UI_GST_Cbx_CheckedChanged);
            // 
            // UI_TotalCost_btn
            // 
            this.UI_TotalCost_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_TotalCost_btn.Location = new System.Drawing.Point(285, 238);
            this.UI_TotalCost_btn.Name = "UI_TotalCost_btn";
            this.UI_TotalCost_btn.Size = new System.Drawing.Size(239, 55);
            this.UI_TotalCost_btn.TabIndex = 7;
            this.UI_TotalCost_btn.Text = "Calculate Total Cost";
            this.UI_TotalCost_btn.UseVisualStyleBackColor = true;
            this.UI_TotalCost_btn.Click += new System.EventHandler(this.UI_TotalCost_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_TotalCost_btn);
            this.Controls.Add(this.UI_GST_Cbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_TotalCost_Tbx);
            this.Controls.Add(this.UI_Item2Cost_Tbx);
            this.Controls.Add(this.UI_Item1Cost_Tbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UI_Item1Cost_Tbx;
        private System.Windows.Forms.TextBox UI_Item2Cost_Tbx;
        private System.Windows.Forms.TextBox UI_TotalCost_Tbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox UI_GST_Cbx;
        private System.Windows.Forms.Button UI_TotalCost_btn;
    }
}

