using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RekenmachineLibrary;

namespace OefRekenmachine
{
    public partial class Rekenmachine : Form
    {
        
        public double Getal1 { get; set; }
        public double Getal2 { get; set; }
        public char Bewerking { get; set; }
        public bool Getal1Ingevuld { get; set; } = false;
        public bool OpgaveGemaakt { get; set; } = false;

        public Rekenmachine()
        {
            InitializeComponent();
        }

        private void BtnNul_Click(object sender, EventArgs e)
        {
            if (OpgaveGemaakt)
            {
                txtInput.Clear();
                OpgaveGemaakt = false;
            }
            txtInput.Text += "0";
        }

        private void BtnEen_Click(object sender, EventArgs e)
        {
            if (OpgaveGemaakt)
            {
                txtInput.Clear();
                OpgaveGemaakt = false;
            }
            txtInput.Text += "1";
        }

        private void BtnTwee_Click(object sender, EventArgs e)
        {
            if (OpgaveGemaakt)
            {
                txtInput.Clear();
                OpgaveGemaakt = false;
            }
            txtInput.Text += "2";
        }

        private void BtnDrie_Click(object sender, EventArgs e)
        {
            if (OpgaveGemaakt)
            {
                txtInput.Clear();
                OpgaveGemaakt = false;
            }
            txtInput.Text += "3";
        }

        private void BtnVier_Click(object sender, EventArgs e)
        {
            if (OpgaveGemaakt)
            {
                txtInput.Clear();
                OpgaveGemaakt = false;
            }
            txtInput.Text += "4";
        }

        private void BtnVijf_Click(object sender, EventArgs e)
        {
            if (OpgaveGemaakt)
            {
                txtInput.Clear();
                OpgaveGemaakt = false;
            }
            txtInput.Text += "5";
        }

        private void BtnZes_Click(object sender, EventArgs e)
        {
            if (OpgaveGemaakt)
            {
                txtInput.Clear();
                OpgaveGemaakt = false;
            }
            txtInput.Text += "6";
        }

        private void BtnZeven_Click(object sender, EventArgs e)
        {
            if (OpgaveGemaakt)
            {
                txtInput.Clear();
                OpgaveGemaakt = false;
            }
            txtInput.Text += "7";
        }

        private void BtnAcht_Click(object sender, EventArgs e)
        {
            if (OpgaveGemaakt)
            {
                txtInput.Clear();
                OpgaveGemaakt = false;
            }
            txtInput.Text += "8";
        }

        private void BtnNegen_Click(object sender, EventArgs e)
        {
            if (OpgaveGemaakt)
            {
                txtInput.Clear();
                OpgaveGemaakt = false;
            }
            txtInput.Text += "9";
        }

        private void BtnKomma_Click(object sender, EventArgs e)
        {
            txtInput.Text += ",";
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            if (!Getal1Ingevuld)
            {
                Getal1 = Convert.ToDouble(txtInput.Text);
                txtInput.Clear();
                Getal1Ingevuld = true;
                txtOpgave.Text += " + " + Getal1;
                Bewerking = '+';
            }
            else
            {
                Getal2 = Convert.ToDouble(txtInput.Text);
                txtOpgave.Text =  txtOpgave.Text.Insert(0, " + " + Getal2.ToString());
                Getal1 = Berekening.MaakBerekening(Getal1, Getal2, Bewerking);
                Bewerking = '+';
                txtInput.Text = Getal1.ToString();
                OpgaveGemaakt = true;
            }
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            if (!Getal1Ingevuld)
            {
                Getal1 = Convert.ToDouble(txtInput.Text);
                txtInput.Clear();
                Getal1Ingevuld = true;
                txtOpgave.Text += " - " + Getal1;
                Bewerking = '-';
            }
            else
            {
                Getal2 = Convert.ToDouble(txtInput.Text);
                txtOpgave.Text = txtOpgave.Text.Insert(0, " - " + Getal2.ToString());
                Getal1 = Berekening.MaakBerekening(Getal1, Getal2, Bewerking);
                Bewerking = '-';
                txtInput.Text = Getal1.ToString();
                OpgaveGemaakt = true;
            }
        }


