
namespace Snake_Game
{
    partial class GameTab
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.scoreLabel = new System.Windows.Forms.Label();
            this.snakeHead = new System.Windows.Forms.PictureBox();
            this.apple = new System.Windows.Forms.PictureBox();
            this.groupBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.snakeHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timerEvent);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.scoreLabel.ForeColor = System.Drawing.Color.Lime;
            this.scoreLabel.Location = new System.Drawing.Point(12, 12);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(115, 31);
            this.scoreLabel.TabIndex = 3;
            this.scoreLabel.Text = "Score: 0";
            // 
            // snakeHead
            // 
            this.snakeHead.BackColor = System.Drawing.Color.SpringGreen;
            this.snakeHead.Location = new System.Drawing.Point(371, 204);
            this.snakeHead.Margin = new System.Windows.Forms.Padding(0);
            this.snakeHead.Name = "snakeHead";
            this.snakeHead.Size = new System.Drawing.Size(20, 20);
            this.snakeHead.TabIndex = 0;
            this.snakeHead.TabStop = false;
            // 
            // apple
            // 
            this.apple.BackColor = System.Drawing.Color.Crimson;
            this.apple.Location = new System.Drawing.Point(294, 267);
            this.apple.Margin = new System.Windows.Forms.Padding(0);
            this.apple.Name = "apple";
            this.apple.Size = new System.Drawing.Size(20, 20);
            this.apple.TabIndex = 1;
            this.apple.TabStop = false;
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Black;
            this.groupBox.Location = new System.Drawing.Point(34, 74);
            this.groupBox.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(700, 443);
            this.groupBox.TabIndex = 4;
            this.groupBox.TabStop = false;
            // 
            // GameTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.snakeHead);
            this.Controls.Add(this.apple);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.groupBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "GameTab";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GameTab_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameTab_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameTab_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.snakeHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.PictureBox snakeHead;
        private System.Windows.Forms.PictureBox apple;
        private System.Windows.Forms.PictureBox groupBox;
    }
}