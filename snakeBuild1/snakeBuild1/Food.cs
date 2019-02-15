using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeBuild1
{
   public class Food
    {
        public Rectangle Piece;
        private int x;
        private int y;
        private int width = 10;
        private int height = 10;

        public Food(Random rnd)
        {
            GenerateFood(rnd);
            Piece = new Rectangle(x, y, width, height);
        }
        public void Draw(Graphics g)
        {
            Piece.X = x;
            Piece.Y = y;
            g.FillRectangle(Brushes.Green, Piece);
        }

        public void GenerateFood(Random rnd)
        {
            x = rnd.Next(0, 40) * 10;
            y = rnd.Next(4, 30) * 10;
        }



    }
}
