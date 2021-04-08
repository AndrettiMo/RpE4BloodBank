using appE4BoodBank.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appE4BloodBank.Datos
{
    class clRegistrarPacienteG
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Documento { get; set; }
        public string TipoDocumento { get; set; }

        public DateTime FechaNacimiento { get; set; }
        public string TipoSangre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }


        clConexion objConexion = new clConexion();

        public int mtdRegistrar()
        {
            string consulta = "insert into donante(Nombre,Apellido,Documento,TipoDocumento,FechaNacimiento,tipoSangre,Telefono,Email)" +
                                "values('" + Nombre + "','" + Apellido + "','" + Documento + "','" + TipoDocumento + "','" + FechaNacimiento + "','" +
                                "" + TipoSangre + "','" + Telefono + "','" + Email + ")";


            int registros = objConexion.mtdConectado(consulta);
            return registros;

            

        }

    }
}
