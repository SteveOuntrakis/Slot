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
    public partial class Form1 : Form
    {
        public static string Sthles = "";
        public static string Frouta = "";
        public static string nomismata = "";
        public static int s;
        Class1 menu = new Class1();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }    
        private void button1_Click(object sender, EventArgs e)
        {            
            if (int.TryParse(textBox1.Text, out s))
            {
                Sthles = comboBox1.Text;
                Frouta = comboBox2.Text;
                nomismata = textBox1.Text;                
                menu.menu();                
            }
            else
                MessageBox.Show("Επιλογή για Χρήματα: ακέραιος θετικός αριθμός");           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kανόνες:" + Environment.NewLine+ Environment.NewLine + " Για να νικήσει ο παίκτης , πρέπει να υπάρχουν 2 η παραπάνω συνεχώμενες εικόνες! " + Environment.NewLine+ Environment.NewLine + "Αν δεν υπάρχουν ίδιες συνεχώμενες εικόνες τότε ο παίκτης χάνει τα λεφτά που πόνταρε" + Environment.NewLine+ Environment.NewLine + "Αν είναι 2 συνεχώμενες εικόνες ίδιες τότε ο παίκτης κερδίζει τα λεφτά του πίσω " + Environment.NewLine+ Environment.NewLine + "Αν είναι παραπάνω από δύο ιδιες συνεχώμενες εικόνες , τότε ο παίκτης κερδίζει τα λεφτά που πόνταρε δύο φορές (αν έχουμε τρεις ιδιες εικόνες) και τρεις φορες (αν εχει τεσσερις ίδιες εικόνες)" + Environment.NewLine+ Environment.NewLine + "Τέλος αν στις ίδιες συνεχώμενες εικόνες τύχουν στην μεσσαια στηλη 7,  παίκτης κερδίζει επιπλέων μπόνους , τα κέρδη *2");
        }
    }
}
