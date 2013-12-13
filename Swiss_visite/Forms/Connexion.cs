using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.Objects;
using System.Data.Objects.DataClasses;



using System.Data.SqlClient;

namespace Swiss_visite
{
    public partial class Connexion : Form
    {
        private ConnectDBGSB ConnectBD;
        string chaineConnexion = ConfigurationManager.ConnectionStrings["ConnectDBGSB"].ConnectionString;

        public Connexion()
        {
            InitializeComponent();
            ConnectBD = new ConnectDBGSB(chaineConnexion);
            bsVisiteurs.DataSource = ConnectBD.COLLABORATEURs;
        }

        //Au chargement de l'appli
        private void Connexion_Load(object sender, EventArgs e)
        {

        }

        //Appui sur le bouton "Quitter"
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            bool quit = AskConfirmQuitAppli();
            if (quit == true)
            {
                Application.Exit();
            }
        }

        //Appui sur le bouton "Connexion"
        private void btnConnex_Click(object sender, EventArgs e)
        {
            //Contrôle de saisie de l'utilisateur et du mot de passe
            if (tbUser.Text == "" && tbPwd.Text == "")
            {
                MessageBox.Show("Veuillez saisir un nom d'utilisateur et un mot de passe");
            }
            else if (tbUser.Text == "")
            {
                MessageBox.Show("Veuillez saisir un nom d'utilisateur");
            }
            else if (tbPwd.Text == "")
            {
                MessageBox.Show("Veuillez saisir un mot de passe");
            }
            else
            {
                    // Nouvelle connection à la base
                    string user = tbUser.Text;
                    string pwd = tbPwd.Text;

                    //Requète LINQ vérif userName et mdp dans les tables collaborateurs et praticiens
                    var userQueryCol = from IDC in ConnectBD.COLLABORATEURs
                                       select IDC;
                    // Booléen de vérif de co
                    bool trouve = false;
                    foreach (COLLABORATEUR c in userQueryCol)
                    {
                        #region Reformatage de données char => string

                        // On stocke les données à conditionner dans des variables
                        // On reformate les données char avec des vides inutiles en string
                        // Reformatage de données user
                        string userTS = c.COL_MATRICULE.ToString();
                        string userTS2 = "";
                        int j = 0;
                        while (userTS[j] != ' ')
                        {
                            userTS2 = userTS2 + userTS[j];
                            j++;
                        }
                        // Reformatage de données pwd
                        string pwdTS = c.COL_MDP.ToString();
                        string pwdTS2 = "";
                        j = 0;
                        while (pwdTS[j] != ' ')
                        {
                            pwdTS2 = pwdTS2 + pwdTS[j];
                            j++;
                        }

                        // Reformatage de données nom
                        string nomTS = c.COL_NOM.ToString();
                        string nomTS2 = "";
                        j = 0;
                        while (nomTS[j] != ' ')
                        {
                            nomTS2 = nomTS2 + nomTS[j];
                            j++;
                        }

                        // Reformatage de données prenom
                        string prenomTS = c.COL_PRENOM.ToString();
                        string prenomTS2 = "";
                        j = 0;
                        while (prenomTS[j] != ' ')
                        {
                            prenomTS2 = prenomTS2 + prenomTS[j];
                            j++;
                        }

                        #endregion

                        if (userTS2 == user && pwdTS2 == pwd)
                        {
                            trouve = true;
                            // On conserve le nom et prénom de l'utilisateur pour les envoyer au form suivant
                            string userName = nomTS2 + " " + prenomTS2;
                            // On stocke le niveau d'acces dans une variable 
                            int accessLvl = Convert.ToInt32(c.COL_NIVEAU_ACCES);
                            // On envoie au form Accueil le nom d'utilisateur, la chaine de connexion, et le niveau d'acces
                            Forms.Accueil accueil = new Forms.Accueil(userName, ConnectBD, accessLvl);
                            // Ouverture d'un form accueil
                            accueil.Show();
                            // On cache ce form
                            this.Hide();
                            break;
                        }                       
                    }
                    // Pas de correspondance d'utilisateur/pwd
                    if (trouve == false)
                    {
                        MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.");
                        
                    }
            }
        }

        // A la sortie du formulaire
        private void Connexion_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Exit();
        }

        #region Confirmation quitter
        // Méthode de demande à l'utilisateur confirmation pour quitter,
        private bool AskConfirmQuitAppli()
        {
            // message confirmation quitter l'application
            if (MessageBox.Show("Quitter l'application ?",
                               "Message de confirmation",
                               MessageBoxButtons.YesNo) == DialogResult.No)
            {
                // non
                return false;
            };

            // oui, quitter
            return true;
        }
        #endregion
    }
}
