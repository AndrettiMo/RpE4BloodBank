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
        clRegistrarDonante donante = new clRegistrarDonante();

        /* private string idProducto = null;
         private bool Editar = false;*/
        string extension = "";
        public frmRegistrarDonante()
        {
            InitializeComponent();
        }

        clConexion conexion = new clConexion();





        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombre.Text) && extension != "")
            {
                clRegistrarDonante objRegistrar = new clRegistrarDonante();

                objRegistrar.Nombre = txtNombre.Text;
                objRegistrar.Apellido = txtApellido.Text;
                objRegistrar.Documento = int.Parse(txtDocumento.Text);
                objRegistrar.Edad = txtEdad.Text;
                objRegistrar.FechaNacimiento = DateTime.Parse(dtpFecha.Text);
                objRegistrar.Peso = txtPeso.Text;
                objRegistrar.Genero = cmbGenero.Text;
                objRegistrar.RH = txtRH.Text;
                objRegistrar.TipoSangre = txtTipoSangre.Text;
                objRegistrar.Telefono = txtTelefono.Text;
                objRegistrar.Email = txtEmail.Text;

                int Registro = 0;
                Registro = objRegistrar.mtdRegistrar();
                if (Registro > 0)
                {
                    MessageBox.Show("Datos insertados correctamente");
                }

                else
                {
                    MessageBox.Show("hubo un error, revisar datos");
                }














                /*
                if (Editar == false)
                {
                    try
                    {
                        donante.Insertar(txtNombre.Text, txtApellido.Text, txtDocumento.Text, txtEdad.Text, dtpFecha.Value, txtPeso.Text, cmbGenero.SelectedItem.ToString(), txtRH.Text, txtTipoSangre.Text, txtEmail.Text, txtTelefono.Text);
                        // parametros.Add(cboEstadoCiv.SelectedItem.ToString());//

                        MessageBox.Show("se inserto correctamente");
                        MostrarRegistros();
                        limpiarForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("no se pudo insertar los datos por: " + ex);
                    }
                }
                //EDITAR
                if (Editar == true)
                {

                    try
                    {
                        donante.Editar(txtNombre.Text, txtApellido.Text, txtDocumento.Text, txtEdad.Text, dtpFecha.Value, txtPeso.Text, cmbGenero.SelectedItem.ToString(), txtRH.Text, txtTipoSangre.Text, txtEmail.Text, txtTelefono.Text);
                        MessageBox.Show("se edito correctamente");
                        MostrarRegistros();
                        limpiarForm();
                        Editar = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("no se pudo editar los datos por: " + ex);
                    }
                }
            }

                 private void limpiarForm()
            {
                txtNombre.Clear();
                txtApellido.Text = "";
                txtDocumento.Clear();
                txtEdad.Clear();
                txtPeso.Clear();
            }

                //genero una instancia la clase usuario


                /*
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

                    */




            }
        }
        List<clRegistrarDonante> RegistrarDonante;
        private void frmRegistrarDonante_Load(object sender, EventArgs e)
        {
            mtdRecargarGrid();

        }

        private void mtdRecargarGrid()
        {
            clMostrar objDonante = new clMostrar();

            RegistrarDonante = objDonante.mtdListar();

            dgvRegistrarDonante.Rows.Clear();

            for (int i = 0; i < RegistrarDonante.Count; i++)
            {
                dgvRegistrarDonante.Rows.Add();
                dgvRegistrarDonante.Rows[i].Cells["Nombre"].Value = RegistrarDonante[i].Nombre;
                dgvRegistrarDonante.Rows[i].Cells["Apellido"].Value = RegistrarDonante[i].Apellido;
                dgvRegistrarDonante.Rows[i].Cells["Documento"].Value = RegistrarDonante[i].Documento;
                dgvRegistrarDonante.Rows[i].Cells["Edad"].Value = RegistrarDonante[i].Edad;
                dgvRegistrarDonante.Rows[i].Cells["FechaNacimiento"].Value = RegistrarDonante[i].FechaNacimiento;
                dgvRegistrarDonante.Rows[i].Cells["Peso"].Value = RegistrarDonante[i].Peso;
                dgvRegistrarDonante.Rows[i].Cells["Genero"].Value = RegistrarDonante[i].Genero;
                dgvRegistrarDonante.Rows[i].Cells["Rh"].Value = RegistrarDonante[i].RH;
                dgvRegistrarDonante.Rows[i].Cells["tipoSangre"].Value = RegistrarDonante[i].TipoSangre;
                dgvRegistrarDonante.Rows[i].Cells["Telefono"].Value = RegistrarDonante[i].Telefono;
                dgvRegistrarDonante.Rows[i].Cells["Email"].Value = RegistrarDonante[i].Email;
                //   dgvListarDonante.Rows[i].Cells["Ver"].Value = "Ver Detalles";//

            }
        }
    }

}