        private void BtnMaal_Click(object sender, EventArgs e)
        {
            if (!Getal1Ingevuld)
            {
                Getal1 = Convert.ToDouble(txtInput.Text);
                txtInput.Clear();
                Getal1Ingevuld = true;
                txtOpgave.Text += " * " + Getal1;
                Bewerking = '*';
            }
            else
            {
                Getal2 = Convert.ToDouble(txtInput.Text);
                txtOpgave.Text = txtOpgave.Text.Insert(0, " * " + Getal2.ToString());
                Getal1 = Berekening.MaakBerekening(Getal1, Getal2, Bewerking);
                Bewerking = '*';
                txtInput.Text = Getal1.ToString();
                OpgaveGemaakt = true;
            }
        }

        private void BtnDeling_Click(object sender, EventArgs e)
        {
            if (!Getal1Ingevuld)
            {
                Getal1 = Convert.ToDouble(txtInput.Text);
                txtInput.Clear();
                Getal1Ingevuld = true;
                txtOpgave.Text += " / " + Getal1;
                Bewerking = '/';
            }
            else
            {
                Getal2 = Convert.ToDouble(txtInput.Text);
                txtOpgave.Text = txtOpgave.Text.Insert(0, " / " + Getal2.ToString());
                Getal1 = Berekening.MaakBerekening(Getal1, Getal2, Bewerking);
                Bewerking = '/';
                txtInput.Text = Getal1.ToString();
                OpgaveGemaakt = true;
            }
        }
        private void BtnEquals_Click(object sender, EventArgs e)
        {
            Getal2 = Convert.ToDouble(txtInput.Text);
            txtInput.Clear();
            txtOpgave.Clear();
            txtInput.Text = Berekening.MaakBerekening(Getal1, Getal2, Bewerking).ToString();
            Getal1Ingevuld = false;
            OpgaveGemaakt = true;
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtOpgave.Clear();
            Getal1Ingevuld = false;
        }

        private void BtnBackSpace_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text.Remove(txtInput.Text.Length-1, 1);
        }

        private void BtnGedeeldDoorX_Click(object sender, EventArgs e)
        {
            txtInput.Text = (1/Convert.ToDouble(txtInput.Text)).ToString();
        }

        private void BtnMacht_Click(object sender, EventArgs e)
        {
            txtInput.Text = (Convert.ToDouble(txtInput.Text)* Convert.ToDouble(txtInput.Text)).ToString();
        }

        private void BtnVierkantsWortel_Click(object sender, EventArgs e)
        {
            txtInput.Text = Math.Sqrt(Convert.ToDouble(txtInput.Text)).ToString();
        }

        private void BtnPercent_Click(object sender, EventArgs e)
        {
            txtInput.Text = (Getal1 * (Convert.ToDouble(txtInput.Text)/100)).ToString();
        }

        private void BtnVeranderTeken_Click(object sender, EventArgs e)
        {
            txtInput.Text = (Convert.ToDouble(txtInput.Text) * -1).ToString();
        }

        private void Rekenmachine_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0) { btnNul.PerformClick(); }
            if (e.KeyCode == Keys.NumPad1) { btnEen.PerformClick(); }
            if (e.KeyCode == Keys.NumPad2) { btnTwee.PerformClick(); }
            if (e.KeyCode == Keys.NumPad3) { btnDrie.PerformClick(); }
            if (e.KeyCode == Keys.NumPad4) { btnVier.PerformClick(); }
            if (e.KeyCode == Keys.NumPad5) { btnVijf.PerformClick(); }
            if (e.KeyCode == Keys.NumPad6) { btnZes.PerformClick(); }
            if (e.KeyCode == Keys.NumPad7) { btnZeven.PerformClick(); }
            if (e.KeyCode == Keys.NumPad8) { btnAcht.PerformClick(); }
            if (e.KeyCode == Keys.NumPad9) { btnNegen.PerformClick(); }
            if (e.KeyCode == Keys.Add) { btnPlus.PerformClick(); }
            if (e.KeyCode == Keys.Subtract) { btnMin.PerformClick(); }
            if (e.KeyCode == Keys.Multiply) { btnMaal.PerformClick(); }
            if (e.KeyCode == Keys.Divide) { btnDeling.PerformClick(); }
            if (e.KeyCode == Keys.Enter) { btnEquals.PerformClick(); }
        }

    }
}
