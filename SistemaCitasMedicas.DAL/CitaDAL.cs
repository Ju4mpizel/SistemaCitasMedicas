using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using SistemaCitasMedicas.ENT;
namespace SistemaCitasMedicas.DAL
{
    public class CitaDAL
    {
        private readonly ConexionBD _cadenaconexion;

        public CitaDAL()
        {
            _cadenaconexion = new ConexionBD();
        }
        public void AgregarCita(Cita cita)
        {
            try
            {
                using (var  conexion = _cadenaconexion.ObtenerConexion())
                {
                    conexion.Open();
                    string consulta = "INSERT INTO Citas(fecha,hora,carnet_paciente,motivo, especialidad) VALUES (@fecha,@hora,@carnet_paciente,@motivo, @especialidad)";
                    using (var cmd = new MySqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@fecha", cita.Fecha);
                        cmd.Parameters.AddWithValue("@hora", cita.Hora);
                        cmd.Parameters.AddWithValue("@carnet_paciente", cita.CarnetPaciente);
                        cmd.Parameters.AddWithValue("@motivo", cita.Motivo ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@especialidad", cita.Especialidad);
                        cmd.ExecuteNonQuery();
                    }
                }

            }

            catch (MySqlException ex)
            {
                throw new Exception("Error en la base de datos al insertar la cita.", ex);

            }
            
        }
        public List<Cita> ObtenerCitas()
        {
            List<Cita> lista = new List<Cita>();
            try
            {
                using (var conexion = _cadenaconexion.ObtenerConexion())
                {
                    conexion.Open();

                    string query = "SELECT id_cita, fecha,hora, carnet_paciente, motivo, especialidad FROM Citas";
                    using (var cmd = new MySqlCommand(query, conexion))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Cita
                            {
                                IdCita = reader.GetInt32("id_cita"),
                                Fecha = reader.GetDateTime("fecha"),
                                Hora = reader.GetTimeSpan("hora"),
                                Especialidad = reader.GetString("especialidad"),
                                Motivo = reader.IsDBNull(reader.GetOrdinal("motivo")) ? null:  reader.GetString("motivo"),
                                CarnetPaciente = reader.GetString("carnet_paciente"),
                            });
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error en la base de datos al obtener las citas: " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al obtener las citas", ex);
            }
            return lista;
        }
    }
}
