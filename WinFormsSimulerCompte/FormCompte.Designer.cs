namespace WinFormsSimulerCompte
{
    partial class FormCompte
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxDonnees = new GroupBox();
            groupBoxMontant = new GroupBox();
            buttonDeposer = new Button();
            buttonRetirer = new Button();
            buttonVider = new Button();
            buttonReset = new Button();
            labelNumero = new Label();
            labelDetenteur = new Label();
            labelSolde = new Label();
            textBoxNumero = new TextBox();
            textBoxSolde = new TextBox();
            textBoxDetenteur = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            textBox1 = new TextBox();
            buttonMontant = new Button();
            buttonRandom = new Button();
            numericUpDown1 = new NumericUpDown();
            radioButton0a1 = new RadioButton();
            radioButton1a10 = new RadioButton();
            radioButton10a100 = new RadioButton();
            radioButton100a1000 = new RadioButton();
            groupBoxDonnees.SuspendLayout();
            groupBoxMontant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxDonnees
            // 
            groupBoxDonnees.Controls.Add(checkBox2);
            groupBoxDonnees.Controls.Add(textBoxDetenteur);
            groupBoxDonnees.Controls.Add(textBoxSolde);
            groupBoxDonnees.Controls.Add(textBoxNumero);
            groupBoxDonnees.Controls.Add(labelSolde);
            groupBoxDonnees.Controls.Add(labelNumero);
            groupBoxDonnees.Controls.Add(labelDetenteur);
            groupBoxDonnees.Location = new Point(12, 12);
            groupBoxDonnees.Name = "groupBoxDonnees";
            groupBoxDonnees.Size = new Size(444, 152);
            groupBoxDonnees.TabIndex = 0;
            groupBoxDonnees.TabStop = false;
            groupBoxDonnees.Text = "Données du compte";
            groupBoxDonnees.Enter += groupBox1_Enter;
            // 
            // groupBoxMontant
            // 
            groupBoxMontant.Controls.Add(radioButton100a1000);
            groupBoxMontant.Controls.Add(radioButton10a100);
            groupBoxMontant.Controls.Add(radioButton1a10);
            groupBoxMontant.Controls.Add(radioButton0a1);
            groupBoxMontant.Controls.Add(numericUpDown1);
            groupBoxMontant.Controls.Add(buttonRandom);
            groupBoxMontant.Controls.Add(buttonMontant);
            groupBoxMontant.Location = new Point(495, 12);
            groupBoxMontant.Name = "groupBoxMontant";
            groupBoxMontant.Size = new Size(293, 152);
            groupBoxMontant.TabIndex = 1;
            groupBoxMontant.TabStop = false;
            groupBoxMontant.Text = "Montant";
            // 
            // buttonDeposer
            // 
            buttonDeposer.BackColor = SystemColors.ControlLight;
            buttonDeposer.FlatStyle = FlatStyle.Popup;
            buttonDeposer.Location = new Point(12, 211);
            buttonDeposer.Name = "buttonDeposer";
            buttonDeposer.Size = new Size(94, 29);
            buttonDeposer.TabIndex = 2;
            buttonDeposer.Text = "Déposer";
            buttonDeposer.UseVisualStyleBackColor = false;
            // 
            // buttonRetirer
            // 
            buttonRetirer.BackColor = SystemColors.ControlLight;
            buttonRetirer.FlatStyle = FlatStyle.Popup;
            buttonRetirer.Location = new Point(232, 211);
            buttonRetirer.Name = "buttonRetirer";
            buttonRetirer.Size = new Size(94, 29);
            buttonRetirer.TabIndex = 3;
            buttonRetirer.Text = "Retirer";
            buttonRetirer.UseVisualStyleBackColor = false;
            // 
            // buttonVider
            // 
            buttonVider.BackColor = SystemColors.ControlLight;
            buttonVider.FlatStyle = FlatStyle.Popup;
            buttonVider.Location = new Point(460, 211);
            buttonVider.Name = "buttonVider";
            buttonVider.Size = new Size(94, 29);
            buttonVider.TabIndex = 4;
            buttonVider.Text = "Vider";
            buttonVider.UseVisualStyleBackColor = false;
            // 
            // buttonReset
            // 
            buttonReset.BackColor = SystemColors.ControlLight;
            buttonReset.FlatStyle = FlatStyle.Popup;
            buttonReset.Location = new Point(694, 211);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(94, 29);
            buttonReset.TabIndex = 5;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = false;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Location = new Point(34, 39);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(70, 20);
            labelNumero.TabIndex = 0;
            labelNumero.Text = "Numéro :";
            labelNumero.Click += this.label1_Click;
            // 
            // labelDetenteur
            // 
            labelDetenteur.AutoSize = true;
            labelDetenteur.Location = new Point(22, 72);
            labelDetenteur.Name = "labelDetenteur";
            labelDetenteur.Size = new Size(82, 20);
            labelDetenteur.TabIndex = 1;
            labelDetenteur.Text = "Détenteur :";
            labelDetenteur.Click += this.label2_Click;
            // 
            // labelSolde
            // 
            labelSolde.AutoSize = true;
            labelSolde.Location = new Point(50, 104);
            labelSolde.Name = "labelSolde";
            labelSolde.Size = new Size(54, 20);
            labelSolde.TabIndex = 2;
            labelSolde.Text = "Solde :";
            labelSolde.Click += this.label3_Click;
            // 
            // textBoxNumero
            // 
            textBoxNumero.BackColor = SystemColors.ControlLight;
            textBoxNumero.BorderStyle = BorderStyle.FixedSingle;
            textBoxNumero.Location = new Point(125, 36);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.ReadOnly = true;
            textBoxNumero.Size = new Size(173, 27);
            textBoxNumero.TabIndex = 3;
            // 
            // textBoxSolde
            // 
            textBoxSolde.BackColor = SystemColors.ControlLight;
            textBoxSolde.BorderStyle = BorderStyle.FixedSingle;
            textBoxSolde.Location = new Point(125, 101);
            textBoxSolde.Name = "textBoxSolde";
            textBoxSolde.ReadOnly = true;
            textBoxSolde.Size = new Size(295, 27);
            textBoxSolde.TabIndex = 4;
            // 
            // textBoxDetenteur
            // 
            textBoxDetenteur.BackColor = SystemColors.Control;
            textBoxDetenteur.BorderStyle = BorderStyle.FixedSingle;
            textBoxDetenteur.Location = new Point(125, 69);
            textBoxDetenteur.Name = "textBoxDetenteur";
            textBoxDetenteur.Size = new Size(295, 27);
            textBoxDetenteur.TabIndex = 5;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(0, 0);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 24);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(332, 39);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(61, 24);
            checkBox2.TabIndex = 6;
            checkBox2.Text = "Gelé";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(12, 272);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(776, 166);
            textBox1.TabIndex = 7;
            // 
            // buttonMontant
            // 
            buttonMontant.BackColor = SystemColors.ControlLight;
            buttonMontant.FlatStyle = FlatStyle.Popup;
            buttonMontant.Location = new Point(22, 67);
            buttonMontant.Name = "buttonMontant";
            buttonMontant.Size = new Size(94, 29);
            buttonMontant.TabIndex = 8;
            buttonMontant.Text = "0.01";
            buttonMontant.UseVisualStyleBackColor = false;
            // 
            // buttonRandom
            // 
            buttonRandom.BackColor = SystemColors.ControlLight;
            buttonRandom.FlatStyle = FlatStyle.Popup;
            buttonRandom.Location = new Point(22, 104);
            buttonRandom.Name = "buttonRandom";
            buttonRandom.Size = new Size(94, 29);
            buttonRandom.TabIndex = 9;
            buttonRandom.Text = "Random";
            buttonRandom.UseVisualStyleBackColor = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = SystemColors.MenuBar;
            numericUpDown1.BorderStyle = BorderStyle.FixedSingle;
            numericUpDown1.Location = new Point(22, 32);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(94, 27);
            numericUpDown1.TabIndex = 10;
            // 
            // radioButton0a1
            // 
            radioButton0a1.AutoSize = true;
            radioButton0a1.Location = new Point(154, 27);
            radioButton0a1.Name = "radioButton0a1";
            radioButton0a1.Size = new Size(62, 24);
            radioButton0a1.TabIndex = 11;
            radioButton0a1.TabStop = true;
            radioButton0a1.Text = "0 à 1";
            radioButton0a1.UseVisualStyleBackColor = true;
            // 
            // radioButton1a10
            // 
            radioButton1a10.AutoSize = true;
            radioButton1a10.Location = new Point(154, 57);
            radioButton1a10.Name = "radioButton1a10";
            radioButton1a10.Size = new Size(70, 24);
            radioButton1a10.TabIndex = 12;
            radioButton1a10.TabStop = true;
            radioButton1a10.Text = "1 à 10";
            radioButton1a10.UseVisualStyleBackColor = true;
            // 
            // radioButton10a100
            // 
            radioButton10a100.AutoSize = true;
            radioButton10a100.Location = new Point(154, 87);
            radioButton10a100.Name = "radioButton10a100";
            radioButton10a100.Size = new Size(86, 24);
            radioButton10a100.TabIndex = 13;
            radioButton10a100.TabStop = true;
            radioButton10a100.Text = "10 à 100";
            radioButton10a100.UseVisualStyleBackColor = true;
            // 
            // radioButton100a1000
            // 
            radioButton100a1000.AutoSize = true;
            radioButton100a1000.Location = new Point(154, 117);
            radioButton100a1000.Name = "radioButton100a1000";
            radioButton100a1000.Size = new Size(102, 24);
            radioButton100a1000.TabIndex = 14;
            radioButton100a1000.TabStop = true;
            radioButton100a1000.Text = "100 à 1000";
            radioButton100a1000.UseVisualStyleBackColor = true;
            // 
            // FormCompte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(checkBox1);
            Controls.Add(buttonReset);
            Controls.Add(buttonVider);
            Controls.Add(buttonRetirer);
            Controls.Add(buttonDeposer);
            Controls.Add(groupBoxMontant);
            Controls.Add(groupBoxDonnees);
            Name = "FormCompte";
            Text = "Simulateur de Compte - Charles-Étienne Filion";
            Load += Form1_Load;
            groupBoxDonnees.ResumeLayout(false);
            groupBoxDonnees.PerformLayout();
            groupBoxMontant.ResumeLayout(false);
            groupBoxMontant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxDonnees;
        private GroupBox groupBoxMontant;
        private Button buttonDeposer;
        private Button buttonRetirer;
        private Button buttonVider;
        private Button buttonReset;
        private Label labelSolde;
        private Label labelDetenteur;
        private Label labelNumero;
        private TextBox textBoxDetenteur;
        private TextBox textBoxSolde;
        private TextBox textBoxNumero;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private Button buttonRandom;
        private Button buttonMontant;
        private RadioButton radioButton100a1000;
        private RadioButton radioButton10a100;
        private RadioButton radioButton1a10;
        private RadioButton radioButton0a1;
    }
}
