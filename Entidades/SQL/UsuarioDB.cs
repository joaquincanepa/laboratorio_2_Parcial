
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Wpf.Toolkit;

namespace Entidades.SQL
{
    internal class UsuarioDB : Consulta, IModificlable<Usuario>
    {
        private SqlConnection conexion;
        public UsuarioDB(string _connection) : base(_connection)
        {
            conexion = new SqlConnection(_connection);
        }

        public bool Agregar(Usuario objeto)
        {
            throw new NotImplementedException();
        }

        public bool Borrar(int id)
        {
            throw new NotImplementedException();
        }

        public bool Editar(Usuario objeto)
        {
            try
            {
                string query = "UPDATE Usuario SET nombre = @nombre, apellido=@apellido, email= @email," +
                    "fechaNacimiento=@fechaNacimiento, dni=@dni  Where idUsuario = @idUsuario";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {

                    command.Parameters.AddWithValue("@nombre", objeto.Nombre);
                    command.Parameters.AddWithValue("@apellido", objeto.Apellido);
                    command.Parameters.AddWithValue("@email", objeto.Email);
                    command.Parameters.AddWithValue("@idUsuario", objeto.IdUsuario);
                    command.Parameters.AddWithValue("@fechaNacimiento", objeto.FechaNacimiento);
                    command.Parameters.AddWithValue("@dni", objeto.Dni);
                    conexion.Open();
                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error al agregar el turno: {ex.Message}");
                return false;
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<Usuario> Traer()
        {
            List<Usuario> usuarios = new List<Usuario>();

            try
            {
                Conectar();

                string query = "SELECT * FROM Usuario";
                DataTable dataTable = EjecutarQuery(query);

                foreach (DataRow row in dataTable.Rows)
                {
                    int idUsuario = Convert.ToInt32(row["IdUsuario"]);
                    string nombre = row["Nombre"].ToString();
                    string apellido = row["Apellido"].ToString();
                    DateTime fechaNacimiento = Convert.ToDateTime(row["FechaNacimiento"]);
                    string dni = row["DNI"].ToString();
                    string email = row["Email"].ToString();
                    string password = row["Password"].ToString();

                    // Aquí debes determinar el tipo de usuario según la estructura de tu base de datos
                    // y crear la instancia correspondiente de la subclase de Usuario
                    Usuario usuario = null;
                    if (row["TipoUsuario"].ToString() == "Operario")
                    {
                        usuario = new Operario(nombre, apellido, fechaNacimiento, dni, email, password,idUsuario);
                    }
                    else if (row["TipoUsuario"].ToString() == "Supervisor")
                    {       
                        usuario = new Supervisor(nombre, apellido, fechaNacimiento, dni, email, password,idUsuario);
                    }
                    if (usuario != null)
                    {
                        usuarios.Add(usuario);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción si ocurrió algún error en la consulta o conexión
                Console.WriteLine("Error al obtener los usuarios: " + ex.Message);
            }
            finally
            {
                Cerrar();
            }

            return usuarios;
        }

        public List<Usuario> Traer(int id)
        {
            throw new NotImplementedException();
        }
    }
}
