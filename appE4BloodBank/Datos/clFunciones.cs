using appE4BoodBank.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appE4BloodBank.Datos
{
    class clFunciones
    {
        // crear un metodo para insertar la informacion a la bd
        public static int insertarDatos (clRegistrarDonante add )
        {
            int estado = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("insert into donante(Nombre,Apellido,Documento,Edad,FechaNacimiento,Peso,Genero,TipoSangre,Rh,Telefono,Email)values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",
                add.Nombre, add.Apellido, add.Documento, add.Edad, add.FechaNacimiento, add.Peso, add.Genero, add.TipoSangre, add.RH, add.Telefono, add.Email), clConexion.crearConexion());

            estado = comando.ExecuteNonQuery();
            return estado;
                          /*   "values('" + Nombre + "','" + Apellido + "','" + Documento + "','" + Edad + "','" + FechaNacimiento + "','" +
                             "" + Peso + "','" + Genero + "','" + TipoSangre + "','" + RH + "','" + Telefono + "','" + Email + ")";);*/
        }
    }
}
