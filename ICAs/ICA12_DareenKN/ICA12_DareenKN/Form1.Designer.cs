namespace ICA12_DareenKN
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
            this.UI_MainFile_Dlg = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UI_TimeTaken_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Sort_Btn = new System.Windows.Forms.Button();
            this.UI_ClearUnsortedListBox_Btn = new System.Windows.Forms.Button();
            this.UI_DisplayUnsortedList_Btn = new System.Windows.Forms.Button();
            this.UI_FileData_RadioBtn = new System.Windows.Forms.RadioButton();
            this.UI_ProvidedList_RadioBtn = new System.Windows.Forms.RadioButton();
            this.UI_UnsortedData_Lbx = new System.Windows.Forms.ListBox();
            this.UI_SortedData_Lbx = new System.Windows.Forms.ListBox();
            this.UI_DragAndDrop_Lbl = new System.Windows.Forms.Label();
            this.UI_ClearSortedListBox_Btn = new System.Windows.Forms.Button();
            this.UI_TimeTaken_Tmr = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // UI_MainFile_Dlg
            // 
            this.UI_MainFile_Dlg.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(404, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Time Taken (Elapsed Ticks):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(543, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Sorted Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Unsorted Data";
            // 
            // UI_TimeTaken_Tbx
            // 
            this.UI_TimeTaken_Tbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UI_TimeTaken_Tbx.Location = new System.Drawing.Point(618, 420);
            this.UI_TimeTaken_Tbx.Name = "UI_TimeTaken_Tbx";
            this.UI_TimeTaken_Tbx.ReadOnly = true;
            this.UI_TimeTaken_Tbx.Size = new System.Drawing.Size(100, 20);
            this.UI_TimeTaken_Tbx.TabIndex = 26;
            this.UI_TimeTaken_Tbx.TabStop = false;
            // 
            // UI_Sort_Btn
            // 
            this.UI_Sort_Btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.UI_Sort_Btn.Location = new System.Drawing.Point(304, 200);
            this.UI_Sort_Btn.Name = "UI_Sort_Btn";
            this.UI_Sort_Btn.Size = new System.Drawing.Size(120, 42);
            this.UI_Sort_Btn.TabIndex = 18;
            this.UI_Sort_Btn.Text = "Sort ";
            this.UI_Sort_Btn.UseVisualStyleBackColor = false;
            this.UI_Sort_Btn.Click += new System.EventHandler(this.UI_Sort_Btn_Click);
            // 
            // UI_ClearUnsortedListBox_Btn
            // 
            this.UI_ClearUnsortedListBox_Btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.UI_ClearUnsortedListBox_Btn.Location = new System.Drawing.Point(304, 100);
            this.UI_ClearUnsortedListBox_Btn.Name = "UI_ClearUnsortedListBox_Btn";
            this.UI_ClearUnsortedListBox_Btn.Size = new System.Drawing.Size(120, 42);
            this.UI_ClearUnsortedListBox_Btn.TabIndex = 16;
            this.UI_ClearUnsortedListBox_Btn.Text = "Clear Unsorted ListBox";
            this.UI_ClearUnsortedListBox_Btn.UseVisualStyleBackColor = false;
            this.UI_ClearUnsortedListBox_Btn.Click += new System.EventHandler(this.UI_ClearUnsortedListBox_Btn_Click);
            // 
            // UI_DisplayUnsortedList_Btn
            // 
            this.UI_DisplayUnsortedList_Btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.UI_DisplayUnsortedList_Btn.Location = new System.Drawing.Point(304, 50);
            this.UI_DisplayUnsortedList_Btn.Name = "UI_DisplayUnsortedList_Btn";
            this.UI_DisplayUnsortedList_Btn.Size = new System.Drawing.Size(120, 42);
            this.UI_DisplayUnsortedList_Btn.TabIndex = 15;
            this.UI_DisplayUnsortedList_Btn.Text = "Display Unsorted List";
            this.UI_DisplayUnsortedList_Btn.UseVisualStyleBackColor = false;
            this.UI_DisplayUnsortedList_Btn.Click += new System.EventHandler(this.UI_DisplayUnsortedList_Btn_Click);
            // 
            // UI_FileData_RadioBtn
            // 
            this.UI_FileData_RadioBtn.AutoSize = true;
            this.UI_FileData_RadioBtn.Location = new System.Drawing.Point(304, 175);
            this.UI_FileData_RadioBtn.Name = "UI_FileData_RadioBtn";
            this.UI_FileData_RadioBtn.Size = new System.Drawing.Size(67, 17);
            this.UI_FileData_RadioBtn.TabIndex = 27;
            this.UI_FileData_RadioBtn.Text = "File Data";
            this.UI_FileData_RadioBtn.UseVisualStyleBackColor = true;
            // 
            // UI_ProvidedList_RadioBtn
            // 
            this.UI_ProvidedList_RadioBtn.AutoSize = true;
            this.UI_ProvidedList_RadioBtn.Checked = true;
            this.UI_ProvidedList_RadioBtn.Location = new System.Drawing.Point(304, 150);
            this.UI_ProvidedList_RadioBtn.Name = "UI_ProvidedList_RadioBtn";
            this.UI_ProvidedList_RadioBtn.Size = new System.Drawing.Size(86, 17);
            this.UI_ProvidedList_RadioBtn.TabIndex = 28;
            this.UI_ProvidedList_RadioBtn.TabStop = true;
            this.UI_ProvidedList_RadioBtn.Text = "Provided List";
            this.UI_ProvidedList_RadioBtn.UseVisualStyleBackColor = true;
            // 
            // UI_UnsortedData_Lbx
            // 
            this.UI_UnsortedData_Lbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.UI_UnsortedData_Lbx.FormattingEnabled = true;
            this.UI_UnsortedData_Lbx.Location = new System.Drawing.Point(12, 40);
            this.UI_UnsortedData_Lbx.Name = "UI_UnsortedData_Lbx";
            this.UI_UnsortedData_Lbx.Size = new System.Drawing.Size(254, 355);
            this.UI_UnsortedData_Lbx.TabIndex = 29;
            // 
            // UI_SortedData_Lbx
            // 
            this.UI_SortedData_Lbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.UI_SortedData_Lbx.FormattingEnabled = true;
            this.UI_SortedData_Lbx.Location = new System.Drawing.Point(462, 40);
            this.UI_SortedData_Lbx.Name = "UI_SortedData_Lbx";
            this.UI_SortedData_Lbx.Size = new System.Drawing.Size(254, 355);
            this.UI_SortedData_Lbx.TabIndex = 30;
            // 
            // UI_DragAndDrop_Lbl
            // 
            this.UI_DragAndDrop_Lbl.AllowDrop = true;
            this.UI_DragAndDrop_Lbl.BackColor = System.Drawing.SystemColors.HotTrack;
            this.UI_DragAndDrop_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_DragAndDrop_Lbl.Location = new System.Drawing.Point(304, 300);
            this.UI_DragAndDrop_Lbl.Name = "UI_DragAndDrop_Lbl";
            this.UI_DragAndDrop_Lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UI_DragAndDrop_Lbl.Size = new System.Drawing.Size(120, 62);
            this.UI_DragAndDrop_Lbl.TabIndex = 31;
            this.UI_DragAndDrop_Lbl.Text = "Drag Drop File Here";
            this.UI_DragAndDrop_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UI_DragAndDrop_Lbl.DragDrop += new System.Windows.Forms.DragEventHandler(this.UI_DragAndDrop_Lbl_DragDrop);
            this.UI_DragAndDrop_Lbl.DragEnter += new System.Windows.Forms.DragEventHandler(this.UI_DragAndDrop_Lbl_DragEnter);
            // 
            // UI_ClearSortedListBox_Btn
            // 
            this.UI_ClearSortedListBox_Btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.UI_ClearSortedListBox_Btn.Location = new System.Drawing.Point(304, 250);
            this.UI_ClearSortedListBox_Btn.Name = "UI_ClearSortedListBox_Btn";
            this.UI_ClearSortedListBox_Btn.Size = new System.Drawing.Size(120, 42);
            this.UI_ClearSortedListBox_Btn.TabIndex = 32;
            this.UI_ClearSortedListBox_Btn.Text = "Clear Sorted ListBox";
            this.UI_ClearSortedListBox_Btn.UseVisualStyleBackColor = false;
            this.UI_ClearSortedListBox_Btn.Click += new System.EventHandler(this.UI_ClearSortedListBox_Btn_Click);
            // 
            // UI_TimeTaken_Tmr
            // 
            this.UI_TimeTaken_Tmr.Tick += new System.EventHandler(this.UI_TimeTaken_Tmr_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 451);
            this.Controls.Add(this.UI_ClearSortedListBox_Btn);
            this.Controls.Add(this.UI_DragAndDrop_Lbl);
            this.Controls.Add(this.UI_SortedData_Lbx);
            this.Controls.Add(this.UI_UnsortedData_Lbx);
            this.Controls.Add(this.UI_FileData_RadioBtn);
            this.Controls.Add(this.UI_ProvidedList_RadioBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_TimeTaken_Tbx);
            this.Controls.Add(this.UI_Sort_Btn);
            this.Controls.Add(this.UI_ClearUnsortedListBox_Btn);
            this.Controls.Add(this.UI_DisplayUnsortedList_Btn);
            this.MinimumSize = new System.Drawing.Size(745, 490);
            this.Name = "Form1";
            this.Text = "ICA12_ QuickSort DareenKN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog UI_MainFile_Dlg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UI_TimeTaken_Tbx;
        private System.Windows.Forms.Button UI_Sort_Btn;
        private System.Windows.Forms.Button UI_ClearUnsortedListBox_Btn;
        private System.Windows.Forms.Button UI_DisplayUnsortedList_Btn;
        private System.Windows.Forms.RadioButton UI_FileData_RadioBtn;
        private System.Windows.Forms.RadioButton UI_ProvidedList_RadioBtn;
        private System.Windows.Forms.ListBox UI_UnsortedData_Lbx;
        private System.Windows.Forms.ListBox UI_SortedData_Lbx;
        private System.Windows.Forms.Label UI_DragAndDrop_Lbl;
        private System.Windows.Forms.Button UI_ClearSortedListBox_Btn;
        private System.Windows.Forms.Timer UI_TimeTaken_Tmr;
    }
}

