using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_HB_Steuertabelle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

            // Constanten deklarieren
            const int gehaltGrenze12T = 12;
            const int gehaltGrenze20T = 20;
            const int gehaltGrenze30T = 20;
            const int steuerSatzElse = 25;

            const int steuerSatzKleiner12T = 12;
            const int steuerSatzKleiner20T = 15;
            const int steuerSatzKleiner30T = 20;

            const int gehaltStart = 5000;
            const int gehaltEnde = 35000;
            const int gehaltSchritte = 3000;

            // Variabeln deklarieren
            double gehalt;
            int steuerSatz;
            double steuerBetrag;
            double netto;


            // label leeren
            lblSteuer.Text = "";

            // For und Kopfzeile befüllen
            for (gehalt = gehaltStart; gehalt <= gehaltEnde; gehalt += gehaltSchritte)
            {
                // Verschachtelte selektion
                if (gehalt <= gehaltGrenze12T)
                    steuerSatz = steuerSatzKleiner12T;

                else if (gehalt <= gehaltGrenze20T)
                    steuerSatz = steuerSatzKleiner20T;

                if (gehalt <= gehaltGrenze30T)
                    steuerSatz = steuerSatzKleiner30T;

                else steuerSatz = steuerSatzElse;

                // Berechnung

                steuerBetrag = gehalt * steuerSatzElse / 100;
                netto = gehalt - steuerBetrag;

                // Ausgabe der werde
                lblSteuer.Text = + gehalt + " €, " + steuerSatz + " %, " + steuerBetrag + " €, " +
                    netto + " €, " + "\n";
            }
        }
    }
}
