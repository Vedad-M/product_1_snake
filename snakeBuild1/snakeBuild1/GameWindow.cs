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
            graphics = e.Graphics;
            snake.Draw(graphics);
            food.CreateFood(graphics);

        }
        private void GameWindow_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Enter:
                    startButton_Click(this, e);

                    // we will use this to begin the game
                    break;
                case Keys.Space:
                    if (startButton.Text == "Start Game")
                    {
                        gameLoop.Stop();
                    }
                    else if(startButton.Text == "Pause Game")
                    {
                        
                        gameLoop.Start();
                    }
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
                if (snake.body[0].X < 0 || snake.body[0].X > gridPB.MaximumSize.Width)
                {
                    Restart();
                }
                if (snake.body[0].Y < 0 || snake.body[0].Y > gridPB.MinimumSize.Height)
                {
                    Restart();
                }
                if (snake.body[0].IntersectsWith(food.foodSquare))
                {
                    score++;
                    snake.Grow();
                    food.FoodLocation(rand);

                }
                
               
            }
            gridPB.Invalidate();
        }

        private void Restart()
        {
            gameLoop.Stop();
            gridPB.Container.Dispose();
           // gridPB.graphics.Clear();
            snake = new Snake();
            food = new Food(rand);
            direction = 0;
            score = 1;

        }
        private void startButton_Click(object sender, EventArgs e)
        {
          
            if (startButton.Text == "Start Game")
            {
                gameLoop.Stop();
                startButton.Text = "Pause Game";
            }else if(startButton.Text == "Pause Game")
            {
                gameLoop.Start();
                startButton.Text = "Start Game";
            }
            }

        //public void On_Load()//Event that occurs once the program begins or the web page is loaded - NH//
        //{

        //}
        //private void DotRandomizeMethod()//Method used to create & Randomize the location of the Dot - NH//
        //{


        //}
        //private void DotLocation()//Method used to locate the dot/fruit for the snake to eat - NH
        //{

        //}
        //private void CreatingDot(int x, int y)// Method to generate a new dot/fruit on the map - NH
        //{


        //}
        //public bool BaitProtocol()// This method will be used to manipulate the dot/fruit so it does not appear on the border/snake - NH
        //{
        //    return true; 
        //}
        //public bool BaitEaten()//Used to determine if the dot/fruit was eaten by the snake or not.
        //{
        //    return false;
        //}


    }

    
}
