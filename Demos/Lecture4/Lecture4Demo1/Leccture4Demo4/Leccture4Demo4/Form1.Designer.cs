namespace Leccture4Demo4
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
            this.UI_DisplayData_Lbx = new System.Windows.Forms.ListBox();
            this.UI_DisplayData_Btn = new System.Windows.Forms.Button();
            this.UI_DragAndDrop_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_DisplayData_Lbx
            // 
            this.UI_DisplayData_Lbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_DisplayData_Lbx.FormattingEnabled = true;
            this.UI_DisplayData_Lbx.ItemHeight = 16;
            this.UI_DisplayData_Lbx.Location = new System.Drawing.Point(101, 42);
            this.UI_DisplayData_Lbx.Name = "UI_DisplayData_Lbx";
            this.UI_DisplayData_Lbx.Size = new System.Drawing.Size(225, 276);
            this.UI_DisplayData_Lbx.TabIndex = 4;
            // 
            // UI_DisplayData_Btn
            // 
            this.UI_DisplayData_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_DisplayData_Btn.Location = new System.Drawing.Point(114, 351);
            this.UI_DisplayData_Btn.Name = "UI_DisplayData_Btn";
            this.UI_DisplayData_Btn.Size = new System.Drawing.Size(201, 58);
            this.UI_DisplayData_Btn.TabIndex = 7;
            this.UI_DisplayData_Btn.Text = "Display Data";
            this.UI_DisplayData_Btn.UseVisualStyleBackColor = true;
            this.UI_DisplayData_Btn.Click += new System.EventHandler(this.Ui_DisplayData_Btn_Click);
            // 
            // UI_DragAndDrop_Lbl
            // 
            this.UI_DragAndDrop_Lbl.AllowDrop = true;
            this.UI_DragAndDrop_Lbl.BackColor = System.Drawing.SystemColors.HotTrack;
            this.UI_DragAndDrop_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_DragAndDrop_Lbl.Location = new System.Drawing.Point(447, 104);
            this.UI_DragAndDrop_Lbl.Name = "UI_DragAndDrop_Lbl";
            this.UI_DragAndDrop_Lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UI_DragAndDrop_Lbl.Size = new System.Drawing.Size(172, 100);
            this.UI_DragAndDrop_Lbl.TabIndex = 11;
            this.UI_DragAndDrop_Lbl.Text = "Drag Drop Your File Here";
            this.UI_DragAndDrop_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UI_DragAndDrop_Lbl.DragDrop += new System.Windows.Forms.DragEventHandler(this.UI_DragAndDrop_Lbl_DragDrop);
            this.UI_DragAndDrop_Lbl.DragEnter += new System.Windows.Forms.DragEventHandler(this.UI_DragAndDrop_Lbl_DragEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_DragAndDrop_Lbl);
            this.Controls.Add(this.UI_DisplayData_Btn);
            this.Controls.Add(this.UI_DisplayData_Lbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox UI_DisplayData_Lbx;
        private System.Windows.Forms.Button UI_DisplayData_Btn;
        private System.Windows.Forms.Label UI_DragAndDrop_Lbl;
    }
}

