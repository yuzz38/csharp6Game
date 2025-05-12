using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace csharp6Game
{
    public partial class Form1 : Form
    {
        public Game game;
        private Bitmap buffer;
        private Font uiFont = new Font("Arial", 12);

        public Form1()
        {
            InitializeComponent();
            gameCanvas.Paint += (s, e) =>
            {
                if (buffer != null)
                {
                    e.Graphics.DrawImage(buffer, 0, 0);
                }
            };
            InitializeGame();
        }

        private void InitializeGame()

        {

            // Создаем буфер для рисования
            buffer = new Bitmap(gameCanvas.Width, gameCanvas.Height);

            // Инициализируем игру
            game = new Game(gameCanvas.Width, gameCanvas.Height);
            game.InitializeLevel(1);
            Redraw();

            // Настраиваем таймер
            gameTimer.Interval = 10;
            gameTimer.Tick += GameLoop;
            gameTimer.Start();

            // Обработчики событий
            gameCanvas.MouseMove += (s, e) => game.PaddleX = e.X;
          
            trackBar.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.R)
                {
                    game = new Game(gameCanvas.Width, gameCanvas.Height);
                    game.InitializeLevel(1);
                    Redraw();
                }
            };
            trackBar1.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.R)
                {
                    game = new Game(gameCanvas.Width, gameCanvas.Height);
                    game.InitializeLevel(1);
                    Redraw();
                }
            };
            trackBarSize.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.R)
                {
                    game = new Game(gameCanvas.Width, gameCanvas.Height);
                    game.InitializeLevel(1);
                    Redraw();
                }
            };
        }
        private void Redraw()
        {
            if (buffer == null) return;

            using (var g = Graphics.FromImage(buffer))
            {
                g.Clear(Color.Black);

                // Отрисовка игры
                game.Draw(g);
                game.DrawPaddle(g);
                // Отрисовка UI
                g.DrawString($"ЖИЗНИ: {game.Lives}", uiFont, Brushes.White, 10, 10);
                g.DrawString($"ОЧКИ: {game.Score}", uiFont, Brushes.White, 10, 30);
                g.DrawString($"УРОВЕНЬ: {game.Level}", uiFont, Brushes.White, 10, 50);

                if (game.GameOver)
                {
                    var font = new Font("Arial", 32, FontStyle.Bold);
                    string text = "ПРОИГРАЛ";
                    var size = g.MeasureString(text, font);
                    g.DrawString(text, font, Brushes.Red,
                        (gameCanvas.Width - size.Width) / 2,
                        (gameCanvas.Height - size.Height) / 2);
                }
            }

            gameCanvas.Invalidate(); // Вызовет OnPaint
        }
        private void GameLoop(object sender, EventArgs e)
        {
            // Обновление игры
            if (!game.GameOver)
            {
                game.Update();
            }

            // Отрисовка
            Redraw();

            // Обновление PictureBox
            using (var g = gameCanvas.CreateGraphics())
            {
                g.DrawImage(buffer, 0, 0);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (buffer != null)
            {
                e.Graphics.DrawImage(buffer, 0, 0);
            }
        }

        

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            gameTimer.Interval = trackBar.Value;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            game.PaddleWidth = trackBar1.Value;  
            Redraw();
        }

        private void labelBallSize_Click(object sender, EventArgs e)
        {

        }

        private void trackBarSize_Scroll(object sender, EventArgs e)
        {
            game.Ball.Radius = trackBarSize.Value;

            // Перерисовываем экран
            Redraw();
        }
    }
}
