namespace Lab3_DareenKN
{
    partial class BallzForm
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
            this.UI_ShowScore_Cbx = new System.Windows.Forms.CheckBox();
            this.UI_ShowAnimationSpeed_Cbx = new System.Windows.Forms.CheckBox();
            this.UI_Play_Btn = new System.Windows.Forms.Button();
            this.UI_GameOn_Tmr = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // UI_ShowScore_Cbx
            // 
            this.UI_ShowScore_Cbx.AutoSize = true;
            this.UI_ShowScore_Cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_ShowScore_Cbx.Location = new System.Drawing.Point(12, 12);
            this.UI_ShowScore_Cbx.Name = "UI_ShowScore_Cbx";
            this.UI_ShowScore_Cbx.Size = new System.Drawing.Size(114, 24);
            this.UI_ShowScore_Cbx.TabIndex = 0;
            this.UI_ShowScore_Cbx.Text = "Show Score";
            this.UI_ShowScore_Cbx.UseVisualStyleBackColor = true;
            this.UI_ShowScore_Cbx.CheckedChanged += new System.EventHandler(this.UI_ShowScore_Cbx_CheckedChanged);
            // 
            // UI_ShowAnimationSpeed_Cbx
            // 
            this.UI_ShowAnimationSpeed_Cbx.AutoSize = true;
            this.UI_ShowAnimationSpeed_Cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_ShowAnimationSpeed_Cbx.Location = new System.Drawing.Point(12, 48);
            this.UI_ShowAnimationSpeed_Cbx.Name = "UI_ShowAnimationSpeed_Cbx";
            this.UI_ShowAnimationSpeed_Cbx.Size = new System.Drawing.Size(194, 24);
            this.UI_ShowAnimationSpeed_Cbx.TabIndex = 1;
            this.UI_ShowAnimationSpeed_Cbx.Text = "Show Animation Speed";
            this.UI_ShowAnimationSpeed_Cbx.UseVisualStyleBackColor = true;
            this.UI_ShowAnimationSpeed_Cbx.CheckedChanged += new System.EventHandler(this.UI_ShowAnimationSpeed_Cbx_CheckedChanged);
            // 
            // UI_Play_Btn
            // 
            this.UI_Play_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UI_Play_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Play_Btn.Location = new System.Drawing.Point(153, 91);
            this.UI_Play_Btn.Name = "UI_Play_Btn";
            this.UI_Play_Btn.Size = new System.Drawing.Size(101, 32);
            this.UI_Play_Btn.TabIndex = 2;
            this.UI_Play_Btn.Text = "Play";
            this.UI_Play_Btn.UseVisualStyleBackColor = true;
            this.UI_Play_Btn.Click += new System.EventHandler(this.UI_Play_Btn_Click);
            // 
            // UI_GameOn_Tmr
            // 
            this.UI_GameOn_Tmr.Enabled = true;
            this.UI_GameOn_Tmr.Tick += new System.EventHandler(this.UI_GameOn_Tmr_Tick);
            // 
            // BallzForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 135);
            this.Controls.Add(this.UI_Play_Btn);
            this.Controls.Add(this.UI_ShowAnimationSpeed_Cbx);
            this.Controls.Add(this.UI_ShowScore_Cbx);
            this.MaximumSize = new System.Drawing.Size(431, 174);
            this.MinimumSize = new System.Drawing.Size(431, 174);
            this.Name = "BallzForm";
            this.Text = "CMPE1666 Lab3_DareenKN - Ballz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox UI_ShowScore_Cbx;
        private System.Windows.Forms.CheckBox UI_ShowAnimationSpeed_Cbx;
        private System.Windows.Forms.Button UI_Play_Btn;
        private System.Windows.Forms.Timer UI_GameOn_Tmr;
    }
}

