namespace ICA8_DareenKN
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
            this.components = new System.ComponentModel.Container();
            this.UI_DragAndDrop_Lbl = new System.Windows.Forms.Label();
            this.UI_SortingTime_Tbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UI_SortValues_Btn = new System.Windows.Forms.Button();
            this.UI_DisplayData_Tbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UI_DisplaySortedData_Tbx = new System.Windows.Forms.TextBox();
            this.UI_SortingMethod_Gbx = new System.Windows.Forms.GroupBox();
            this.UI_InsertionSort_RadioBtn = new System.Windows.Forms.RadioButton();
            this.UI_SelectionSort_RadioBtn = new System.Windows.Forms.RadioButton();
            this.UI_ClearSorted_Btn = new System.Windows.Forms.Button();
            this.UI_SortingTime_Tmr = new System.Windows.Forms.Timer(this.components);
            this.UI_SortingMethod_Gbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_DragAndDrop_Lbl
            // 
            this.UI_DragAndDrop_Lbl.AllowDrop = true;
            this.UI_DragAndDrop_Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UI_DragAndDrop_Lbl.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.UI_DragAndDrop_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_DragAndDrop_Lbl.Location = new System.Drawing.Point(83, 354);
            this.UI_DragAndDrop_Lbl.Name = "UI_DragAndDrop_Lbl";
            this.UI_DragAndDrop_Lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UI_DragAndDrop_Lbl.Size = new System.Drawing.Size(125, 43);
            this.UI_DragAndDrop_Lbl.TabIndex = 21;
            this.UI_DragAndDrop_Lbl.Text = "Drag Drop Your File Here";
            this.UI_DragAndDrop_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UI_DragAndDrop_Lbl.DragDrop += new System.Windows.Forms.DragEventHandler(this.UI_DragAndDrop_Lbl_DragDrop);
            this.UI_DragAndDrop_Lbl.DragEnter += new System.Windows.Forms.DragEventHandler(this.UI_DragAndDrop_Lbl_DragEnter);
            // 
            // UI_SortingTime_Tbx
            // 
            this.UI_SortingTime_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_SortingTime_Tbx.Location = new System.Drawing.Point(345, 278);
            this.UI_SortingTime_Tbx.Name = "UI_SortingTime_Tbx";
            this.UI_SortingTime_Tbx.ReadOnly = true;
            this.UI_SortingTime_Tbx.Size = new System.Drawing.Size(103, 22);
            this.UI_SortingTime_Tbx.TabIndex = 20;
            this.UI_SortingTime_Tbx.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(321, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Sorting Time (Ticks):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Initial Values";
            // 
            // UI_SortValues_Btn
            // 
            this.UI_SortValues_Btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.UI_SortValues_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_SortValues_Btn.Location = new System.Drawing.Point(343, 176);
            this.UI_SortValues_Btn.Name = "UI_SortValues_Btn";
            this.UI_SortValues_Btn.Size = new System.Drawing.Size(106, 36);
            this.UI_SortValues_Btn.TabIndex = 2;
            this.UI_SortValues_Btn.Text = "Sort Values";
            this.UI_SortValues_Btn.UseVisualStyleBackColor = false;
            this.UI_SortValues_Btn.Click += new System.EventHandler(this.UI_SortValues_Btn_Click);
            // 
            // UI_DisplayData_Tbx
            // 
            this.UI_DisplayData_Tbx.AllowDrop = true;
            this.UI_DisplayData_Tbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.UI_DisplayData_Tbx.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UI_DisplayData_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_DisplayData_Tbx.Location = new System.Drawing.Point(29, 47);
            this.UI_DisplayData_Tbx.Multiline = true;
            this.UI_DisplayData_Tbx.Name = "UI_DisplayData_Tbx";
            this.UI_DisplayData_Tbx.ReadOnly = true;
            this.UI_DisplayData_Tbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UI_DisplayData_Tbx.Size = new System.Drawing.Size(233, 290);
            this.UI_DisplayData_Tbx.TabIndex = 11;
            this.UI_DisplayData_Tbx.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(596, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Sorted Values";
            // 
            // UI_DisplaySortedData_Tbx
            // 
            this.UI_DisplaySortedData_Tbx.AllowDrop = true;
            this.UI_DisplaySortedData_Tbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.UI_DisplaySortedData_Tbx.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UI_DisplaySortedData_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_DisplaySortedData_Tbx.Location = new System.Drawing.Point(531, 47);
            this.UI_DisplaySortedData_Tbx.Multiline = true;
            this.UI_DisplaySortedData_Tbx.Name = "UI_DisplaySortedData_Tbx";
            this.UI_DisplaySortedData_Tbx.ReadOnly = true;
            this.UI_DisplaySortedData_Tbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UI_DisplaySortedData_Tbx.Size = new System.Drawing.Size(233, 290);
            this.UI_DisplaySortedData_Tbx.TabIndex = 22;
            this.UI_DisplaySortedData_Tbx.TabStop = false;
            // 
            // UI_SortingMethod_Gbx
            // 
            this.UI_SortingMethod_Gbx.Controls.Add(this.UI_InsertionSort_RadioBtn);
            this.UI_SortingMethod_Gbx.Controls.Add(this.UI_SelectionSort_RadioBtn);
            this.UI_SortingMethod_Gbx.Location = new System.Drawing.Point(327, 76);
            this.UI_SortingMethod_Gbx.Name = "UI_SortingMethod_Gbx";
            this.UI_SortingMethod_Gbx.Size = new System.Drawing.Size(139, 75);
            this.UI_SortingMethod_Gbx.TabIndex = 25;
            this.UI_SortingMethod_Gbx.TabStop = false;
            this.UI_SortingMethod_Gbx.Text = "Sorting Method";
            // 
            // UI_InsertionSort_RadioBtn
            // 
            this.UI_InsertionSort_RadioBtn.AutoSize = true;
            this.UI_InsertionSort_RadioBtn.Location = new System.Drawing.Point(16, 42);
            this.UI_InsertionSort_RadioBtn.Name = "UI_InsertionSort_RadioBtn";
            this.UI_InsertionSort_RadioBtn.Size = new System.Drawing.Size(87, 17);
            this.UI_InsertionSort_RadioBtn.TabIndex = 1;
            this.UI_InsertionSort_RadioBtn.Text = "Insertion Sort";
            this.UI_InsertionSort_RadioBtn.UseVisualStyleBackColor = true;
            // 
            // UI_SelectionSort_RadioBtn
            // 
            this.UI_SelectionSort_RadioBtn.AutoSize = true;
            this.UI_SelectionSort_RadioBtn.Checked = true;
            this.UI_SelectionSort_RadioBtn.Location = new System.Drawing.Point(16, 19);
            this.UI_SelectionSort_RadioBtn.Name = "UI_SelectionSort_RadioBtn";
            this.UI_SelectionSort_RadioBtn.Size = new System.Drawing.Size(91, 17);
            this.UI_SelectionSort_RadioBtn.TabIndex = 1;
            this.UI_SelectionSort_RadioBtn.TabStop = true;
            this.UI_SelectionSort_RadioBtn.Text = "Selection Sort";
            this.UI_SelectionSort_RadioBtn.UseVisualStyleBackColor = true;
            // 
            // UI_ClearSorted_Btn
            // 
            this.UI_ClearSorted_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UI_ClearSorted_Btn.BackColor = System.Drawing.SystemColors.Menu;
            this.UI_ClearSorted_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_ClearSorted_Btn.Location = new System.Drawing.Point(595, 354);
            this.UI_ClearSorted_Btn.Name = "UI_ClearSorted_Btn";
            this.UI_ClearSorted_Btn.Size = new System.Drawing.Size(106, 36);
            this.UI_ClearSorted_Btn.TabIndex = 3;
            this.UI_ClearSorted_Btn.Text = "Clear Sorted";
            this.UI_ClearSorted_Btn.UseVisualStyleBackColor = false;
            this.UI_ClearSorted_Btn.Click += new System.EventHandler(this.UI_ClearSorted_Btn_Click);
            // 
            // UI_SortingTime_Tmr
            // 
            this.UI_SortingTime_Tmr.Tick += new System.EventHandler(this.UI_SortingTime_Tmr_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_ClearSorted_Btn);
            this.Controls.Add(this.UI_SortingMethod_Gbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UI_DisplaySortedData_Tbx);
            this.Controls.Add(this.UI_DragAndDrop_Lbl);
            this.Controls.Add(this.UI_SortingTime_Tbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UI_SortValues_Btn);
            this.Controls.Add(this.UI_DisplayData_Tbx);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "Form1";
            this.UI_SortingMethod_Gbx.ResumeLayout(false);
            this.UI_SortingMethod_Gbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UI_DragAndDrop_Lbl;
        private System.Windows.Forms.TextBox UI_SortingTime_Tbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UI_SortValues_Btn;
        private System.Windows.Forms.TextBox UI_DisplayData_Tbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UI_DisplaySortedData_Tbx;
        private System.Windows.Forms.GroupBox UI_SortingMethod_Gbx;
        private System.Windows.Forms.RadioButton UI_InsertionSort_RadioBtn;
        private System.Windows.Forms.RadioButton UI_SelectionSort_RadioBtn;
        private System.Windows.Forms.Button UI_ClearSorted_Btn;
        private System.Windows.Forms.Timer UI_SortingTime_Tmr;
    }
}

