namespace ViolinSuzukiLeila
{
    partial class FormCargarPersona
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            txtCalle = new TextBox();
            txtAltura = new TextBox();
            txtColegio = new TextBox();
            txtObservaciones = new TextBox();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDni = new Label();
            lblCalle = new Label();
            lblAltura = new Label();
            lblColegio = new Label();
            lblObservaciones = new Label();
            rdbAlumno = new RadioButton();
            rdbResponsable = new RadioButton();
            dtpFechaNac = new DateTimePicker();
            lblFechaNac = new Label();
            cboCiudad = new ComboBox();
            label1 = new Label();
            cboProvincia = new ComboBox();
            lblProvincia = new Label();
            cboTipoResponsable = new ComboBox();
            label2 = new Label();
            btnCancelar = new Button();
            btnGrabar = new Button();
            btnSalir = new Button();
            textBox1 = new TextBox();
            lblTelefono = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(103, 117);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(269, 118);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 1;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(417, 118);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(100, 23);
            txtDni.TabIndex = 2;
            txtDni.TextChanged += txtDni_TextChanged;
            // 
            // txtCalle
            // 
            txtCalle.Location = new Point(103, 162);
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(100, 23);
            txtCalle.TabIndex = 3;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(269, 162);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 4;
            // 
            // txtColegio
            // 
            txtColegio.Location = new Point(103, 203);
            txtColegio.Name = "txtColegio";
            txtColegio.Size = new Size(266, 23);
            txtColegio.TabIndex = 5;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(141, 330);
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(596, 23);
            txtObservaciones.TabIndex = 6;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(43, 121);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(209, 121);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 8;
            lblApellido.Text = "Apellido:";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(383, 121);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(28, 15);
            lblDni.TabIndex = 9;
            lblDni.Text = "Dni:";
            // 
            // lblCalle
            // 
            lblCalle.AutoSize = true;
            lblCalle.Location = new Point(64, 165);
            lblCalle.Name = "lblCalle";
            lblCalle.Size = new Size(36, 15);
            lblCalle.TabIndex = 10;
            lblCalle.Text = "Calle:";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(224, 165);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(42, 15);
            lblAltura.TabIndex = 11;
            lblAltura.Text = "Altura:";
            // 
            // lblColegio
            // 
            lblColegio.AutoSize = true;
            lblColegio.Location = new Point(46, 208);
            lblColegio.Name = "lblColegio";
            lblColegio.Size = new Size(51, 15);
            lblColegio.TabIndex = 12;
            lblColegio.Text = "Colegio:";
            // 
            // lblObservaciones
            // 
            lblObservaciones.AutoSize = true;
            lblObservaciones.Location = new Point(34, 333);
            lblObservaciones.Name = "lblObservaciones";
            lblObservaciones.Size = new Size(87, 15);
            lblObservaciones.TabIndex = 13;
            lblObservaciones.Text = "Observaciones:";
            // 
            // rdbAlumno
            // 
            rdbAlumno.AutoSize = true;
            rdbAlumno.Location = new Point(302, 67);
            rdbAlumno.Name = "rdbAlumno";
            rdbAlumno.Size = new Size(68, 19);
            rdbAlumno.TabIndex = 14;
            rdbAlumno.TabStop = true;
            rdbAlumno.Text = "Alumno";
            rdbAlumno.UseVisualStyleBackColor = true;
            rdbAlumno.CheckedChanged += rdbAlumno_CheckedChanged;
            // 
            // rdbResponsable
            // 
            rdbResponsable.AutoSize = true;
            rdbResponsable.Location = new Point(383, 67);
            rdbResponsable.Name = "rdbResponsable";
            rdbResponsable.Size = new Size(91, 19);
            rdbResponsable.TabIndex = 15;
            rdbResponsable.TabStop = true;
            rdbResponsable.Text = "Responsable";
            rdbResponsable.UseVisualStyleBackColor = true;
            rdbResponsable.CheckedChanged += rdbResponsable_CheckedChanged;
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Format = DateTimePickerFormat.Short;
            dtpFechaNac.Location = new Point(169, 247);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(200, 23);
            dtpFechaNac.TabIndex = 16;
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Location = new Point(44, 253);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(122, 15);
            lblFechaNac.TabIndex = 17;
            lblFechaNac.Text = "Fecha de Nacimiento:";
            // 
            // cboCiudad
            // 
            cboCiudad.FormattingEnabled = true;
            cboCiudad.Location = new Point(590, 162);
            cboCiudad.Name = "cboCiudad";
            cboCiudad.Size = new Size(147, 23);
            cboCiudad.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(539, 167);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 19;
            label1.Text = "Ciudad:";
            // 
            // cboProvincia
            // 
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(590, 122);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(147, 23);
            cboProvincia.TabIndex = 20;
            cboProvincia.SelectedIndexChanged += cboProvincia_SelectedIndexChanged;
            // 
            // lblProvincia
            // 
            lblProvincia.AutoSize = true;
            lblProvincia.Location = new Point(523, 124);
            lblProvincia.Name = "lblProvincia";
            lblProvincia.Size = new Size(59, 15);
            lblProvincia.TabIndex = 21;
            lblProvincia.Text = "Provincia:";
            // 
            // cboTipoResponsable
            // 
            cboTipoResponsable.FormattingEnabled = true;
            cboTipoResponsable.Location = new Point(590, 203);
            cboTipoResponsable.Name = "cboTipoResponsable";
            cboTipoResponsable.Size = new Size(147, 23);
            cboTipoResponsable.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(469, 206);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 23;
            label2.Text = "Tipo de Responsable:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(263, 388);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(364, 388);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(75, 23);
            btnGrabar.TabIndex = 25;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(463, 388);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 26;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(590, 244);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(147, 23);
            textBox1.TabIndex = 27;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(532, 247);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(55, 15);
            lblTelefono.TabIndex = 28;
            lblTelefono.Text = "Telefono:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(520, 285);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(217, 23);
            txtEmail.TabIndex = 29;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(478, 288);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 30;
            lblEmail.Text = "eMail:";
            // 
            // FormCargarPersona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 430);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblTelefono);
            Controls.Add(textBox1);
            Controls.Add(btnSalir);
            Controls.Add(btnGrabar);
            Controls.Add(btnCancelar);
            Controls.Add(label2);
            Controls.Add(cboTipoResponsable);
            Controls.Add(lblProvincia);
            Controls.Add(cboProvincia);
            Controls.Add(label1);
            Controls.Add(cboCiudad);
            Controls.Add(lblFechaNac);
            Controls.Add(dtpFechaNac);
            Controls.Add(rdbResponsable);
            Controls.Add(rdbAlumno);
            Controls.Add(lblObservaciones);
            Controls.Add(lblColegio);
            Controls.Add(lblAltura);
            Controls.Add(lblCalle);
            Controls.Add(lblDni);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(txtObservaciones);
            Controls.Add(txtColegio);
            Controls.Add(txtAltura);
            Controls.Add(txtCalle);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Name = "FormCargarPersona";
            Text = "FormCargarAlumnos";
            Load += FormCargarPersona_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDni;
        private TextBox txtCalle;
        private TextBox txtAltura;
        private TextBox txtColegio;
        private TextBox txtObservaciones;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDni;
        private Label lblCalle;
        private Label lblAltura;
        private Label lblColegio;
        private Label lblObservaciones;
        private RadioButton rdbAlumno;
        private RadioButton rdbResponsable;
        private DateTimePicker dtpFechaNac;
        private Label lblFechaNac;
        private ComboBox cboCiudad;
        private Label label1;
        private ComboBox cboProvincia;
        private Label lblProvincia;
        private ComboBox cboTipoResponsable;
        private Label label2;
        private Button btnCancelar;
        private Button btnGrabar;
        private Button btnSalir;
        private TextBox textBox1;
        private Label lblTelefono;
        private TextBox txtEmail;
        private Label lblEmail;
    }
}