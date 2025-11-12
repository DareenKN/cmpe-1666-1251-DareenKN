namespace ICA11_DareenKN
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UI_OrdersOfEntry_Lbx = new System.Windows.Forms.ListBox();
            this.UI_SortedNames_Lbx = new System.Windows.Forms.ListBox();
            this.UI_InputName_Tbx = new System.Windows.Forms.TextBox();
            this.UI_AddName_Btn = new System.Windows.Forms.Button();
            this.UI_Searchname_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of Names (Orders of Entry)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(457, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "List of Names (Sorted)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name:";
            // 
            // UI_OrdersOfEntry_Lbx
            // 
            this.UI_OrdersOfEntry_Lbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.UI_OrdersOfEntry_Lbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.UI_OrdersOfEntry_Lbx.FormattingEnabled = true;
            this.UI_OrdersOfEntry_Lbx.Location = new System.Drawing.Point(23, 41);
            this.UI_OrdersOfEntry_Lbx.Name = "UI_OrdersOfEntry_Lbx";
            this.UI_OrdersOfEntry_Lbx.Size = new System.Drawing.Size(166, 290);
            this.UI_OrdersOfEntry_Lbx.TabIndex = 3;
            this.UI_OrdersOfEntry_Lbx.TabStop = false;
            // 
            // UI_SortedNames_Lbx
            // 
            this.UI_SortedNames_Lbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.UI_SortedNames_Lbx.FormattingEnabled = true;
            this.UI_SortedNames_Lbx.Location = new System.Drawing.Point(453, 41);
            this.UI_SortedNames_Lbx.Name = "UI_SortedNames_Lbx";
            this.UI_SortedNames_Lbx.Size = new System.Drawing.Size(166, 290);
            this.UI_SortedNames_Lbx.TabIndex = 4;
            this.UI_SortedNames_Lbx.TabStop = false;
            // 
            // UI_InputName_Tbx
            // 
            this.UI_InputName_Tbx.AcceptsReturn = true;
            this.UI_InputName_Tbx.Location = new System.Drawing.Point(259, 55);
            this.UI_InputName_Tbx.Name = "UI_InputName_Tbx";
            this.UI_InputName_Tbx.Size = new System.Drawing.Size(175, 20);
            this.UI_InputName_Tbx.TabIndex = 1;
            // 
            // UI_AddName_Btn
            // 
            this.UI_AddName_Btn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.UI_AddName_Btn.Location = new System.Drawing.Point(266, 113);
            this.UI_AddName_Btn.Name = "UI_AddName_Btn";
            this.UI_AddName_Btn.Size = new System.Drawing.Size(110, 34);
            this.UI_AddName_Btn.TabIndex = 2;
            this.UI_AddName_Btn.Text = "Add Name";
            this.UI_AddName_Btn.UseVisualStyleBackColor = false;
            this.UI_AddName_Btn.Click += new System.EventHandler(this.UI_AddName_Btn_Click);
            // 
            // UI_Searchname_Btn
            // 
            this.UI_Searchname_Btn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.UI_Searchname_Btn.Location = new System.Drawing.Point(266, 162);
            this.UI_Searchname_Btn.Name = "UI_Searchname_Btn";
            this.UI_Searchname_Btn.Size = new System.Drawing.Size(110, 34);
            this.UI_Searchname_Btn.TabIndex = 3;
            this.UI_Searchname_Btn.Text = "Search";
            this.UI_Searchname_Btn.UseVisualStyleBackColor = false;
            this.UI_Searchname_Btn.Click += new System.EventHandler(this.UI_Searchname_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 351);
            this.Controls.Add(this.UI_Searchname_Btn);
            this.Controls.Add(this.UI_AddName_Btn);
            this.Controls.Add(this.UI_InputName_Tbx);
            this.Controls.Add(this.UI_SortedNames_Lbx);
            this.Controls.Add(this.UI_OrdersOfEntry_Lbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(660, 390);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox UI_OrdersOfEntry_Lbx;
        private System.Windows.Forms.ListBox UI_SortedNames_Lbx;
        private System.Windows.Forms.TextBox UI_InputName_Tbx;
        private System.Windows.Forms.Button UI_AddName_Btn;
        private System.Windows.Forms.Button UI_Searchname_Btn;
    }
}

