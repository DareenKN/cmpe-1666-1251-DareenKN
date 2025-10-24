namespace Lab2_DareenKN
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.UI_UnsortedData_Dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UI_DisplayUnsortedList_Btn = new System.Windows.Forms.Button();
            this.UI_ClearUnsortedDataGrid_Btn = new System.Windows.Forms.Button();
            this.UI_SortByEmployee_Btn = new System.Windows.Forms.Button();
            this.UI_SortByLastNames_Btn = new System.Windows.Forms.Button();
            this.UI_ClearSortedDataGrid_Btn = new System.Windows.Forms.Button();
            this.UI_OpenFileThroughOFD_Btn = new System.Windows.Forms.Button();
            this.UI_SortedData_Dgv = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UI_FileData_RadioBtn = new System.Windows.Forms.RadioButton();
            this.UI_ProvidedList_RadioBtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UI_TimeTaken_Tbx = new System.Windows.Forms.TextBox();
            this.UI_MainFile_Dlg = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.UI_UnsortedData_Dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_SortedData_Dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_UnsortedData_Dgv
            // 
            this.UI_UnsortedData_Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UI_UnsortedData_Dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.UI_UnsortedData_Dgv.Location = new System.Drawing.Point(12, 64);
            this.UI_UnsortedData_Dgv.Name = "UI_UnsortedData_Dgv";
            this.UI_UnsortedData_Dgv.RowHeadersVisible = false;
            this.UI_UnsortedData_Dgv.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.UI_UnsortedData_Dgv.Size = new System.Drawing.Size(340, 375);
            this.UI_UnsortedData_Dgv.TabIndex = 0;
            this.UI_UnsortedData_Dgv.TabStop = false;
            // 
            // Column1
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column1.HeaderText = "Employee Id";
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column2.HeaderText = "First Name";
            this.Column2.Name = "Column2";
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 110;
            // 
            // Column3
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column3.HeaderText = "Last Name";
            this.Column3.Name = "Column3";
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 110;
            // 
            // UI_DisplayUnsortedList_Btn
            // 
            this.UI_DisplayUnsortedList_Btn.Location = new System.Drawing.Point(373, 64);
            this.UI_DisplayUnsortedList_Btn.Name = "UI_DisplayUnsortedList_Btn";
            this.UI_DisplayUnsortedList_Btn.Size = new System.Drawing.Size(120, 42);
            this.UI_DisplayUnsortedList_Btn.TabIndex = 1;
            this.UI_DisplayUnsortedList_Btn.Text = "Display Unsorted List";
            this.UI_DisplayUnsortedList_Btn.UseVisualStyleBackColor = true;
            // 
            // UI_ClearUnsortedDataGrid_Btn
            // 
            this.UI_ClearUnsortedDataGrid_Btn.Location = new System.Drawing.Point(373, 112);
            this.UI_ClearUnsortedDataGrid_Btn.Name = "UI_ClearUnsortedDataGrid_Btn";
            this.UI_ClearUnsortedDataGrid_Btn.Size = new System.Drawing.Size(120, 42);
            this.UI_ClearUnsortedDataGrid_Btn.TabIndex = 2;
            this.UI_ClearUnsortedDataGrid_Btn.Text = "Clear Unsorted Data Grid";
            this.UI_ClearUnsortedDataGrid_Btn.UseVisualStyleBackColor = true;
            // 
            // UI_SortByEmployee_Btn
            // 
            this.UI_SortByEmployee_Btn.Location = new System.Drawing.Point(373, 237);
            this.UI_SortByEmployee_Btn.Name = "UI_SortByEmployee_Btn";
            this.UI_SortByEmployee_Btn.Size = new System.Drawing.Size(120, 42);
            this.UI_SortByEmployee_Btn.TabIndex = 4;
            this.UI_SortByEmployee_Btn.Text = "Sort By EmployeeID";
            this.UI_SortByEmployee_Btn.UseVisualStyleBackColor = true;
            // 
            // UI_SortByLastNames_Btn
            // 
            this.UI_SortByLastNames_Btn.Location = new System.Drawing.Point(373, 285);
            this.UI_SortByLastNames_Btn.Name = "UI_SortByLastNames_Btn";
            this.UI_SortByLastNames_Btn.Size = new System.Drawing.Size(120, 42);
            this.UI_SortByLastNames_Btn.TabIndex = 5;
            this.UI_SortByLastNames_Btn.Text = "Sort By Last Names";
            this.UI_SortByLastNames_Btn.UseVisualStyleBackColor = true;
            // 
            // UI_ClearSortedDataGrid_Btn
            // 
            this.UI_ClearSortedDataGrid_Btn.Location = new System.Drawing.Point(373, 333);
            this.UI_ClearSortedDataGrid_Btn.Name = "UI_ClearSortedDataGrid_Btn";
            this.UI_ClearSortedDataGrid_Btn.Size = new System.Drawing.Size(120, 42);
            this.UI_ClearSortedDataGrid_Btn.TabIndex = 6;
            this.UI_ClearSortedDataGrid_Btn.Text = "Clear Sorted Data Grid";
            this.UI_ClearSortedDataGrid_Btn.UseVisualStyleBackColor = true;
            // 
            // UI_OpenFileThroughOFD_Btn
            // 
            this.UI_OpenFileThroughOFD_Btn.Enabled = false;
            this.UI_OpenFileThroughOFD_Btn.Location = new System.Drawing.Point(373, 381);
            this.UI_OpenFileThroughOFD_Btn.Name = "UI_OpenFileThroughOFD_Btn";
            this.UI_OpenFileThroughOFD_Btn.Size = new System.Drawing.Size(120, 42);
            this.UI_OpenFileThroughOFD_Btn.TabIndex = 7;
            this.UI_OpenFileThroughOFD_Btn.Text = "Open File Through OFD";
            this.UI_OpenFileThroughOFD_Btn.UseVisualStyleBackColor = true;
            this.UI_OpenFileThroughOFD_Btn.Click += new System.EventHandler(this.UI_OpenFileThroughOFD_Btn_Click);
            // 
            // UI_SortedData_Dgv
            // 
            this.UI_SortedData_Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UI_SortedData_Dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.UI_SortedData_Dgv.Location = new System.Drawing.Point(514, 64);
            this.UI_SortedData_Dgv.Name = "UI_SortedData_Dgv";
            this.UI_SortedData_Dgv.RowHeadersVisible = false;
            this.UI_SortedData_Dgv.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.UI_SortedData_Dgv.Size = new System.Drawing.Size(340, 375);
            this.UI_SortedData_Dgv.TabIndex = 8;
            this.UI_SortedData_Dgv.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn1.HeaderText = "Employee Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 110;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn3.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 110;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UI_FileData_RadioBtn);
            this.groupBox1.Controls.Add(this.UI_ProvidedList_RadioBtn);
            this.groupBox1.Location = new System.Drawing.Point(373, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 71);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Source";
            // 
            // UI_FileData_RadioBtn
            // 
            this.UI_FileData_RadioBtn.AutoSize = true;
            this.UI_FileData_RadioBtn.Location = new System.Drawing.Point(16, 42);
            this.UI_FileData_RadioBtn.Name = "UI_FileData_RadioBtn";
            this.UI_FileData_RadioBtn.Size = new System.Drawing.Size(67, 17);
            this.UI_FileData_RadioBtn.TabIndex = 1;
            this.UI_FileData_RadioBtn.Text = "File Data";
            this.UI_FileData_RadioBtn.UseVisualStyleBackColor = true;
            // 
            // UI_ProvidedList_RadioBtn
            // 
            this.UI_ProvidedList_RadioBtn.AutoSize = true;
            this.UI_ProvidedList_RadioBtn.Checked = true;
            this.UI_ProvidedList_RadioBtn.Location = new System.Drawing.Point(16, 19);
            this.UI_ProvidedList_RadioBtn.Name = "UI_ProvidedList_RadioBtn";
            this.UI_ProvidedList_RadioBtn.Size = new System.Drawing.Size(86, 17);
            this.UI_ProvidedList_RadioBtn.TabIndex = 3;
            this.UI_ProvidedList_RadioBtn.TabStop = true;
            this.UI_ProvidedList_RadioBtn.Text = "Provided List";
            this.UI_ProvidedList_RadioBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Unsorted Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(639, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sorted Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(526, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Time Taken (Elapsed Ticks):";
            // 
            // UI_TimeTaken_Tbx
            // 
            this.UI_TimeTaken_Tbx.Location = new System.Drawing.Point(740, 466);
            this.UI_TimeTaken_Tbx.Name = "UI_TimeTaken_Tbx";
            this.UI_TimeTaken_Tbx.ReadOnly = true;
            this.UI_TimeTaken_Tbx.Size = new System.Drawing.Size(100, 20);
            this.UI_TimeTaken_Tbx.TabIndex = 13;
            this.UI_TimeTaken_Tbx.TabStop = false;
            // 
            // UI_MainFile_Dlg
            // 
            this.UI_MainFile_Dlg.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 508);
            this.Controls.Add(this.UI_TimeTaken_Tbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UI_SortedData_Dgv);
            this.Controls.Add(this.UI_OpenFileThroughOFD_Btn);
            this.Controls.Add(this.UI_ClearSortedDataGrid_Btn);
            this.Controls.Add(this.UI_SortByLastNames_Btn);
            this.Controls.Add(this.UI_SortByEmployee_Btn);
            this.Controls.Add(this.UI_ClearUnsortedDataGrid_Btn);
            this.Controls.Add(this.UI_DisplayUnsortedList_Btn);
            this.Controls.Add(this.UI_UnsortedData_Dgv);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.UI_UnsortedData_Dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_SortedData_Dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UI_UnsortedData_Dgv;
        private System.Windows.Forms.Button UI_DisplayUnsortedList_Btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button UI_ClearUnsortedDataGrid_Btn;
        private System.Windows.Forms.Button UI_SortByEmployee_Btn;
        private System.Windows.Forms.Button UI_SortByLastNames_Btn;
        private System.Windows.Forms.Button UI_ClearSortedDataGrid_Btn;
        private System.Windows.Forms.Button UI_OpenFileThroughOFD_Btn;
        private System.Windows.Forms.DataGridView UI_SortedData_Dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton UI_FileData_RadioBtn;
        private System.Windows.Forms.RadioButton UI_ProvidedList_RadioBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UI_TimeTaken_Tbx;
        private System.Windows.Forms.OpenFileDialog UI_MainFile_Dlg;
    }
}

