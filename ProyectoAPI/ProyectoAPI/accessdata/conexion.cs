using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoAPI.accessdata
{
    public class conexion
    {
        // private MySqlConnection conexion1 = new MySqlConnection("");
        //private SqlConnection myConnection = new SqlConnection(cadenaConexion);
        string cadenaConexion = "Server=localhost;Database=bd_tarea; Uid=root;Pwd=root;"; //CAMBIAR
        /// 
        /// </summary>
        /// <param name="sentencia"></param>
        /// <param name="TipoComando"></param>
        /// <returns></returns>

        public bool EjecutarOperacion(string sentencia, CommandType TipoComando)
        {


            using (MySqlConnection con = new MySqlConnection(this.cadenaConexion))
            {

                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = sentencia;
                comando.CommandType = TipoComando;
                comando.Connection = con;
              int filasAfectadas=  comando.ExecuteNonQuery();
                return filasAfectadas > 0 ? true : false;
            }


        }
        public void EjecutarOperacion(string sentencia, List<MySqlParameter> ListaParametros, CommandType TipoComando)
        {


            using (MySqlConnection con = new MySqlConnection(this.cadenaConexion))
            {

                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = sentencia;
                comando.CommandType = TipoComando;
                comando.Connection = con;
                foreach (MySqlParameter parametro in ListaParametros)
                {
                    comando.Parameters.Add(parametro);
                }
                comando.ExecuteNonQuery();
            }


        }
        public DataTable EjecutarConsulta(string sentencia,CommandType TipoComando)
        {
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            using (MySqlConnection con = new MySqlConnection(cadenaConexion))
            {
                adaptador.SelectCommand = new MySqlCommand(sentencia, con);
                adaptador.SelectCommand.CommandType = TipoComando;

             
                try
                {
                    DataSet resultado = new DataSet();
                    adaptador.Fill(resultado);

                    return resultado.Tables[0];
                }
                catch (Exception)
                {
                    throw;
                }
            }

        }
        public DataTable EjecutarConsulta(string sentencia, List<MySqlParameter> ListaParametros, CommandType TipoComando)
        {
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            using (MySqlConnection con = new MySqlConnection(cadenaConexion))
            {
                adaptador.SelectCommand = new MySqlCommand(sentencia, con);
                adaptador.SelectCommand.CommandType = TipoComando;

                foreach (MySqlParameter parametro in ListaParametros)
                {
                    adaptador.SelectCommand.Parameters.Add(parametro);
                }
                try
                {
                    DataSet resultado = new DataSet();
                    adaptador.Fill(resultado);

                    return resultado.Tables[0];
                }
                catch (Exception)
                {
                    throw;
                }
            }

        }
    }
}
