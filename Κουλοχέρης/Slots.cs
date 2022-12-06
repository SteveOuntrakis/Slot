using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Κουλοχέρης
{
    class Slots
    {
        public void Slot()
        {
            PictureBox[] Picture = new PictureBox[4];
            int[] Counter = new int[4];
            Random r = new Random();
            string sthles = Form1.Sthles;
            string froutakia = Form1.Frouta;
            int S1;
            int s; //xrhmata bet
            int s2;//xrhmata label
            int epi;//radiobutton
            if (sthles == "3")
            {
                for (int i = 0; i <= 2; i++)
                {
                    Picture[i].Visible = true;
                    if (froutakia == "5")
                        Picture[i].Image = Image.FromFile("Q1.png");
                    else
                        Picture[i].Image = Image.FromFile("W1.png");
                    Picture[i].Location = new Point(235 * i, 40);
                }
                Picture[3].Visible = false;
            }
            else if (sthles == "4")
            {
                for (int i = 0; i <= 3; i++)
                {
                    Picture[i].Visible = true;
                    if (froutakia == "5")
                        Picture[i].Image = Image.FromFile("Q1.png");
                    else
                        Picture[i].Image = Image.FromFile("W1.png");
                    Picture[i].Location = new Point(150 * i + 20, 40);
                }
            }
            ChangePicture();
        }
    }
}
