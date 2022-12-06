using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Κουλοχέρης
{
    class Class2
    {
        public void Slots()
        {
            string sthles = Form2.sthles;
            string froutakia = Form2.froutakia;
            PictureBox[] Picture = Form2.Picture;
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
        }

    }
}
