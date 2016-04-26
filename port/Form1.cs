using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Navire_interface;

namespace Port_classes
{
    public partial class Form1 : Form
    {
        private Port _port;
        private Navire _navire;
        public Form1()
        {
            InitializeComponent();
            if(this._port == null)
            {
                grpStockage.Enabled = false;
                grpBoxNavire.Enabled = false;
                grpBoxAction.Enabled = false;
            }
        }

        private void btnCreerPort_Click(object sender, EventArgs e)
        {
            this._port = new Port();
            lbNbStockage.Text = "NbStockages 0";
            grpStockage.Enabled = true;
            btnCreerPort.Enabled = false;
        }

        private void btnCreerStockage_Click(object sender, EventArgs e)
        {
            try {
                this._port.AddStockage((int)numUpDownCapacite.Value);
                lbNbStockage.Text = "NbStockages " + this._port.Stockages.Count;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "NavireIHM", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            if (this._port.Stockages.Count >= 3)
            {
                grpBoxNavire.Enabled = true;
            }
        }

        private void btnAfficherStockage_Click(object sender, EventArgs e)
        {
            cmbBoxStockage.Items.Clear();
            cmbBoxStockage.BeginUpdate();
            for(int i = 0; i < this._port.Stockages.Count; i++)
            {
                cmbBoxStockage.Items.Add(i+"- CapaTotal : " + this._port.Stockages[i].CapaTotal + " CapaDispo : " + this._port.Stockages[i].CapaDispo);
            }
            cmbBoxStockage.Text = cmbBoxStockage.Items[0].ToString();
            cmbBoxStockage.EndUpdate();
        }

        private void btnCreerNavire_Click(object sender, EventArgs e)
        {
            try {
                this._navire = new Navire(txtBoxNumero.Text, txtBoxNom.Text, txtBoxFret.Text, Convert.ToInt32(txtBoxQte.Text));
                grpBoxAction.Enabled = true;
                txtBoxFret.Enabled = false;
                txtBoxNom.Enabled = false;
                txtBoxNumero.Enabled = false;
                txtBoxQte.Enabled = false;
                btnCreerNavire.Enabled = false;
                btnVoirNomBateau.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "NavireIHM", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void btnDecharger_Click(object sender, EventArgs e)
        {
            try
            {
                this._port.Dechargement(this._navire);
                MessageBox.Show("Navire complétement déchargé", "NavireIHM", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "NavireIHM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Voulez-vous quitter l'application ?", "NavireIHM", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                this.Close();
        }
    }
}
