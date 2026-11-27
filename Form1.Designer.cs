namespace Boletin_calificaciones
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            rdbVespertina = new RadioButton();
            rdbMatutina = new RadioButton();
            label2 = new Label();
            txtEstudiante = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnRegistrar = new Button();
            chkAsistencia = new CheckBox();
            txtP4 = new TextBox();
            txtP3 = new TextBox();
            txtP2 = new TextBox();
            txtP1 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            cmbAsignatura = new ComboBox();
            label3 = new Label();
            btnResumen = new Button();
            grpBoletin = new GroupBox();
            lstBoletin = new ListBox();
            groupBox3 = new GroupBox();
            lblSituacion = new Label();
            lblReprobadas = new Label();
            lblRecuperacion = new Label();
            lblAprobadas = new Label();
            lblPromedioGeneral = new Label();
            btnLimpiar = new Button();
            btnSalir = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            grpBoletin.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbVespertina);
            groupBox1.Controls.Add(rdbMatutina);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtEstudiante);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 155);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del estudiante";
            // 
            // rdbVespertina
            // 
            rdbVespertina.AutoSize = true;
            rdbVespertina.Location = new Point(166, 81);
            rdbVespertina.Name = "rdbVespertina";
            rdbVespertina.Size = new Size(99, 24);
            rdbVespertina.TabIndex = 4;
            rdbVespertina.TabStop = true;
            rdbVespertina.Text = "Vespertina";
            rdbVespertina.UseVisualStyleBackColor = true;
            // 
            // rdbMatutina
            // 
            rdbMatutina.AutoSize = true;
            rdbMatutina.Location = new Point(71, 79);
            rdbMatutina.Name = "rdbMatutina";
            rdbMatutina.Size = new Size(89, 24);
            rdbMatutina.TabIndex = 3;
            rdbMatutina.TabStop = true;
            rdbMatutina.Text = "Matutina";
            rdbMatutina.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 81);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 2;
            label2.Text = "Tanda:";
            // 
            // txtEstudiante
            // 
            txtEstudiante.Location = new Point(79, 31);
            txtEstudiante.Name = "txtEstudiante";
            txtEstudiante.Size = new Size(164, 27);
            txtEstudiante.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 31);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnRegistrar);
            groupBox2.Controls.Add(chkAsistencia);
            groupBox2.Controls.Add(txtP4);
            groupBox2.Controls.Add(txtP3);
            groupBox2.Controls.Add(txtP2);
            groupBox2.Controls.Add(txtP1);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cmbAsignatura);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(12, 173);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(316, 261);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Registro de asignatura";
            // 
            // btnRegistrar
            // 
            btnRegistrar.ForeColor = SystemColors.ActiveCaption;
            btnRegistrar.Location = new Point(26, 218);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(189, 29);
            btnRegistrar.TabIndex = 12;
            btnRegistrar.Text = "Registrar asignatura";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // chkAsistencia
            // 
            chkAsistencia.AutoSize = true;
            chkAsistencia.Location = new Point(8, 188);
            chkAsistencia.Name = "chkAsistencia";
            chkAsistencia.Size = new Size(286, 24);
            chkAsistencia.TabIndex = 11;
            chkAsistencia.Text = "Cumple con la asistencia minima(80%)";
            chkAsistencia.UseVisualStyleBackColor = true;
            // 
            // txtP4
            // 
            txtP4.Location = new Point(210, 144);
            txtP4.Name = "txtP4";
            txtP4.Size = new Size(63, 27);
            txtP4.TabIndex = 10;
            // 
            // txtP3
            // 
            txtP3.Location = new Point(146, 144);
            txtP3.Name = "txtP3";
            txtP3.Size = new Size(58, 27);
            txtP3.TabIndex = 9;
            // 
            // txtP2
            // 
            txtP2.Location = new Point(79, 144);
            txtP2.Name = "txtP2";
            txtP2.Size = new Size(59, 27);
            txtP2.TabIndex = 8;
            // 
            // txtP1
            // 
            txtP1.Location = new Point(8, 144);
            txtP1.Name = "txtP1";
            txtP1.Size = new Size(65, 27);
            txtP1.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(218, 121);
            label8.Name = "label8";
            label8.Size = new Size(25, 20);
            label8.TabIndex = 6;
            label8.Text = "P4";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(165, 120);
            label7.Name = "label7";
            label7.Size = new Size(25, 20);
            label7.TabIndex = 5;
            label7.Text = "P3";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(92, 121);
            label6.Name = "label6";
            label6.Size = new Size(25, 20);
            label6.TabIndex = 4;
            label6.Text = "P2";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 121);
            label5.Name = "label5";
            label5.Size = new Size(25, 20);
            label5.TabIndex = 3;
            label5.Text = "P1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 88);
            label4.Name = "label4";
            label4.Size = new Size(253, 20);
            label4.TabIndex = 2;
            label4.Text = "Calificaciones por periodo ( 0 a 100):\r\n";
            // 
            // cmbAsignatura
            // 
            cmbAsignatura.FormattingEnabled = true;
            cmbAsignatura.Location = new Point(92, 32);
            cmbAsignatura.Name = "cmbAsignatura";
            cmbAsignatura.Size = new Size(202, 28);
            cmbAsignatura.TabIndex = 1;
            cmbAsignatura.Text = "seleccione una asignatura";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 32);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 0;
            label3.Text = "Asignatura:";
            // 
            // btnResumen
            // 
            btnResumen.Location = new Point(3, 440);
            btnResumen.Name = "btnResumen";
            btnResumen.Size = new Size(199, 47);
            btnResumen.TabIndex = 3;
            btnResumen.Text = "Mostrar resumen";
            btnResumen.UseVisualStyleBackColor = true;
            btnResumen.Click += btnResumen_Click;
            // 
            // grpBoletin
            // 
            grpBoletin.Controls.Add(lstBoletin);
            grpBoletin.Location = new Point(360, 12);
            grpBoletin.Name = "grpBoletin";
            grpBoletin.Size = new Size(314, 197);
            grpBoletin.TabIndex = 4;
            grpBoletin.TabStop = false;
            grpBoletin.Text = "Boletin del estudiante";
            grpBoletin.Enter += groupBox3_Enter;
            // 
            // lstBoletin
            // 
            lstBoletin.FormattingEnabled = true;
            lstBoletin.Location = new Point(6, 26);
            lstBoletin.Name = "lstBoletin";
            lstBoletin.Size = new Size(302, 144);
            lstBoletin.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblSituacion);
            groupBox3.Controls.Add(lblReprobadas);
            groupBox3.Controls.Add(lblRecuperacion);
            groupBox3.Controls.Add(lblAprobadas);
            groupBox3.Controls.Add(lblPromedioGeneral);
            groupBox3.Location = new Point(360, 219);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(314, 201);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Resumen";
            // 
            // lblSituacion
            // 
            lblSituacion.AutoSize = true;
            lblSituacion.Location = new Point(10, 151);
            lblSituacion.Name = "lblSituacion";
            lblSituacion.Size = new Size(73, 20);
            lblSituacion.TabIndex = 4;
            lblSituacion.Text = "Situacion:";
            // 
            // lblReprobadas
            // 
            lblReprobadas.AutoSize = true;
            lblReprobadas.Location = new Point(6, 121);
            lblReprobadas.Name = "lblReprobadas";
            lblReprobadas.Size = new Size(92, 20);
            lblReprobadas.TabIndex = 3;
            lblReprobadas.Text = "Reprobadas:";
            // 
            // lblRecuperacion
            // 
            lblRecuperacion.AutoSize = true;
            lblRecuperacion.Location = new Point(0, 87);
            lblRecuperacion.Name = "lblRecuperacion";
            lblRecuperacion.Size = new Size(118, 20);
            lblRecuperacion.TabIndex = 2;
            lblRecuperacion.Text = "En recuperacion:";
            // 
            // lblAprobadas
            // 
            lblAprobadas.AutoSize = true;
            lblAprobadas.Location = new Point(0, 54);
            lblAprobadas.Name = "lblAprobadas";
            lblAprobadas.Size = new Size(85, 20);
            lblAprobadas.TabIndex = 1;
            lblAprobadas.Text = "Aprobadas:";
            lblAprobadas.Click += label10_Click;
            // 
            // lblPromedioGeneral
            // 
            lblPromedioGeneral.AutoSize = true;
            lblPromedioGeneral.Location = new Point(0, 23);
            lblPromedioGeneral.Name = "lblPromedioGeneral";
            lblPromedioGeneral.Size = new Size(131, 20);
            lblPromedioGeneral.TabIndex = 0;
            lblPromedioGeneral.Text = "Promedio general:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(244, 440);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(172, 47);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(462, 440);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(166, 47);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 499);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(groupBox3);
            Controls.Add(grpBoletin);
            Controls.Add(btnResumen);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Boletin de calificaciones";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            grpBoletin.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtEstudiante;
        private Label label1;
        private RadioButton rdbVespertina;
        private RadioButton rdbMatutina;
        private GroupBox groupBox2;
        private Label label3;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox cmbAsignatura;
        private TextBox txtP1;
        private TextBox txtP2;
        private TextBox txtP4;
        private TextBox txtP3;
        private Button btnRegistrar;
        private CheckBox chkAsistencia;
        private Button btnResumen;
        private GroupBox grpBoletin;
        private ListBox lstBoletin;
        private GroupBox groupBox3;
        private Label lblReprobadas;
        private Label lblRecuperacion;
        private Label lblAprobadas;
        private Label lblPromedioGeneral;
        private Label lblSituacion;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}
