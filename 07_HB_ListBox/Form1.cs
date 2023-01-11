using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_HB_ListBox
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
            // Anzahl ausgeben in der Forms
            lblAnzahl.Text = "Anzahl: " + lstGerichte.Items.Count;

            // Ausgewählten eintrag ausgeben
            lblAusgewählt.Text = "Ausgewählter Eintrag: " + lstGerichte.SelectedItem;

            // Ausgewählte Items ausgeben
            lblIndex.Text = "Nummer des Ausgewählten Items: " + lstGerichte.SelectedIndex;

            // Alle einträge ausgeben
            lblAll.Text = "Alle Einträge: " + "\n";

            // For schleife zum ausgeben aller Einträge
            for(int i = 0; i < lstGerichte.Items.Count; i++)
            {
                lblAll.Text += lstGerichte.Items[i] + "\n";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Listen erstellen und befüllen

            lstGerichte.Items.Add("Spaghetti"); // Index 0 ...
            lstGerichte.Items.Add("Grüne Nudeln");
            lstGerichte.Items.Add("Tortellini");
            lstGerichte.Items.Add("Pizza");
            lstGerichte.Items.Add("Lasagne");

            lstGerichte.SelectedIndex = 0; // Vorauswahl
        }
    }
}
