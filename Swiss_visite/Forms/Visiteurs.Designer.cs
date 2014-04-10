namespace Swiss_visite.Forms
{
    partial class Visiteurs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblVisiteur = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.lblEmbauche = new System.Windows.Forms.Label();
            this.lblCodeBD = new System.Windows.Forms.Label();
            this.bsVisiteurs = new System.Windows.Forms.BindingSource(this.components);
            this.lblAdresseBD = new System.Windows.Forms.Label();
            this.lblVilleBD = new System.Windows.Forms.Label();
            this.lblCPBD = new System.Windows.Forms.Label();
            this.lblEmbaucheBD = new System.Windows.Forms.Label();
            this.cBVisiteur = new System.Windows.Forms.ComboBox();
            this.lblAcces = new System.Windows.Forms.Label();
            this.lblAccesBD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteurs)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVisiteur
            // 
            this.lblVisiteur.AutoSize = true;
            this.lblVisiteur.Location = new System.Drawing.Point(31, 20);
            this.lblVisiteur.Name = "lblVisiteur";
            this.lblVisiteur.Size = new System.Drawing.Size(44, 13);
            this.lblVisiteur.TabIndex = 1;
            this.lblVisiteur.Text = "Visiteur:";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(31, 62);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(35, 13);
            this.lblCode.TabIndex = 2;
            this.lblCode.Text = "Code:";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(31, 101);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(48, 13);
            this.lblAdresse.TabIndex = 3;
            this.lblAdresse.Text = "Adresse:";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(31, 141);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(29, 13);
            this.lblVille.TabIndex = 4;
            this.lblVille.Text = "Ville:";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(31, 185);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(67, 13);
            this.lblCP.TabIndex = 5;
            this.lblCP.Text = "Code Postal:";
            // 
            // lblEmbauche
            // 
            this.lblEmbauche.AutoSize = true;
            this.lblEmbauche.Location = new System.Drawing.Point(31, 227);
            this.lblEmbauche.Name = "lblEmbauche";
            this.lblEmbauche.Size = new System.Drawing.Size(72, 13);
            this.lblEmbauche.TabIndex = 6;
            this.lblEmbauche.Text = "Embauché le:";
            // 
            // lblCodeBD
            // 
            this.lblCodeBD.AutoSize = true;
            this.lblCodeBD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVisiteurs, "COL_MATRICULE", true));
            this.lblCodeBD.Location = new System.Drawing.Point(137, 62);
            this.lblCodeBD.Name = "lblCodeBD";
            this.lblCodeBD.Size = new System.Drawing.Size(0, 13);
            this.lblCodeBD.TabIndex = 7;
            // 
            // lblAdresseBD
            // 
            this.lblAdresseBD.AutoSize = true;
            this.lblAdresseBD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVisiteurs, "COL_ADRESSE", true));
            this.lblAdresseBD.Location = new System.Drawing.Point(137, 101);
            this.lblAdresseBD.Name = "lblAdresseBD";
            this.lblAdresseBD.Size = new System.Drawing.Size(0, 13);
            this.lblAdresseBD.TabIndex = 8;
            // 
            // lblVilleBD
            // 
            this.lblVilleBD.AutoSize = true;
            this.lblVilleBD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVisiteurs, "COL_VILLE", true));
            this.lblVilleBD.Location = new System.Drawing.Point(137, 141);
            this.lblVilleBD.Name = "lblVilleBD";
            this.lblVilleBD.Size = new System.Drawing.Size(0, 13);
            this.lblVilleBD.TabIndex = 9;
            // 
            // lblCPBD
            // 
            this.lblCPBD.AutoSize = true;
            this.lblCPBD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVisiteurs, "COL_CP", true));
            this.lblCPBD.Location = new System.Drawing.Point(137, 185);
            this.lblCPBD.Name = "lblCPBD";
            this.lblCPBD.Size = new System.Drawing.Size(0, 13);
            this.lblCPBD.TabIndex = 10;
            // 
            // lblEmbaucheBD
            // 
            this.lblEmbaucheBD.AutoSize = true;
            this.lblEmbaucheBD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVisiteurs, "COL_DATEEMBAUCHE", true));
            this.lblEmbaucheBD.Location = new System.Drawing.Point(137, 227);
            this.lblEmbaucheBD.Name = "lblEmbaucheBD";
            this.lblEmbaucheBD.Size = new System.Drawing.Size(0, 13);
            this.lblEmbaucheBD.TabIndex = 11;
            // 
            // cBVisiteur
            // 
            this.cBVisiteur.DataSource = this.bsVisiteurs;
            this.cBVisiteur.DisplayMember = "COL_NOM";
            this.cBVisiteur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBVisiteur.FormattingEnabled = true;
            this.cBVisiteur.Location = new System.Drawing.Point(102, 17);
            this.cBVisiteur.Name = "cBVisiteur";
            this.cBVisiteur.Size = new System.Drawing.Size(245, 21);
            this.cBVisiteur.TabIndex = 12;
            this.cBVisiteur.ValueMember = "COL_MATRICULE";
            // 
            // lblAcces
            // 
            this.lblAcces.AutoSize = true;
            this.lblAcces.Location = new System.Drawing.Point(31, 270);
            this.lblAcces.Name = "lblAcces";
            this.lblAcces.Size = new System.Drawing.Size(84, 13);
            this.lblAcces.TabIndex = 13;
            this.lblAcces.Text = "Niveau d\'accès:";
            // 
            // lblAccesBD
            // 
            this.lblAccesBD.AutoSize = true;
            this.lblAccesBD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVisiteurs, "COL_NIVEAU_ACCES", true));
            this.lblAccesBD.Location = new System.Drawing.Point(137, 270);
            this.lblAccesBD.Name = "lblAccesBD";
            this.lblAccesBD.Size = new System.Drawing.Size(0, 13);
            this.lblAccesBD.TabIndex = 14;
            // 
            // Visiteurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 335);
            this.Controls.Add(this.lblAccesBD);
            this.Controls.Add(this.lblAcces);
            this.Controls.Add(this.cBVisiteur);
            this.Controls.Add(this.lblEmbaucheBD);
            this.Controls.Add(this.lblCPBD);
            this.Controls.Add(this.lblVilleBD);
            this.Controls.Add(this.lblAdresseBD);
            this.Controls.Add(this.lblCodeBD);
            this.Controls.Add(this.lblEmbauche);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblVisiteur);
            this.Name = "Visiteurs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visiteurs";
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVisiteur;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.Label lblEmbauche;
        private System.Windows.Forms.Label lblCodeBD;
        private System.Windows.Forms.Label lblAdresseBD;
        private System.Windows.Forms.Label lblVilleBD;
        private System.Windows.Forms.Label lblCPBD;
        private System.Windows.Forms.Label lblEmbaucheBD;
        private System.Windows.Forms.ComboBox cBVisiteur;
        private System.Windows.Forms.Label lblAcces;
        private System.Windows.Forms.Label lblAccesBD;
        private System.Windows.Forms.BindingSource bsVisiteurs;

    }
}