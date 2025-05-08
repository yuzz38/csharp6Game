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
            ((System.ComponentModel.ISupportInitialize)(this.gameCanvas)).BeginInit();
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(938, 985);
            this.Controls.Add(this.gameCanvas);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ISTBGAME";
            ((System.ComponentModel.ISupportInitialize)(this.gameCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.PictureBox gameCanvas;
        private System.Windows.Forms.Timer gameTimer;
    }
}