using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCitasMedicas.ENT
{
    public class Cita
    {
        public int IdCita { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public string CarnetPaciente{ get; set; }
        public string Motivo { get; set; }
        public string Especialidad { get; set; }

    }
}
