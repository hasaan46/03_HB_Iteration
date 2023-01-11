using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_HB_ForSchleife
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnSchleife1_Click(object sender, EventArgs e)
        {
            {
                int i; //Schleifenvariable
                lblSchleife1.Text = ""; //Label leeren
                for (i = 3; i <= 7; i++) // (Startausdruck; Laufbedingung; Änderung)
                    lblSchleife1.Text += i + "\n"; // Ausgabe der Werte der Schleifenvariablen
            }
        }

        private void btnSchleife2_Click(object sender, EventArgs e)
        {
            int i; //Schleifenvariable
            lblSchleife2.Text = ""; //Label leeren
            for (i = 3; i <= 11; i = i + 2) // (Startausdruck; Laufbedingung; Änderung)
            {
                lblSchleife2.Text += i + "\n"; // Ausgabe der Werte der Schleifenvariablen
            }
        }

        private void btnSchleife3_Click(object sender, EventArgs e)
        {
            int i; //Schleifenvariable
            lblSchleife3.Text = ""; //Label leeren
            for (i = 7; i >= 3; i--) // (Startausdruck; Laufbedingung; Änderung)
            {
                lblSchleife3.Text += i + "\n"; // Ausgabe der Werte der Schleifenvariablen
            }
        }

        private void btnSchleife4_Click(object sender, EventArgs e)
        {
            double d; //Schleifenvariable
            lblSchleife4.Text = ""; //Label leeren
            for (d = 3.5; d <= 7.5; d = d + 1.5) //(Startausdruck; Laufbedingung; Änderung)
            {
                lblSchleife4.Text += d + "\n"; // Ausgabe der Werte der Schleifenvariablen
            }
        }

        private void btnSchleife5_Click(object sender, EventArgs e)
        {
            int i; //Schleifenvariable
            lblSchleife5.Text = ""; //Label leeren
            for (i = 3; i <= 20; i++) // (Startausdruck; Laufbedingung; Änderung)
            {
                if (i >= 5 && i <= 7)
                    continue;
                if (i >= 11)
                    break;
                lblSchleife5.Text += i + "\n"; // Ausgabe der Werte der Schleifenvariablen
            }
        }
    }
}
