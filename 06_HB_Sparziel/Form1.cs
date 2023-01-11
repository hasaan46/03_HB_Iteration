using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_HB_Sparziel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                // Variabeln deklarieren und Initialisieren
                double kapital = Convert.ToDouble(txtAnfangEuro.Text);
                double wunschKapital = Convert.ToDouble(txtEndEuro.Text);
                double zinsSatz = Convert.ToDouble(txtZinssatz.Text)/100;
                double laufZeit = 0;

                // Bestimmung des Zinsfaktors
                double zinsFaktor = 1 + zinsSatz;

                if (wunschKapital <= kapital)
                {
                    MessageBox.Show("Das Sparziel muss größer als das Anfangkapital.");
                    return; // das Ausführen des weiteren Codes wird abgebrochen
                }

                // While schleife weil wir nicht wissen was die ausganggröße ist
                while(kapital <= wunschKapital) // schleife wird so lange ausgeführt bis..
                {
                    kapital *= zinsFaktor; // (Kapital = Kapital * Zinsfaktor)
                    // In jedem Schleifendurchlauf wird das Kapital um die Zinsen f+r 1 Jahr erhöht

                    laufZeit++;
                }

                // Werte ausgeben
                txtTatEndkapital.Text = Math.Round(kapital, 2).ToString("0.00" + " €");
                txtJahre.Text = laufZeit.ToString();
            }
            catch
            {
                // Fehler ausgeben
                MessageBox.Show("Bitte geben sie nur gültige Zahlen ein!");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // alle textboxen leeren
            txtAnfangEuro.Clear();
            txtEndEuro.Clear();
            txtJahre.Clear();
            txtTatEndkapital.Clear();
            txtZinssatz.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Schließen der Anwendung
            Close();
        }
    }
}
