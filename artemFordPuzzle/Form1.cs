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
        bool SquareleClicked, SquareleClicked2, DoorClicked, DoorClicked2, HoodClicked, RoofClicked, TrunkClicked = false;
        bool StatusDone, StatusDone2, StatusDone3, StatusDone4, StatusDone5, StatusDone6, StatusDone7 = false;
        int  SquareX, SquareY, SquareX2, SquareY2, DoorX, DoorY, DoorX2, DoorY2, HoodX, HoodY, RoofX, RoofY,TrunkX,TrunkY = 0;
        int X, Y, dX, dY;
        int LastClicked = 0;
        Image img,img2, img3,img4,img5,img6;

        /*Rectangle square = new Rectangle(380, 10, 150, 150);
        Rectangle square2 = new Rectangle(380, 10, 150, 150);
        Rectangle door = new Rectangle(220, 10, 200, 143);
        Rectangle door2 = new Rectangle(220, 10, 220, 143);
        Rectangle hood = new Rectangle(380, 10, 270, 190);
        Rectangle roof = new Rectangle(380, 10, 570, 150);
        Rectangle trunk = new Rectangle(50, 10, 265, 205);*/

        Rectangle square = new Rectangle(200, 10, 50, 50);
        Rectangle square2 = new Rectangle(500, 10, 50, 50);
        Rectangle door = new Rectangle(700, 10, 67, 48);
        Rectangle door2 = new Rectangle(600, 10, 67, 48);
        Rectangle hood = new Rectangle(300, 10, 90, 63);
        Rectangle roof = new Rectangle(800, 10, 190, 50);
        Rectangle trunk = new Rectangle(50, 10, 88, 68);


        public Form1()
        {
            InitializeComponent();
            pictureBox1.MouseDown += PictureBox1_MouseDown;
            pictureBox1.MouseUp += PictureBox1_MouseUp;
            pictureBox1.MouseMove += PictureBox1_MouseMove;

            img = Image.FromFile("C:/Users/opilane/projects/artemFordPuzzle/artemFordPuzzle/images/carwheel.png");
            img2 = Image.FromFile("C:/Users/opilane/projects/artemFordPuzzle/artemFordPuzzle/images/door.png");
            img3 = Image.FromFile("C:/Users/opilane/projects/artemFordPuzzle/artemFordPuzzle/images/door2.png");
            img4 = Image.FromFile("C:/Users/opilane/projects/artemFordPuzzle/artemFordPuzzle/images/kapot.png");
            img5 = Image.FromFile("C:/Users/opilane/projects/artemFordPuzzle/artemFordPuzzle/images/krisha.png");
            img6 = Image.FromFile("C:/Users/opilane/projects/artemFordPuzzle/artemFordPuzzle/images/bagaz.png");

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
            if (StatusDone5 == false)
            {
                if (HoodClicked)
                {
                    hood.X = e.X - HoodX;
                    hood.Y = e.Y - HoodY;
                }
            }
            if (StatusDone6 == false)
            {
                if (RoofClicked)
                {
                    roof.X = e.X - RoofX;
                    roof.Y = e.Y - RoofY;
                }
            }
            if (StatusDone7 == false)
            {
                if (TrunkClicked)
                {
                    trunk.X = e.X - TrunkX;
                    trunk.Y = e.Y - TrunkY;
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
                square.Size = new Size(150, 150);


            }
            if (((label2.Location.X < square2.X + square2.Width) && (label2.Location.X > square2.X))
              && ((label2.Location.Y < square2.Y + square2.Height) && (label2.Location.Y > square2.Y)))
            {
                StatusDone2 = true;
                square2.X = 120;
                square2.Y = 225;
                square2.Size = new Size(150, 150);


            }
            if (((label3.Location.X < door.X + door.Width) && (label3.Location.X > door.X))
              && ((label3.Location.Y < door.Y + door.Height) && (label3.Location.Y > door.Y)))
            {
                StatusDone3 = true;
                door.X = 325;
                door.Y = 167;
                door.Size = new Size(200, 143);

            }
            if (((label4.Location.X < door2.X + door2.Width) && (label4.Location.X > door2.X))
              && ((label4.Location.Y < door2.Y + door2.Height) && (label4.Location.Y > door2.Y)))
            {
                StatusDone4 = true;
                door2.X = 522;
                door2.Y = 164;
                door2.Size = new Size(200, 143);

            }
            if (((label5.Location.X < hood.X + hood.Width) && (label5.Location.X > hood.X))
              && ((label5.Location.Y < hood.Y + hood.Height) && (label5.Location.Y > hood.Y)))
            {
                StatusDone5 = true;
                hood.X = 35;
                hood.Y = 150;
                hood.Size = new Size(270, 190);

            }
            if (((label6.Location.X < roof.X + roof.Width) && (label6.Location.X > roof.X))
              && ((label6.Location.Y < roof.Y + roof.Height) && (label6.Location.Y > roof.Y)))
            {
                StatusDone6 = true;
                roof.X = 300;
                roof.Y = 53;
                roof.Size = new Size(570, 150);

            }
            if (((label7.Location.X < trunk.X + trunk.Width) && (label7.Location.X > trunk.X))
              && ((label7.Location.Y < trunk.Y + trunk.Height) && (label7.Location.Y > trunk.Y)))
            {
                StatusDone7 = true;
                trunk.X = 720;
                trunk.Y = 125;
                trunk.Size = new Size(265, 205);

            }
            if(StatusDone==true && StatusDone2==true && StatusDone3==true && StatusDone4==true && StatusDone5==true && StatusDone6==true && StatusDone7==true)
            {
                label8.Text = "Всё собрано";
            }



            if (SquareleClicked)
            {
                LastClicked = 1;
                X = square.X;
                Y = square.Y;
                if (StatusDone == true)
                {
                    square.Size = new Size(150, 150);
                }
                else
                {
                    square.Size = new Size(50, 50);
                }
                
            }
            else if (SquareleClicked2)
            {
                LastClicked = 2;
                X = square2.X;
                Y = square2.Y;
                if (StatusDone2 == true)
                {
                    square2.Size = new Size(150, 150);
                }
                else
                {
                    square2.Size = new Size(50, 50);
                }
            }
            else if (DoorClicked)
            {
                LastClicked = 3;
                X = door.X;
                Y = door.Y;
                if (StatusDone3 == true)
                {
                    door.Size = new Size(200, 143);
                }
                else
                {
                    door.Size = new Size(67, 48);
                }
            }
            else if (DoorClicked2)
            {
                LastClicked = 4;
                X = door2.X;
                Y = door2.Y;
                if (StatusDone4 == true)
                {
                    door2.Size = new Size(200, 143);
                }
                else
                {
                    door2.Size = new Size(67, 48);
                }
                
            }
            else if (HoodClicked)
            {
                LastClicked = 5;
                X = hood.X;
                Y = hood.Y;
                if (StatusDone5 == true)
                {
                    hood.Size = new Size(270, 190);
                }
                else
                {
                    hood.Size = new Size(90, 63);
                }
                
            }
            else if (RoofClicked)
            {
                LastClicked = 6;
                X = roof.X;
                Y = roof.Y;
                if (StatusDone6 == true)
                {
                    roof.Size = new Size(570, 150);
                }
                else
                {
                    roof.Size = new Size(190, 50);
                }
                
            }
            else if (TrunkClicked)
            {
                LastClicked = 7;
                X = trunk.X;
                Y = trunk.Y;
                if (StatusDone7 == true)
                {
                    roof.Size = new Size(265, 205);
                }
                else
                {
                    trunk.Size = new Size(88, 68);
                }
                
            }
            SquareleClicked = false;
            SquareleClicked2 = false;
            DoorClicked = false;
            DoorClicked2 = false;
            HoodClicked = false;
            RoofClicked = false;
            TrunkClicked = false;


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
                    square.Size = new Size(150,150);
                }
            }
            else if ((e.X < square2.X + square2.Width) && (e.X > square2.X))
            {
                if ((e.Y < square2.Y + square2.Height) && (e.Y > square2.Y))
                {
                    SquareleClicked2 = true;

                    SquareX2 = e.X - square2.X;
                    SquareY2 = e.Y - square2.Y;
                    square2.Size = new Size(150, 150);
                }
            }
            else if ((e.X < door.X + door.Width) && (e.X > door.X))
            {
                if ((e.Y < door.Y + door.Height) && (e.Y > door.Y))
                {
                    DoorClicked = true;

                    DoorX = e.X - door.X;
                    DoorY = e.Y - door.Y;
                    door.Size = new Size(200, 143);
                }
            }
            else if ((e.X < door2.X + door2.Width) && (e.X > door2.X))
            {
                if ((e.Y < door2.Y + door2.Height) && (e.Y > door2.Y))
                {
                    DoorClicked2 = true;

                    DoorX2 = e.X - door2.X;
                    DoorY2 = e.Y - door2.Y;
                    door2.Size = new Size(200, 143);
                }
            }
            else if ((e.X < hood.X + hood.Width) && (e.X > hood.X))
            {
                if ((e.Y < hood.Y + hood.Height) && (e.Y > hood.Y))
                {
                    HoodClicked = true;

                    HoodX = e.X - hood.X;
                    HoodY = e.Y - hood.Y;
                    hood.Size = new Size(270, 190);
                }
            }
            else if ((e.X < roof.X + roof.Width) && (e.X > roof.X))
            {
                if ((e.Y < roof.Y + roof.Height) && (e.Y > roof.Y))
                {
                    RoofClicked = true;

                    RoofX = e.X - roof.X;
                    RoofY = e.Y - roof.Y;
                    roof.Size = new Size(570, 150);
                }
            }
            else if ((e.X < trunk.X + trunk.Width) && (e.X > trunk.X))
            {
                if ((e.Y < trunk.Y + trunk.Height) && (e.Y > trunk.Y))
                {
                    TrunkClicked = true;

                    TrunkX = e.X - trunk.X;
                    TrunkY = e.Y - trunk.Y;
                    trunk.Size = new Size(265, 205);
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
            e.Graphics.DrawImage(img4, hood);
            e.Graphics.DrawImage(img5, roof);
            e.Graphics.DrawImage(img6, trunk);

        }
    }
}
