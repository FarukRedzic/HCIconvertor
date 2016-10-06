using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCI_P {
    public partial class frmMatrica : Form {
        string ispisMatrica = string.Empty;
        public frmMatrica(string ispisMatrica) {
            InitializeComponent();
            this.ispisMatrica = ispisMatrica;
        }

        private void frmMatrica_Load(object sender, EventArgs e) {
            txtMatrica.Text = ispisMatrica;
            txtMatrica.ReadOnly = true;
        }

        private void btnIzlaz_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
