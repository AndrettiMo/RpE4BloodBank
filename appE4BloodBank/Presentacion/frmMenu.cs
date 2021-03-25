using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appE4BloodBank.Presentacion
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void donanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form regDonante = new frmRegistrarDonante();
            regDonante.Show();
        }
    }
}
