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
    public partial class Compte_Rendus : Form
    {
        public Compte_Rendus()
        {
            InitializeComponent();
        }


        // A la sortie du formulaire
        private void Compte_Rendus_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Exit();
        }
    }
}
