namespace Learnin20
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
            this.btnBuyGoats = new System.Windows.Forms.Button();
            this.lblGoats = new System.Windows.Forms.Label();
            this.lblGoatCounter = new System.Windows.Forms.Label();
            this.btnSellGoats = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblGoatsCommentary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBuyGoats
            // 
            this.btnBuyGoats.Location = new System.Drawing.Point(12, 191);
            this.btnBuyGoats.Name = "btnBuyGoats";
            this.btnBuyGoats.Size = new System.Drawing.Size(75, 50);
            this.btnBuyGoats.TabIndex = 0;
            this.btnBuyGoats.Text = "Buy Goats";
            this.btnBuyGoats.UseVisualStyleBackColor = true;
            this.btnBuyGoats.Click += new System.EventHandler(this.btnBuyGoats_Click);
            // 
            // lblGoats
            // 
            this.lblGoats.AutoSize = true;
            this.lblGoats.Location = new System.Drawing.Point(24, 31);
            this.lblGoats.Name = "lblGoats";
            this.lblGoats.Size = new System.Drawing.Size(46, 17);
            this.lblGoats.TabIndex = 1;
            this.lblGoats.Text = "Goats";
            this.lblGoats.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblGoatCounter
            // 
            this.lblGoatCounter.AutoSize = true;
            this.lblGoatCounter.Location = new System.Drawing.Point(24, 60);
            this.lblGoatCounter.Name = "lblGoatCounter";
            this.lblGoatCounter.Size = new System.Drawing.Size(46, 17);
            this.lblGoatCounter.TabIndex = 2;
            this.lblGoatCounter.Text = "label1";
            // 
            // btnSellGoats
            // 
            this.btnSellGoats.Location = new System.Drawing.Point(93, 191);
            this.btnSellGoats.Name = "btnSellGoats";
            this.btnSellGoats.Size = new System.Drawing.Size(75, 50);
            this.btnSellGoats.TabIndex = 3;
            this.btnSellGoats.Text = "Sell Goats";
            this.btnSellGoats.UseVisualStyleBackColor = true;
            this.btnSellGoats.Click += new System.EventHandler(this.btnSellGoats_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblGoatsCommentary
            // 
            this.lblGoatsCommentary.AutoSize = true;
            this.lblGoatsCommentary.Location = new System.Drawing.Point(24, 86);
            this.lblGoatsCommentary.Name = "lblGoatsCommentary";
            this.lblGoatsCommentary.Size = new System.Drawing.Size(46, 17);
            this.lblGoatsCommentary.TabIndex = 5;
            this.lblGoatsCommentary.Text = "label1";
            this.lblGoatsCommentary.Click += new System.EventHandler(this.lblGoatsCommentary_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.lblGoatsCommentary);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSellGoats);
            this.Controls.Add(this.lblGoatCounter);
            this.Controls.Add(this.lblGoats);
            this.Controls.Add(this.btnBuyGoats);
            this.Name = "Form1";
            this.Text = "frmMainwindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuyGoats;
        private System.Windows.Forms.Label lblGoats;
        private System.Windows.Forms.Label lblGoatCounter;
        private System.Windows.Forms.Button btnSellGoats;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblGoatsCommentary;
    }
}

