using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_HB_Halbierung
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
            // Code testen
            try
            {
                // Variabeln deklarieren
                double zahl = Convert.ToDouble(txtZahleingabe.Text);

                // Label leeren
                lblZahl.Text = "";

                // While loop wenn größer als 0.001
                while (zahl >= 0.001)
                {
                    // Zahl durch 2
                    zahl /= 2;

                    // Zahl ausgeben
                    lblZahl.Text += zahl.ToString() + "\n"; // Ausgabe aller Werte im Label
                }
            }
            // Fehler abfangen
            catch
            {
                // MessageBox zum ausgeben der Werte!
                MessageBox.Show("Geben sie nur gültige Zahlen ein!");
            }
        }
    }
}
