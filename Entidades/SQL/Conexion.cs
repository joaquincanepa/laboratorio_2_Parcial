using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Net;
using DateTime = System.DateTime;



namespace Entidades.SQL
{
    public static class Conexion
    {

        private static SqlConnection _connection;
        private static SqlCommand _command;
        private static string _connectionString;
        private static OperarioDB operarioDB;
        private static SupervisorDB supervisorDB;
        private static UsuarioDB usuarioDb;


        static Conexion()
        {
            
            _connectionString = "server=DESKTOP-QNA3LF7\\SQLEXPRESS; dataBase=BaseDeDatosFabrica; integrated security=true;";
            _connection = new SqlConnection(_connectionString);
            _command = _connection.CreateCommand();
            _command.CommandType = System.Data.CommandType.Text;
            operarioDB = new OperarioDB(_connectionString);
            supervisorDB = new SupervisorDB(_connectionString);
            usuarioDb = new UsuarioDB(_connectionString);

        }

        /// <summary>
        /// Lee y devuelve la lista de usuarios (Operarios y Supervisores) desde la base de datos.
        /// </summary>
        /// <returns>Lista de usuarios.</returns>
        public static List<Usuario> Leer()
        {
            List<Usuario> listUsuario = new List<Usuario>();
            try
            {
                listUsuario.AddRange(operarioDB.Traer());
                listUsuario.AddRange(supervisorDB.Traer());
                return listUsuario;
            }
            catch
            {
                throw;
            }
            finally
            {
                _connection.Close();
            }
        }

        /// <summary>
        /// Agrega un operario a la base de datos.
        /// </summary>
        /// <param name="objeto">Operario a agregar.</param>
        /// <returns>True si la operación fue exitosa, False en caso contrario.</returns>
        public static bool AgregarOperario(Operario objeto)
        {
            try
            {
                return operarioDB.Agregar(objeto);
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        /// <summary>
        /// Agrega un supervisor a la base de datos.
        /// </summary>
        /// <param name="objeto">Supervisor a agregar.</param>
        /// <returns>True si la operación fue exitosa, False en caso contrario.</returns>
        public static bool AgregarSupervisor(Supervisor objeto)
        {
            try
            {
                return supervisorDB.Agregar(objeto);
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        /// <summary>
        /// Borra un operario de la base de datos.
        /// </summary>
        /// <param name="operarioId">ID del operario a borrar.</param>
        /// <returns>True si la operación fue exitosa, False en caso contrario.</returns>
        public static bool BorrarOperario(int operarioId)
        {
            try
            {
                return operarioDB.Borrar(operarioId);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// Borra un supervisor de la base de datos.
        /// </summary>
        /// <param name="supervisorId">ID del supervisor a borrar.</param>
        /// <returns>True si la operación fue exitosa, False en caso contrario.</returns>
        public static bool BorrarSupervisor(int supervisorId)
        {
            try
            {
                return supervisorDB.Borrar(supervisorId);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// Edita los datos de un usuario en la base de datos.
        /// </summary>
        /// <param name="usuario">Usuario con los datos actualizados.</param>
        /// <returns>True si la operación fue exitosa, False en caso contrario.</returns>
        public static bool EditarUsuario(Usuario usuario)
        {
            try
            {
                return usuarioDb.Editar(usuario);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
