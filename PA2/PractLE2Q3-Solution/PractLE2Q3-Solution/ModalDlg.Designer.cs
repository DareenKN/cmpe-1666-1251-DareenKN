
namespace PractLE2Q3_Solution
{
    partial class ModalDlg
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
            this.UI_Temp_TrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.UI_Hum_TrackBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.UI_OK_Btn = new System.Windows.Forms.Button();
            this.UI_Cancel_Btn = new System.Windows.Forms.Button();
            this.UI_Temp_Label = new System.Windows.Forms.Label();
            this.UI_Hum_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UI_Temp_TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_Hum_TrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_Temp_TrackBar
            // 
            this.UI_Temp_TrackBar.Location = new System.Drawing.Point(203, 71);
            this.UI_Temp_TrackBar.Maximum = 35;
            this.UI_Temp_TrackBar.Minimum = -35;
            this.UI_Temp_TrackBar.Name = "UI_Temp_TrackBar";
            this.UI_Temp_TrackBar.Size = new System.Drawing.Size(395, 45);
            this.UI_Temp_TrackBar.TabIndex = 0;
            this.UI_Temp_TrackBar.Scroll += new System.EventHandler(this.UI_Temp_TrackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Temperature:";
            // 
            // UI_Hum_TrackBar
            // 
            this.UI_Hum_TrackBar.Location = new System.Drawing.Point(203, 133);
            this.UI_Hum_TrackBar.Maximum = 100;
            this.UI_Hum_TrackBar.Name = "UI_Hum_TrackBar";
            this.UI_Hum_TrackBar.Size = new System.Drawing.Size(395, 45);
            this.UI_Hum_TrackBar.TabIndex = 2;
            this.UI_Hum_TrackBar.Scroll += new System.EventHandler(this.UI_Hum_TrackBar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Humidity:";
            // 
            // UI_OK_Btn
            // 
            this.UI_OK_Btn.Location = new System.Drawing.Point(203, 245);
            this.UI_OK_Btn.Name = "UI_OK_Btn";
            this.UI_OK_Btn.Size = new System.Drawing.Size(105, 52);
            this.UI_OK_Btn.TabIndex = 4;
            this.UI_OK_Btn.Text = "OK";
            this.UI_OK_Btn.UseVisualStyleBackColor = true;
            this.UI_OK_Btn.Click += new System.EventHandler(this.UI_OK_Btn_Click);
            // 
            // UI_Cancel_Btn
            // 
            this.UI_Cancel_Btn.Location = new System.Drawing.Point(472, 245);
            this.UI_Cancel_Btn.Name = "UI_Cancel_Btn";
            this.UI_Cancel_Btn.Size = new System.Drawing.Size(105, 52);
            this.UI_Cancel_Btn.TabIndex = 5;
            this.UI_Cancel_Btn.Text = "Cancel";
            this.UI_Cancel_Btn.UseVisualStyleBackColor = true;
            this.UI_Cancel_Btn.Click += new System.EventHandler(this.UI_Cancel_Btn_Click);
            // 
            // UI_Temp_Label
            // 
            this.UI_Temp_Label.AutoSize = true;
            this.UI_Temp_Label.Location = new System.Drawing.Point(615, 81);
            this.UI_Temp_Label.Name = "UI_Temp_Label";
            this.UI_Temp_Label.Size = new System.Drawing.Size(49, 13);
            this.UI_Temp_Label.TabIndex = 6;
            this.UI_Temp_Label.Text = "0 Celsius";
            // 
            // UI_Hum_Label
            // 
            this.UI_Hum_Label.AutoSize = true;
            this.UI_Hum_Label.Location = new System.Drawing.Point(615, 146);
            this.UI_Hum_Label.Name = "UI_Hum_Label";
            this.UI_Hum_Label.Size = new System.Drawing.Size(24, 13);
            this.UI_Hum_Label.TabIndex = 7;
            this.UI_Hum_Label.Text = "0 %";
            // 
            // ModalDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.UI_Hum_Label);
            this.Controls.Add(this.UI_Temp_Label);
            this.Controls.Add(this.UI_Cancel_Btn);
            this.Controls.Add(this.UI_OK_Btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UI_Hum_TrackBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_Temp_TrackBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModalDlg";
            this.Text = "ModalDlg";
            ((System.ComponentModel.ISupportInitialize)(this.UI_Temp_TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_Hum_TrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar UI_Temp_TrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar UI_Hum_TrackBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UI_OK_Btn;
        private System.Windows.Forms.Button UI_Cancel_Btn;
        private System.Windows.Forms.Label UI_Temp_Label;
        private System.Windows.Forms.Label UI_Hum_Label;
    }
}