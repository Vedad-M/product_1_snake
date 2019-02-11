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
        public Rectangle foodSquare;
        private int x;
        private int y;
        private int width = 10;
        private int height = 10;
        //private SolidBrush brush;

        public Food(Random rand) //generating a new food square at a certain X,Y location with set size
        {

            foodSquare = new Rectangle(x, y, width, height);
            x = rand.Next(0, 32) *10;
            y = rand.Next(0, 32) *10;
           // brush = new SolidBrush(Color.Yellow);
            //width = 10;
           // height = 10;

        }

        public void CreateFood(Graphics g)//Drawing the food onto the grid
        {
            foodSquare.X = x;
            foodSquare.Y = y;
            g.FillRectangle(Brushes.OrangeRed, foodSquare);

        }

        public void FoodLocation(Random randLocation)// Generating the location for the food
        {
            x = randLocation.Next(0, 463); //* 10
            y = randLocation.Next(0, 336);//* 10


        }
    }
}
