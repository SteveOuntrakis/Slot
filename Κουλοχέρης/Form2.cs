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
    public partial class Form2 : Form
    {
        public static PictureBox[] Picture= new PictureBox[4];
        public static Label[] Label = new Label[5];     
        int[] Counter = new int[4];
        Random r = new Random();
        public static string sthles = Form1.Sthles;
        public static string froutakia = Form1.Frouta;        
        int S1;
        public static int s; //xrhmata bet
        public static int s2;//xrhmata label
        public static int epi;//radiobutton    
        Class2 slots = new Class2();
        public Form2()
        {
            InitializeComponent();
        }
        public void Slots()
        {
            slots.Slots();
            ChangePicture();
        }
        public void visibility()
        {
            Label[0] = label1;
            Label[1] = label2;
            Label[2] = label3;
            Label[3] = label4;
            Label[4] = label5;

            for (int i=0;i<=4;i++)
            {
                
                Label[i].Visible = false;
            }

        }
        public void ChangePicture()
        {
            for (int i=0;i<=3;i++)
            {
                if(froutakia=="5")
                {
                    S1 = r.Next(1, 5);
                    Picture[i].Image = Image.FromFile("Q" + S1 + ".png");
                    Counter[i] = S1;
                }
                else
                {
                    S1 = r.Next(1, 6);
                    Picture[i].Image = Image.FromFile("W" + S1 + ".png");
                    Counter[i] = S1;
                }
            }    
        }
        public void Elegxos(int epi)
        {
            if (epi == 0)
            {
                MessageBox.Show("Select RadioButton To Multiply Your Bet");
                moxlosdown.Visible = false;
                moxlosup.Visible = true;
            }
            else if (s2 >= s * epi)
            {
                timer1.Start();
                s2 = s2 - s*epi;
                label1.Text = s2.ToString();
            }
            else
            {
                MessageBox.Show("το υπολοιπο δεν επαρκεί ");
                moxlosdown.Visible = false;
                moxlosup.Visible = true;
            }            
        }
        public void Elegxos2()
        {
            MessageBox.Show("Μόνο θετικοί και ακέραιοι αριθμοί");
            moxlosdown.Visible = false;
            moxlosup.Visible = true;
        }
        public void Rules()
        {
            if (sthles == "3")
                Counter[3] = 0;
            int n = 0;
            int b = 0;
            for (int i=0;i<3;i++)
            {
                if (Counter[i]==Counter[i+1])
                    n++;
                if (Counter[i] == Counter[i + 1] & Counter[i] == 1)
                    b++;
            }
            s= s * n * epi + s * b * epi;
            s2 = s2 + s;
            label1.Text = s2.ToString();
            if(s>0)
                MessageBox.Show("Κέρδισες: " +s+ "€");
            else
                MessageBox.Show("Έχασες");
        }
        private void Form2_Load(object sender, EventArgs e)
        {            
            this.BackColor = Color.Black;
            label1.Text = Form1.nomismata;
            comboBox1.Text = sthles;
            comboBox2.Text = froutakia;
            board.Image = Image.FromFile("board.jpg");
            button1.Image = Image.FromFile("button.png");
            moxlosdown.Image = Image.FromFile("moxlosdown.png");
            moxlosdown.Visible = false;
            moxlosup.Image = Image.FromFile("moxlosup.png");
            Picture[0] = slot14;
            Picture[1] = slot24;
            Picture[2] = slot34;
            Picture[3] = slot44;
            Slots();
        }
        int dur = 1;
        int dur2 = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            moxlosdown.Visible = false;
            moxlosup.Visible = true;
            moxlosup.Enabled = false;
            button1.Enabled = false;
            if (froutakia == "5")
            {
                if (dur<5)
                    timer2.Start();                    
                else
                {
                    dur2++;
                    timer1.Interval = dur2 * 10;
                    timer2.Interval = dur2 * 10;
                    dur = 1;
                }             
            }
            else if (froutakia == "6")
            {
                if (dur<6)              
                    timer2.Start(); 
                else
                {
                    dur2++;
                    timer1.Interval = dur2 * 10;
                    timer2.Interval = dur2 * 10;
                    dur = 1;
                }  
            }
            if (dur2==20)
            {
                timer1.Stop();
                timer2.Stop();
                ChangePicture();
                Rules();
                moxlosup.Enabled = true;
                button1.Enabled = true;
            }
            dur++;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (froutakia == "5")
            {
                for (int i = 0; i <= 3; i++)
                {
                    Picture[i].Image = Image.FromFile("Q" + dur + ".png");
                }
            }
            else
            {
                for (int i = 0; i <= 3; i++)
                {
                    Picture[i].Image = Image.FromFile("W" + dur + ".png");
                }
            }
        }
       
        private void moxlosup_Click(object sender, EventArgs e)
        {
            moxlosup.Visible = false;
            moxlosdown.Visible = true;
            dur = 1;
            dur2 = 1;
            if (int.TryParse(textBox1.Text, out s))
            {
                if (s > 0)
                {
                    if (int.TryParse(label1.Text, out s2))
                    {
                        if (radioButton1.Checked)
                        {
                            epi = 1;
                            Elegxos(epi);
                        }
                        else if (radioButton2.Checked)
                        {
                            epi = 2;
                            Elegxos(epi);
                        }
                        else if (radioButton3.Checked)
                        {
                            epi = 3;
                            Elegxos(epi);
                        }
                        else
                        {
                            epi = 0;
                            Elegxos(epi);
                        }
                    }
                    else
                        Elegxos2();
                }
                else
                    Elegxos2();
            }
            else
                Elegxos2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sthles = comboBox1.Text;
            froutakia = comboBox2.Text;
            Slots();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            visibility();
            MessageBox.Show("Kανόνες:" + Environment.NewLine + Environment.NewLine + " Για να νικήσει ο παίκτης , πρέπει να υπάρχουν 2 η παραπάνω συνεχώμενες εικόνες! " + Environment.NewLine + Environment.NewLine + "Αν δεν υπάρχουν ίδιες συνεχώμενες εικόνες τότε ο παίκτης χάνει τα λεφτά που πόνταρε" + Environment.NewLine + Environment.NewLine + "Αν είναι 2 συνεχώμενες εικόνες ίδιες τότε ο παίκτης κερδίζει τα λεφτά του πίσω " + Environment.NewLine + Environment.NewLine + "Αν είναι παραπάνω από δύο ιδιες συνεχώμενες εικόνες , τότε ο παίκτης κερδίζει τα λεφτά που πόνταρε δύο φορές (αν έχουμε τρεις ιδιες εικόνες) και τρεις φορες (αν εχει τεσσερις ίδιες εικόνες)" + Environment.NewLine + Environment.NewLine + "Τέλος αν στις ίδιες συνεχώμενες εικόνες τύχουν στην μεσσαια στηλη 7,  παίκτης κερδίζει επιπλέων μπόνους , τα κέρδη *2");
        }
    }
}
