using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FlappyBird
{
    class Player//отвечает за игрока
    {
        public float x;//координаты 
        public float y;

        public int size;//размер картинки
        public int score;

        public float gravityValue;

        public Image birdImg;//спрайт

        public bool isAlive;

        public Player(int x, int y)//контструктор объявления
        {
            birdImg = new Bitmap("D:\\ProjectsVisual\\FlappyBird\\Image\\bird.png");
            this.x = x;//координаты на входе
            this.y = y;
            size = 50;
            gravityValue = 0.1f;
            isAlive = true;
            score = 0;
        }
    }
}
