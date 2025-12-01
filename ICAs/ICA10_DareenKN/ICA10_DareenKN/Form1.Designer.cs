namespace ICA10_DareenKN
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
            this.label1 = new System.Windows.Forms.Label();
            this.UI_FillColor_Cdg = new System.Windows.Forms.ColorDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.UI_Generate_Btn = new System.Windows.Forms.Button();
            this.UI_FillColor_Btn = new System.Windows.Forms.Button();
            this.UI_Fill_Btn = new System.Windows.Forms.Button();
            this.UI_NumberOfBlocks_Tbr = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UI_ColorPanel_Pnl = new System.Windows.Forms.Panel();
            this.UI_Fill_Tmr = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UI_NumberOfBlocks_Tbr)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Blocks";
            // 
            // UI_FillColor_Cdg
            // 
            this.UI_FillColor_Cdg.Color = System.Drawing.Color.SteelBlue;
            this.UI_FillColor_Cdg.FullOpen = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fill Color";
            // 
            // UI_Generate_Btn
            // 
            this.UI_Generate_Btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.UI_Generate_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Generate_Btn.Location = new System.Drawing.Point(5, 118);
            this.UI_Generate_Btn.Name = "UI_Generate_Btn";
            this.UI_Generate_Btn.Size = new System.Drawing.Size(88, 31);
            this.UI_Generate_Btn.TabIndex = 3;
            this.UI_Generate_Btn.Text = "Generate";
            this.UI_Generate_Btn.UseVisualStyleBackColor = false;
            this.UI_Generate_Btn.Click += new System.EventHandler(this.UI_Generate_Btn_Click);
            // 
            // UI_FillColor_Btn
            // 
            this.UI_FillColor_Btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.UI_FillColor_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_FillColor_Btn.Location = new System.Drawing.Point(99, 118);
            this.UI_FillColor_Btn.Name = "UI_FillColor_Btn";
            this.UI_FillColor_Btn.Size = new System.Drawing.Size(88, 31);
            this.UI_FillColor_Btn.TabIndex = 4;
            this.UI_FillColor_Btn.Text = "Fill Color";
            this.UI_FillColor_Btn.UseVisualStyleBackColor = false;
            this.UI_FillColor_Btn.Click += new System.EventHandler(this.UI_FillColor_Btn_Click);
            // 
            // UI_Fill_Btn
            // 
            this.UI_Fill_Btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.UI_Fill_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Fill_Btn.Location = new System.Drawing.Point(194, 118);
            this.UI_Fill_Btn.Name = "UI_Fill_Btn";
            this.UI_Fill_Btn.Size = new System.Drawing.Size(88, 31);
            this.UI_Fill_Btn.TabIndex = 5;
            this.UI_Fill_Btn.Text = "Fill";
            this.UI_Fill_Btn.UseVisualStyleBackColor = false;
            this.UI_Fill_Btn.Click += new System.EventHandler(this.UI_Fill_Btn_Click);
            // 
            // UI_NumberOfBlocks_Tbr
            // 
            this.UI_NumberOfBlocks_Tbr.BackColor = System.Drawing.SystemColors.Control;
            this.UI_NumberOfBlocks_Tbr.LargeChange = 15;
            this.UI_NumberOfBlocks_Tbr.Location = new System.Drawing.Point(12, 31);
            this.UI_NumberOfBlocks_Tbr.Maximum = 30;
            this.UI_NumberOfBlocks_Tbr.Minimum = 1;
            this.UI_NumberOfBlocks_Tbr.Name = "UI_NumberOfBlocks_Tbr";
            this.UI_NumberOfBlocks_Tbr.Size = new System.Drawing.Size(270, 45);
            this.UI_NumberOfBlocks_Tbr.TabIndex = 6;
            this.UI_NumberOfBlocks_Tbr.Value = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "3000";
            // 
            // UI_ColorPanel_Pnl
            // 
            this.UI_ColorPanel_Pnl.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.UI_ColorPanel_Pnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UI_ColorPanel_Pnl.Location = new System.Drawing.Point(143, 74);
            this.UI_ColorPanel_Pnl.Name = "UI_ColorPanel_Pnl";
            this.UI_ColorPanel_Pnl.Size = new System.Drawing.Size(41, 30);
            this.UI_ColorPanel_Pnl.TabIndex = 9;
            // 
            // UI_Fill_Tmr
            // 
            this.UI_Fill_Tmr.Interval = 50;
            this.UI_Fill_Tmr.Tick += new System.EventHandler(this.UI_Fill_Tmr_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(294, 161);
            this.Controls.Add(this.UI_ColorPanel_Pnl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UI_NumberOfBlocks_Tbr);
            this.Controls.Add(this.UI_Fill_Btn);
            this.Controls.Add(this.UI_FillColor_Btn);
            this.Controls.Add(this.UI_Generate_Btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(310, 200);
            this.MinimumSize = new System.Drawing.Size(310, 200);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.UI_NumberOfBlocks_Tbr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog UI_FillColor_Cdg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UI_Generate_Btn;
        private System.Windows.Forms.Button UI_FillColor_Btn;
        private System.Windows.Forms.Button UI_Fill_Btn;
        private System.Windows.Forms.TrackBar UI_NumberOfBlocks_Tbr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel UI_ColorPanel_Pnl;
        private System.Windows.Forms.Timer UI_Fill_Tmr;
    }
}

