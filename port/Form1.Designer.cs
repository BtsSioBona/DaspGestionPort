namespace Port_classes
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpBoxPort = new System.Windows.Forms.GroupBox();
            this.lbNbStockage = new System.Windows.Forms.Label();
            this.btnCreerPort = new System.Windows.Forms.Button();
            this.grpStockage = new System.Windows.Forms.GroupBox();
            this.cmbBoxStockage = new System.Windows.Forms.ComboBox();
            this.btnAfficherStockage = new System.Windows.Forms.Button();
            this.btnCreerStockage = new System.Windows.Forms.Button();
            this.numUpDownCapacite = new System.Windows.Forms.NumericUpDown();
            this.lbCapacite = new System.Windows.Forms.Label();
            this.grpBoxNavire = new System.Windows.Forms.GroupBox();
            this.btnVoirNomBateau = new System.Windows.Forms.Button();
            this.btnCreerNavire = new System.Windows.Forms.Button();
            this.txtBoxQte = new System.Windows.Forms.TextBox();
            this.lbQte = new System.Windows.Forms.Label();
            this.txtBoxFret = new System.Windows.Forms.TextBox();
            this.lbFret = new System.Windows.Forms.Label();
            this.txtBoxNom = new System.Windows.Forms.TextBox();
            this.lbNom = new System.Windows.Forms.Label();
            this.txtBoxNumero = new System.Windows.Forms.TextBox();
            this.lbNumero = new System.Windows.Forms.Label();
            this.grpBoxAction = new System.Windows.Forms.GroupBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnDecharger = new System.Windows.Forms.Button();
            this.lbTitre = new System.Windows.Forms.Label();
            this.grpBoxPort.SuspendLayout();
            this.grpStockage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownCapacite)).BeginInit();
            this.grpBoxNavire.SuspendLayout();
            this.grpBoxAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxPort
            // 
            this.grpBoxPort.Controls.Add(this.lbNbStockage);
            this.grpBoxPort.Controls.Add(this.btnCreerPort);
            this.grpBoxPort.Location = new System.Drawing.Point(12, 66);
            this.grpBoxPort.Name = "grpBoxPort";
            this.grpBoxPort.Size = new System.Drawing.Size(412, 83);
            this.grpBoxPort.TabIndex = 0;
            this.grpBoxPort.TabStop = false;
            this.grpBoxPort.Text = "Port";
            // 
            // lbNbStockage
            // 
            this.lbNbStockage.AutoSize = true;
            this.lbNbStockage.Location = new System.Drawing.Point(108, 38);
            this.lbNbStockage.Name = "lbNbStockage";
            this.lbNbStockage.Size = new System.Drawing.Size(72, 13);
            this.lbNbStockage.TabIndex = 1;
            this.lbNbStockage.Text = "NbStockages";
            // 
            // btnCreerPort
            // 
            this.btnCreerPort.Location = new System.Drawing.Point(7, 32);
            this.btnCreerPort.Name = "btnCreerPort";
            this.btnCreerPort.Size = new System.Drawing.Size(94, 23);
            this.btnCreerPort.TabIndex = 0;
            this.btnCreerPort.Text = "Créer un Port";
            this.btnCreerPort.UseVisualStyleBackColor = true;
            this.btnCreerPort.Click += new System.EventHandler(this.btnCreerPort_Click);
            // 
            // grpStockage
            // 
            this.grpStockage.Controls.Add(this.cmbBoxStockage);
            this.grpStockage.Controls.Add(this.btnAfficherStockage);
            this.grpStockage.Controls.Add(this.btnCreerStockage);
            this.grpStockage.Controls.Add(this.numUpDownCapacite);
            this.grpStockage.Controls.Add(this.lbCapacite);
            this.grpStockage.Location = new System.Drawing.Point(12, 155);
            this.grpStockage.Name = "grpStockage";
            this.grpStockage.Size = new System.Drawing.Size(412, 117);
            this.grpStockage.TabIndex = 1;
            this.grpStockage.TabStop = false;
            this.grpStockage.Text = "Stockage";
            // 
            // cmbBoxStockage
            // 
            this.cmbBoxStockage.FormattingEnabled = true;
            this.cmbBoxStockage.Location = new System.Drawing.Point(78, 86);
            this.cmbBoxStockage.Name = "cmbBoxStockage";
            this.cmbBoxStockage.Size = new System.Drawing.Size(313, 21);
            this.cmbBoxStockage.TabIndex = 4;
            // 
            // btnAfficherStockage
            // 
            this.btnAfficherStockage.Location = new System.Drawing.Point(78, 52);
            this.btnAfficherStockage.Name = "btnAfficherStockage";
            this.btnAfficherStockage.Size = new System.Drawing.Size(127, 27);
            this.btnAfficherStockage.TabIndex = 3;
            this.btnAfficherStockage.Text = "Afficher les stockages";
            this.btnAfficherStockage.UseVisualStyleBackColor = true;
            this.btnAfficherStockage.Click += new System.EventHandler(this.btnAfficherStockage_Click);
            // 
            // btnCreerStockage
            // 
            this.btnCreerStockage.Location = new System.Drawing.Point(162, 23);
            this.btnCreerStockage.Name = "btnCreerStockage";
            this.btnCreerStockage.Size = new System.Drawing.Size(107, 23);
            this.btnCreerStockage.TabIndex = 2;
            this.btnCreerStockage.Text = "Créer un Stockage";
            this.btnCreerStockage.UseVisualStyleBackColor = true;
            this.btnCreerStockage.Click += new System.EventHandler(this.btnCreerStockage_Click);
            // 
            // numUpDownCapacite
            // 
            this.numUpDownCapacite.Location = new System.Drawing.Point(78, 24);
            this.numUpDownCapacite.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numUpDownCapacite.Name = "numUpDownCapacite";
            this.numUpDownCapacite.Size = new System.Drawing.Size(78, 20);
            this.numUpDownCapacite.TabIndex = 1;
            this.numUpDownCapacite.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lbCapacite
            // 
            this.lbCapacite.AutoSize = true;
            this.lbCapacite.Location = new System.Drawing.Point(22, 24);
            this.lbCapacite.Name = "lbCapacite";
            this.lbCapacite.Size = new System.Drawing.Size(49, 13);
            this.lbCapacite.TabIndex = 0;
            this.lbCapacite.Text = "Capacité";
            // 
            // grpBoxNavire
            // 
            this.grpBoxNavire.Controls.Add(this.btnVoirNomBateau);
            this.grpBoxNavire.Controls.Add(this.btnCreerNavire);
            this.grpBoxNavire.Controls.Add(this.txtBoxQte);
            this.grpBoxNavire.Controls.Add(this.lbQte);
            this.grpBoxNavire.Controls.Add(this.txtBoxFret);
            this.grpBoxNavire.Controls.Add(this.lbFret);
            this.grpBoxNavire.Controls.Add(this.txtBoxNom);
            this.grpBoxNavire.Controls.Add(this.lbNom);
            this.grpBoxNavire.Controls.Add(this.txtBoxNumero);
            this.grpBoxNavire.Controls.Add(this.lbNumero);
            this.grpBoxNavire.Location = new System.Drawing.Point(12, 278);
            this.grpBoxNavire.Name = "grpBoxNavire";
            this.grpBoxNavire.Size = new System.Drawing.Size(412, 146);
            this.grpBoxNavire.TabIndex = 2;
            this.grpBoxNavire.TabStop = false;
            this.grpBoxNavire.Text = "Navire";
            // 
            // btnVoirNomBateau
            // 
            this.btnVoirNomBateau.Location = new System.Drawing.Point(258, 81);
            this.btnVoirNomBateau.Name = "btnVoirNomBateau";
            this.btnVoirNomBateau.Size = new System.Drawing.Size(133, 23);
            this.btnVoirNomBateau.TabIndex = 9;
            this.btnVoirNomBateau.Text = "Voir Nom Du Bateau";
            this.btnVoirNomBateau.UseVisualStyleBackColor = true;
            this.btnVoirNomBateau.Visible = false;
            // 
            // btnCreerNavire
            // 
            this.btnCreerNavire.Location = new System.Drawing.Point(258, 29);
            this.btnCreerNavire.Name = "btnCreerNavire";
            this.btnCreerNavire.Size = new System.Drawing.Size(133, 23);
            this.btnCreerNavire.TabIndex = 8;
            this.btnCreerNavire.Text = "Créer Navire";
            this.btnCreerNavire.UseVisualStyleBackColor = true;
            this.btnCreerNavire.Click += new System.EventHandler(this.btnCreerNavire_Click);
            // 
            // txtBoxQte
            // 
            this.txtBoxQte.Location = new System.Drawing.Point(78, 107);
            this.txtBoxQte.Name = "txtBoxQte";
            this.txtBoxQte.Size = new System.Drawing.Size(151, 20);
            this.txtBoxQte.TabIndex = 7;
            // 
            // lbQte
            // 
            this.lbQte.AutoSize = true;
            this.lbQte.Location = new System.Drawing.Point(27, 107);
            this.lbQte.Name = "lbQte";
            this.lbQte.Size = new System.Drawing.Size(24, 13);
            this.lbQte.TabIndex = 6;
            this.lbQte.Text = "Qté";
            // 
            // txtBoxFret
            // 
            this.txtBoxFret.Location = new System.Drawing.Point(78, 81);
            this.txtBoxFret.Name = "txtBoxFret";
            this.txtBoxFret.Size = new System.Drawing.Size(151, 20);
            this.txtBoxFret.TabIndex = 5;
            // 
            // lbFret
            // 
            this.lbFret.AutoSize = true;
            this.lbFret.Location = new System.Drawing.Point(27, 81);
            this.lbFret.Name = "lbFret";
            this.lbFret.Size = new System.Drawing.Size(25, 13);
            this.lbFret.TabIndex = 4;
            this.lbFret.Text = "Frêt";
            // 
            // txtBoxNom
            // 
            this.txtBoxNom.Location = new System.Drawing.Point(78, 55);
            this.txtBoxNom.Name = "txtBoxNom";
            this.txtBoxNom.Size = new System.Drawing.Size(151, 20);
            this.txtBoxNom.TabIndex = 3;
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Location = new System.Drawing.Point(27, 55);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(29, 13);
            this.lbNom.TabIndex = 2;
            this.lbNom.Text = "Nom";
            // 
            // txtBoxNumero
            // 
            this.txtBoxNumero.Location = new System.Drawing.Point(78, 29);
            this.txtBoxNumero.Name = "txtBoxNumero";
            this.txtBoxNumero.Size = new System.Drawing.Size(151, 20);
            this.txtBoxNumero.TabIndex = 1;
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Location = new System.Drawing.Point(27, 29);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(44, 13);
            this.lbNumero.TabIndex = 0;
            this.lbNumero.Text = "Numéro";
            // 
            // grpBoxAction
            // 
            this.grpBoxAction.Controls.Add(this.btnQuitter);
            this.grpBoxAction.Controls.Add(this.btnDecharger);
            this.grpBoxAction.Location = new System.Drawing.Point(12, 431);
            this.grpBoxAction.Name = "grpBoxAction";
            this.grpBoxAction.Size = new System.Drawing.Size(269, 77);
            this.grpBoxAction.TabIndex = 3;
            this.grpBoxAction.TabStop = false;
            this.grpBoxAction.Text = "Action";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(134, 35);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(103, 23);
            this.btnQuitter.TabIndex = 1;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnDecharger
            // 
            this.btnDecharger.Location = new System.Drawing.Point(25, 35);
            this.btnDecharger.Name = "btnDecharger";
            this.btnDecharger.Size = new System.Drawing.Size(103, 23);
            this.btnDecharger.TabIndex = 0;
            this.btnDecharger.Text = "Décharger";
            this.btnDecharger.UseVisualStyleBackColor = true;
            this.btnDecharger.Click += new System.EventHandler(this.btnDecharger_Click);
            // 
            // lbTitre
            // 
            this.lbTitre.AutoSize = true;
            this.lbTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitre.Location = new System.Drawing.Point(7, 21);
            this.lbTitre.Name = "lbTitre";
            this.lbTitre.Size = new System.Drawing.Size(420, 37);
            this.lbTitre.TabIndex = 4;
            this.lbTitre.Text = "Les Classes et les Winforms";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 516);
            this.Controls.Add(this.lbTitre);
            this.Controls.Add(this.grpBoxAction);
            this.Controls.Add(this.grpBoxNavire);
            this.Controls.Add(this.grpStockage);
            this.Controls.Add(this.grpBoxPort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpBoxPort.ResumeLayout(false);
            this.grpBoxPort.PerformLayout();
            this.grpStockage.ResumeLayout(false);
            this.grpStockage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownCapacite)).EndInit();
            this.grpBoxNavire.ResumeLayout(false);
            this.grpBoxNavire.PerformLayout();
            this.grpBoxAction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxPort;
        private System.Windows.Forms.Label lbNbStockage;
        private System.Windows.Forms.Button btnCreerPort;
        private System.Windows.Forms.GroupBox grpStockage;
        private System.Windows.Forms.ComboBox cmbBoxStockage;
        private System.Windows.Forms.Button btnAfficherStockage;
        private System.Windows.Forms.Button btnCreerStockage;
        private System.Windows.Forms.NumericUpDown numUpDownCapacite;
        private System.Windows.Forms.Label lbCapacite;
        private System.Windows.Forms.GroupBox grpBoxNavire;
        private System.Windows.Forms.Button btnVoirNomBateau;
        private System.Windows.Forms.Button btnCreerNavire;
        private System.Windows.Forms.TextBox txtBoxQte;
        private System.Windows.Forms.Label lbQte;
        private System.Windows.Forms.TextBox txtBoxFret;
        private System.Windows.Forms.Label lbFret;
        private System.Windows.Forms.TextBox txtBoxNom;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.TextBox txtBoxNumero;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.GroupBox grpBoxAction;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnDecharger;
        private System.Windows.Forms.Label lbTitre;
    }
}

