namespace csharp6Game
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameCanvas = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.labelWidthPlatform = new System.Windows.Forms.Label();
            this.trackBarSize = new System.Windows.Forms.TrackBar();
            this.labelBallSize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gameCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).BeginInit();
            this.SuspendLayout();
            // 
            // gameCanvas
            // 
            this.gameCanvas.BackColor = System.Drawing.Color.Black;
            this.gameCanvas.Dock = System.Windows.Forms.DockStyle.Top;
            this.gameCanvas.Location = new System.Drawing.Point(0, 0);
            this.gameCanvas.Name = "gameCanvas";
            this.gameCanvas.Size = new System.Drawing.Size(938, 750);
            this.gameCanvas.TabIndex = 0;
            this.gameCanvas.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 4000;
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(12, 780);
            this.trackBar.Maximum = 50;
            this.trackBar.Minimum = 1;
            this.trackBar.Name = "trackBar";
            this.trackBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBar.Size = new System.Drawing.Size(262, 56);
            this.trackBar.TabIndex = 1;
            this.trackBar.Value = 50;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpeed.ForeColor = System.Drawing.Color.White;
            this.labelSpeed.Location = new System.Drawing.Point(57, 745);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(152, 36);
            this.labelSpeed.TabIndex = 2;
            this.labelSpeed.Text = "Скорость";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(301, 780);
            this.trackBar1.Maximum = 200;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(310, 56);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // labelWidthPlatform
            // 
            this.labelWidthPlatform.AutoSize = true;
            this.labelWidthPlatform.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWidthPlatform.ForeColor = System.Drawing.Color.White;
            this.labelWidthPlatform.Location = new System.Drawing.Point(291, 745);
            this.labelWidthPlatform.Name = "labelWidthPlatform";
            this.labelWidthPlatform.Size = new System.Drawing.Size(320, 36);
            this.labelWidthPlatform.TabIndex = 4;
            this.labelWidthPlatform.Text = "Ширина платформы";
            this.labelWidthPlatform.Click += new System.EventHandler(this.label2_Click);
            // 
            // trackBarSize
            // 
            this.trackBarSize.Location = new System.Drawing.Point(674, 780);
            this.trackBarSize.Maximum = 60;
            this.trackBarSize.Minimum = 10;
            this.trackBarSize.Name = "trackBarSize";
            this.trackBarSize.Size = new System.Drawing.Size(223, 56);
            this.trackBarSize.TabIndex = 5;
            this.trackBarSize.Value = 10;
            this.trackBarSize.Scroll += new System.EventHandler(this.trackBarSize_Scroll);
            // 
            // labelBallSize
            // 
            this.labelBallSize.AutoSize = true;
            this.labelBallSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBallSize.ForeColor = System.Drawing.Color.White;
            this.labelBallSize.Location = new System.Drawing.Point(717, 741);
            this.labelBallSize.Name = "labelBallSize";
            this.labelBallSize.Size = new System.Drawing.Size(126, 36);
            this.labelBallSize.TabIndex = 6;
            this.labelBallSize.Text = "Размер";
            this.labelBallSize.Click += new System.EventHandler(this.labelBallSize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(938, 985);
            this.Controls.Add(this.labelBallSize);
            this.Controls.Add(this.trackBarSize);
            this.Controls.Add(this.labelWidthPlatform);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.gameCanvas);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ISTBGAME";
            ((System.ComponentModel.ISupportInitialize)(this.gameCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox gameCanvas;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label labelWidthPlatform;
        private System.Windows.Forms.TrackBar trackBarSize;
        private System.Windows.Forms.Label labelBallSize;
    }
}