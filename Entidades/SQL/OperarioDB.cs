using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Entidades.SQL
{
    public class OperarioDB : Consulta, IModificlable<Operario>
    {
        private string _connection;

        public OperarioDB(string connection) : base(connection)
        {
            _connection = connection;
        }

        public bool Agregar(Operario objeto)
        {
            try
            {
                // Insertar el nuevo operario en la tabla Operario
                var query1 = $"INSERT INTO Usuario (nombre, apellido, fechaNacimiento, dni,email, contrasenia) " +
                            $"VALUES ('{objeto.Nombre}', '{objeto.Apellido}', '{objeto.FechaNacimiento.ToString("yyyy-MM-dd")}', " +
                            $"'{objeto.Dni}', '{objeto.Email}', '{objeto.Password}');" +
                            $"SELECT CAST(scope_identity() AS int);";

                var usuarioid = EjecutarNonQuery(query1);
                var query2 = $"INSERT INTO Operario (idUsuario) VALUES ('{usuarioid}')";
                var operarioId = EjecutarNonQuery(query2);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Borrar(int id)
        {
            try
            {
                // Obtener el ID del usuario asociado al operario
                string query1 = $"SELECT idUsuario FROM Operario WHERE operarioId = {id}";
                int idUsuario;

                using (var connection = new SqlConnection(_connection))
                {
                    connection.Open();
                    using (var command = new SqlCommand(query1, connection))
                    {
                        idUsuario = Convert.ToInt32(command.ExecuteScalar());
                    }
                }

                // Eliminar el operario de la tabla Operario
                string query2 = $"DELETE FROM Operario WHERE operarioId = {id}";
                EjecutarNonQuery(query2);

                // Eliminar el usuario de la tabla Usuario
                return EliminarUsuario(idUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al borrar el operario");
            }
        }

        public bool Editar(Operario objeto)
        {
            throw new NotImplementedException();
        }

        public List<Operario> Traer()
        {
            var operario = new List<Operario>();
            //var dataTable = EjecutarQuery("SELECT * FROM Usuario");
            var dataTable = EjecutarQuery("SELECT * FROM Operario INNER JOIN Usuario ON Operario.idUsuario = Usuario.idUsuario");

            foreach (DataRow item in dataTable.Rows)
            {
                var nombre = item["nombre"].ToString();
                var apellido = item["apellido"].ToString();
                var fechaNacimientoStr = item["fechaNacimiento"].ToString();
                var dni = item["dni"].ToString();
                var email = item["email"].ToString();
                var password = item["contrasenia"].ToString();
                var operarioId = Convert.ToInt32(item["operarioId"]);
                var UsuarioId = Convert.ToInt32(item["idUsuario"]);

                DateTime fechaNacimiento;
                try
                {
                    if (DateTime.TryParse(fechaNacimientoStr, out fechaNacimiento))
                    {
                        operario.Add(new Operario(nombre, apellido, fechaNacimiento, dni, email, password, operarioId, UsuarioId));
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error al traer los usuario: {ex.Message}");
                }
            }
            return operario;
        }

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
