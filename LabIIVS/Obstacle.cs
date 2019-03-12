using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace LabIIVS
{
    class Obstacle : Thing
    {

        private int speed = 1;
        private int pair;

        
        

        public Obstacle(int x, int y, int pair)      
        {

            this.height = 60;
            this.width = 60;
            this.pair = pair;
            if(pair%2 ==0) this.image = Properties.Resources.obstacle;
            else this.image = Properties.Resources.obstacle;
            
            constructPB(x, y);
            
        }

        public void move()
        {
            if (pair % 2 != 0)
            {
                if (getY() == 1 || getY()+this.height==600) speed = -speed;
                setLocation(getX(), getY()+speed);
            }
            else
            {
                if (getX() == 1 || getX()+this.width==1000) speed = -speed;
                setLocation(getX() + speed, getY());
            }

        }

        public void gotHit(ArrayList oList, Form form)
        {
            /*
            setHeight(getHeight() - this.height/4);
            setWidth(getWidth() - this.width / 4);

            if(this.width<=0 || this.height <= 0)
            {
                removeElement(oList, form);
            }
            */

            removeElement(oList, form);
        }

     
    }
}