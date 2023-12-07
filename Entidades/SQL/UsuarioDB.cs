
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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

        /// <summary>
        /// Edita los datos de un usuario en la base de datos.
        /// </summary>
        /// <param name="objeto">Usuario con los datos actualizados.</param>
        /// <returns>True si la operación fue exitosa, False en caso contrario.</returns>
        /// <exception cref="Exception">Se produce cuando ocurre un error al editar el usuario.</exception>
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
                throw new Exception($"Error al editar el Usuario: {ex.Message}");
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<Usuario> Traer()
        {
            throw new NotImplementedException();
        }
    }
}
