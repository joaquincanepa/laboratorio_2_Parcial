
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades.SQL
{
    internal class SupervisorDB : Consulta, IModificlable<Supervisor>
    {
        private string _connection;
        public SupervisorDB(string connection) : base(connection)
        {
            _connection = connection;
        }


        /// <summary>
        /// Agrega un nuevo supervisor a la base de datos.
        /// </summary>
        /// <param name="objeto">Supervisor a agregar.</param>
        /// <returns>True si la operación fue exitosa, False en caso contrario.</returns>
        /// <exception cref="Exception">Se produce cuando ocurre un error al agregar el supervisor.</exception>
        public bool Agregar(Supervisor objeto)
        {
            try
            {
                // Insertar el nuevo Supervisor en la tabla Usuario
                var query1 = $"INSERT INTO Usuario (nombre, apellido, fechaNacimiento, dni,email, contrasenia) " +
                            $"VALUES ('{objeto.Nombre}', '{objeto.Apellido}', '{objeto.FechaNacimiento.ToString("yyyy-MM-dd")}', " +
                            $"'{objeto.Dni}','{objeto.Email}', '{objeto.Password}');" +
                            $"SELECT CAST(scope_identity() AS int);";

                var usuarioid = EjecutarNonQuery(query1);

                var query2 = $"INSERT INTO Supervisor (idUsuario) VALUES ('{usuarioid}')";
                var operarioId = EjecutarNonQuery(query2);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al agregar el Supervisor: {ex.Message}");
            }
        }

        /// <summary>
        /// Borra un supervisor de la base de datos.
        /// </summary>
        /// <param name="id">ID del supervisor a borrar.</param>
        /// <returns>True si la operación fue exitosa, False en caso contrario.</returns>
        /// <exception cref="Exception">Se produce cuando ocurre un error al borrar el supervisor.</exception>
        public bool Borrar(int id)
        {

            try
            {
                // Obtener el ID del usuario asociado al Supervisor
                string query1 = $"SELECT idUsuario FROM Supervisor WHERE supervisorId = {id}";
                int idUsuario;

                using (var connection = new SqlConnection(_connection))
                {
                    connection.Open();
                    using (var command = new SqlCommand(query1, connection))
                    {
                        idUsuario = Convert.ToInt32(command.ExecuteScalar());
                    }
                }

                // Eliminar el Supervisor de la tabla Supervisor
                string query2 = $"DELETE FROM Supervisor WHERE supervisorId = {id}";
                EjecutarNonQuery(query2);
                // Eliminar el usuario de la tabla Usuario
                string query3 = $"DELETE FROM Usuario WHERE idUsuario = {idUsuario}";
                EjecutarNonQuery(query3);

                return EliminarUsuario(idUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al borrar el Supervisor: {ex.Message}");
            }
        }

        public bool Editar(Supervisor objeto)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Obtiene la lista de supervisores desde la base de datos.
        /// </summary>
        /// <returns>Lista de supervisores.</returns>
        /// <exception cref="Exception">Se produce cuando ocurre un error al obtener los supervisores.</exception>
        public List<Supervisor> Traer()
        {
            var supervisor = new List<Supervisor>();
            var dataTable = EjecutarQuery("SELECT * FROM Supervisor INNER JOIN Usuario ON Supervisor.idUsuario = Usuario.idUsuario");

            foreach (DataRow item in dataTable.Rows)
            {
                var nombre = item["nombre"].ToString();
                var apellido = item["apellido"].ToString();
                var fechaNacimientoStr = item["fechaNacimiento"].ToString();
                var dni = item["dni"].ToString();
                var email = item["email"].ToString();
                var password = item["contrasenia"].ToString();
                var supervisorId = Convert.ToInt32(item["supervisorId"]);
                var UsuarioId = Convert.ToInt32(item["idUsuario"]);
                DateTime fechaNacimiento;
                try
                {
                    if (DateTime.TryParse(fechaNacimientoStr, out fechaNacimiento))
                    {
                        supervisor.Add(new Supervisor(nombre, apellido, fechaNacimiento, dni, email, password, supervisorId, UsuarioId));
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error al traer los usuario: {ex.Message}");
                }
            }
            return supervisor;
        }


        /// <summary>
        /// Elimina un usuario de la base de datos.
        /// </summary>
        /// <param name="idUsuario">ID del usuario a eliminar.</param>
        /// <returns>True si la operación fue exitosa, False en caso contrario.</returns>
        /// <exception cref="Exception">Se produce cuando ocurre un error al eliminar el usuario.</exception>
        private bool EliminarUsuario(int idUsuario)
        {
            try
            {
                string query = $"DELETE FROM Usuario WHERE idUsuario = {idUsuario}";
                EjecutarNonQuery(query);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar el usuario: {ex.Message}");
            }
        }
    }
}
