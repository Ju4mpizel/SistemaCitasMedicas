using SistemaCitasMedicas.BLL;
using SistemaCitasMedicas.DAL;
using SistemaCitasMedicas.ENT;
using System.Text;
using System.Windows.Forms;
namespace SistemaCitasMedicas.UI
{
    public partial class FormularioCitas : Form
    {
        private readonly PacienteNegocioBLL _pacienteBLL = new PacienteNegocioBLL();
        private readonly CitaNegocioBLL _citaBLL = new CitaNegocioBLL();
        private List<Cita> listaCitas;
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
            {
                // Se bloquea la hora si es que no esta seleccionada la especialidad
                cb_hora.Enabled = false;
                return;
            }
            if (cb_especialidad.SelectedItem == null)
                return;
            string especialidad = cb_especialidad.SelectedItem.ToString();

            // Limpia el ComboBox de horarios
            cb_hora.Items.Clear();

            // Carga los horarios según la especialidad seleccionada
            if (HorariosNegocioBLL.horariosPorEspecialidad.ContainsKey(especialidad))
            {
                foreach (string hora in HorariosNegocioBLL.horariosPorEspecialidad[especialidad])
                {
                    cb_hora.Items.Add(hora);
                }
            }
            cb_hora.Enabled = true;
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
            CargarCitasDesdeBD();
            tb_buscarCarnet.MaxLength = 7;
            cb_hora.Enabled = false;
            cb_especialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_hora.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            // Llama a la funcion para validar si todo esta bien llenado
            if (ValidarFormulario())
            {
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
            // Verifica si el paciente ya existe antes de agregar
            if (!_pacienteBLL.ExistePaciente(tb_carnet.Text))
            {
                _pacienteBLL.AgregarPaciente(pacienteNuevo);
            }
            //Verifica el Id de la cita y la guarda para ponerla en el boton
            int idGenerado = _citaBLL.AgregarCita(citaNueva);
            citaNueva.IdCita = idGenerado;
            // Añade el botón a la lista de citas
            CrearBotonCita(citaNueva, pacienteNuevo);
            // Mensaje de confirmación
            MessageBox.Show("Cita añadida con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Limpia el formulario
            LimpiarFormulario();
        }
        public bool ValidarFormulario()
        {
            bool hayError = false;
            StringBuilder mensajeError = new StringBuilder("Corrija los siguientes errores:\n");

            int maxCarnet = 7;
            int maxNombre = 100;
            int maxApellido = 100;
            int maxTelefono = 15;
            int maxDireccion = 150;
            int maxMotivo = 200;
            int maxEspecialidad = 100;

            // Validar carnet
            if (string.IsNullOrWhiteSpace(tb_carnet.Text))
            {
                lb_carnet.ForeColor = Color.Red;
                mensajeError.AppendLine("- Carnet vacío");
                hayError = true;
            }
            else if (tb_carnet.Text.Length > maxCarnet)
            {
                lb_carnet.ForeColor = Color.Red;
                mensajeError.AppendLine($"- Carnet supera {maxCarnet} caracteres");
                hayError = true;
            }
            else
            {
                lb_carnet.ForeColor = Color.Black;
            }

            // Validar nombre
            if (string.IsNullOrWhiteSpace(tb_nombre.Text))
            {
                lb_nombre.ForeColor = Color.Red;
                mensajeError.AppendLine("- Nombre vacío");
                hayError = true;
            }
            else if (tb_nombre.Text.Length > maxNombre)
            {
                lb_nombre.ForeColor = Color.Red;
                mensajeError.AppendLine($"- Nombre supera {maxNombre} caracteres");
                hayError = true;
            }
            else
            {
                lb_nombre.ForeColor = Color.Black;
            }

            // Validar apellido
            if (string.IsNullOrWhiteSpace(tb_apellido.Text))
            {
                lb_apellido.ForeColor = Color.Red;
                mensajeError.AppendLine("- Apellido vacío");
                hayError = true;
            }
            else if (tb_apellido.Text.Length > maxApellido)
            {
                lb_apellido.ForeColor = Color.Red;
                mensajeError.AppendLine($"- Apellido supera {maxApellido} caracteres");
                hayError = true;
            }
            else
            {
                lb_apellido.ForeColor = Color.Black;
            }

            // Validar teléfono
            if (!string.IsNullOrEmpty(tb_numero.Text) && tb_numero.Text.Length > maxTelefono)
            {
                lb_numero.ForeColor = Color.Red;
                mensajeError.AppendLine($"- Teléfono supera {maxTelefono} caracteres");
                hayError = true;
            }
            else
            {
                lb_numero.ForeColor = Color.Black;
            }

            // Validar dirección
            if (!string.IsNullOrEmpty(tb_direccion.Text) && tb_direccion.Text.Length > maxDireccion)
            {
                lb_direccion.ForeColor = Color.Red;
                mensajeError.AppendLine($"- Dirección supera {maxDireccion} caracteres");
                hayError = true;
            }
            else
            {
                lb_direccion.ForeColor = Color.Black;
            }

            // Validar motivo
            if (!string.IsNullOrEmpty(tb_motivo.Text) && tb_motivo.Text.Length > maxMotivo)
            {
                lb_motivo.ForeColor = Color.Red;
                mensajeError.AppendLine($"- Motivo supera {maxMotivo} caracteres");
                hayError = true;
            }
            else
            {
                lb_motivo.ForeColor = Color.Black;
            }

            // Validar especialidad
            if (cb_especialidad.SelectedItem == null)
            {
                lb_especialidad.ForeColor = Color.Red;
                mensajeError.AppendLine("- Especialidad no seleccionada");
                hayError = true;
            }
            else if (cb_especialidad.SelectedItem.ToString().Length > maxEspecialidad)
            {
                lb_especialidad.ForeColor = Color.Red;
                mensajeError.AppendLine($"- Especialidad supera {maxEspecialidad} caracteres");
                hayError = true;
            }
            else
            {
                lb_especialidad.ForeColor = Color.Black;
            }

            // Validar hora
            if (string.IsNullOrWhiteSpace(cb_hora.Text))
            {
                lb_hora.ForeColor = Color.Red;
                mensajeError.AppendLine("- Hora no seleccionada");
                hayError = true;
            }
            else
            {
                lb_hora.ForeColor = Color.Black;
            }

            // Mostrar mensaje si hay errores
            if (hayError)
                MessageBox.Show(mensajeError.ToString(), "Errores en el formulario", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            return hayError;
        }
        public void LimpiarFormulario()
        {
            // Limpia el formulario
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
        public void CrearBotonCita(Cita cita, Paciente paciente = null)
        {
            Button btnCita = new Button
            {
                Text = paciente == null ? $"{cita.IdCita} - {cita.CarnetPaciente}"
                                        : $"{cita.IdCita} - {cita.CarnetPaciente}",
                Tag = paciente == null ? (object)cita : new { Cita = cita, Paciente = paciente },
                Width = 220,
                Height = 40,
                Margin = new Padding(5)
            };

            btnCita.Click += (s, ev) =>
            {
                if (paciente == null)
                {
                    // Solo Cita (cuando cargamos desde BD)
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
                }
                else
                {
                    // Cita + Paciente (cuando agregamos nueva)
                    var data = (dynamic)((Button)s).Tag;
                    Cita c = data.Cita;
                    Paciente p = data.Paciente;

                    MessageBox.Show(
                        $"📋 Detalles de la cita:\n\n" +
                        $"Paciente: {p.Nombre} {p.Apellido}\n" +
                        $"Carnet: {p.Carnet}\n" +
                        $"Teléfono: {p.Telefono}\n" +
                        $"Dirección: {p.Direccion}\n\n" +
                        $"Especialidad: {c.Especialidad}\n" +
                        $"Motivo: {c.Motivo}\n" +
                        $"Fecha: {c.Fecha:dd/MM/yyyy}\n" +
                        $"Hora: {c.Hora}",
                        "Información de la Cita"
                    );
                }
            };

            flp_citas.Controls.Add(btnCita);
            flp_citas.FlowDirection = FlowDirection.TopDown;
            flp_citas.WrapContents = false;
            flp_citas.AutoScroll = true;
            flp_citas.AutoSize = false;
        }
        private void CargarCitasDesdeBD()
        {
            listaCitas = _citaBLL.ListarCitas();
            flp_citas.Controls.Clear();

            foreach (var cita in listaCitas)
            {
                CrearBotonCita(cita);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string carnet = tb_buscarCarnet.Text;

            // Limpia la lista de citas mostradas
            flp_citas.Controls.Clear();

            if (string.IsNullOrEmpty(carnet))
            {
                // Muestra todo otra vez si no hay nada en el textbox
                foreach (var cita in listaCitas)
                {
                    CrearBotonCita(cita);
                }
            }
            else
            {
                // Aplico filtro
                var resultados = listaCitas
                    .Where(c => c.CarnetPaciente.Equals(carnet, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                foreach (var cita in resultados)
                {
                    CrearBotonCita(cita);
                }
            }
        }


        private void tb_buscarCarnet_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_buscarCarnet.Clear();
            CargarCitasDesdeBD();
        }
    }
}

