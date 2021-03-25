using appE4BloodBank.Datos;
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
    public partial class frmRegistrarDonante : Form
    {
        public frmRegistrarDonante()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            clRegistrarDonante objRegistrar = new clRegistrarDonante();

            objRegistrar.Nombre = txtNombre.Text;
            objRegistrar.Apellido = txtApellido.Text;
            objRegistrar.Documento = txtDocumento.Text;
            objRegistrar.Edad = txtEdad.Text;
            objRegistrar.Peso = txtEdad.Text;
            objRegistrar.Genero =//combo box
            objRegistrar.RH = txtRH.Text;
            objRegistrar.TipoSangre = txtTipoSangre.Text;
            




        }
    }
}
