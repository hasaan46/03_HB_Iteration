using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_HB_ÜbungForSchleif
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            // Variabeln deklarieren
            double d;
            double summe = 0;
            double count = 0;
            double mittelWert;
            rTxtZahl1.Text = ""; // Textfeld für die ausgabe leeren

            // Schleifenkopf mit Startausdruck; Laufbediegung; Veränderung
            for (d = 35; d >= 20; d = d - 2.5)
            {

                // Ausgabe der durch Bediegungen im Schleifenkopf erzuegten Werte in der Textbox
                rTxtZahl1.Text +=  d.ToString("0.00") + "\n";
                summe = summe + d;

                count += 1;     // Bei jedem schleifendurch lauf wird der neue Wert für d zur Summe hinzuaddiert
                                // summe = summe + d
            }
            // Berechnung des Mittelwerts
            mittelWert = summe / count;

            // Ausgabe von Summe und Mittelwert
            txtSumme.Text = "Summe:" + summe.ToString("0.00");
            txtMittelwert.Text = "Mittelwert: " + mittelWert.ToString("0.00");
        }
    }
}
