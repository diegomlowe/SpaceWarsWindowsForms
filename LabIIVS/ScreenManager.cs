using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;


namespace LabIIVS
{
    class ScreenManager
    {

        //Form form;

        public ScreenManager (){}

        /*
        public ScreenManager(Form fm)
        {

            this.form = fm;

        }

        public void printElement(string c, int x, int y)
        {
            
            Label newLabel = new Label();
            newLabel.Location = new Point(x, y);
            newLabel.Text = c;
            this.form.Controls.Add(newLabel);
            
            
            Console.SetCursorPosition(x, y);
            Console.Write(c);
            
        }

        public void printScreen(bool killedEmAll)
        {

            //(x,1)
            for (int i = 100; i < 800; i++)
            {
                printElement("_", i, 100);            
                
            }
            //(x,24)
            for (int i = 100; i < 800; i++)
            {

                printElement("_", i, 800);

              
            }

            //(2, y)
            for (int i = 200; i < 800; i++)
            {

                printElement("|", 200, i);
                
            }

            //(79, i)
            for (int i = 200; i < 800; i++)
            {

                /*
                if (killedEmAll)
                {
                    if (i == 12 || i == 13)
                    {
                        printElement(" ", 79, i);
                    }

                    else
                    {
                        printElement("|", 79, i);
                        
                    }
                }
                else
                {

                    printElement("|", 800, i);
               // }
            }
        }

        public void gameOver()
        {

            Console.Clear();

            this.printScreen(false);

            Console.SetCursorPosition(35, 13);
            Console.Write("GAME OVER");

            Thread.Sleep(4000);
        }*/

        public void addThingsToLists(ArrayList oList, int oS, ArrayList eList, int eS, Random rand, Form form)
        {
            for (int i = 0; i < oS; i++)
            {

                Obstacle obstacle = new Obstacle(rand.Next(10, 900), rand.Next(2, 600), i);
                oList.Add(obstacle);
                obstacle.printElement(form);

            }

            for (int i = 0; i < eS; i++)
            {
                Enemy enemy = new Enemy(rand.Next(10, 900), rand.Next(2, 600));
                eList.Add(enemy);
                enemy.printElement(form);
            }

        }

        public void locateMoveCheckCollition(Player player, ArrayList oList, ArrayList eList, ref bool fin, Form form)
        {
            //player.locate(eventArgs, form);

            foreach (Enemy e in eList)
            {

               // e.locate(eventArgs, form);
                //e.move();
                if (checkCollision(player, e)) fin = true;
            }

            foreach (Obstacle obs in oList)
            {

                //obs.locate(eventArgs, form);
                obs.move();

                if (checkCollision(player, obs)) fin = true;


                //if ((player.getX() == obs.getX() || player.getX() + 1 == obs.getX() || player.getX() + 2 == obs.getX() || player.getX() + 3 == obs.getX()) && player.getY() == obs.getY()) fin = true;
            }


            if (player.getPList().Count != 0)
            {
                foreach (Proyectil p in player.getPList())
                {
                    bool enemigoEliminado = false;
                    //p.locate(eventArgs, form);
                    if(p.move(player, form)) break;

                    foreach (Obstacle o in oList)
                    {
                        if (checkCollision(o, p))
                        {
                            o.gotHit(oList, form);
                            enemigoEliminado = true;
                            break;

                        }

                    }

                    if (enemigoEliminado == true)
                    {
                        p.removeElement(player.getPList(), form);
                        break;
                    }


                }
            }
        }

        public bool checkCollision(Thing t1, Thing t2)
        {

            bool collisionX = false;
            bool collisionY = false;

            if (t1.getX() + t1.getWidth() >= t2.getX() && t1.getX() <= t2.getX() + t2.getWidth()) collisionX = true;

            if (t1.getY() + t1.getHeight() >= t2.getY() && t1.getY() <= t2.getY() + t2.getHeight()) collisionY = true;
            

            return (collisionX && collisionY);
        }

   
    }
}