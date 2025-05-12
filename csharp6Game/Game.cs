using SimpleArkanoid;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp6Game
{
    public class Game
    {
        public int Width { get; }
        public int Height { get; }
        public float PaddleX { get; set; }
        public Ball Ball { get; private set; }
        public List<Particle> Particles { get; } = new List<Particle>();
        public int Lives { get; set; } = 3;
        public int Score { get; set; } = 0;
        public int Level { get; set; } = 1;
        public bool GameOver { get; set; } = false;

        public float PaddleWidth = 100;
        private const float PaddleHeight = 15;
        private const float PaddleYOffset = 30;
        private readonly Random random = new Random();

        public Game(int width, int height)
        {
            Width = width;
            Height = height;
            PaddleX = width / 2;
            InitializeBall();
            InitializeLevel(Level);
        }

        public void InitializeLevel(int level)
        {
            Level = level;
            Particles.Clear();
            GameOver = false;


            Particles.AddRange(Particle.CreateParticles(level, Width, Height, random));
        }


        private void InitializeBall()
        {
            Ball = new Ball(Width / 2, Height - 50, 12)
            {
                VelocityX = random.Next(-5, 6),
                VelocityY = -5
            } ;
        }

        public void DrawPaddle(Graphics g)
        {
            g.FillRectangle(Brushes.DeepSkyBlue,
                PaddleX - PaddleWidth / 2,
                Height - PaddleYOffset - PaddleHeight / 2,
                PaddleWidth,
                PaddleHeight);
        }

        public void Update()
        {
            // Движение мяча
            Ball.X += Ball.VelocityX;
            Ball.Y += Ball.VelocityY;

            // Столкновение со стенами
            if (Ball.X - Ball.Radius < 0 || Ball.X + Ball.Radius > Width)
                Ball.VelocityX *= -1;
            if (Ball.Y - Ball.Radius < 0)
                Ball.VelocityY *= -1;

            // Проверка проигрыша
            if (Ball.Y + Ball.Radius > Height)
            {
                Lives--;
                if (Lives <= 0)
                    GameOver = true;
                else
                    InitializeBall();
            }

            // Столкновение с платформой
            if (Ball.Y + Ball.Radius > Height - PaddleYOffset - PaddleHeight / 2 &&
                Ball.Y - Ball.Radius < Height - PaddleYOffset + PaddleHeight / 2 &&
                Ball.X > PaddleX - PaddleWidth / 2 &&
                Ball.X < PaddleX + PaddleWidth / 2)
            {
                float hitPos = (Ball.X - PaddleX) / (PaddleWidth / 2);
                Ball.VelocityX = hitPos * 8;
                Ball.VelocityY = -Math.Abs(Ball.VelocityY);
            }

            // Обновление частиц и проверка столкновений
            UpdateParticles();

            // Проверка завершения уровня
            if (Particles.Count == 0)
            {
                Level++;
                InitializeLevel(Level);
                InitializeBall();
            }
        }

        private void UpdateParticles()
        {
            foreach (var particle in Particles.ToArray())
            {
                particle.Update(Width, Height / 2);

                if (particle.CheckCollision(Ball))
                {
                    Particles.Remove(particle);
                    Score += particle.Score;
                    particle.HandleCollision(Ball);
                }
            }
        }

        public void Draw(Graphics g)
        {
            DrawPaddle(g);
            Ball.Draw(g);

            // Отрисовка частиц
            foreach (var particle in Particles)
            {
                particle.Draw(g);


            }

        }


    }
}
