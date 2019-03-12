using System.Drawing;
using System.Windows.Forms;

namespace LabIIVS
{
    class Proyectil : Thing
    {

        private int speed=20;
        private char eje;

        public Proyectil(string s, int x, int y)
        {

            
            switch (s)
            {
                case "a":
                    this.image = Properties.Resources.laserLeft;
                    this.eje = 'x';
                    this.height = 15;
                    this.width = 30;
                    speed *= -1;
                    break;
                case "d":
                    this.image = Properties.Resources.laserRight;
                    this.eje = 'x';
                    this.height = 15;
                    this.width = 30;
                    speed *= 1;
                    break;
                case "s":
                    this.image = Properties.Resources.laserDown;
                    this.eje = 'y';
                    this.height =30;
                    this.width =15;
                    speed *= 1;
                    break;
                case "w":
                    this.image = Properties.Resources.laserUp;
                    this.eje = 'y';
                    this.height = 30;
                    this.width = 15;
                    speed *= -1;
                    break;

            }

            constructPB(x, y);


        }

        public bool move(Player player, Form form)
        {
            if (this.eje == 'x')
            {
                setLocation(getX() + speed, getY());

                if (this.getX() == 1 || this.getX() == 1000)
                {

                    removeElement(player.getPList(), form);
                    return true;
                }

            }
            else
            {

                setLocation(getX(), getY() + speed);

                if (this.getY() == 1 || this.getY() == 600)
                {
                    removeElement(player.getPList(), form);
                    return true;

                }
            }

            
            return false;


        }


    }
}