using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeBuild1
{
    public class Snake
    {
        public Rectangle[] Body;
        public int x = 0;
        public int y = 50;
        private int width = 10;
        private int height = 10;

        public Snake()
        {
            Body = new Rectangle[3];
            Body[0] = new Rectangle(x, y, width, height);
        }
        public void Draw()
        {
            for (int i = Body.Length - 1; i > 0; i--)
            {
                Body[i] = Body[i - 1];
            }
        }
        public void Draw(Graphics g)
        {
            g.FillRectangles(Brushes.Blue, Body);
        }
        public void Move(int move)
        {
            Draw();
            switch (move)
            {
                case 0:
                    Body[0].X += 10;
                    break;
                case 1:
                    Body[0].X -= 10;
                    break;
                case 2:
                    Body[0].Y += 10;
                    break;
                case 3:
                    Body[0].Y -= 10;
                    break;
            }
        }
        public void Grow()
        {
            List<Rectangle> temp = Body.ToList();
            temp.Add(new Rectangle(Body[Body.Length - 1].X, Body[Body.Length - 1].Y, width, height));
            Body = temp.ToArray();
        }
    }
}
