using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using MySqlConnector;
namespace SistemaCitasMedicas.DAL
{
    public class ConexionBD
    {
        private readonly string _cadenaconexion;//Variable para la cadena de conexión

        public ConexionBD()
        {
            //Leer la configuracion mediante appsettings.json
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
            _cadenaconexion = configuration.GetConnectionString("SistemaCitas"); //Colocar el nombre de nuestra base de datos
        }
        //enerConexion: Método para obtener una conexión a la base de datos
        public MySqlConnection ObtenerConexion()
        {
            //Retorna una nueva conexión a la base de datos
            return new MySqlConnection(_cadenaconexion);
        }
    }
}
