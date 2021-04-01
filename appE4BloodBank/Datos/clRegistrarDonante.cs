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
}
