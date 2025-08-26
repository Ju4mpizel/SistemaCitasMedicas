using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCitasMedicas.BLL
{
    public class HorariosNegocioBLL
    {
        public static Dictionary<string, List<string>> horariosPorEspecialidad =
        new Dictionary<string, List<string>>()
{
        { "Medicina General", new List<string> { "08:00", "08:30", "09:00", "09:30", "10:00", "10:30" } },
        { "Emergencias", new List<string> { "00:00", "06:00", "12:00", "18:00" } }, // guardias
        { "Traumatologia", new List<string> { "09:00", "09:30", "10:00", "10:30" } },
        { "Pediatria", new List<string> { "14:00", "14:30", "15:00", "15:30" } },
        { "Gastroenterologia", new List<string> { "11:00", "11:30", "12:00" } },
        { "Ginecología y Obstetricia", new List<string> { "08:00", "08:30", "09:00", "09:30" } },
        { "Cardiología", new List<string> { "10:00", "10:30", "11:00", "11:30" } },
        { "Dermatología", new List<string> { "16:00", "16:30", "17:00" } },
        { "Oftalmología", new List<string> { "15:00", "15:30", "16:00" } },
        { "Otorrinolaringología", new List<string> { "09:00", "09:30", "10:00" } },
        { "Neurología", new List<string> { "13:00", "13:30", "14:00" } },
        { "Urología", new List<string> { "11:00", "11:30", "12:00" } },
        { "Alergología", new List<string> { "10:00", "10:30", "11:00" } },
        { "Medicina Interna", new List<string> { "08:00", "08:30", "09:00", "09:30" } },
        { "Reumatología", new List<string> { "15:00", "15:30", "16:00" } },
        { "Neumología", new List<string> { "14:00", "14:30", "15:00" } },
        { "Endocrinología", new List<string> { "10:00", "10:30", "11:00" } },
        { "Psiquiatría", new List<string> { "16:00", "16:30", "17:00" } },
        { "Psicología", new List<string> { "09:00", "09:30", "10:00", "10:30", "11:00" } },
        { "Oncología", new List<string> { "13:00", "13:30", "14:00" } },
        { "Nutrición", new List<string> { "12:00", "12:30", "13:00" } },
        { "Fisioterapia", new List<string> { "08:00", "08:30", "09:00", "09:30", "10:00" } },
        { "Odontología", new List<string> { "15:00", "15:30", "16:00", "16:30" } }
        };
    }
}
