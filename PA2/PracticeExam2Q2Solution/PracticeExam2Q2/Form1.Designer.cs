namespace PracticeExam2Q2
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
            this.UI_GenValues_Btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.UI_Sort_btn = new System.Windows.Forms.Button();
            this.UI_BubbleSort_Radio = new System.Windows.Forms.RadioButton();
            this.UI_SelectionSort_Radio = new System.Windows.Forms.RadioButton();
            this.UI_Sorting_GBx = new System.Windows.Forms.GroupBox();
            this.UI_QuickSort_Radio = new System.Windows.Forms.RadioButton();
            this.UI_SearchValue_Tbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UI_PerformSearch_Btn = new System.Windows.Forms.Button();
            this.UI_SearchResults_Lbx = new System.Windows.Forms.ListBox();
            this.UI_SearchList_Tbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UI_DisplayList_Btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UI_Unsorted_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Sorted_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Sorting_GBx.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_GenValues_Btn
            // 
            this.UI_GenValues_Btn.Location = new System.Drawing.Point(23, 85);
            this.UI_GenValues_Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_GenValues_Btn.Name = "UI_GenValues_Btn";
            this.UI_GenValues_Btn.Size = new System.Drawing.Size(139, 54);
            this.UI_GenValues_Btn.TabIndex = 0;
            this.UI_GenValues_Btn.Text = "Generate Values";
            this.UI_GenValues_Btn.UseVisualStyleBackColor = true;
            this.UI_GenValues_Btn.Click += new System.EventHandler(this.UI_GenValues_Btn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(60, 530);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // UI_Sort_btn
            // 
            this.UI_Sort_btn.Location = new System.Drawing.Point(29, 374);
            this.UI_Sort_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_Sort_btn.Name = "UI_Sort_btn";
            this.UI_Sort_btn.Size = new System.Drawing.Size(139, 54);
            this.UI_Sort_btn.TabIndex = 4;
            this.UI_Sort_btn.Text = "Sort";
            this.UI_Sort_btn.UseVisualStyleBackColor = true;
            this.UI_Sort_btn.Click += new System.EventHandler(this.UI_Sort_btn_Click);
            // 
            // UI_BubbleSort_Radio
            // 
            this.UI_BubbleSort_Radio.AutoSize = true;
            this.UI_BubbleSort_Radio.Checked = true;
            this.UI_BubbleSort_Radio.Location = new System.Drawing.Point(6, 29);
            this.UI_BubbleSort_Radio.Name = "UI_BubbleSort_Radio";
            this.UI_BubbleSort_Radio.Size = new System.Drawing.Size(80, 17);
            this.UI_BubbleSort_Radio.TabIndex = 6;
            this.UI_BubbleSort_Radio.TabStop = true;
            this.UI_BubbleSort_Radio.Text = "Bubble Sort";
            this.UI_BubbleSort_Radio.UseVisualStyleBackColor = true;
            // 
            // UI_SelectionSort_Radio
            // 
            this.UI_SelectionSort_Radio.AutoSize = true;
            this.UI_SelectionSort_Radio.Location = new System.Drawing.Point(6, 62);
            this.UI_SelectionSort_Radio.Name = "UI_SelectionSort_Radio";
            this.UI_SelectionSort_Radio.Size = new System.Drawing.Size(91, 17);
            this.UI_SelectionSort_Radio.TabIndex = 7;
            this.UI_SelectionSort_Radio.Text = "Selection Sort";
            this.UI_SelectionSort_Radio.UseVisualStyleBackColor = true;
            // 
            // UI_Sorting_GBx
            // 
            this.UI_Sorting_GBx.Controls.Add(this.UI_QuickSort_Radio);
            this.UI_Sorting_GBx.Controls.Add(this.UI_BubbleSort_Radio);
            this.UI_Sorting_GBx.Controls.Add(this.UI_SelectionSort_Radio);
            this.UI_Sorting_GBx.Location = new System.Drawing.Point(23, 229);
            this.UI_Sorting_GBx.Name = "UI_Sorting_GBx";
            this.UI_Sorting_GBx.Size = new System.Drawing.Size(122, 120);
            this.UI_Sorting_GBx.TabIndex = 8;
            this.UI_Sorting_GBx.TabStop = false;
            this.UI_Sorting_GBx.Text = "Sorting Technique";
            // 
            // UI_QuickSort_Radio
            // 
            this.UI_QuickSort_Radio.AutoSize = true;
            this.UI_QuickSort_Radio.Location = new System.Drawing.Point(6, 97);
            this.UI_QuickSort_Radio.Name = "UI_QuickSort_Radio";
            this.UI_QuickSort_Radio.Size = new System.Drawing.Size(75, 17);
            this.UI_QuickSort_Radio.TabIndex = 8;
            this.UI_QuickSort_Radio.Text = "Quick Sort";
            this.UI_QuickSort_Radio.UseVisualStyleBackColor = true;
            // 
            // UI_SearchValue_Tbx
            // 
            this.UI_SearchValue_Tbx.Location = new System.Drawing.Point(144, 159);
            this.UI_SearchValue_Tbx.Name = "UI_SearchValue_Tbx";
            this.UI_SearchValue_Tbx.Size = new System.Drawing.Size(111, 20);
            this.UI_SearchValue_Tbx.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Search Value:";
            // 
            // UI_PerformSearch_Btn
            // 
            this.UI_PerformSearch_Btn.Location = new System.Drawing.Point(59, 192);
            this.UI_PerformSearch_Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_PerformSearch_Btn.Name = "UI_PerformSearch_Btn";
            this.UI_PerformSearch_Btn.Size = new System.Drawing.Size(196, 31);
            this.UI_PerformSearch_Btn.TabIndex = 11;
            this.UI_PerformSearch_Btn.Text = "Perform Search";
            this.UI_PerformSearch_Btn.UseVisualStyleBackColor = true;
            this.UI_PerformSearch_Btn.Click += new System.EventHandler(this.UI_PerformSearch_Btn_Click);
            // 
            // UI_SearchResults_Lbx
            // 
            this.UI_SearchResults_Lbx.FormattingEnabled = true;
            this.UI_SearchResults_Lbx.Location = new System.Drawing.Point(67, 266);
            this.UI_SearchResults_Lbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_SearchResults_Lbx.Name = "UI_SearchResults_Lbx";
            this.UI_SearchResults_Lbx.Size = new System.Drawing.Size(197, 173);
            this.UI_SearchResults_Lbx.TabIndex = 12;
            // 
            // UI_SearchList_Tbx
            // 
            this.UI_SearchList_Tbx.Location = new System.Drawing.Point(58, 38);
            this.UI_SearchList_Tbx.Multiline = true;
            this.UI_SearchList_Tbx.Name = "UI_SearchList_Tbx";
            this.UI_SearchList_Tbx.ReadOnly = true;
            this.UI_SearchList_Tbx.Size = new System.Drawing.Size(196, 70);
            this.UI_SearchList_Tbx.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Unsorted values";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Sorted values";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Search List";
            // 
            // UI_DisplayList_Btn
            // 
            this.UI_DisplayList_Btn.Location = new System.Drawing.Point(59, 113);
            this.UI_DisplayList_Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_DisplayList_Btn.Name = "UI_DisplayList_Btn";
            this.UI_DisplayList_Btn.Size = new System.Drawing.Size(196, 31);
            this.UI_DisplayList_Btn.TabIndex = 17;
            this.UI_DisplayList_Btn.Text = "Display Search List";
            this.UI_DisplayList_Btn.UseVisualStyleBackColor = true;
            this.UI_DisplayList_Btn.Click += new System.EventHandler(this.UI_DisplayList_Btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UI_Sorted_Tbx);
            this.groupBox1.Controls.Add(this.UI_Unsorted_Tbx);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.UI_Sorting_GBx);
            this.groupBox1.Controls.Add(this.UI_Sort_btn);
            this.groupBox1.Controls.Add(this.UI_GenValues_Btn);
            this.groupBox1.Location = new System.Drawing.Point(17, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 444);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Part A";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.UI_DisplayList_Btn);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.UI_SearchList_Tbx);
            this.groupBox2.Controls.Add(this.UI_SearchResults_Lbx);
            this.groupBox2.Controls.Add(this.UI_PerformSearch_Btn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.UI_SearchValue_Tbx);
            this.groupBox2.Location = new System.Drawing.Point(471, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 443);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Part B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Search Results List";
            // 
            // UI_Unsorted_Tbx
            // 
            this.UI_Unsorted_Tbx.Location = new System.Drawing.Point(208, 38);
            this.UI_Unsorted_Tbx.Multiline = true;
            this.UI_Unsorted_Tbx.Name = "UI_Unsorted_Tbx";
            this.UI_Unsorted_Tbx.ReadOnly = true;
            this.UI_Unsorted_Tbx.Size = new System.Drawing.Size(196, 174);
            this.UI_Unsorted_Tbx.TabIndex = 16;
            // 
            // UI_Sorted_Tbx
            // 
            this.UI_Sorted_Tbx.Location = new System.Drawing.Point(208, 241);
            this.UI_Sorted_Tbx.Multiline = true;
            this.UI_Sorted_Tbx.Name = "UI_Sorted_Tbx";
            this.UI_Sorted_Tbx.ReadOnly = true;
            this.UI_Sorted_Tbx.Size = new System.Drawing.Size(196, 187);
            this.UI_Sorted_Tbx.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 466);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.UI_Sorting_GBx.ResumeLayout(false);
            this.UI_Sorting_GBx.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UI_GenValues_Btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button UI_Sort_btn;
        private System.Windows.Forms.RadioButton UI_BubbleSort_Radio;
        private System.Windows.Forms.RadioButton UI_SelectionSort_Radio;
        private System.Windows.Forms.GroupBox UI_Sorting_GBx;
        private System.Windows.Forms.TextBox UI_SearchValue_Tbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UI_PerformSearch_Btn;
        private System.Windows.Forms.ListBox UI_SearchResults_Lbx;
        private System.Windows.Forms.TextBox UI_SearchList_Tbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton UI_QuickSort_Radio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button UI_DisplayList_Btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UI_Sorted_Tbx;
        private System.Windows.Forms.TextBox UI_Unsorted_Tbx;
    }
}

