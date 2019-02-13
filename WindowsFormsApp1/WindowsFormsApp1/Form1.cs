using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int dir = 0;
        private Timer gameLoop = new Timer();
        private Random rnd = new Random();
        private Graphics g;
        private Snake snake;
        private Food food;

        public Form1()
        {
            InitializeComponent();
            snake = new Snake();
            food = new Food(rnd);
            gameLoop.Interval = 75;
            gameLoop.Tick += Update;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Enter:
                    gameLoop.Start();
                    break;
                case Keys.Right:
                    if (dir != 1)
                        dir = 0;
                    break;
                case Keys.Left:
                    if (dir != 0)
                        dir = 1;
                    break;
                case Keys.Up:
                    if (dir != 2)
                        dir = 3;
                    break;
                case Keys.Down:
                    if (dir != 3)
                        dir = 2;
                    break;
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = this.CreateGraphics();
            snake.Draw(g);
            food.Draw(g);
        }
        private void Update(object sender, EventArgs e)
        {
            snake.Move(dir);
            for (int i = 1; i < snake.Body.Length; i++)         
                if (snake.Body[0].IntersectsWith(snake.Body[i]))
                    Restart();
            if (snake.Body[0].X < 0 || snake.Body[0].X > 290)
                Restart();
            if (snake.Body[0].Y < 0 || snake.Body[0].Y > 190)
                Restart();
            if (snake.Body[0].IntersectsWith(food.Piece))
                {
                    snake.Grow();
                    food.GenerateFood(rnd);
                }      
            this.Invalidate();
        }
        private void Restart()
        {
            gameLoop.Stop();
            g.Clear(SystemColors.Control);
            snake = new Snake();
            food = new Food(rnd);
            dir = 0;
        }

      
    }
}
