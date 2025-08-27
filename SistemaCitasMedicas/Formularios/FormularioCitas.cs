using SistemaCitasMedicas.BLL;
namespace SistemaCitasMedicas.UI
{
    public partial class FormularioCitas : Form
    {
        public FormularioCitas()
        {
            InitializeComponent();
        }

        private void gb_formulariocita_Enter(object sender, EventArgs e)
        {

        }

        private void gb_cita_Enter(object sender, EventArgs e)
        {

        }

        private void lb_nombre_Click(object sender, EventArgs e)
        {

        }

        private void tb_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_apellido_Click(object sender, EventArgs e)
        {

        }

        private void tb_apellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_carnet_Click(object sender, EventArgs e)
        {

        }

        private void tb_carnet_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_numero_Click(object sender, EventArgs e)
        {

        }

        private void tb_numero_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_direccion_Click(object sender, EventArgs e)
        {

        }

        private void tb_direccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_especialidad_Click(object sender, EventArgs e)
        {

        }

        private void cb_especialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            string especialidad = cb_especialidad.SelectedItem.ToString();

            // Limpiar el ComboBox de horarios
            cb_hora.Items.Clear();

            // Cargar los horarios según la especialidad seleccionada
            if (HorariosNegocioBLL.horariosPorEspecialidad.ContainsKey(especialidad))
            {
                foreach (string hora in HorariosNegocioBLL.horariosPorEspecialidad[especialidad])
                {
                    cb_hora.Items.Add(hora);
                }
            }
        }

        private void lb_fecha_Click(object sender, EventArgs e)
        {

        }

        private void dt_fecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lb_hora_Click(object sender, EventArgs e)
        {

        }

        private void cb_hora_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lb_motivo_Click(object sender, EventArgs e)
        {

        }

        private void tb_motivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormularioCitas_Load(object sender, EventArgs e)
        {

        }
    }
}
