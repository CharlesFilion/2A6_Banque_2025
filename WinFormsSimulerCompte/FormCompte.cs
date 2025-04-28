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
            textBoxNumero.Text = _compte.Num�ro.ToString();
            textBoxDetenteur.Text = _compte.D�tenteur.ToString();
            textBoxSolde.Text = _compte.Solde.ToString() + "$";
            if (_compte.Statut == Compte.StatutCompte.Gel�)
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

            if (_compte.PeutD�poser(numericUpDownMontant.Value) == false)
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
            if (_compte.Statut == Compte.StatutCompte.Gel�)
            {
                _compte.D�geler();
                textBoxLog.AppendText("[CF] Compte d�gel�" + Environment.NewLine);
            }
            else
            {
                _compte.Geler();
                textBoxLog.AppendText("[CF] Compte gel�" + Environment.NewLine);
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
            if (_compte.Statut == Compte.StatutCompte.Gel�)
            {
                textBoxLog.AppendText("[CF] Impossible de vider un compte gel�" + Environment.NewLine);
            }
            else
            {
                textBoxLog.AppendText($"[CF] Retrait complet de {_compte.Vider()}$" + Environment.NewLine);
            }
            Repercuter();
        }

        private void buttonDeposer_Click(object sender, EventArgs e)
        {
            _compte.D�poser(numericUpDownMontant.Value);
            textBoxLog.AppendText($"[CF] D�p�t de {numericUpDownMontant.Value}$" + Environment.NewLine);
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
            textBoxDetenteur.Text = _compte.D�tenteur;
            Repercuter();
        }

        private void DetenteurEnterKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (textBoxDetenteur.Text == _compte.D�tenteur || string.IsNullOrEmpty(textBoxDetenteur.Text) || string.IsNullOrWhiteSpace(textBoxDetenteur.Text))
                {
                    textBoxDetenteur.Text = _compte.D�tenteur;
                }
                else
                {
                    MessageBox.Show("[CF] Le nom du d�tenteur a �t� modifi�");
                    textBoxLog.AppendText($"[CF] Le nom du d�tenteur a �t� modifi� par {_compte.D�tenteur}" + Environment.NewLine);
                    _compte.SetD�tenteur(textBoxDetenteur.Text);
                    textBoxSolde.Focus();
                }
            }
            Repercuter();
        }
        private void DetenteurEscapeKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                textBoxDetenteur.Text = _compte.D�tenteur;
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
                _compte.SetD�tenteur("Charles-�tienne Filion");
                textBoxDetenteur.Text = _compte.D�tenteur;
                _compte.SetRandomSolde();
                textBoxSolde.Text = _compte.Solde.ToString() + "$";
                _compte.D�geler();
                numericUpDownMontant.Value = 0.01m;
                radioButton0a1.Checked = true;
                textBoxLog.Text = "";
            }
            Repercuter();
        }
    }
}
