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
    public partial class VistaAsignaturas : Form
    {
        public VistaAsignaturas()
        {
            InitializeComponent();
            cargarTabla(null);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            Asignatura _asignatura = new Asignatura();
            _asignatura.Codigo = txtcodigo.Text;
            _asignatura.Nombre = txtnombre.Text;
            _asignatura.Color = txtcolor.Text;
            _asignatura.Sala_especial = txtsalaespecial.Text;
            _asignatura.Bloques = int.Parse(txtbloques.Text);
            //_asignatura.Vigente = txtvigente.Text;


            Control_Asignaturas ctrl = new Control_Asignaturas();

            if (txtid.Text != "")
            {
                _asignatura.Id = int.Parse(txtid.Text);
                bandera = ctrl.actualizar(_asignatura);

            }
            else
            {
                bandera = ctrl.insertar(_asignatura);

            }

            if (bandera)
            {
                MessageBox.Show("Registro guardado!!");
                limpiar();
                cargarTabla(null);
            }
            else
            {
                MessageBox.Show("Registro no se pudo guardar :( ");
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string dato = txtcampo.Text;
            cargarTabla(dato);
        }

        private void cargarTabla(string dato)
        {
            List<Asignatura> lista = new List<Asignatura>();
            Control_Asignaturas _ctrlAsignaturas = new Control_Asignaturas();
            dataGridView1.DataSource = _ctrlAsignaturas.consulta(dato);

        }

        public void limpiar()
        {
            txtid.Text = "";
            txtcodigo.Text = "";
            txtnombre.Text = "";
            txtcolor.Text = "";
            txtsalaespecial.Text = "";
            txtbloques.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtcodigo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtnombre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtcolor.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtsalaespecial .Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtbloques.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            bool bandera = false;

            DialogResult resultado = MessageBox.Show("Estás seguro que deseas eliminar el registro?", "Salir",
                MessageBoxButtons.YesNoCancel);
            if (resultado == DialogResult.Yes)
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                Control_Asignaturas _ctrl = new Control_Asignaturas();
                bandera = _ctrl.eliminar(id);


                if (bandera)
                {
                    MessageBox.Show("Registro eliminado!!");
                    limpiar();
                    cargarTabla(null);
                }
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            VistaColegios vc = new VistaColegios();
            vc.Show();
            this.Visible = false;

        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            VistaProfesores vp = new VistaProfesores();
            vp.Show();
            this.Visible = false;

        }
    }
}
