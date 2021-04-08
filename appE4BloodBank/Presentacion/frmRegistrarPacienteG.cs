using appE4BloodBank.Datos;
using appE4BoodBank.Datos;
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
    public partial class frmRegistrarPacienteG : Form
    {
        clRegistrarPacienteG Paciente = new clRegistrarPacienteG();
        string extension = "";


        public frmRegistrarPacienteG()
        {
            InitializeComponent();
        }

        clConexion conexion = new clConexion();

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombre.Text) && extension != "")
            {
                clRegistrarPacienteG  objRegistrar = new clRegistrarPacienteG();

                objRegistrar.Nombre = txtNombre.Text;
                objRegistrar.Apellido = txtApellido.Text;
                objRegistrar.Documento = txtDocumento.Text;
                objRegistrar.TipoDocumento = txtDocumento.Text;
                objRegistrar.FechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text);
                objRegistrar.TipoSangre = cmbTipoSangre.Text;
                objRegistrar.Telefono = txtTelefono.Text;
                objRegistrar.Email = txtEmail.Text;


                int Registro = 0;
                Registro = objRegistrar.mtdRegistrar();
                if (Registro > 0)
                {
                    MessageBox.Show("Registrado Correctamente");
                }

                else
                {
                    MessageBox.Show("Registro Incorrecto");
                }

            }
        }


    }
}