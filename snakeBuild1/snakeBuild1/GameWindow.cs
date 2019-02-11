using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace snakeBuild1
{
    public partial class GameWindow : Form
    {
        private int direction = 0;
        private int score = 1;
        private Timer gameLoop = new Timer();
        private Random rand = new Random();
        private Graphics graphics;
        private Snake snake;
        private Food food; 
      
        public GameWindow()
        {
            InitializeComponent();
            snake = new Snake();
            food = new Food(rand);
            gameLoop.Interval = 75; // speed 
            gameLoop.Tick += Update;
            //On_Load();
            
        }

        private void gridPB_Paint(object sender, PaintEventArgs e)
        {
            graphics = gridPB.CreateGraphics();
            snake.Draw(graphics);
            food.Draw(graphics);
        }
        private void GameWindow_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Enter:
                    // we will use this to begin the game
                    break;
                case Keys.Space:
                    // we will use this to pause the game 
                    break;
                case Keys.Right:
                    if (direction != 2)
                    {
                        direction = 0;
                    }
                    break;
                case Keys.Down:
                    if (direction != 3)
                    {
                        direction = 1;
                    }
                    break;
                case Keys.Left:
                    if (direction != 0)
                    {
                        direction = 2;
                    }
                    break;
                case Keys.Up:
                    if (direction !=1)
                    {
                        direction = 3;
                    }
                    break;
            }
        }

        private void Update(object sender, EventArgs e)
        {
            snake.Move(direction);
            for (int i = 1; i < snake.body.Length; i++)
            {
                if (snake.body[0].IntersectsWith(snake.body[i]))
                {
                    Restart();
                }
                if (snake.body[0].X < 0 || snake.body[0].X > 463)
                {
                    Restart();
                }
                if (snake.body[0].Y < 0 || snake.body[0].Y > 336)
                {
                    Restart();
                }
                if (snake.body[0].IntersectsWith(food.square))
                {
                    score++;
                    snake.Grow();
                    food.Generate(rand);

                }
                
                gridPB.Invalidate();
            }

        }

        private void Restart()
        {
            gameLoop.Stop();
            graphics.Clear(SystemColors.Control);
            snake = new Snake();
            food = new Food(rand);
            direction = 0;
            score = 1;

        }
        public void On_Load()//Event that occurs once the program begins or the web page is loaded - NH//
        {
            Brush brush  ;
            Bitmap bitmap;
            bitmap = new Bitmap(1080,1920);
            Graphics graph = Graphics.FromImage(bitmap);
            //graph.FillRectangle(brush, 10, 10, 1080, 1920);
        }
        private void DotRandomizeMethod()//Method used to create & Randomize the location of the Dot - NH//
        {
            Random rand = new Random();


        }
        private void DotLocation()//Method used to locate the dot/fruit for the snake to eat - NH
        {

        }
        private void CreatingDot(int x, int y)// Method to generate a new dot/fruit on the map - NH
        {
            

        }
        public bool BaitProtocol()// This method will be used to manipulate the dot/fruit so it does not appear on the border/snake - NH
        {
            return true; 
        }
        public bool BaitEaten()//Used to determine if the dot/fruit was eaten by the snake or not.
        {
            return false;
        }

    

     
    }

    
}
