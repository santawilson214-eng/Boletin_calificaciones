namespace Boletin_calificaciones
{
    public partial class Form1 : Form
    {

        const double NOTA_APROBADA = 70;
        const double NOTA_RECUPERACION = 60;
        const int PERIODOS = 4;
        const double NOTA_MIN = 0;
        const double NOTA_MAX = 100;


        int cantAprobadas = 0;
        int cantRecuperacion = 0;
        int cantReprobadas = 0;
        double sumaPromedios = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbAsignatura.Items.Add("Matemática");
            cmbAsignatura.Items.Add("Lengua Española");
            cmbAsignatura.Items.Add("Ciencias Naturales");
            cmbAsignatura.Items.Add("Inglés");
            cmbAsignatura.Items.Add("Informática");

            cmbAsignatura.SelectedIndex = -1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // ----- Validación 1: el nombre no puede estar vacío -----
            if (txtEstudiante.Text.Trim() == "")
            {
                MessageBox.Show("Escriba el nombre del estudiante.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEstudiante.Focus();
                return;
            }

            // ----- Validación 2: debe haber una tanda seleccionada -----
            if (!rdbMatutina.Checked && !rdbVespertina.Checked)
            {
                MessageBox.Show("Seleccione la tanda del estudiante.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ----- Validación 3: debe haber una asignatura seleccionada -----
            if (cmbAsignatura.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una asignatura.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbAsignatura.Focus();
                return;
            }

            // ----- Validación 4: las 4 calificaciones deben ser números de 0 a 100 -----
            double p1, p2, p3, p4;

            if (!double.TryParse(txtP1.Text, out p1) || p1 < NOTA_MIN || p1 > NOTA_MAX)
            {
                MessageBox.Show("La calificación del período 1 debe ser un número entre 0 y 100.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtP1.Focus();
                return;
            }
            if (!double.TryParse(txtP2.Text, out p2) || p2 < NOTA_MIN || p2 > NOTA_MAX)
            {
                MessageBox.Show("La calificación del período 2 debe ser un número entre 0 y 100.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtP2.Focus();
                return;
            }
            if (!double.TryParse(txtP3.Text, out p3) || p3 < NOTA_MIN || p3 > NOTA_MAX)
            {
                MessageBox.Show("La calificación del período 3 debe ser un número entre 0 y 100.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtP3.Focus();
                return;
            }
            if (!double.TryParse(txtP4.Text, out p4) || p4 < NOTA_MIN || p4 > NOTA_MAX)
            {
                MessageBox.Show("La calificación del período 4 debe ser un número entre 0 y 100.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtP4.Focus();
                return;
            }


            double promedio = (p1 + p2 + p3 + p4) / PERIODOS;


            string situacion;

            if (!chkAsistencia.Checked)
            {

                situacion = "Reprobada por asistencia";
                cantReprobadas++;
            }
            else if (promedio >= NOTA_APROBADA)
            {
                situacion = "Aprobada";
                cantAprobadas++;
            }
            else if (promedio >= NOTA_RECUPERACION)
            {
                situacion = "En recuperación";
                cantRecuperacion++;
            }
            else
            {
                situacion = "Reprobada";
                cantReprobadas++;
            }


            sumaPromedios += promedio;


            lstBoletin.Items.Add(cmbAsignatura.Text + " · " + promedio.ToString("F2") + " · " + situacion);


            cmbAsignatura.SelectedIndex = -1;
            txtP1.Clear();
            txtP2.Clear();
            txtP3.Clear();
            txtP4.Clear();
            chkAsistencia.Checked = true;
            cmbAsignatura.Focus();
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            int totalAsignaturas = cantAprobadas + cantRecuperacion + cantReprobadas;

            if (totalAsignaturas == 0)
            {
                MessageBox.Show("Registre al menos una asignatura antes de mostrar el resumen.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            double promedioGeneral = sumaPromedios / totalAsignaturas;


            lblPromedioGeneral.Text = "Promedio general: " + promedioGeneral.ToString("F2");
            lblAprobadas.Text = "Aprobadas: " + cantAprobadas;
            lblRecuperacion.Text = "En recuperación: " + cantRecuperacion;
            lblReprobadas.Text = "Reprobadas: " + cantReprobadas;

            if (cantReprobadas > 0)
            {
                lblSituacion.Text = "Situación: Tiene asignaturas reprobadas";
            }
            else if (cantRecuperacion > 0)
            {
                lblSituacion.Text = "Situación: Tiene asignaturas en recuperación";
            }
            else
            {
                lblSituacion.Text = "Situación: Aprobó todas las asignaturas";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtEstudiante.Clear();
            rdbMatutina.Checked = false;
            rdbVespertina.Checked = false;


            cmbAsignatura.SelectedIndex = -1;
            txtP1.Clear();
            txtP2.Clear();
            txtP3.Clear();
            txtP4.Clear();
            chkAsistencia.Checked = true;


            lstBoletin.Items.Clear();


            cantAprobadas = 0;
            cantRecuperacion = 0;
            cantReprobadas = 0;
            sumaPromedios = 0;


            lblPromedioGeneral.Text = "Promedio general:";
            lblAprobadas.Text = "Aprobadas:";
            lblRecuperacion.Text = "En recuperación:";
            lblReprobadas.Text = "Reprobadas:";
            lblSituacion.Text = "Situación:";


            txtEstudiante.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
            
            

            
        
    

