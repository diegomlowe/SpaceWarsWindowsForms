using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabIIVS
{
    public partial class Form1: Form
    {

        private int x=1, y=1;

        ScreenManager sm = new ScreenManager();

        Random rand = new Random();

        Player player; 

        ArrayList oList = new ArrayList();
        ArrayList eList = new ArrayList();

        Label label = new Label();

        public bool gameOver = false;


        public Form1()
        {
            InitializeComponent();

            x = 950;
            y = 550;

           // Image background = Properties.Resources.player;
            //background.


            //this.BackgroundImage = Properties.Resources.player;
            

           

        }
        

        private void timerMove_Tick(object sender, EventArgs e)
        {

            //this.Controls.Clear();

            //label.Text = this.Size.ToString();

            if (!gameOver) sm.locateMoveCheckCollition(player, oList, eList, ref gameOver, this);
            else
            {

                label.Location = new System.Drawing.Point(500, 300);

                label.Text = "Game Over";

                this.Controls.Add(label);


            }

           

            Invalidate();


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            player.action(e, this);

          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           

            this.Size = new Size(1000, 600);

            this.StartPosition = FormStartPosition.CenterScreen;

            player = new Player(x, y);

            player.printElement(this);

            sm.addThingsToLists(oList, 5, eList, 5, rand, this);

            /*
            label.Location = new System.Drawing.Point(500, 300);

            label.Text = this.Size.ToString();
                       
            this.Controls.Add(label);
            */
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            /*
            
            if(!gameOver) sm.locateMoveCheckCollition(player, oList, eList, ref gameOver, e, this);
            else
            {

                label.Location = new System.Drawing.Point(500, 300);

                label.Text = "Game Over";

                this.Controls.Add(label);


            }

         */

        }
    }
}
