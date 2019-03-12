using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LabIIVS
{
    abstract class Thing
    {

        
        //protected float x, y;
        protected int height, width;
        protected Image image;
        protected PictureBox pb;


        public Thing() { }

        public int getX() { return pb.Location.X; }

        public int getY() { return pb.Location.Y; }
        
        /*
        public void setX(float x)
        
        public void setY(float y) { this.y = y; }*/

        public int getWidth() { return this.pb.Width; }

        public int getHeight() { return this.pb.Height; }

        public void setHeight(int height)
        {
            this.pb.Height = height;
            //this.height = height;
        }

        public void setWidth(int width)
        {
            this.pb.Width = width;
            //this.width = width;
        }

        public void setLocation(int x, int y) { this.pb.Location = new Point(x, y); }

       
       
        
        public void printElement(Form form) 
        {

            
            //e.Graphics.FillRectangle(color, x, y, width, height);
            //e.Graphics.DrawImage(Properties.Resources.laser, x, y, width, height);

            
            form.Controls.Add(pb);


        }

        public void constructPB(int x, int y)
        {
            this.pb = new PictureBox();
            pb.Image = this.image;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Height = this.height;
            pb.Width = this.width;
            pb.Location = new Point(x, y);

           

        }

        public void removeElement(ArrayList list, Form form)
        {
            form.Controls.Remove(this.pb);
            list.Remove(this);
            
        }


    }


}