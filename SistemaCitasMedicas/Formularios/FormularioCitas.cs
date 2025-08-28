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
            CargarCitas();
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
            // Verifica si hay campos vacíos
            if (AlertaVacio())
            {
                // Marca los campos vacíos en rojo
                MarcarVacios();
                return;
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
            // Añade el botón a la lista
            CreacionBotonesLista(pacienteNuevo, citaNueva);
            // Mensaje de confirmación
            MessageBox.Show("Cita añadida con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarFormulario();
        }
        public void CreacionBotonesLista(Paciente pacienteNuevo, Cita citaNueva)
        {
            // ⚡ Crear botón dinámico en el FlowLayoutPanel
            Button btnCita = new Button();
            btnCita.Text = $"{citaNueva.IdCita} - {citaNueva.CarnetPaciente}";
            btnCita.Tag = new { Cita = citaNueva, Paciente = pacienteNuevo }; // Guarda los datos de referencia
            btnCita.Width = 220;
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
        }
        public bool AlertaVacio()
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
                return true;
            }
            return false;
        }
        public void LimpiarFormulario()
        {
            tb_carnet.Clear();
            tb_nombre.Clear();
            tb_apellido.Clear();
            tb_numero.Clear();
            tb_direccion.Clear();
            cb_especialidad.SelectedIndex = -1;
            dt_fecha.Value = DateTime.Now;
            cb_hora.SelectedIndex = -1;
            tb_motivo.Clear();
        }
        public void MarcarVacios()
        {
            bool camposValidos = true;
            if (string.IsNullOrWhiteSpace(tb_carnet.Text))
            {
                lb_carnet.ForeColor = Color.Red;
                camposValidos = false;
            }
            else
            {
                lb_carnet.ForeColor = Color.Black;
            }
            if (string.IsNullOrWhiteSpace(tb_nombre.Text))
            {
                lb_nombre.ForeColor = Color.Red;
                camposValidos = false;
            }
            else
            {
                lb_nombre.ForeColor = Color.Black;
            }
            if (string.IsNullOrWhiteSpace(tb_apellido.Text))
            {
                lb_apellido.ForeColor = Color.Red;
                camposValidos = false;
            }
            else
            {
                lb_apellido.ForeColor = Color.Black;
            }
            if (string.IsNullOrWhiteSpace(cb_hora.Text))
            {
                lb_hora.ForeColor = Color.Red;
                camposValidos = false;
            }
            else
            {
                lb_hora.ForeColor = Color.Black;
            }
            if (cb_especialidad.SelectedItem == null)
            {
                lb_especialidad.ForeColor = Color.Red;
                camposValidos = false;
            }
            else
            {
                lb_especialidad.ForeColor = Color.Black;
            }
        }
        public void CargarCitas()
        {
            List<Cita> listaCitas = _citaBLL.ListarCitas(); // Todas las citas de la BD

            foreach (var cita in listaCitas)
            {
                // Creamos el botón solo con información de la cita
                Button btnCita = new Button
                {
                    Text = $"{cita.IdCita} - {cita.CarnetPaciente}", // Opcional: mostrar motivo también
                    Tag = cita, // Guardamos la cita completa en el Tag
                    Width = 220,
                    Height = 40,
                    Margin = new Padding(5)
                };

                btnCita.Click += (s, ev) =>
                {
                    Cita c = (Cita)((Button)s).Tag;

                    MessageBox.Show(
                        $"📋 Detalles de la cita:\n\n" +
                        $"Carnet: {c.CarnetPaciente}\n" +
                        $"Especialidad: {c.Especialidad}\n" +
                        $"Motivo: {c.Motivo}\n" +
                        $"Fecha: {c.Fecha:dd/MM/yyyy}\n" +
                        $"Hora: {c.Hora}",
                        "Información de la Cita"
                    );
                };

                flp_citas.Controls.Add(btnCita);
            }

            flp_citas.FlowDirection = FlowDirection.TopDown;
            flp_citas.WrapContents = false;
            flp_citas.AutoScroll = true;
            flp_citas.AutoSize = false;
        }
    }
}

