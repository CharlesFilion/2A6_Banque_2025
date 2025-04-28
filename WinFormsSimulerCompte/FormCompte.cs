using System.Reflection.Metadata;
using BanqueLib;
using Microsoft.VisualBasic.Devices;

namespace WinFormsSimulerCompte
{
    public partial class FormCompte : Form
    {
        private Random rnd = new Random();
        private readonly Compte _compte;
        public FormCompte(Compte compte)
        {
            _compte = compte;
            InitializeComponent();
            textBoxNumero.Text = _compte.Numéro.ToString();
            textBoxDetenteur.Text = _compte.Détenteur.ToString();
            textBoxSolde.Text = _compte.Solde.ToString() + "$";
            if (_compte.Statut == Compte.StatutCompte.Gelé)
            {
                checkBoxGele.Checked = true;
            }
            else
            {
                checkBoxGele.Checked = false;
            }
        }

        private void Repercuter()
        {
            textBoxSolde.Text = _compte.Solde.ToString() + "$";
            buttonReset.Enabled = _compte.Solde != 0;

            if (_compte.PeutDéposer(numericUpDownMontant.Value) == false)
            {
                buttonDeposer.Enabled = false;
            }
            else
            {
                buttonDeposer.Enabled = true;
            }

            if (_compte.PeutRetirer(numericUpDownMontant.Value) == false)
            {
                buttonRetirer.Enabled = false;
            }
            else
            {
                buttonRetirer.Enabled = true;
            }

            if (_compte.PeutRetirer(_compte.Solde) == false || _compte.Solde == 0)
            {
                buttonVider.Enabled = false;
            }
            else
            {
                buttonVider.Enabled = true;
            }

            if (string.IsNullOrEmpty(textBoxLog.Text))
            {
                buttonReset.Enabled = false;
            }
            else
            {
                buttonReset.Enabled = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Repercuter();
        }

        private void checkBoxGele_Click(object sender, EventArgs e)
        {
            if (_compte.Statut == Compte.StatutCompte.Gelé)
            {
                _compte.Dégeler();
                textBoxLog.AppendText("[CF] Compte dégelé" + Environment.NewLine);
            }
            else
            {
                _compte.Geler();
                textBoxLog.AppendText("[CF] Compte gelé" + Environment.NewLine);
            }
            Repercuter();
        }

        private void buttonResetMontant_Click(object sender, EventArgs e)
        {
            numericUpDownMontant.Value = 0.01m;
            Repercuter();
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            decimal montant;
            if (radioButton0a1.Checked)
            {
                montant = rnd.Next(0, 100);
                montant /= 100;
                numericUpDownMontant.Value += montant;
            }
            else if (radioButton1a10.Checked)
            {
                montant = rnd.Next(100, 1000);
                montant /= 100;
                numericUpDownMontant.Value += montant;
            }
            else if (radioButton10a100.Checked)
            {
                montant = rnd.Next(1000, 10000);
                montant /= 100;
                numericUpDownMontant.Value += montant;
            }
            else if (radioButton100a1000.Checked)
            {
                montant = rnd.Next(10000, 100000);
                montant /= 100;
                numericUpDownMontant.Value += montant;
            }
            Repercuter();
        }

        private void buttonVider_Click(object sender, EventArgs e)
        {
            if (_compte.Statut == Compte.StatutCompte.Gelé)
            {
                textBoxLog.AppendText("[CF] Impossible de vider un compte gelé" + Environment.NewLine);
            }
            else
            {
                textBoxLog.AppendText($"[CF] Retrait complet de {_compte.Vider()}$" + Environment.NewLine);
            }
            Repercuter();
        }

        private void buttonDeposer_Click(object sender, EventArgs e)
        {
            _compte.Déposer(numericUpDownMontant.Value);
            textBoxLog.AppendText($"[CF] Dépôt de {numericUpDownMontant.Value}$" + Environment.NewLine);
            Repercuter();
        }

        private void buttonRetirer_Click(object sender, EventArgs e)
        {
            _compte.Retirer(numericUpDownMontant.Value);
            textBoxLog.AppendText($"[CF] Retrait de {numericUpDownMontant.Value}$" + Environment.NewLine);
            Repercuter();
        }

        private void textBoxDetenteur_Leave(object sender, EventArgs e)
        {
            textBoxDetenteur.Text = _compte.Détenteur;
            Repercuter();
        }

        private void DetenteurEnterKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (textBoxDetenteur.Text == _compte.Détenteur || string.IsNullOrEmpty(textBoxDetenteur.Text) || string.IsNullOrWhiteSpace(textBoxDetenteur.Text))
                {
                    textBoxDetenteur.Text = _compte.Détenteur;
                }
                else
                {
                    MessageBox.Show("[CF] Le nom du détenteur a été modifié");
                    textBoxLog.AppendText($"[CF] Le nom du détenteur a été modifié par {_compte.Détenteur}" + Environment.NewLine);
                    _compte.SetDétenteur(textBoxDetenteur.Text);
                    textBoxSolde.Focus();
                }
            }
            Repercuter();
        }
        private void DetenteurEscapeKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                textBoxDetenteur.Text = _compte.Détenteur;
                textBoxSolde.Focus();
            }
            Repercuter();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Voulez-vous effacer la simulation?", "Confirmation", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.No || result == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                _compte.SetDétenteur("Charles-Étienne Filion");
                textBoxDetenteur.Text = _compte.Détenteur;
                _compte.SetRandomSolde();
                textBoxSolde.Text = _compte.Solde.ToString() + "$";
                _compte.Dégeler();
                numericUpDownMontant.Value = 0.01m;
                radioButton0a1.Checked = true;
                textBoxLog.Text = "";
            }
            Repercuter();
        }
    }
}
