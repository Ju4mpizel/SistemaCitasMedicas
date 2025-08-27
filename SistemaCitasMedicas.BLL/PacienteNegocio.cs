using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaCitasMedicas.DAL;
using SistemaCitasMedicas.ENT;
namespace SistemaCitasMedicas.BLL
{
    internal class PacienteNegocio
    {
        private readonly PacienteDAL _pacienteDAL = new PacienteDAL();

        public void AgregarPaciente(Paciente paciente)
        {
            if (string.IsNullOrWhiteSpace(paciente.Carnet))
                throw new Exception("El carnet no puede estar vacío.");
            if (string.IsNullOrWhiteSpace(paciente.Nombre))
                throw new Exception("El nombre no puede estar vacío.");
            if (string.IsNullOrWhiteSpace(paciente.Apellido))
                throw new Exception("El apellido no puede estar vacío.");

            _pacienteDAL.AgregarPaciente(paciente);
        }

        public List<Paciente> ListarPacientes()
        {
            return _pacienteDAL.ObtenerPacientes();
        }
    }
}
