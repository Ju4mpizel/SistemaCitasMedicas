using SistemaCitasMedicas.BLL;
using SistemaCitasMedicas.ENT;
namespace SistemaCitasMedicas.UI
{
    public partial class FormularioCitas : Form
    {
        private readonly PacienteNegocioBLL _pacienteBLL = new PacienteNegocioBLL();
        private readonly CitaNegocioBLL _citaBLL = new CitaNegocioBLL();
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
            if (cb_especialidad.SelectedItem == null)
                return;
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
            cb_especialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_hora.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_carnet.Text) ||
            string.IsNullOrWhiteSpace(tb_nombre.Text) ||
            string.IsNullOrWhiteSpace(tb_apellido.Text) ||
            string.IsNullOrWhiteSpace(cb_hora.Text) ||
            cb_especialidad.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios: Nombre, Apellido, Carnet, Hora y Especialidad.",
                                "Campos incompletos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return; // Detiene la ejecución si hay campos vacíos
            }
            // Guardado de datos en las clases
            Paciente pacienteNuevo = new Paciente
            {
                Carnet = tb_carnet.Text,
                Nombre = tb_nombre.Text,
                Apellido = tb_apellido.Text,
                Telefono = tb_numero.Text,
                Direccion = tb_direccion.Text
            };

            Cita citaNueva = new Cita
            {
                Fecha = dt_fecha.Value,
                Hora = cb_hora.Text,
                CarnetPaciente = tb_carnet.Text,
                Motivo = tb_motivo.Text,
                Especialidad = cb_especialidad.SelectedItem?.ToString()
            };

            // Funciones que añaden al paciente y a la cita a la BD
            _pacienteBLL.AgregarPaciente(pacienteNuevo);
            _citaBLL.AgregarCita(citaNueva);

            // ⚡ Crear botón dinámico en el FlowLayoutPanel
            Button btnCita = new Button();
            btnCita.Text = $"{pacienteNuevo.Carnet}";
            btnCita.Tag = new { Cita = citaNueva, Paciente = pacienteNuevo }; // Guarda los datos de referencia
            btnCita.Width = 160;
            btnCita.Height = 40;
            btnCita.Margin = new Padding(5);

            // Evento click del botón -> mostrar detalles
            btnCita.Click += (s, ev) =>
            {
                var data = (dynamic)((Button)s).Tag;
                Cita cita = data.Cita;
                Paciente paciente = data.Paciente;

                MessageBox.Show(
                    $"📋 Detalles de la cita:\n\n" +
                    $"Paciente: {paciente.Nombre} {paciente.Apellido}\n" +
                    $"Carnet: {paciente.Carnet}\n" +
                    $"Teléfono: {paciente.Telefono}\n" +
                    $"Dirección: {paciente.Direccion}\n\n" +
                    $"Especialidad: {cita.Especialidad}\n" +
                    $"Motivo: {cita.Motivo}\n" +
                    $"Fecha: {cita.Fecha:dd/MM/yyyy}\n" +
                    $"Hora: {cita.Hora}",
                    "Información de la Cita"
                );
            };

            // Agregar botón al FlowLayoutPanel
            flp_citas.Controls.Add(btnCita);

            flp_citas.FlowDirection = FlowDirection.TopDown;
            flp_citas.WrapContents = false;
            flp_citas.AutoScroll = true;
            flp_citas.AutoSize = false;

            // Mensaje de confirmación
            MessageBox.Show("Cita añadida con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar campos
            tb_carnet.Clear();
            tb_nombre.Clear();
            tb_apellido.Clear();
            tb_numero.Clear();
            tb_direccion.Clear();
            tb_motivo.Clear();

            cb_hora.SelectedIndex = 0; // vuelve al "Seleccione una hora..."
            cb_especialidad.SelectedIndex = -1; // deja vacío

            dt_fecha.Value = DateTime.Now; // reinicia la fecha a hoy
        }

    }
}

