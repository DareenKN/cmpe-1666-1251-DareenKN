namespace ICA6_DareenKN
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
            this.UI_LoadCards_Btn = new System.Windows.Forms.Button();
            this.UI_ShuffleCards_Btn = new System.Windows.Forms.Button();
            this.UI_DealHands_Btn = new System.Windows.Forms.Button();
            this.UI_DetermineWinner_Btn = new System.Windows.Forms.Button();
            this.UI_StartingDeck_Lbx = new System.Windows.Forms.ListBox();
            this.UI_ShuffledDeck_Lbx = new System.Windows.Forms.ListBox();
            this.UI_PlayersHands_Lbx = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UI_Winner_Tbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UI_LoadCards_Btn
            // 
            this.UI_LoadCards_Btn.Location = new System.Drawing.Point(23, 58);
            this.UI_LoadCards_Btn.Name = "UI_LoadCards_Btn";
            this.UI_LoadCards_Btn.Size = new System.Drawing.Size(155, 45);
            this.UI_LoadCards_Btn.TabIndex = 1;
            this.UI_LoadCards_Btn.Text = "Load Cards";
            this.UI_LoadCards_Btn.UseVisualStyleBackColor = true;
            this.UI_LoadCards_Btn.Click += new System.EventHandler(this.UI_LoadCards_Btn_Click);
            // 
            // UI_ShuffleCards_Btn
            // 
            this.UI_ShuffleCards_Btn.Location = new System.Drawing.Point(23, 142);
            this.UI_ShuffleCards_Btn.Name = "UI_ShuffleCards_Btn";
            this.UI_ShuffleCards_Btn.Size = new System.Drawing.Size(155, 45);
            this.UI_ShuffleCards_Btn.TabIndex = 2;
            this.UI_ShuffleCards_Btn.Text = "Shuffle Cards";
            this.UI_ShuffleCards_Btn.UseVisualStyleBackColor = true;
            this.UI_ShuffleCards_Btn.Click += new System.EventHandler(this.UI_ShuffleCards_Btn_Click);
            // 
            // UI_DealHands_Btn
            // 
            this.UI_DealHands_Btn.Location = new System.Drawing.Point(23, 224);
            this.UI_DealHands_Btn.Name = "UI_DealHands_Btn";
            this.UI_DealHands_Btn.Size = new System.Drawing.Size(155, 45);
            this.UI_DealHands_Btn.TabIndex = 3;
            this.UI_DealHands_Btn.Text = "Deal Hands";
            this.UI_DealHands_Btn.UseVisualStyleBackColor = true;
            this.UI_DealHands_Btn.Click += new System.EventHandler(this.UI_DealHands_Btn_Click);
            // 
            // UI_DetermineWinner_Btn
            // 
            this.UI_DetermineWinner_Btn.Location = new System.Drawing.Point(23, 303);
            this.UI_DetermineWinner_Btn.Name = "UI_DetermineWinner_Btn";
            this.UI_DetermineWinner_Btn.Size = new System.Drawing.Size(155, 45);
            this.UI_DetermineWinner_Btn.TabIndex = 4;
            this.UI_DetermineWinner_Btn.Text = "Determine Winner";
            this.UI_DetermineWinner_Btn.UseVisualStyleBackColor = true;
            this.UI_DetermineWinner_Btn.Click += new System.EventHandler(this.UI_DetermineWinner_Btn_Click);
            // 
            // UI_StartingDeck_Lbx
            // 
            this.UI_StartingDeck_Lbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.UI_StartingDeck_Lbx.FormattingEnabled = true;
            this.UI_StartingDeck_Lbx.Location = new System.Drawing.Point(206, 58);
            this.UI_StartingDeck_Lbx.Name = "UI_StartingDeck_Lbx";
            this.UI_StartingDeck_Lbx.Size = new System.Drawing.Size(175, 290);
            this.UI_StartingDeck_Lbx.TabIndex = 5;
            this.UI_StartingDeck_Lbx.TabStop = false;
            // 
            // UI_ShuffledDeck_Lbx
            // 
            this.UI_ShuffledDeck_Lbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.UI_ShuffledDeck_Lbx.FormattingEnabled = true;
            this.UI_ShuffledDeck_Lbx.Location = new System.Drawing.Point(404, 58);
            this.UI_ShuffledDeck_Lbx.Name = "UI_ShuffledDeck_Lbx";
            this.UI_ShuffledDeck_Lbx.Size = new System.Drawing.Size(175, 290);
            this.UI_ShuffledDeck_Lbx.TabIndex = 6;
            this.UI_ShuffledDeck_Lbx.TabStop = false;
            // 
            // UI_PlayersHands_Lbx
            // 
            this.UI_PlayersHands_Lbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.UI_PlayersHands_Lbx.FormattingEnabled = true;
            this.UI_PlayersHands_Lbx.Location = new System.Drawing.Point(605, 58);
            this.UI_PlayersHands_Lbx.Name = "UI_PlayersHands_Lbx";
            this.UI_PlayersHands_Lbx.Size = new System.Drawing.Size(175, 290);
            this.UI_PlayersHands_Lbx.TabIndex = 7;
            this.UI_PlayersHands_Lbx.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Starting Deck";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Shuffled Deck";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(655, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Players Hands";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(672, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Winner";
            // 
            // UI_Winner_Tbx
            // 
            this.UI_Winner_Tbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UI_Winner_Tbx.Location = new System.Drawing.Point(605, 393);
            this.UI_Winner_Tbx.Name = "UI_Winner_Tbx";
            this.UI_Winner_Tbx.ReadOnly = true;
            this.UI_Winner_Tbx.Size = new System.Drawing.Size(175, 20);
            this.UI_Winner_Tbx.TabIndex = 8;
            this.UI_Winner_Tbx.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_Winner_Tbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_PlayersHands_Lbx);
            this.Controls.Add(this.UI_ShuffledDeck_Lbx);
            this.Controls.Add(this.UI_StartingDeck_Lbx);
            this.Controls.Add(this.UI_DetermineWinner_Btn);
            this.Controls.Add(this.UI_DealHands_Btn);
            this.Controls.Add(this.UI_ShuffleCards_Btn);
            this.Controls.Add(this.UI_LoadCards_Btn);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UI_LoadCards_Btn;
        private System.Windows.Forms.Button UI_ShuffleCards_Btn;
        private System.Windows.Forms.Button UI_DealHands_Btn;
        private System.Windows.Forms.Button UI_DetermineWinner_Btn;
        private System.Windows.Forms.ListBox UI_StartingDeck_Lbx;
        private System.Windows.Forms.ListBox UI_ShuffledDeck_Lbx;
        private System.Windows.Forms.ListBox UI_PlayersHands_Lbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UI_Winner_Tbx;
    }
}

