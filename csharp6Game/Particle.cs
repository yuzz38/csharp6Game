using SimpleArkanoid;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp6Game
{
    public class Particle
    {
        public float X { get; private set; }
        public float Y { get; private set; }
        public int Size { get; }
        public Color Color { get; }
        public int Score { get; }
        public float VelocityX { get; private set; }
        public float VelocityY { get; private set; }

        public Particle(float x, float y, int size, Color color, int score, float velocityX, float velocityY)
        {
            X = x;
            Y = y;
            Size = size;
            Color = color;
            Score = score;
            VelocityX = velocityX;
            VelocityY = velocityY;
        }

        public static IEnumerable<Particle> CreateParticles(int level, int width, int height, Random random)
        {
            int count = 50;
            for (int i = 0; i < count; i++)
            {
                yield return new Particle(
                    x: random.Next(50, width - 50),
                    y: random.Next(50, height / 2),
                    size: random.Next(10, 20),
                    color: Color.FromArgb(random.Next(150, 256), random.Next(150, 256), random.Next(150, 256)),
                    score: (15 - random.Next(5, 15)) * level,
                    velocityX: (float)(random.NextDouble() * 4 - 2),
                    velocityY: (float)(random.NextDouble() * 4 - 2)
                );
            }
        }

        public void Update(int fieldWidth, int fieldHeight)
        {
            X += VelocityX;
            Y += VelocityY;

            // Отскок от границ
            if (X < 0 || X > fieldWidth) VelocityX *= -1;
            if (Y < 0 || Y > fieldHeight) VelocityY *= -1;
        }

        public bool CheckCollision(Ball ball)
        {
            float dx = ball.X - X;
            float dy = ball.Y - Y;
            float distance = (float)Math.Sqrt(dx * dx + dy * dy);
            return distance < ball.Radius + Size / 2;
        }

        public void HandleCollision(Ball ball)
        {
            float dx = ball.X - X;
            float dy = ball.Y - Y;
            float distance = (float)Math.Sqrt(dx * dx + dy * dy);

            ball.VelocityX = dx / distance * 5;
            ball.VelocityY = dy / distance * 5;
        }

        public void Draw(Graphics g)
        {

            // Основная частица
            g.FillEllipse(new SolidBrush(Color), X - Size / 2, Y - Size / 2, Size, Size);
        }
    }
}
