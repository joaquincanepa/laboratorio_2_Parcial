﻿
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
    internal class SupervisorDB : Consulta, IModificlable<Supervisor>
    {
        private string _connection;
        public SupervisorDB(string connection) : base(connection)
        {
            _connection = connection;
        }
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
                return true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error al agregar el Supervisor: {ex.Message}");
                return false;
            }
        }

        public bool Borrar(int id)
        {

            try
            {
                Conexion.BorrarSupervisor(id);
                // Obtener el ID del usuario asociado al médico
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

                // Eliminar el médico de la tabla Supervisor
                string query2 = $"DELETE FROM Supervisor WHERE supervisorId = {id}";
                EjecutarNonQuery(query2);

                // Eliminar el usuario de la tabla Usuario
                string query3 = $"DELETE FROM Usuario WHERE idUsuario = {idUsuario}";
                EjecutarNonQuery(query3);

                return true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error al borrar el médico: {ex.Message}");
                return false;
            }
        }

        public bool Editar(Supervisor objeto)
        {
            throw new NotImplementedException();
        }

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
                if (DateTime.TryParse(fechaNacimientoStr, out fechaNacimiento))
                {
                    supervisor.Add(new Supervisor(nombre, apellido, fechaNacimiento, dni, email, password, supervisorId, UsuarioId));
                }
                else
                {
                    //MessageBox.Show("Error en traer los pacientes");
                }
            }

            return supervisor;
        }

        public List<Supervisor> Traer(int id)
        {
            throw new NotImplementedException();
        }
    }
}