namespace pong
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
            this.Ball = new System.Windows.Forms.PictureBox();
            this.Player1 = new System.Windows.Forms.PictureBox();
            this.Player2 = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.Player1Score = new System.Windows.Forms.Label();
            this.Player2Score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).BeginInit();
            this.SuspendLayout();
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Ball.Location = new System.Drawing.Point(315, 148);
            this.Ball.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(20, 18);
            this.Ball.TabIndex = 0;
            this.Ball.TabStop = false;
            // 
            // Player1
            // 
            this.Player1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Player1.Location = new System.Drawing.Point(16, 33);
            this.Player1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(20, 123);
            this.Player1.TabIndex = 1;
            this.Player1.TabStop = false;
            // 
            // Player2
            // 
            this.Player2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Player2.Location = new System.Drawing.Point(1009, 172);
            this.Player2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(20, 123);
            this.Player2.TabIndex = 2;
            this.Player2.TabStop = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // Player1Score
            // 
            this.Player1Score.AutoSize = true;
            this.Player1Score.ForeColor = System.Drawing.Color.Lime;
            this.Player1Score.Location = new System.Drawing.Point(200, 12);
            this.Player1Score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Player1Score.Name = "Player1Score";
            this.Player1Score.Size = new System.Drawing.Size(24, 17);
            this.Player1Score.TabIndex = 3;
            this.Player1Score.Text = "00";
            // 
            // Player2Score
            // 
            this.Player2Score.AutoSize = true;
            this.Player2Score.ForeColor = System.Drawing.Color.Red;
            this.Player2Score.Location = new System.Drawing.Point(800, 12);
            this.Player2Score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Player2Score.Name = "Player2Score";
            this.Player2Score.Size = new System.Drawing.Size(24, 17);
            this.Player2Score.TabIndex = 4;
            this.Player2Score.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(1045, 567);
            this.Controls.Add(this.Player2Score);
            this.Controls.Add(this.Player1Score);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.Ball);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Pong Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.PictureBox Player1;
        private System.Windows.Forms.PictureBox Player2;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label Player1Score;
        private System.Windows.Forms.Label Player2Score;
    }
}

