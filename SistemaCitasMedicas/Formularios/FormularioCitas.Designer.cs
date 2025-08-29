namespace SistemaCitasMedicas.UI
{
    partial class FormularioCitas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gb_formulariocita = new GroupBox();
            tb_direccion = new TextBox();
            lb_direccion = new Label();
            tb_numero = new TextBox();
            lb_numero = new Label();
            lb_carnet = new Label();
            tb_carnet = new TextBox();
            tb_apellido = new TextBox();
            lb_apellido = new Label();
            tb_nombre = new TextBox();
            lb_nombre = new Label();
            gb_cita = new GroupBox();
            tb_motivo = new TextBox();
            lb_motivo = new Label();
            cb_hora = new ComboBox();
            dt_fecha = new DateTimePicker();
            lb_hora = new Label();
            lb_fecha = new Label();
            cb_especialidad = new ComboBox();
            lb_especialidad = new Label();
            btn_guardar = new Button();
            flp_citas = new FlowLayoutPanel();
            gb_listacitas = new GroupBox();
            tb_buscarCarnet = new TextBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            btn_buscar = new Button();
            label1 = new Label();
            gb_formulariocita.SuspendLayout();
            gb_cita.SuspendLayout();
            gb_listacitas.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gb_formulariocita
            // 
            gb_formulariocita.Controls.Add(tb_direccion);
            gb_formulariocita.Controls.Add(lb_direccion);
            gb_formulariocita.Controls.Add(tb_numero);
            gb_formulariocita.Controls.Add(lb_numero);
            gb_formulariocita.Controls.Add(lb_carnet);
            gb_formulariocita.Controls.Add(tb_carnet);
            gb_formulariocita.Controls.Add(tb_apellido);
            gb_formulariocita.Controls.Add(lb_apellido);
            gb_formulariocita.Controls.Add(tb_nombre);
            gb_formulariocita.Controls.Add(lb_nombre);
            gb_formulariocita.Location = new Point(26, 24);
            gb_formulariocita.Name = "gb_formulariocita";
            gb_formulariocita.Size = new Size(254, 256);
            gb_formulariocita.TabIndex = 0;
            gb_formulariocita.TabStop = false;
            gb_formulariocita.Text = "Formulario de datos del Paciente";
            gb_formulariocita.Enter += gb_formulariocita_Enter;
            // 
            // tb_direccion
            // 
            tb_direccion.Location = new Point(19, 213);
            tb_direccion.Name = "tb_direccion";
            tb_direccion.Size = new Size(210, 23);
            tb_direccion.TabIndex = 9;
            tb_direccion.TextChanged += tb_direccion_TextChanged;
            // 
            // lb_direccion
            // 
            lb_direccion.AutoSize = true;
            lb_direccion.Location = new Point(19, 195);
            lb_direccion.Name = "lb_direccion";
            lb_direccion.Size = new Size(127, 15);
            lb_direccion.TabIndex = 8;
            lb_direccion.Text = "Direccion de Domicilio";
            lb_direccion.Click += lb_direccion_Click;
            // 
            // tb_numero
            // 
            tb_numero.Location = new Point(19, 169);
            tb_numero.Name = "tb_numero";
            tb_numero.Size = new Size(210, 23);
            tb_numero.TabIndex = 7;
            tb_numero.TextChanged += tb_numero_TextChanged;
            // 
            // lb_numero
            // 
            lb_numero.AutoSize = true;
            lb_numero.Location = new Point(19, 151);
            lb_numero.Name = "lb_numero";
            lb_numero.Size = new Size(157, 15);
            lb_numero.TabIndex = 6;
            lb_numero.Text = "Numero de Telefono/Celular";
            lb_numero.Click += lb_numero_Click;
            // 
            // lb_carnet
            // 
            lb_carnet.AutoSize = true;
            lb_carnet.Location = new Point(19, 107);
            lb_carnet.Name = "lb_carnet";
            lb_carnet.Size = new Size(119, 15);
            lb_carnet.TabIndex = 5;
            lb_carnet.Text = "Carnet de Identidad *";
            lb_carnet.Click += lb_carnet_Click;
            // 
            // tb_carnet
            // 
            tb_carnet.Location = new Point(19, 125);
            tb_carnet.Name = "tb_carnet";
            tb_carnet.Size = new Size(210, 23);
            tb_carnet.TabIndex = 4;
            tb_carnet.TextChanged += tb_carnet_TextChanged;
            // 
            // tb_apellido
            // 
            tb_apellido.Location = new Point(19, 81);
            tb_apellido.Name = "tb_apellido";
            tb_apellido.Size = new Size(210, 23);
            tb_apellido.TabIndex = 3;
            tb_apellido.TextChanged += tb_apellido_TextChanged;
            // 
            // lb_apellido
            // 
            lb_apellido.AutoSize = true;
            lb_apellido.Location = new Point(19, 63);
            lb_apellido.Name = "lb_apellido";
            lb_apellido.Size = new Size(69, 15);
            lb_apellido.TabIndex = 2;
            lb_apellido.Text = "Apellido/s *";
            lb_apellido.Click += lb_apellido_Click;
            // 
            // tb_nombre
            // 
            tb_nombre.Location = new Point(19, 37);
            tb_nombre.Name = "tb_nombre";
            tb_nombre.Size = new Size(210, 23);
            tb_nombre.TabIndex = 1;
            tb_nombre.TextChanged += tb_nombre_TextChanged;
            // 
            // lb_nombre
            // 
            lb_nombre.AutoSize = true;
            lb_nombre.Location = new Point(19, 19);
            lb_nombre.Name = "lb_nombre";
            lb_nombre.Size = new Size(69, 15);
            lb_nombre.TabIndex = 0;
            lb_nombre.Text = "Nombre/s *";
            lb_nombre.Click += lb_nombre_Click;
            // 
            // gb_cita
            // 
            gb_cita.Controls.Add(tb_motivo);
            gb_cita.Controls.Add(lb_motivo);
            gb_cita.Controls.Add(cb_hora);
            gb_cita.Controls.Add(dt_fecha);
            gb_cita.Controls.Add(lb_hora);
            gb_cita.Controls.Add(lb_fecha);
            gb_cita.Controls.Add(cb_especialidad);
            gb_cita.Controls.Add(lb_especialidad);
            gb_cita.Location = new Point(311, 24);
            gb_cita.Name = "gb_cita";
            gb_cita.Size = new Size(254, 256);
            gb_cita.TabIndex = 1;
            gb_cita.TabStop = false;
            gb_cita.Text = "Formulario de cita";
            gb_cita.Enter += gb_cita_Enter;
            // 
            // tb_motivo
            // 
            tb_motivo.Location = new Point(17, 169);
            tb_motivo.Multiline = true;
            tb_motivo.Name = "tb_motivo";
            tb_motivo.Size = new Size(215, 67);
            tb_motivo.TabIndex = 7;
            tb_motivo.TextChanged += tb_motivo_TextChanged;
            // 
            // lb_motivo
            // 
            lb_motivo.AutoSize = true;
            lb_motivo.Location = new Point(17, 151);
            lb_motivo.Name = "lb_motivo";
            lb_motivo.Size = new Size(45, 15);
            lb_motivo.TabIndex = 6;
            lb_motivo.Text = "Motivo";
            lb_motivo.Click += lb_motivo_Click;
            // 
            // cb_hora
            // 
            cb_hora.FormattingEnabled = true;
            cb_hora.Location = new Point(17, 125);
            cb_hora.Name = "cb_hora";
            cb_hora.Size = new Size(215, 23);
            cb_hora.TabIndex = 4;
            cb_hora.SelectedIndexChanged += cb_hora_SelectedIndexChanged;
            // 
            // dt_fecha
            // 
            dt_fecha.Location = new Point(17, 81);
            dt_fecha.Name = "dt_fecha";
            dt_fecha.Size = new Size(215, 23);
            dt_fecha.TabIndex = 5;
            dt_fecha.ValueChanged += dt_fecha_ValueChanged;
            // 
            // lb_hora
            // 
            lb_hora.AutoSize = true;
            lb_hora.Location = new Point(17, 107);
            lb_hora.Name = "lb_hora";
            lb_hora.Size = new Size(41, 15);
            lb_hora.TabIndex = 3;
            lb_hora.Text = "Hora *";
            lb_hora.Click += lb_hora_Click;
            // 
            // lb_fecha
            // 
            lb_fecha.AutoSize = true;
            lb_fecha.Location = new Point(17, 63);
            lb_fecha.Name = "lb_fecha";
            lb_fecha.Size = new Size(46, 15);
            lb_fecha.TabIndex = 2;
            lb_fecha.Text = "Fecha *";
            lb_fecha.Click += lb_fecha_Click;
            // 
            // cb_especialidad
            // 
            cb_especialidad.FormattingEnabled = true;
            cb_especialidad.Items.AddRange(new object[] { "Medicina General", "Emergencias", "Traumatologia", "Pediatria", "Gastroenterologia", "Ginecología y Obstetricia", "Cardiología", "Dermatología", "Oftalmología", "Otorrinolaringología", "Neurología", "Urología", "Alergología", "Medicina Interna", "Reumatología", "Neumología", "Endocrinología", "Psiquiatría", "Psicología", "Oncología", "Nutrición", "Fisioterapia", "Odontología" });
            cb_especialidad.Location = new Point(17, 37);
            cb_especialidad.Name = "cb_especialidad";
            cb_especialidad.Size = new Size(215, 23);
            cb_especialidad.TabIndex = 1;
            cb_especialidad.SelectedIndexChanged += cb_especialidad_SelectedIndexChanged;
            // 
            // lb_especialidad
            // 
            lb_especialidad.AutoSize = true;
            lb_especialidad.Location = new Point(17, 19);
            lb_especialidad.Name = "lb_especialidad";
            lb_especialidad.Size = new Size(80, 15);
            lb_especialidad.TabIndex = 0;
            lb_especialidad.Text = "Especialidad *";
            lb_especialidad.Click += lb_especialidad_Click;
            // 
            // btn_guardar
            // 
            btn_guardar.Location = new Point(234, 301);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(135, 51);
            btn_guardar.TabIndex = 2;
            btn_guardar.Text = "Guardar Cita";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // flp_citas
            // 
            flp_citas.Location = new Point(6, 33);
            flp_citas.Name = "flp_citas";
            flp_citas.Size = new Size(260, 130);
            flp_citas.TabIndex = 3;
            // 
            // gb_listacitas
            // 
            gb_listacitas.Controls.Add(flp_citas);
            gb_listacitas.Location = new Point(599, 97);
            gb_listacitas.Name = "gb_listacitas";
            gb_listacitas.Size = new Size(288, 183);
            gb_listacitas.TabIndex = 4;
            gb_listacitas.TabStop = false;
            gb_listacitas.Text = "Lista de citas";
            // 
            // tb_buscarCarnet
            // 
            tb_buscarCarnet.Location = new Point(6, 34);
            tb_buscarCarnet.Name = "tb_buscarCarnet";
            tb_buscarCarnet.Size = new Size(180, 23);
            tb_buscarCarnet.TabIndex = 6;
            tb_buscarCarnet.TextChanged += tb_buscarCarnet_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btn_buscar);
            groupBox1.Controls.Add(tb_buscarCarnet);
            groupBox1.Location = new Point(599, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(288, 67);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar por carnet";
            // 
            // button1
            // 
            button1.Location = new Point(251, 34);
            button1.Name = "button1";
            button1.Size = new Size(29, 23);
            button1.TabIndex = 8;
            button1.Text = "↻";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_buscar
            // 
            btn_buscar.Location = new Point(192, 34);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(53, 23);
            btn_buscar.TabIndex = 8;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // label1
            // 
            label1.Location = new Point(599, 283);
            label1.Name = "label1";
            label1.Size = new Size(288, 60);
            label1.TabIndex = 8;
            label1.Text = "* Una vez añadida la cita refrescar  la lista para  obtener todos los datos";
            // 
            // FormularioCitas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 364);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(gb_listacitas);
            Controls.Add(btn_guardar);
            Controls.Add(gb_cita);
            Controls.Add(gb_formulariocita);
            Name = "FormularioCitas";
            Text = "Form1";
            Load += FormularioCitas_Load;
            gb_formulariocita.ResumeLayout(false);
            gb_formulariocita.PerformLayout();
            gb_cita.ResumeLayout(false);
            gb_cita.PerformLayout();
            gb_listacitas.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb_formulariocita;
        private TextBox tb_direccion;
        private Label lb_direccion;
        private TextBox tb_numero;
        private Label lb_numero;
        private Label lb_carnet;
        private TextBox tb_carnet;
        private TextBox tb_apellido;
        private Label lb_apellido;
        private TextBox tb_nombre;
        private Label lb_nombre;
        private GroupBox gb_cita;
        private Label lb_especialidad;
        private ComboBox cb_especialidad;
        private TextBox tb_motivo;
        private Label lb_motivo;
        private DateTimePicker dt_fecha;
        private ComboBox cb_hora;
        private Label lb_hora;
        private Label lb_fecha;
        private Button btn_guardar;
        private FlowLayoutPanel flp_citas;
        private GroupBox gb_listacitas;
        private TextBox tb_buscarCarnet;
        private GroupBox groupBox1;
        private Button btn_buscar;
        private Button button1;
        private Label label1;
    }
}
