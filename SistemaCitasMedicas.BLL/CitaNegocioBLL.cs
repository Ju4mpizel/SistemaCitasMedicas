using SistemaCitasMedicas.DAL;
using SistemaCitasMedicas.ENT;

namespace SistemaCitasMedicas.BLL
{
    public class CitaNegocioBLL
    {
        private readonly CitaDAL _citaDAL = new CitaDAL();

        public void AgregarCita(Cita cita)
        {
            if (cita.Fecha == default(DateTime))
                throw new Exception("La fecha no puede estar vacía.");
            if (string.IsNullOrWhiteSpace(cita.Hora))
                throw new Exception("La hora no puede estar vacía.");
            if (string.IsNullOrWhiteSpace(cita.Especialidad))
                throw new Exception("La especialidad no puede estar vacía.");

            _citaDAL.AgregarCita(cita);
        }

        public List<Cita> ListarCitas()
        {
            return _citaDAL.ObtenerCitas();
        }
    }
}
