namespace ICA7_DareenKN
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
            this.UI_DisplayData_Tbx = new System.Windows.Forms.TextBox();
            this.UI_DisplayCount_Btn = new System.Windows.Forms.Button();
            this.UI_DisplayMin_Btn = new System.Windows.Forms.Button();
            this.UI_DisplayMax_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UI_NumOfVal_Tbx = new System.Windows.Forms.TextBox();
            this.UI_MinVal_Tbx = new System.Windows.Forms.TextBox();
            this.UI_MaxVal_Tbx = new System.Windows.Forms.TextBox();
            this.UI_DragAndDrop_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_DisplayData_Tbx
            // 
            this.UI_DisplayData_Tbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.UI_DisplayData_Tbx.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UI_DisplayData_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_DisplayData_Tbx.Location = new System.Drawing.Point(35, 120);
            this.UI_DisplayData_Tbx.Multiline = true;
            this.UI_DisplayData_Tbx.Name = "UI_DisplayData_Tbx";
            this.UI_DisplayData_Tbx.ReadOnly = true;
            this.UI_DisplayData_Tbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UI_DisplayData_Tbx.Size = new System.Drawing.Size(233, 290);
            this.UI_DisplayData_Tbx.TabIndex = 0;
            // 
            // UI_DisplayCount_Btn
            // 
            this.UI_DisplayCount_Btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.UI_DisplayCount_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_DisplayCount_Btn.Location = new System.Drawing.Point(307, 120);
            this.UI_DisplayCount_Btn.Name = "UI_DisplayCount_Btn";
            this.UI_DisplayCount_Btn.Size = new System.Drawing.Size(142, 42);
            this.UI_DisplayCount_Btn.TabIndex = 1;
            this.UI_DisplayCount_Btn.Text = "Display Count";
            this.UI_DisplayCount_Btn.UseVisualStyleBackColor = false;
            this.UI_DisplayCount_Btn.Click += new System.EventHandler(this.UI_DisplayCount_Btn_Click);
            // 
            // UI_DisplayMin_Btn
            // 
            this.UI_DisplayMin_Btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.UI_DisplayMin_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_DisplayMin_Btn.Location = new System.Drawing.Point(307, 168);
            this.UI_DisplayMin_Btn.Name = "UI_DisplayMin_Btn";
            this.UI_DisplayMin_Btn.Size = new System.Drawing.Size(142, 42);
            this.UI_DisplayMin_Btn.TabIndex = 2;
            this.UI_DisplayMin_Btn.Text = "Display Minimum";
            this.UI_DisplayMin_Btn.UseVisualStyleBackColor = false;
            this.UI_DisplayMin_Btn.Click += new System.EventHandler(this.UI_DisplayMin_Btn_Click);
            // 
            // UI_DisplayMax_Btn
            // 
            this.UI_DisplayMax_Btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.UI_DisplayMax_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_DisplayMax_Btn.Location = new System.Drawing.Point(307, 216);
            this.UI_DisplayMax_Btn.Name = "UI_DisplayMax_Btn";
            this.UI_DisplayMax_Btn.Size = new System.Drawing.Size(142, 42);
            this.UI_DisplayMax_Btn.TabIndex = 3;
            this.UI_DisplayMax_Btn.Text = "Display Maximum";
            this.UI_DisplayMax_Btn.UseVisualStyleBackColor = false;
            this.UI_DisplayMax_Btn.Click += new System.EventHandler(this.UI_DisplayMax_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(485, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number of Values:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(485, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Minimum Value:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(485, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Maximum Value:";
            // 
            // UI_NumOfVal_Tbx
            // 
            this.UI_NumOfVal_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_NumOfVal_Tbx.Location = new System.Drawing.Point(637, 130);
            this.UI_NumOfVal_Tbx.Name = "UI_NumOfVal_Tbx";
            this.UI_NumOfVal_Tbx.Size = new System.Drawing.Size(88, 22);
            this.UI_NumOfVal_Tbx.TabIndex = 7;
            // 
            // UI_MinVal_Tbx
            // 
            this.UI_MinVal_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_MinVal_Tbx.Location = new System.Drawing.Point(637, 178);
            this.UI_MinVal_Tbx.Name = "UI_MinVal_Tbx";
            this.UI_MinVal_Tbx.Size = new System.Drawing.Size(88, 22);
            this.UI_MinVal_Tbx.TabIndex = 8;
            // 
            // UI_MaxVal_Tbx
            // 
            this.UI_MaxVal_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_MaxVal_Tbx.Location = new System.Drawing.Point(637, 226);
            this.UI_MaxVal_Tbx.Name = "UI_MaxVal_Tbx";
            this.UI_MaxVal_Tbx.Size = new System.Drawing.Size(88, 22);
            this.UI_MaxVal_Tbx.TabIndex = 9;
            // 
            // UI_DragAndDrop_Lbl
            // 
            this.UI_DragAndDrop_Lbl.AllowDrop = true;
            this.UI_DragAndDrop_Lbl.BackColor = System.Drawing.SystemColors.HotTrack;
            this.UI_DragAndDrop_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_DragAndDrop_Lbl.Location = new System.Drawing.Point(89, 46);
            this.UI_DragAndDrop_Lbl.Name = "UI_DragAndDrop_Lbl";
            this.UI_DragAndDrop_Lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UI_DragAndDrop_Lbl.Size = new System.Drawing.Size(125, 62);
            this.UI_DragAndDrop_Lbl.TabIndex = 10;
            this.UI_DragAndDrop_Lbl.Text = "Drag Drop Your File On the Text Box";
            this.UI_DragAndDrop_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UI_DragAndDrop_Lbl.DragDrop += new System.Windows.Forms.DragEventHandler(this.UI_DragAndDrop_Lbl_DragDrop);
            this.UI_DragAndDrop_Lbl.DragEnter += new System.Windows.Forms.DragEventHandler(this.UI_DragAndDrop_Lbl_DragEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(769, 446);
            this.Controls.Add(this.UI_DragAndDrop_Lbl);
            this.Controls.Add(this.UI_MaxVal_Tbx);
            this.Controls.Add(this.UI_MinVal_Tbx);
            this.Controls.Add(this.UI_NumOfVal_Tbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_DisplayMax_Btn);
            this.Controls.Add(this.UI_DisplayMin_Btn);
            this.Controls.Add(this.UI_DisplayCount_Btn);
            this.Controls.Add(this.UI_DisplayData_Tbx);
            this.MinimumSize = new System.Drawing.Size(785, 485);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UI_DisplayData_Tbx;
        private System.Windows.Forms.Button UI_DisplayCount_Btn;
        private System.Windows.Forms.Button UI_DisplayMin_Btn;
        private System.Windows.Forms.Button UI_DisplayMax_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UI_NumOfVal_Tbx;
        private System.Windows.Forms.TextBox UI_MinVal_Tbx;
        private System.Windows.Forms.TextBox UI_MaxVal_Tbx;
        private System.Windows.Forms.Label UI_DragAndDrop_Lbl;
    }
}

