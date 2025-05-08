using System.Drawing;

namespace SimpleArkanoid
{
    public class Ball
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float VelocityX { get; set; }
        public float VelocityY { get; set; }
        public int Radius { get; }
        public Color Color { get; } = Color.White;

        public Ball(float x, float y, int radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public void Draw(Graphics g)
        {



            g.FillEllipse(new SolidBrush(Color.DeepSkyBlue), X - Radius, Y - Radius, Radius * 2, Radius * 2);
        }
    }
}