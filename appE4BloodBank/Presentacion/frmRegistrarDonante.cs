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
    public partial class frmRegistrarDonante : Form
    {
        public frmRegistrarDonante()
        {
            InitializeComponent();
        }
        clConexion conexion = new clConexion();

        private void button1_Click(object sender, EventArgs e)
        {

            clConexion.crearConexion();
            MessageBox.Show("conexion exitosa");
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            //genero una instancia la clase usuario



            clRegistrarDonante objRegistrar = new clRegistrarDonante();

            objRegistrar.Nombre = txtNombre.Text;
            objRegistrar.Apellido = txtApellido.Text;
            objRegistrar.Documento = txtDocumento.Text;
            objRegistrar.FechaNacimiento = txtFecha.Text;
            objRegistrar.Edad = txtEdad.Text;
            objRegistrar.Peso = txtEdad.Text;
            objRegistrar.Genero = cmbGenero.Text;
            objRegistrar.RH = txtRH.Text;
            objRegistrar.TipoSangre = txtTipoSangre.Text;

            int estado = clFunciones.insertarDatos(objRegistrar);
            if (estado > 0)
            {
                MessageBox.Show("Datos insertados correctamente");
                Limpiar();
            }
            else
            {
                MessageBox.Show("hubo un error, revisar datos");
            }
        }

      
            // creo un metodo para limpiar los campos
        private void Limpiar()
        {
            txtNombre.Text = " ";
            txtApellido.Text="" ;
            txtDocumento.Text = "";
            txtEdad.Text = "";
            txtPeso.Text = "";
            txtTipoSangre.Text="";
            txtRH.Text = "";
            txtTelefono.Text = " ";
            cmbGenero.Text = " ";
            txtFecha.Text = "";
            txtNombre.Focus();



        }






    }

}

