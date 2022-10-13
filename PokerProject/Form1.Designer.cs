namespace PokerProject
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
            this.DealButton = new System.Windows.Forms.Button();
            this.ShuffleButton = new System.Windows.Forms.Button();
            this.yourHandCard1 = new System.Windows.Forms.Label();
            this.yourHandCard2 = new System.Windows.Forms.Label();
            this.yourHandCard3 = new System.Windows.Forms.Label();
            this.yourCardHand4 = new System.Windows.Forms.Label();
            this.yourHandCard5 = new System.Windows.Forms.Label();
            this.theirCard1lbl = new System.Windows.Forms.Label();
            this.theirCard2lbl = new System.Windows.Forms.Label();
            this.theirCard3lbl = new System.Windows.Forms.Label();
            this.theirCard4lbl = new System.Windows.Forms.Label();
            this.theirCard5lbl = new System.Windows.Forms.Label();
            this.btnShowHand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DealButton
            // 
            this.DealButton.Location = new System.Drawing.Point(713, 179);
            this.DealButton.Name = "DealButton";
            this.DealButton.Size = new System.Drawing.Size(75, 23);
            this.DealButton.TabIndex = 0;
            this.DealButton.Text = "Deal";
            this.DealButton.UseVisualStyleBackColor = true;
            this.DealButton.Click += new System.EventHandler(this.DealButton_Click);
            // 
            // ShuffleButton
            // 
            this.ShuffleButton.Location = new System.Drawing.Point(713, 137);
            this.ShuffleButton.Name = "ShuffleButton";
            this.ShuffleButton.Size = new System.Drawing.Size(75, 23);
            this.ShuffleButton.TabIndex = 1;
            this.ShuffleButton.Text = "Shuffle";
            this.ShuffleButton.UseVisualStyleBackColor = true;
            this.ShuffleButton.Click += new System.EventHandler(this.ShuffleButton_Click);
            // 
            // yourHandCard1
            // 
            this.yourHandCard1.AutoSize = true;
            this.yourHandCard1.Location = new System.Drawing.Point(51, 341);
            this.yourHandCard1.Name = "yourHandCard1";
            this.yourHandCard1.Size = new System.Drawing.Size(38, 13);
            this.yourHandCard1.TabIndex = 2;
            this.yourHandCard1.Text = "Card 1";
            // 
            // yourHandCard2
            // 
            this.yourHandCard2.AutoSize = true;
            this.yourHandCard2.Location = new System.Drawing.Point(178, 341);
            this.yourHandCard2.Name = "yourHandCard2";
            this.yourHandCard2.Size = new System.Drawing.Size(38, 13);
            this.yourHandCard2.TabIndex = 3;
            this.yourHandCard2.Text = "Card 2";
            // 
            // yourHandCard3
            // 
            this.yourHandCard3.AutoSize = true;
            this.yourHandCard3.Location = new System.Drawing.Point(303, 341);
            this.yourHandCard3.Name = "yourHandCard3";
            this.yourHandCard3.Size = new System.Drawing.Size(38, 13);
            this.yourHandCard3.TabIndex = 4;
            this.yourHandCard3.Text = "Card 3";
            // 
            // yourCardHand4
            // 
            this.yourCardHand4.AutoSize = true;
            this.yourCardHand4.Location = new System.Drawing.Point(426, 341);
            this.yourCardHand4.Name = "yourCardHand4";
            this.yourCardHand4.Size = new System.Drawing.Size(38, 13);
            this.yourCardHand4.TabIndex = 5;
            this.yourCardHand4.Text = "Card 4";
            // 
            // yourHandCard5
            // 
            this.yourHandCard5.AutoSize = true;
            this.yourHandCard5.Location = new System.Drawing.Point(539, 341);
            this.yourHandCard5.Name = "yourHandCard5";
            this.yourHandCard5.Size = new System.Drawing.Size(38, 13);
            this.yourHandCard5.TabIndex = 6;
            this.yourHandCard5.Text = "Card 5";
            // 
            // theirCard1lbl
            // 
            this.theirCard1lbl.AutoSize = true;
            this.theirCard1lbl.Location = new System.Drawing.Point(36, 51);
            this.theirCard1lbl.Name = "theirCard1lbl";
            this.theirCard1lbl.Size = new System.Drawing.Size(35, 13);
            this.theirCard1lbl.TabIndex = 7;
            this.theirCard1lbl.Text = "Card1";
            // 
            // theirCard2lbl
            // 
            this.theirCard2lbl.AutoSize = true;
            this.theirCard2lbl.Location = new System.Drawing.Point(158, 51);
            this.theirCard2lbl.Name = "theirCard2lbl";
            this.theirCard2lbl.Size = new System.Drawing.Size(38, 13);
            this.theirCard2lbl.TabIndex = 8;
            this.theirCard2lbl.Text = "Card 2";
            // 
            // theirCard3lbl
            // 
            this.theirCard3lbl.AutoSize = true;
            this.theirCard3lbl.Location = new System.Drawing.Point(290, 51);
            this.theirCard3lbl.Name = "theirCard3lbl";
            this.theirCard3lbl.Size = new System.Drawing.Size(38, 13);
            this.theirCard3lbl.TabIndex = 9;
            this.theirCard3lbl.Text = "Card 3";
            // 
            // theirCard4lbl
            // 
            this.theirCard4lbl.AutoSize = true;
            this.theirCard4lbl.Location = new System.Drawing.Point(411, 51);
            this.theirCard4lbl.Name = "theirCard4lbl";
            this.theirCard4lbl.Size = new System.Drawing.Size(35, 13);
            this.theirCard4lbl.TabIndex = 10;
            this.theirCard4lbl.Text = "Card4";
            // 
            // theirCard5lbl
            // 
            this.theirCard5lbl.AutoSize = true;
            this.theirCard5lbl.Location = new System.Drawing.Point(527, 51);
            this.theirCard5lbl.Name = "theirCard5lbl";
            this.theirCard5lbl.Size = new System.Drawing.Size(38, 13);
            this.theirCard5lbl.TabIndex = 11;
            this.theirCard5lbl.Text = "Card 5";
            // 
            // btnShowHand
            // 
            this.btnShowHand.Location = new System.Drawing.Point(713, 229);
            this.btnShowHand.Name = "btnShowHand";
            this.btnShowHand.Size = new System.Drawing.Size(75, 23);
            this.btnShowHand.TabIndex = 12;
            this.btnShowHand.Text = "Show Hand";
            this.btnShowHand.UseVisualStyleBackColor = true;
            this.btnShowHand.Click += new System.EventHandler(this.btnShowHand_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowHand);
            this.Controls.Add(this.theirCard5lbl);
            this.Controls.Add(this.theirCard4lbl);
            this.Controls.Add(this.theirCard3lbl);
            this.Controls.Add(this.theirCard2lbl);
            this.Controls.Add(this.theirCard1lbl);
            this.Controls.Add(this.yourHandCard5);
            this.Controls.Add(this.yourCardHand4);
            this.Controls.Add(this.yourHandCard3);
            this.Controls.Add(this.yourHandCard2);
            this.Controls.Add(this.yourHandCard1);
            this.Controls.Add(this.ShuffleButton);
            this.Controls.Add(this.DealButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DealButton;
        private System.Windows.Forms.Button ShuffleButton;
        private System.Windows.Forms.Label yourHandCard1;
        private System.Windows.Forms.Label yourHandCard2;
        private System.Windows.Forms.Label yourHandCard3;
        private System.Windows.Forms.Label yourCardHand4;
        private System.Windows.Forms.Label yourHandCard5;
        private System.Windows.Forms.Label theirCard1lbl;
        private System.Windows.Forms.Label theirCard2lbl;
        private System.Windows.Forms.Label theirCard3lbl;
        private System.Windows.Forms.Label theirCard4lbl;
        private System.Windows.Forms.Label theirCard5lbl;
        private System.Windows.Forms.Button btnShowHand;
    }
}

