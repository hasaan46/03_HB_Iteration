using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_HB_SelctedIndexChanged
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
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

        
        private void txtBoxAusgewählt_TextChanged(object sender, EventArgs e)
        {
        }

        private void lstGerichte_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Auswahl ausgeben
            txtBoxAusgewählt.Text = lstGerichte.SelectedItem.ToString();
        }
    }
}
