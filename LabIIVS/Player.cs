using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LabIIVS
{
    class Player : Thing
    {


        private ArrayList pList; 

        private int score, speed=10;




        public Player(int x, int y)
        {
            pList = new ArrayList();
            this.image = Properties.Resources.player;
            this.height = 75;
            this.width = 75;
            constructPB(x, y);

        }

        public ArrayList getPList()
        {

            return pList;
        }


        public void action(KeyEventArgs e, Form form)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    if(!(getX()==1000-this.height))setLocation(getX()+speed, getY());
                    break;
                case Keys.Left:
                    if (!(getX() ==0)) setLocation(getX() - speed, getY());
                    break;
                case Keys.Down:
                    if (!(getY() == 600 - this.height)) setLocation(getX(), getY() + speed);
                    break;
                case Keys.Up:
                    if (!(getY() == 1)) setLocation(getX(), getY() - speed);
                    break;
                case Keys.D:
                    Proyectil pC = new Proyectil("d", getX()+this.width, getY() + this.height / 2);
                    pList.Add(pC);
                    pC.printElement(form);
                    break;
                case Keys.A:
                    Proyectil pA = new Proyectil("a", getX(), getY() + this.height / 2);
                    pList.Add(pA);
                    pA.printElement(form);
                    break;
                case Keys.S:
                    Proyectil pS = new Proyectil("s", getX() + this.width / 2, getY() + this.height);
                    pList.Add(pS);
                    pS.printElement(form);
                    break;
                case Keys.W:
                    Proyectil pW = new Proyectil("w", getX() + this.width / 2, getY());
                    pList.Add(pW);
                    pW.printElement(form);
                    break;
                

            }

            
        }
    }







}