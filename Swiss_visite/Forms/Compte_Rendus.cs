using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Swiss_visite.Forms {
    public partial class Compte_Rendus : Form {
        private ConnectDBGSB ConnectBD;
        public Compte_Rendus(ConnectDBGSB connectBD) {
            InitializeComponent();
            this.ConnectBD = connectBD;
        }
        // ADD CODE HERE
    }
}
