using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace artem_figures
{
    public partial class Form1 : Form
    {
        bool SquareleClicked, SquareleClicked2, DoorClicked, DoorClicked2 = false;
        bool StatusDone, StatusDone2, StatusDone3, StatusDone4 = false;
        int  SquareX, SquareY, SquareX2, SquareY2, DoorX, DoorY, DoorX2, DoorY2 = 0;
        int X, Y, dX, dY;
        int LastClicked = 0;
        Image img,img2, img3;

        Rectangle door = new Rectangle(220, 10, 200, 143);
        Rectangle door2 = new Rectangle(220, 10, 220, 143);
        Rectangle square = new Rectangle(380, 10, 150, 150);
        Rectangle square2 = new Rectangle(380, 10, 150, 150);
        public Form1()
        {
            InitializeComponent();
            pictureBox1.MouseDown += PictureBox1_MouseDown;
            pictureBox1.MouseUp += PictureBox1_MouseUp;
            pictureBox1.MouseMove += PictureBox1_MouseMove;

            img = Image.FromFile("C:/Users/opilane/projects/artemFordPuzzle/artemFordPuzzle/images/carwheel.png");
            img2 = Image.FromFile("C:/Users/opilane/projects/artemFordPuzzle/artemFordPuzzle/images/door.png");
            img3 = Image.FromFile("C:/Users/opilane/projects/artemFordPuzzle/artemFordPuzzle/images/door2.png");

        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (StatusDone == false)
            {
                if (SquareleClicked)
                {
                    square.X = e.X - SquareX;
                    square.Y = e.Y - SquareY;
                }
            }
            if (StatusDone2 == false)
            {
                if (SquareleClicked2)
                {
                    square2.X = e.X - SquareX2;
                    square2.Y = e.Y - SquareY2;
                }
            }
            if (StatusDone3 == false)
            {
                if (DoorClicked)
                {
                    door.X = e.X - DoorX;
                    door.Y = e.Y - DoorY;
                }
            }
            if (StatusDone4 == false)
            {
                if (DoorClicked2)
                {
                    door2.X = e.X - DoorX2;
                    door2.Y = e.Y - DoorY2;
                }
            }
            pictureBox1.Invalidate();




        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (((label1.Location.X < square.X + square.Width) && (label1.Location.X > square.X))
              && ((label1.Location.Y < square.Y + square.Height) && (label1.Location.Y > square.Y)))
            {
                StatusDone = true;
                square.X = 687;
                square.Y = 230;

            }
            if (((label2.Location.X < square2.X + square2.Width) && (label2.Location.X > square2.X))
              && ((label2.Location.Y < square2.Y + square2.Height) && (label2.Location.Y > square2.Y)))
            {
                StatusDone2 = true;
                square2.X = 120;
                square2.Y = 225;

            }
            if (((label3.Location.X < door.X + door.Width) && (label3.Location.X > door.X))
              && ((label3.Location.Y < door.Y + door.Height) && (label3.Location.Y > door.Y)))
            {
                StatusDone3 = true;
                door.X = 325;
                door.Y = 167;

            }
            if (((label4.Location.X < door2.X + door2.Width) && (label4.Location.X > door2.X))
              && ((label4.Location.Y < door2.Y + door2.Height) && (label4.Location.Y > door2.Y)))
            {
                StatusDone4 = true;
                door2.X = 522;
                door2.Y = 164;

            }



            if (SquareleClicked)
            {
                LastClicked = 1;
                X = square.X;
                Y = square.Y;
            }
            else if (SquareleClicked2)
            {
                LastClicked = 2;
                X = square2.X;
                Y = square2.Y;
            }
            else if (DoorClicked)
            {
                LastClicked = 3;
                X = door.X;
                Y = door.Y;
            }
            else if (DoorClicked2)
            {
                LastClicked = 4;
                X = door2.X;
                Y = door2.Y;
            }
            SquareleClicked = false;
            SquareleClicked2 = false;
            DoorClicked = false;
            DoorClicked2 = false;


        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            
            if ((e.X < square.X + square.Width) && (e.X > square.X))
            {
                if ((e.Y < square.Y + square.Height) && (e.Y > square.Y))
                {
                    SquareleClicked = true;

                    SquareX = e.X - square.X;
                    SquareY = e.Y - square.Y;
                }
            }
            else if ((e.X < square2.X + square2.Width) && (e.X > square2.X))
            {
                if ((e.Y < square2.Y + square2.Height) && (e.Y > square2.Y))
                {
                    SquareleClicked2 = true;

                    SquareX2 = e.X - square2.X;
                    SquareY2 = e.Y - square2.Y;
                }
            }
            else if ((e.X < door.X + door.Width) && (e.X > door.X))
            {
                if ((e.Y < door.Y + door.Height) && (e.Y > door.Y))
                {
                    DoorClicked = true;

                    DoorX = e.X - door.X;
                    DoorY = e.Y - door.Y;
                }
            }
            else if ((e.X < door2.X + door2.Width) && (e.X > door2.X))
            {
                if ((e.Y < door2.Y + door2.Height) && (e.Y > door2.Y))
                {
                    DoorClicked2 = true;

                    DoorX2 = e.X - door2.X;
                    DoorY2 = e.Y - door2.Y;
                }
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(img, square);
            e.Graphics.DrawImage(img, square2);
            e.Graphics.DrawImage(img2, door);
            e.Graphics.DrawImage(img3, door2);

        }
    }
}
