using appE4BoodBank.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace appE4BloodBank.Datos
{
    class clRegistrarDonante
    {

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int  Documento { get; set; }
        public string Edad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Peso { get; set; }
        public string Genero { get; set; }
        public string TipoSangre { get; set; }
        public string RH { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }



        clConexion objConexion = new clConexion();

        public int mtdRegistrar()
        {
            string consulta = "insert into donante(Nombre,Apellido,Documento,Edad,FechaNacimiento,Peso,Genero,tipoSangre,RH,Telefono,Email)" +
                                "values('" + Nombre + "','" + Apellido + "','" + Documento + "','" + Edad + "','" + FechaNacimiento + "','" +
                                "" + Peso + "','" + Genero + "','" + TipoSangre + "','" + RH + "','" + Telefono + "','" + Email + ")";


            int registros = objConexion.mtdConectado(consulta);
            return registros;

            DateTime fechaActual = DateTime.Now;
            string fecha = Convert.ToDateTime(fechaActual).ToString("yyyy-MM-dd,hh,mm,ss");

        }

        



        }



            /*
        public List<clAprendiz> mtdListar()
        {
            string consulta = "select * from aprendiz";
            clConexion objConexion = new clConexion();
            DataTable tblAprendiz = new DataTable();
            tblAprendiz = objConexion.mtdDesconectado(consulta);

            List<clAprendiz> listaAprendiz = new List<clAprendiz>();

            for (int i = 0; i < tblAprendiz.Rows.Count; i++)
            {
                clAprendiz objPasarAprendiz = new clAprendiz();
                objPasarAprendiz.idAprendiz = int.Parse(tblAprendiz.Rows[i]["idAprendiz"].ToString());
                objPasarAprendiz.documento = tblAprendiz.Rows[i]["documento"].ToString();
                objPasarAprendiz.nombres = tblAprendiz.Rows[i]["nombres"].ToString();
                objPasarAprendiz.apellidos = tblAprendiz.Rows[i]["apellidos"].ToString();
                objPasarAprendiz.fechaNacimiento = DateTime.Parse(tblAprendiz.Rows[i]["fechaNacimiento"].ToString());
                objPasarAprendiz.direccion = tblAprendiz.Rows[i]["direccion"].ToString();
                objPasarAprendiz.email = tblAprendiz.Rows[i]["email"].ToString();
                objPasarAprendiz.idprograma = int.Parse(tblAprendiz.Rows[i]["idPrograma"].ToString());

                listaAprendiz.Add(objPasarAprendiz);
            }

            return listaAprendiz;
            */












            /*  private clConexion conexion = new clConexion();
              MySqlDataReader leer;
              DataTable tabla = new DataTable();
              MySqlCommand comando = new MySqlCommand();





              public DataTable Mostrar ()
              {
                  comando.Connection = conexion.AbrirConexion();
                  comando.CommandText = "Mostrar datos registrados ";
                  comando.CommandType = CommandType.StoredProcedure;
                  leer = comando.ExecuteReader();
                  tabla.Load(leer);
                  conexion.CerrarConexion();
                  return tabla;
              }



              public void Insertar( string nombre, string apellido, string documento, string edad, DateTime fechaNacimiento, string peso,string genero, string Rh, string tipoSangre, string email, string telefono)
              {
                  comando.Connection = conexion.AbrirConexion();
                  comando.CommandText = "InsetarProductos";
                  comando.CommandType = CommandType.StoredProcedure;

                  comando.Parameters.AddWithValue("@nombre", nombre);
                  comando.Parameters.AddWithValue("@apellido", apellido);
                  comando.Parameters.AddWithValue("@documento", documento);
                  comando.Parameters.AddWithValue("@edad", edad);
                  comando.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
                  comando.Parameters.AddWithValue("@peso", peso);
                  comando.Parameters.AddWithValue("@genero", genero);
                  // parametros.Add(cboEstadoCiv.SelectedItem.ToString());// para un combo box en caso de que no funcione
                  comando.Parameters.AddWithValue("@Rh", Rh);
                  comando.Parameters.AddWithValue("@tipoSangre", tipoSangre);
                  comando.Parameters.AddWithValue("@email", email);
                  comando.Parameters.AddWithValue("@telefono", telefono);
                  comando.ExecuteNonQuery();
                  comando.Parameters.Clear();
                  conexion.CerrarConexion();
              }
              public void Editar(string nombre, string apellido, string documento, string edad, DateTime fechaNacimiento, string peso,string genero, string Rh, string tipoSangre, string email, string telefono)
              {
                  comando.Connection = conexion.AbrirConexion();
                  comando.CommandText = "EditarProductos";
                  comando.CommandType = CommandType.StoredProcedure;
                  comando.Parameters.AddWithValue("@nombre", nombre);
                  comando.Parameters.AddWithValue("@apellido", apellido);
                  comando.Parameters.AddWithValue("@documento", documento);
                  comando.Parameters.AddWithValue("@edad", edad);
                  comando.Parameters.AddWithValue("@peso", peso);
                  comando.Parameters.AddWithValue("@genero", genero);
                  comando.Parameters.AddWithValue("@Rh", Rh);
                  comando.Parameters.AddWithValue("@tipoSangre", tipoSangre);
                  comando.Parameters.AddWithValue("@email", email);
                  comando.Parameters.AddWithValue("@telefono", telefono);
                  comando.ExecuteNonQuery();
                  comando.Parameters.Clear();
                  conexion.CerrarConexion();
              }
              public void Eliminar(string nombre)
              {
                  comando.Connection = conexion.AbrirConexion();
                  comando.CommandText = "EliminarProducto";
                  comando.CommandType = CommandType.StoredProcedure;
                  comando.Parameters.AddWithValue("@nombre", nombre);
                  comando.ExecuteNonQuery();
                  comando.Parameters.Clear();
                  conexion.CerrarConexion();
              }
          }*/


            /*  public string Nombre { get; set; }
              public string Apellido { get; set; }
              public string Documento { get; set; }
              public string Edad { get; set; }
              public  string  FechaNacimiento { get; set; }
              public string Peso { get; set; }
              public string Genero { get; set; }
              public string TipoSangre { get; set; }
              public string RH { get; set; }
              public string Telefono { get; set; }
              public string Email { get; set; }

            /*  public clRegistrarDonante (string nombre, string apellido, string documento, string edad, string fechaNacimiento, string peso, string genero, string tipoSangre, string rH, string telefono, string email)
              {
                  Nombre = nombre;
                  Apellido = apellido;
                  Documento = documento;
                  Edad = edad;
                  FechaNacimiento = fechaNacimiento;
                  Peso = peso;
                  Genero = genero;
                  TipoSangre = tipoSangre;
                  RH = rH;
                  Telefono = telefono;
                  Email = email;
              }
              */








            /*

                    clConexion objConexion = new clConexion();


                    public int mtdRegistrar()
                    {

                        string consulta = "insert into donante(Nombre,Apellido,Documento,edad,FechaNacimiento,Peso,Genero,TipoSangre,RH,Telefono,Email)" +
                                         "values('" + Nombre + "','" + Apellido + "','" + Documento + "','"+Edad+"','" + FechaNacimiento + "','" +
                                         "" + Peso + "','" + Genero + "','" + TipoSangre + "','" + RH + "','" + Telefono + "','" + Email + ")";

                        int registrar = objConexion.mtdConectado(consulta);

                        return registrar;*/



        }
    
