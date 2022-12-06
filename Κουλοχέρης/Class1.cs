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
    class Class1
    {
        public void menu()
        {
            int s = Form1.s;
            string Sthles = Form1.Sthles;
            string Frouta = Form1.Frouta;
            if (s > 0)
            {
                if (Sthles == "3" || Sthles == "4")
                {
                    if (Frouta == "5" || Frouta == "6")
                    {
                        Form2 Hello = new Form2();
                        Hello.Show();
                    }
                    else
                        MessageBox.Show("Επιλογή για φρουτάκια: 5 η 6");
                }
                else
                    MessageBox.Show("Επιλογή για στήλες: 3 η 4");
            }
            else
                MessageBox.Show("Επιλογή για Χρήματα: ακέραιος θετικός αριθμός");
        }
    }
        
}
