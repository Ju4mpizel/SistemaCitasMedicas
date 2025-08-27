using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaCitasMedicas.ENT;

namespace SistemaCitasMedicas.DAL
{
    public class PacienteDAL
    {
        private readonly ConexionBD _conexion;

        public PacienteDAL()
        {
            _conexion = new ConexionBD();
        }

        public void AgregarPaciente(Paciente paciente)
        {
            try
            {
                using (var conexion = _conexion.ObtenerConexion())
                {
                    conexion.Open();

                    string query = "INSERT INTO Paciente (carnet, nombre, apellido, telefono, direccion) VALUES (@carnet, @nombre, @apellido, @telefono, @direccion)";
                    using (var cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@carnet", paciente.Carnet);
                        cmd.Parameters.AddWithValue("@nombre", paciente.Nombre);
                        cmd.Parameters.AddWithValue("@apellido", paciente.Apellido);
                        cmd.Parameters.AddWithValue("@telefono", paciente.Telefono ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@direccion", paciente.Direccion ?? (object)DBNull.Value);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error en la base de datos al insertar el movimiento: " + ex.Message, ex);

            }
            catch (Exception ex)
            {
                // Cualquier otra excepción
                throw new Exception("Ocurrió un error inesperado al insertar el paciente.", ex);
            }
        }

        public List<Paciente> ObtenerPacientes()
        {
            List<Paciente> lista = new List<Paciente>();
            try
            {
                using (var conexion = _conexion.ObtenerConexion())
                {
                    conexion.Open();

                    string query = "SELECT carnet, nombre, apellido, telefono, direccion FROM Paciente";
                    using (var cmd = new MySqlCommand(query, conexion))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Paciente
                            {
                                Carnet = reader.GetString("carnet"),
                                Nombre = reader.GetString("nombre"),
                                Apellido = reader.GetString("apellido"),
                                Telefono = reader.IsDBNull(reader.GetOrdinal("telefono")) ? null : reader.GetString("telefono"),
                                Direccion = reader.IsDBNull(reader.GetOrdinal("direccion")) ? null : reader.GetString("direccion")
                            });
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error en la base de datos al obtener los pacientes " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al obtener los pacientes", ex);
            }
            return lista;
        }
    }
}
