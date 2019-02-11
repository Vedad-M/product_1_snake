using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeBuild1
{
    class Food
    {
        public Rectangle square;
        private int x, y, width = 10, height = 10;

        public Food(Random rand)
        {
            Generate(rand);
            square = new Rectangle(x, y, width, height);

        }

        public void Draw(Graphics g)
        {
            square.X = x;
            square.Y = y;
            g.FillRectangle(Brushes.Red, square);

        }

        public void Generate(Random rand)
        {
            x = rand.Next(0, 463); //width of gridPB 
            y = rand.Next(0, 336); // height of gridPB

          
        }
    }
}
