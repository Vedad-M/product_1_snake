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
        public GameWindow()
        {
            InitializeComponent();
            On_Load();
        }
        

        public void On_Load()//Event that occurs once the program begins or the web page is loaded - NH//
        {
            Brush brush =;
            Bitmap bitmap;
            bitmap = new Bitmap(1080,1920);
            Graphics graph = Graphics.FromImage(bitmap);
            graph.FillRectangle(brush, 10, 10, 1080, 1920);
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
