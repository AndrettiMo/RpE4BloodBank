using appE4BoodBank.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appE4BloodBank.Datos
{
    class clMostrar
    { 
        public List<clRegistrarDonante> mtdListar()
        {
            string consulta = "select * from donante";
            clConexion objConexion = new clConexion();
            DataTable tblDonante = new DataTable();
            tblDonante = objConexion.mtdDesconectado(consulta);

            List<clRegistrarDonante> RegistrarDonante = new List<clRegistrarDonante>();

            for (int i = 0; i < tblDonante.Rows.Count; i++)
            {
                clRegistrarDonante objMostrarDonante = new clRegistrarDonante();
                objMostrarDonante.Nombre = (tblDonante.Rows[i]["Nombre"].ToString());
                objMostrarDonante.Apellido = (tblDonante.Rows[i]["Apellido"].ToString());
                objMostrarDonante.Documento = int.Parse(tblDonante.Rows[i]["Documento"].ToString());
                objMostrarDonante.Edad = (tblDonante.Rows[i]["Edad"].ToString());
                objMostrarDonante.FechaNacimiento = DateTime.Parse(tblDonante.Rows[i]["fechaNacimiento"].ToString());
                objMostrarDonante.Peso = (tblDonante.Rows[i]["Peso"].ToString());
                objMostrarDonante.Genero = (tblDonante.Rows[i]["Genero"].ToString());
                objMostrarDonante.RH = (tblDonante.Rows[i]["Rh"].ToString());
                objMostrarDonante.TipoSangre = (tblDonante.Rows[i]["tipoSangre"].ToString());
                objMostrarDonante.Telefono = (tblDonante.Rows[i]["Telefono"].ToString());
                objMostrarDonante.Email = (tblDonante.Rows[i]["Email"].ToString());

                RegistrarDonante.Add(objMostrarDonante);
            }
            return RegistrarDonante;
        }
    }
}
