using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Swiss_visite.Forms {
    public partial class Error : Form {
        public Error() {
            InitializeComponent();
        }
        private void btnQuit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        // A la sortie du formulaire
        private void Error_Closing(object sender)
        {
            Application.Exit();
        }
    }
}
