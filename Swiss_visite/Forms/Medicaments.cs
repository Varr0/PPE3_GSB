using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Swiss_visite.Forms {
    public partial class Medicaments : Form {
        private ConnectDBGSB ConnectBD;
        public Medicaments(ConnectDBGSB connectBD) {
            InitializeComponent();
            this.ConnectBD = connectBD;
            bsMedicaments.DataSource = ConnectBD.MEDICAMENTs;
        }
        //TODO: mettre en rapport le champ "Nouveau" de la BD avec la checkBoxNew pour affichage.
    }
}
