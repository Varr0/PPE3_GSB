using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Swiss_visite.Forms
{
    public partial class Accueil : Form
    {
        int AccessLvl = 0;
        private ConnectDBGSB ConnectBD;
        public Accueil(string userName, ConnectDBGSB connectBD, int accessLvl)
        {
            InitializeComponent();   
            this.Text = "Bienvenue " + userName;
            this.ConnectBD = connectBD;
            this.AccessLvl = accessLvl;
        }
        // Au chargement de la page
        private void Accueil_Load(object sender, EventArgs e)
        {
            if (AccessLvl == 2)
            {
                // Pas d'accès aux médicaments ni aux praticiens
                btnMédics.Visible = false;
                btnPraticiens.Visible = false;
            }
        }
        // A la sortie du formulaire
        private void Accueil_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Exit();
        }
        // Clic sur le bouton "quitter"
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            bool quit = AskConfirmQuitAppli();
            if (quit == true)
            {
                ConnectBD.Dispose();
                Application.Exit();
            }
        }
        // Clic sur le bouton Deconnexion
        private void btnDeco_Click(object sender, EventArgs e)
        {
            bool deco = AskConfirmDecoAppli();
            if (deco == true)
            {
                Connexion newFormCon = new Connexion();
                ConnectBD.Dispose();
                this.Close();
                newFormCon.Show();
            }
        }

        #region Confirmation quitter
        // Méthode de confirmation user pour quitter
        private bool AskConfirmQuitAppli()
        {
            // Message confirmation quit application
            if (MessageBox.Show("Quitter l'application ?",
                               "Message de confirmation",
                               MessageBoxButtons.YesNo) == DialogResult.No)
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
            if (MessageBox.Show("Voulez-vous vraiment vous déconnecter ?",
                               "Message de confirmation",
                               MessageBoxButtons.YesNo) == DialogResult.No)
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
