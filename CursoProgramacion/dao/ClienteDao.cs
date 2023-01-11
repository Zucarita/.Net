using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoProgramacion.dao
{
    internal class ClienteDao
    {
        public void Conectar()
        {
            string servidor = "localhost";
            string usuario = "root";
            string password = "";
            string baseDeDatos = "clientes";

            string cadenaConexion = "Database=" + baseDeDatos + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + "";


            MySqlConnection conexionDb = new MySqlConnection(cadenaConexion);
            conexionDb.Open();
            

            string consulta = "SELECT * FROM `clientes`";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection= conexionDb;
            MySqlDataReader lectura= comando.ExecuteReader();

            string resultado = "";
            while(lectura.Read())
            {
                resultado += lectura.GetString(0);
            }

            string breackpoint = resultado;
           
        }
    }
}
