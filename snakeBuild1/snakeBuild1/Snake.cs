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
        public Rectangle[] body;
        private int X =0, Y=0, width = 10, height = 10;
        
        public Snake()
        {
            Random rand = new Random();
            X = rand.Next(0, 463);
            Y = rand.Next(0, 336);
            body = new Rectangle[1];
            body[0] = new Rectangle(X,Y ,width, height);
        }
        public void Draw()
        {
            for (int i = body.Length-1; i > 0 ; i--)
            {
                body[i] = body[i - 1];
            }
        }
        public void Draw(Graphics g)
        {
            g.FillRectangles(Brushes.Green, body);
        }

        public void Move(int direction)
        {
            Draw();
            switch(direction)
            {
                case 0: // right
                    body[0].X += 10;
                    break;
                case 1:// down
                    body[0].Y += 10;
                    break;
                case 2:// left 
                    body[0].X -= 10;
                    break;
                case 3://up 
                    body[0].Y -= 10;
                    break;
            }
        }

        public void Grow()
        {
            List<Rectangle> temp = body.ToList();
            temp.Add(new Rectangle(body[body.Length - 1].X, body[body.Length - 1].Y, width, height));
            body = temp.ToArray();

       
        }
    }
}
