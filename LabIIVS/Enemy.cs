using System;
using System.Drawing;

namespace LabIIVS
{
    class Enemy : Thing
    {

        //float xincr = 0.5f, yincr = 0.5f;

        private int speed;

        private int dir;

        

        public Enemy(int x, int y)
        {
            Random rand = new Random();

            dir = rand.Next(1, 9);

            this.image = Properties.Resources.enemy1;
            
            this.height = 75;
            this.width = 75;

            constructPB(x, y);

        }

        /*
        public void move()
        {
            Random rand = new Random();

            int randomMove = rand.Next(1, 5);

            // 1 arriba 2 der 3 izq 4 abajo 5 arriba izq 6 arriba der 7 abajo der 8 abajo izq

            if (x == 1)
            {
                if (y == 1) doblar(3, 8, 5, 1);
                else if (y == 600) doblar(3, 4, 5, 7);
                else doblar ()

            }

            switch(dir)
            {
                case 1:
                    y--;
                    break;
                case 2:
                    x++;
                    break;
                case 3:
                    x--;
                    break;
                case 4:
                    y++;
                    break;
                case 5:
                    y--;
                    x--;
                    break;
                case 6:
                    y--;
                    x++;
                    break;
                case 7:
                    y++;
                    x++;
                    break;
                case 8:
                    y++;
                    x--;
                    break;

            }
            

            if (randomMove == 1 && x != 78) x += xincr;
            if (randomMove == 2 && x != 2) x -= xincr;
            if (randomMove == 3 && y != 2) y -= yincr;
            if (randomMove == 4 && y != 24) y += yincr;

        }

        public int doblar(int dir1, int dir2, int dir3, int dir4)
        {
            int newDir;
            Random random = new Random();

            do
            {
                newDir = random.Next(1, 9);

            } while (newDir != dir1 && newDir != dir2 && newDir != dir3 && newDir!=dir4);

            return newDir;

        }
        */
        

    }
}