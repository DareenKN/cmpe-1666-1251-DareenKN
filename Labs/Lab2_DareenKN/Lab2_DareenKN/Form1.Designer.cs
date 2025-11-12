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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UI_FileData_RadioBtn = new System.Windows.Forms.RadioButton();
            this.UI_ProvidedList_RadioBtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UI_TimeTaken_Tbx = new System.Windows.Forms.TextBox();
            this.UI_MainFile_Dlg = new System.Windows.Forms.OpenFileDialog();
            this.UI_SortedData_Dgv = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UI_EllapsedTicks_Tmr = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UI_UnsortedData_Dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UI_SortedData_Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_UnsortedData_Dgv
            // 
            this.UI_UnsortedData_Dgv.AllowDrop = true;
            this.UI_UnsortedData_Dgv.AllowUserToAddRows = false;
            this.UI_UnsortedData_Dgv.AllowUserToResizeRows = false;
            this.UI_UnsortedData_Dgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UI_UnsortedData_Dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.UI_UnsortedData_Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UI_UnsortedData_Dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UI_UnsortedData_Dgv.DefaultCellStyle = dataGridViewCellStyle19;
            this.UI_UnsortedData_Dgv.Location = new System.Drawing.Point(12, 64);
            this.UI_UnsortedData_Dgv.Name = "UI_UnsortedData_Dgv";
            this.UI_UnsortedData_Dgv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UI_UnsortedData_Dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.UI_UnsortedData_Dgv.RowHeadersVisible = false;
            this.UI_UnsortedData_Dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.UI_UnsortedData_Dgv.RowsDefaultCellStyle = dataGridViewCellStyle21;
            this.UI_UnsortedData_Dgv.Size = new System.Drawing.Size(338, 378);
            this.UI_UnsortedData_Dgv.TabIndex = 0;
            this.UI_UnsortedData_Dgv.TabStop = false;
            this.UI_UnsortedData_Dgv.DragDrop += new System.Windows.Forms.DragEventHandler(this.UI_UnsortedData_Dgv_DragDrop);
            this.UI_UnsortedData_Dgv.DragEnter += new System.Windows.Forms.DragEventHandler(this.UI_UnsortedData_Dgv_DragEnter);
            // 
            // Column1
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle16;
            this.Column1.HeaderText = "Employee Id";
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 115;
            // 
            // Column2
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle17;
            this.Column2.HeaderText = "First Name";
            this.Column2.Name = "Column2";
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 110;
            // 
            // Column3
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle18;
            this.Column3.HeaderText = "Last Name";
            this.Column3.Name = "Column3";
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 110;
            // 
            // UI_DisplayUnsortedList_Btn
            // 
            this.UI_DisplayUnsortedList_Btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.UI_DisplayUnsortedList_Btn.Location = new System.Drawing.Point(372, 64);
            this.UI_DisplayUnsortedList_Btn.Name = "UI_DisplayUnsortedList_Btn";
            this.UI_DisplayUnsortedList_Btn.Size = new System.Drawing.Size(120, 42);
            this.UI_DisplayUnsortedList_Btn.TabIndex = 1;
            this.UI_DisplayUnsortedList_Btn.Text = "Display Unsorted List";
            this.UI_DisplayUnsortedList_Btn.UseVisualStyleBackColor = false;
            this.UI_DisplayUnsortedList_Btn.Click += new System.EventHandler(this.UI_DisplayUnsortedList_Btn_Click);
            // 
            // UI_ClearUnsortedDataGrid_Btn
            // 
            this.UI_ClearUnsortedDataGrid_Btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.UI_ClearUnsortedDataGrid_Btn.Location = new System.Drawing.Point(372, 112);
            this.UI_ClearUnsortedDataGrid_Btn.Name = "UI_ClearUnsortedDataGrid_Btn";
            this.UI_ClearUnsortedDataGrid_Btn.Size = new System.Drawing.Size(120, 42);
            this.UI_ClearUnsortedDataGrid_Btn.TabIndex = 2;
            this.UI_ClearUnsortedDataGrid_Btn.Text = "Clear Unsorted Data Grid";
            this.UI_ClearUnsortedDataGrid_Btn.UseVisualStyleBackColor = false;
            this.UI_ClearUnsortedDataGrid_Btn.Click += new System.EventHandler(this.UI_ClearUnsortedDataGrid_Btn_Click);
            // 
            // UI_SortByEmployee_Btn
            // 
            this.UI_SortByEmployee_Btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.UI_SortByEmployee_Btn.Location = new System.Drawing.Point(372, 237);
            this.UI_SortByEmployee_Btn.Name = "UI_SortByEmployee_Btn";
            this.UI_SortByEmployee_Btn.Size = new System.Drawing.Size(120, 42);
            this.UI_SortByEmployee_Btn.TabIndex = 4;
            this.UI_SortByEmployee_Btn.Text = "Sort By EmployeeID";
            this.UI_SortByEmployee_Btn.UseVisualStyleBackColor = false;
            this.UI_SortByEmployee_Btn.Click += new System.EventHandler(this.UI_SortByEmployee_Btn_Click);
            // 
            // UI_SortByLastNames_Btn
            // 
            this.UI_SortByLastNames_Btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.UI_SortByLastNames_Btn.Location = new System.Drawing.Point(372, 285);
            this.UI_SortByLastNames_Btn.Name = "UI_SortByLastNames_Btn";
            this.UI_SortByLastNames_Btn.Size = new System.Drawing.Size(120, 42);
            this.UI_SortByLastNames_Btn.TabIndex = 5;
            this.UI_SortByLastNames_Btn.Text = "Sort By Last Names";
            this.UI_SortByLastNames_Btn.UseVisualStyleBackColor = false;
            this.UI_SortByLastNames_Btn.Click += new System.EventHandler(this.UI_SortByLastNames_Btn_Click);
            // 
            // UI_ClearSortedDataGrid_Btn
            // 
            this.UI_ClearSortedDataGrid_Btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.UI_ClearSortedDataGrid_Btn.Location = new System.Drawing.Point(372, 333);
            this.UI_ClearSortedDataGrid_Btn.Name = "UI_ClearSortedDataGrid_Btn";
            this.UI_ClearSortedDataGrid_Btn.Size = new System.Drawing.Size(120, 42);
            this.UI_ClearSortedDataGrid_Btn.TabIndex = 6;
            this.UI_ClearSortedDataGrid_Btn.Text = "Clear Sorted Data Grid";
            this.UI_ClearSortedDataGrid_Btn.UseVisualStyleBackColor = false;
            this.UI_ClearSortedDataGrid_Btn.Click += new System.EventHandler(this.UI_ClearSortedDataGrid_Btn_Click);
            // 
            // UI_OpenFileThroughOFD_Btn
            // 
            this.UI_OpenFileThroughOFD_Btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.UI_OpenFileThroughOFD_Btn.Enabled = false;
            this.UI_OpenFileThroughOFD_Btn.Location = new System.Drawing.Point(372, 381);
            this.UI_OpenFileThroughOFD_Btn.Name = "UI_OpenFileThroughOFD_Btn";
            this.UI_OpenFileThroughOFD_Btn.Size = new System.Drawing.Size(120, 42);
            this.UI_OpenFileThroughOFD_Btn.TabIndex = 7;
            this.UI_OpenFileThroughOFD_Btn.Text = "Open File Through OFD";
            this.UI_OpenFileThroughOFD_Btn.UseVisualStyleBackColor = false;
            this.UI_OpenFileThroughOFD_Btn.Click += new System.EventHandler(this.UI_OpenFileThroughOFD_Btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UI_FileData_RadioBtn);
            this.groupBox1.Controls.Add(this.UI_ProvidedList_RadioBtn);
            this.groupBox1.Location = new System.Drawing.Point(372, 160);
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
            this.UI_FileData_RadioBtn.CheckedChanged += new System.EventHandler(this.UI_DataSource_CheckedChanged);
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
            this.label1.Location = new System.Drawing.Point(128, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Unsorted Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(638, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sorted Data";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(525, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Time Taken (Elapsed Ticks):";
            // 
            // UI_TimeTaken_Tbx
            // 
            this.UI_TimeTaken_Tbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UI_TimeTaken_Tbx.Location = new System.Drawing.Point(739, 466);
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
            // UI_SortedData_Dgv
            // 
            this.UI_SortedData_Dgv.AllowUserToAddRows = false;
            this.UI_SortedData_Dgv.AllowUserToResizeRows = false;
            this.UI_SortedData_Dgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UI_SortedData_Dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.UI_SortedData_Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UI_SortedData_Dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UI_SortedData_Dgv.DefaultCellStyle = dataGridViewCellStyle26;
            this.UI_SortedData_Dgv.Location = new System.Drawing.Point(514, 64);
            this.UI_SortedData_Dgv.Name = "UI_SortedData_Dgv";
            this.UI_SortedData_Dgv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UI_SortedData_Dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.UI_SortedData_Dgv.RowHeadersVisible = false;
            this.UI_SortedData_Dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.UI_SortedData_Dgv.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.UI_SortedData_Dgv.Size = new System.Drawing.Size(338, 378);
            this.UI_SortedData_Dgv.TabIndex = 14;
            this.UI_SortedData_Dgv.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridViewTextBoxColumn1.HeaderText = "Employee Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 115;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 110;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridViewTextBoxColumn3.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 110;
            // 
            // UI_EllapsedTicks_Tmr
            // 
            this.UI_EllapsedTicks_Tmr.Tick += new System.EventHandler(this.UI_EllapsedTicks_Tmr_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 511);
            this.Controls.Add(this.UI_SortedData_Dgv);
            this.Controls.Add(this.UI_TimeTaken_Tbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UI_OpenFileThroughOFD_Btn);
            this.Controls.Add(this.UI_ClearSortedDataGrid_Btn);
            this.Controls.Add(this.UI_SortByLastNames_Btn);
            this.Controls.Add(this.UI_SortByEmployee_Btn);
            this.Controls.Add(this.UI_ClearUnsortedDataGrid_Btn);
            this.Controls.Add(this.UI_DisplayUnsortedList_Btn);
            this.Controls.Add(this.UI_UnsortedData_Dgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(880, 550);
            this.Name = "Form1";
            this.Text = "Lab2 - Creating and Sorting Lists of Structs - DareenKN";
            ((System.ComponentModel.ISupportInitialize)(this.UI_UnsortedData_Dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UI_SortedData_Dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UI_UnsortedData_Dgv;
        private System.Windows.Forms.Button UI_DisplayUnsortedList_Btn;
        private System.Windows.Forms.Button UI_ClearUnsortedDataGrid_Btn;
        private System.Windows.Forms.Button UI_SortByEmployee_Btn;
        private System.Windows.Forms.Button UI_SortByLastNames_Btn;
        private System.Windows.Forms.Button UI_ClearSortedDataGrid_Btn;
        private System.Windows.Forms.Button UI_OpenFileThroughOFD_Btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton UI_FileData_RadioBtn;
        private System.Windows.Forms.RadioButton UI_ProvidedList_RadioBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UI_TimeTaken_Tbx;
        private System.Windows.Forms.OpenFileDialog UI_MainFile_Dlg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridView UI_SortedData_Dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Timer UI_EllapsedTicks_Tmr;
    }
}

