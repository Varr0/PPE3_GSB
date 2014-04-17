using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Swiss_visite.Forms {
    public partial class Praticiens : Form {
        private ConnectDBGSB ConnectBD;
        public Praticiens(ConnectDBGSB connectBD) {
            InitializeComponent();
            this.ConnectBD = connectBD;
            bsPraticiens.DataSource = ConnectBD.PRATICIENs;
        }
        //TODO: Modifier la liste déroulante de sélection => mettre nom/prenom de chaque praticien ?
    }
}
