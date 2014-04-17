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
            this.lblNom = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.lblEmbauche = new System.Windows.Forms.Label();
            this.lblNomBD = new System.Windows.Forms.Label();
            this.bsVisiteurs = new System.Windows.Forms.BindingSource(this.components);
            this.gSB_Collaborateur = new Swiss_visite.Datasets.GSB_Collaborateur();
            this.lblAdresseBD = new System.Windows.Forms.Label();
            this.lblVilleBD = new System.Windows.Forms.Label();
            this.lblCPBD = new System.Windows.Forms.Label();
            this.lblEmbaucheBD = new System.Windows.Forms.Label();
            this.cBVisiteur = new System.Windows.Forms.ComboBox();
            this.lblAcces = new System.Windows.Forms.Label();
            this.lblAccesBD = new System.Windows.Forms.Label();
            this.cOLLABORATEURTableAdapter = new Swiss_visite.Datasets.GSB_CollaborateurTableAdapters.COLLABORATEURTableAdapter();
            this.tableAdapterManager = new Swiss_visite.Datasets.GSB_CollaborateurTableAdapters.TableAdapterManager();
            this.lblPrenomBD = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSB_Collaborateur)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVisiteur
            // 
            this.lblVisiteur.AutoSize = true;
            this.lblVisiteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisiteur.Location = new System.Drawing.Point(31, 20);
            this.lblVisiteur.Name = "lblVisiteur";
            this.lblVisiteur.Size = new System.Drawing.Size(44, 13);
            this.lblVisiteur.TabIndex = 1;
            this.lblVisiteur.Text = "Visiteur:";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(31, 59);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(32, 13);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nom:";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(31, 130);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(48, 13);
            this.lblAdresse.TabIndex = 3;
            this.lblAdresse.Text = "Adresse:";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(31, 170);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(29, 13);
            this.lblVille.TabIndex = 4;
            this.lblVille.Text = "Ville:";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(31, 214);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(67, 13);
            this.lblCP.TabIndex = 5;
            this.lblCP.Text = "Code Postal:";
            // 
            // lblEmbauche
            // 
            this.lblEmbauche.AutoSize = true;
            this.lblEmbauche.Location = new System.Drawing.Point(31, 256);
            this.lblEmbauche.Name = "lblEmbauche";
            this.lblEmbauche.Size = new System.Drawing.Size(72, 13);
            this.lblEmbauche.TabIndex = 6;
            this.lblEmbauche.Text = "Embauché le:";
            // 
            // lblNomBD
            // 
            this.lblNomBD.AutoSize = true;
            this.lblNomBD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVisiteurs, "COL_NOM", true));
            this.lblNomBD.Location = new System.Drawing.Point(137, 59);
            this.lblNomBD.Name = "lblNomBD";
            this.lblNomBD.Size = new System.Drawing.Size(0, 13);
            this.lblNomBD.TabIndex = 7;
            // 
            // bsVisiteurs
            // 
            this.bsVisiteurs.DataMember = "COLLABORATEUR";
            this.bsVisiteurs.DataSource = this.gSB_Collaborateur;
            // 
            // gSB_Collaborateur
            // 
            this.gSB_Collaborateur.DataSetName = "GSB_Collaborateur";
            this.gSB_Collaborateur.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblAdresseBD
            // 
            this.lblAdresseBD.AutoSize = true;
            this.lblAdresseBD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVisiteurs, "COL_ADRESSE", true));
            this.lblAdresseBD.Location = new System.Drawing.Point(137, 130);
            this.lblAdresseBD.Name = "lblAdresseBD";
            this.lblAdresseBD.Size = new System.Drawing.Size(0, 13);
            this.lblAdresseBD.TabIndex = 8;
            // 
            // lblVilleBD
            // 
            this.lblVilleBD.AutoSize = true;
            this.lblVilleBD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVisiteurs, "COL_VILLE", true));
            this.lblVilleBD.Location = new System.Drawing.Point(137, 170);
            this.lblVilleBD.Name = "lblVilleBD";
            this.lblVilleBD.Size = new System.Drawing.Size(0, 13);
            this.lblVilleBD.TabIndex = 9;
            // 
            // lblCPBD
            // 
            this.lblCPBD.AutoSize = true;
            this.lblCPBD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVisiteurs, "COL_CP", true));
            this.lblCPBD.Location = new System.Drawing.Point(137, 214);
            this.lblCPBD.Name = "lblCPBD";
            this.lblCPBD.Size = new System.Drawing.Size(0, 13);
            this.lblCPBD.TabIndex = 10;
            // 
            // lblEmbaucheBD
            // 
            this.lblEmbaucheBD.AutoSize = true;
            this.lblEmbaucheBD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVisiteurs, "COL_DATEEMBAUCHE", true));
            this.lblEmbaucheBD.Location = new System.Drawing.Point(137, 256);
            this.lblEmbaucheBD.Name = "lblEmbaucheBD";
            this.lblEmbaucheBD.Size = new System.Drawing.Size(0, 13);
            this.lblEmbaucheBD.TabIndex = 11;
            // 
            // cBVisiteur
            // 
            this.cBVisiteur.DataSource = this.bsVisiteurs;
            this.cBVisiteur.DisplayMember = "COL_MATRICULE";
            this.cBVisiteur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBVisiteur.FormattingEnabled = true;
            this.cBVisiteur.Location = new System.Drawing.Point(102, 17);
            this.cBVisiteur.Name = "cBVisiteur";
            this.cBVisiteur.Size = new System.Drawing.Size(201, 21);
            this.cBVisiteur.TabIndex = 12;
            this.cBVisiteur.ValueMember = "COL_MATRICULE";
            // 
            // lblAcces
            // 
            this.lblAcces.AutoSize = true;
            this.lblAcces.Location = new System.Drawing.Point(31, 299);
            this.lblAcces.Name = "lblAcces";
            this.lblAcces.Size = new System.Drawing.Size(84, 13);
            this.lblAcces.TabIndex = 13;
            this.lblAcces.Text = "Niveau d\'accès:";
            // 
            // lblAccesBD
            // 
            this.lblAccesBD.AutoSize = true;
            this.lblAccesBD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVisiteurs, "COL_NIVEAU_ACCES", true));
            this.lblAccesBD.Location = new System.Drawing.Point(137, 299);
            this.lblAccesBD.Name = "lblAccesBD";
            this.lblAccesBD.Size = new System.Drawing.Size(0, 13);
            this.lblAccesBD.TabIndex = 14;
            // 
            // cOLLABORATEURTableAdapter
            // 
            this.cOLLABORATEURTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.COLLABORATEURTableAdapter = this.cOLLABORATEURTableAdapter;
            this.tableAdapterManager.UpdateOrder = Swiss_visite.Datasets.GSB_CollaborateurTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lblPrenomBD
            // 
            this.lblPrenomBD.AutoSize = true;
            this.lblPrenomBD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVisiteurs, "COL_PRENOM", true));
            this.lblPrenomBD.Location = new System.Drawing.Point(137, 94);
            this.lblPrenomBD.Name = "lblPrenomBD";
            this.lblPrenomBD.Size = new System.Drawing.Size(0, 13);
            this.lblPrenomBD.TabIndex = 16;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(31, 94);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(46, 13);
            this.lblPrenom.TabIndex = 15;
            this.lblPrenom.Text = "Prenom:";
            // 
            // Visiteurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 332);
            this.Controls.Add(this.lblPrenomBD);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblAccesBD);
            this.Controls.Add(this.lblAcces);
            this.Controls.Add(this.cBVisiteur);
            this.Controls.Add(this.lblEmbaucheBD);
            this.Controls.Add(this.lblCPBD);
            this.Controls.Add(this.lblVilleBD);
            this.Controls.Add(this.lblAdresseBD);
            this.Controls.Add(this.lblNomBD);
            this.Controls.Add(this.lblEmbauche);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblVisiteur);
            this.Name = "Visiteurs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visiteurs";
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSB_Collaborateur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVisiteur;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.Label lblEmbauche;
        private System.Windows.Forms.Label lblNomBD;
        private System.Windows.Forms.Label lblAdresseBD;
        private System.Windows.Forms.Label lblVilleBD;
        private System.Windows.Forms.Label lblCPBD;
        private System.Windows.Forms.Label lblEmbaucheBD;
        private System.Windows.Forms.ComboBox cBVisiteur;
        private System.Windows.Forms.Label lblAcces;
        private System.Windows.Forms.Label lblAccesBD;
        private Datasets.GSB_Collaborateur gSB_Collaborateur;
        private System.Windows.Forms.BindingSource bsVisiteurs;
        private Datasets.GSB_CollaborateurTableAdapters.COLLABORATEURTableAdapter cOLLABORATEURTableAdapter;
        private Datasets.GSB_CollaborateurTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lblPrenomBD;
        private System.Windows.Forms.Label lblPrenom;

    }
}