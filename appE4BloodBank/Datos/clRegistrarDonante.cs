using appE4BoodBank.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appE4BloodBank.Datos
{
    class clRegistrarDonante
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Documento { get; set; }
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

            string consulta = "insert into donante(Nombre,Apellido,Documento,edad,FechaNacimiento,Peso,Genero,TipoSangre,RH,Telefono,Email)" +
                             "values('" + Nombre + "','" + Apellido + "','" + Documento + "','"+Edad+"','" + FechaNacimiento + "','" +
                             "" + Peso + "','" + Genero + "','" + TipoSangre + "','" + RH + "','" + Telefono + "','" + Email + ")";

            int registrar = objConexion.mtdConectado(consulta);

            return registrar;


        }
    }
}
