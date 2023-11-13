
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
        public Consulta(string _connection) : base(_connection)// string de conexion 
        {
            _command = new SqlCommand();
            _command.CommandType = CommandType.Text;
        }

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
