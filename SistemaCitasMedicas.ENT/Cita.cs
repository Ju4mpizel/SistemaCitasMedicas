using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCitasMedicas.ENT
{
    public class Cita
    {
        public int id_cita { get; set; }
        public string fecha { get; set; }
        public string hora { get; set; }
        public string carnet_paciente{ get; set; }
        public string motivo { get; set; }

    }
}
