
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.SQL
{
    public class Consulta : ConexionGN
    {
        private static SqlCommand _command;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Consulta"/>.
        /// </summary>
        /// <param name="_connection">Cadena de conexión a la base de datos.</param>
        public Consulta(string _connection) : base(_connection)// string de conexion 
        {
            _command = new SqlCommand();
            _command.CommandType = CommandType.Text;
        }

        /// <summary>
        /// Ejecuta una consulta SQL y devuelve el resultado como un DataTable.
        /// </summary>
        /// <param name="query">Consulta SQL.</param>
        /// <returns>DataTable con los resultados de la consulta.</returns>
        protected DataTable EjecutarQuery(string query)
        {
            try
            {
                Conectar();

                _command.Connection = _connection;
                _command.CommandText = query;

                var sqlReader = _command.ExecuteReader();

                var dataTable = new DataTable();

                dataTable.Load(sqlReader);

                sqlReader.Close();
                return dataTable;
            }
            catch
            {
                throw;
            }
            finally
            {
                Cerrar();
            }

        }

        /// <summary>
        /// Ejecuta una consulta SQL que no devuelve datos y devuelve el número de filas afectadas.
        /// </summary>
        /// <param name="query">Consulta SQL.</param>
        /// <returns>Número de filas afectadas.</returns>
        protected int? EjecutarNonQuery(string query)
        {
            try
            {
                Conectar();

                _command.Connection = _connection;
                _command.CommandText = query;
                var id = (int?)_command.ExecuteScalar();
                return id;
            }
            catch
            {
                throw;
            }
            finally
            {
                Cerrar();
            }

        }

        /// <summary>
        /// Ejecuta una consulta SQL con parámetros y devuelve el número de filas afectadas.
        /// </summary>
        /// <param name="query">Consulta SQL.</param>
        /// <param name="parameters">Parámetros a agregar a la consulta.</param>
        /// <returns>Número de filas afectadas.</returns>
        protected int? EjecutarNonQuery(string query, params SqlParameter[] parameters)
        {
            try
            {
                Conectar();

                _command.Connection = _connection;
                _command.CommandText = query;

                // Agregar los parámetros a la colección de parámetros
                if (parameters != null)
                {
                    _command.Parameters.AddRange(parameters);
                }

                var id = (int?)_command.ExecuteScalar();
                return id;
            }
            catch
            {
                throw;
            }
            finally
            {
                Cerrar();
            }
        }
    }
}
