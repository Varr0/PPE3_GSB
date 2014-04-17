using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Swiss_visite.Forms {
    public partial class CompteRendus : Form {
        private ConnectDBGSB ConnectBD;
        public CompteRendus(ConnectDBGSB connectBD) {
            InitializeComponent();
            this.ConnectBD = connectBD;
            bsRapport.DataSource = ConnectBD.RAPPORT_VISITE;
            bsMotif.DataSource = connectBD.MOTIFs;
        }

        //TODO: faire fonctionner l'affichage des motifs.
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            //Add code to save data.
        }
    }
}
