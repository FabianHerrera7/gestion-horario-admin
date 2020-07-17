using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHorariosHESAR
{
    public partial class VistaCursos : Form
    {
        public VistaCursos()
        {
            InitializeComponent();
            cargarTabla(null);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string dato = txtcampo.Text;
            cargarTabla(dato);
        }

        private void cargarTabla(string dato)
        {
            List<Curso> lista = new List<Curso>();
            Control_Cursos _ctrlCursos = new Control_Cursos();
            dataGridView1.DataSource = _ctrlCursos.consulta(dato);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            Curso _curso = new Curso();
            _curso.Codigo = txtcodigo.Text;


            Control_Cursos ctrl = new Control_Cursos();


            if (txtid.Text != "")
            {
                _curso.Id = int.Parse(txtid.Text);
                bandera = ctrl.actualizar(_curso);

            }
            else
            {
                bandera = ctrl.insertar(_curso);

            }

            if (bandera)
            {
                MessageBox.Show("Registro del curso guardado!!");
                limpiar();
                cargarTabla(null);
            }
            else
            {
                MessageBox.Show("Registro no se pudo guardar :( ");
            }
        }

        public void limpiar()
        {
            txtid.Text = "";
            txtcodigo.Text = "";

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtcodigo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            bool bandera = false;

            DialogResult resultado = MessageBox.Show("Estás seguro que deseas eliminar el registro?", "Salir",
                MessageBoxButtons.YesNoCancel);
            if (resultado == DialogResult.Yes)
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                Control_Cursos _ctrl = new Control_Cursos();
                bandera = _ctrl.eliminar(id);


                if (bandera)
                {
                    MessageBox.Show("Registro del curso eliminado!!");
                    limpiar();
                    cargarTabla(null);
                }
            }
        }
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void VistaCursos_Load(object sender, EventArgs e)
        {

        }
    }
}
