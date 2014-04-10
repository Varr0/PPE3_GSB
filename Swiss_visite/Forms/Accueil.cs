using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Swiss_visite.Forms {
    public partial class Accueil : Form {
        int AccessLvl = 0;
        private ConnectDBGSB ConnectBD;
        public Accueil(string userName, ConnectDBGSB connectBD, int accessLvl) {
            InitializeComponent();   
            this.Text = "Bienvenue " + userName;
            this.ConnectBD = connectBD;
            this.AccessLvl = accessLvl;
        }
        // Au chargement de la page
        private void Accueil_Load(object sender, EventArgs e) {
            if (AccessLvl == 2) {
                // Pas d'accès aux médicaments ni aux praticiens
                btnMédics.Visible = false;
                btnPraticiens.Visible = false;
            }
        }
        // A la sortie du formulaire
        private void Accueil_Closing(object sender) {
            ConnectBD.Dispose();
            Application.Exit();
        }
        // Clic sur le bouton "quitter"
        private void btnQuitter_Click(object sender, EventArgs e) {
            bool quit = AskConfirmQuitAppli();
            if (quit == true) {
                ConnectBD.Dispose();
                Application.Exit();
            }
        }
        // Clic sur le bouton Deconnexion
        private void btnDeco_Click(object sender, EventArgs e) {
            bool deco = AskConfirmDecoAppli();
            if (deco == true) {
                Connexion newFormCon = new Connexion();
                ConnectBD.Dispose();
                this.Close();
                newFormCon.Show();
            }
        }
        // Appui sur le bouton Compte-Rendus
        private void btnCompteRendu_Click(object sender, EventArgs e) {
            Forms.CompteRendus compteRendus = new Forms.CompteRendus(ConnectBD);
            compteRendus.Show();
        }
        // Appui sur le bouton Medicaments
        private void btnMédics_Click(object sender, EventArgs e) {
            Forms.Medicaments medicaments = new Forms.Medicaments(ConnectBD);
            medicaments.Show();
        }
        // Appui sur le bouton Praticiens
        private void btnPraticiens_Click(object sender, EventArgs e) {
            Forms.Praticiens praticiens = new Forms.Praticiens(ConnectBD);
            praticiens.Show();
        }
        // Appui sur le bouton Visiteurs
        private void btnVisiteurs_Click(object sender, EventArgs e) {
            Forms.Visiteurs visiteurs = new Forms.Visiteurs(ConnectBD);
            visiteurs.Show();
        }
        #region Confirmation quitter
        // Méthode de confirmation user pour quitter
        private bool AskConfirmQuitAppli()
        {
            // Message confirmation quit application
            if (MessageBox.Show("Quitter l'application ?", "Message de confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                // Non
                return false;
            };

            // Oui, quitter
            return true;
        }
        #endregion

        #region Confirmation Déco
        // Méthode de demande à l'utilisateur confirmation pour se déconnecter,
        private bool AskConfirmDecoAppli()
        {
            // message confirmation deconnexion application
            if (MessageBox.Show("Voulez-vous vraiment vous déconnecter ?", "Message de confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                // non
                return false;
            };

            // oui, déco
            return true;
        }
        #endregion
    }
}
