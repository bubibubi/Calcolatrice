using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcolatrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPiu_Click(object sender, EventArgs e)
        {
            if (!TryParseValues(out var n1, out var n2)) 
                return;

            float risultato = n1 + n2;

            lstRisultati.Items.Add(string.Format("{0} + {1} = {2}", n1, n2, risultato));

        }

        private bool TryParseValues(out float n1, out float n2)
        {
            if (!float.TryParse(textBox1.Text, out n1))
            {
                n2 = 0;
                MessageBox.Show("Numero 1 errato", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!float.TryParse(textBox2.Text, out n2))
            {
                MessageBox.Show("Numero 2 errato", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnMeno_Click(object sender, EventArgs e)
        {
            if (!TryParseValues(out var n1, out var n2))
                return;

            float risultato = n1 - n2;

            lstRisultati.Items.Add(string.Format("{0} - {1} = {2}", n1, n2, risultato));

        }

        private void btnPer_Click(object sender, EventArgs e)
        {
            if (!TryParseValues(out var n1, out var n2))
                return;

            float risultato = n1 * n2;

            lstRisultati.Items.Add(string.Format("{0} * {1} = {2}", n1, n2, risultato));
        }

        private void btnDiviso_Click(object sender, EventArgs e)
        {
            if (!TryParseValues(out var n1, out var n2))
                return;

            float risultato = n1 / n2;

            lstRisultati.Items.Add(string.Format("{0} / {1} = {2}", n1, n2, risultato));

        }
    }
}
