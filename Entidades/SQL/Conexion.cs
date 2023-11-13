using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Net;
using DateTime = System.DateTime;

using Xceed.Wpf.Toolkit;

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

       

        public static bool AgregarOperario(Operario objeto)
        {
            try
            {
                return operarioDB.Agregar(objeto);
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error al agregar el operario: {ex.Message}");
                //MessageBox.Show($"");
                return false;
            }
        }

        public static bool AgregarSupervisor(Supervisor objeto)
        {
            try
            {
                return supervisorDB.Agregar(objeto);
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error al agregar el paciente: {ex.Message}");
                return false;
            }
        }

        

        public static bool BorrarOperario(int operarioId)
        {
            try
            {
                return operarioDB.Borrar(operarioId);
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error al borrar el operario: {ex.Message}");
                return false;
            }
        }

        public static bool BorrarSupervisor(int supervisorId)
        {
            try
            {
                return supervisorDB.Borrar(supervisorId);
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error al borrar el paciente: {ex.Message}");
                return false;
            }
        }


        public static bool EditarUsuario(Usuario usuario)
        {
            try
            {
                return usuarioDb.Editar(usuario);
            }
            catch (Exception ex)
            {
               // MessageBox.Show($"Error al editar observaciones {ex.Message}");
                return false;
            }
        }
    }
}
