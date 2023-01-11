using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_HB_While_DoWhile
{
    public partial class Form1 : Form
    {
        // Zufallsvariable als globale Variable deklarieren
        // Der Variabe
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            // Variabeln deklarieren
            int zahl;
            int summe = 0;

            lblZahl.Text = ""; // Label leeren

            /*
            Die While-Schleife prüft die Bedingung vor
            ausführung der Anweisung 
            = Kopfgesteuerte Schleife 
            */
            while (summe < 20)
            {
                zahl = r.Next(1, 7); // Zufallszahl zwischen 1 und 6


                // summe = summe + zahl;
                summe += zahl;

                lblZahl.Text += summe + "\n"; // Ausgabe aller Werte im Label
            }
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            // Variabeln deklarieren
            int zahl;
            int summe = 0;

            lblZahl.Text = ""; // Label leeren

            /*
            Die While-Schleife prüft die Bedingung vor
            ausführung der Anweisung 
            = Kopfgesteuerte Schleife 
            */
            do
            {
                zahl = r.Next(1, 7); // Zufallszahl zwischen 1 und 6


                // summe = summe + zahl;
                summe += zahl;

                lblZahl.Text += summe + "\n"; // Ausgabe aller Werte im Label
            } 
            while (summe < 20);
        }
    }
}
