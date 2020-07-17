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
    public partial class VistaColegios : Form
    {
        public VistaColegios()
        {
            InitializeComponent();
            cargarTabla(null);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string dato = txtcampo.Text;
            cargarTabla(dato);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            Colegio _colegio = new Colegio();
            _colegio.Codigo = txtcodigo.Text;
            _colegio.Nombre = txtnombre.Text;

            
            Control_Colegios ctrl = new Control_Colegios();

            if (txtid.Text != "")
            {
                _colegio.Id = int.Parse(txtid.Text);
                bandera = ctrl.actualizar(_colegio);

            }
            else
            {
                bandera = ctrl.insertar(_colegio);

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

        private void cargarTabla(string dato)
        {
            List<Colegio> lista = new List<Colegio>();
            Control_Colegios _ctrlColegios = new Control_Colegios();
            dataGridView1.DataSource = _ctrlColegios.consulta(dato);

        }

        public void limpiar()
        {
            txtid.Text = "";
            txtcodigo.Text = "";
            txtnombre.Text = "";

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

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            bool bandera = false;

            DialogResult resultado = MessageBox.Show("Estás seguro que deseas eliminar el registro?", "Salir",
                MessageBoxButtons.YesNoCancel);
            if (resultado == DialogResult.Yes)
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                Control_Colegios _ctrl = new Control_Colegios();
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
            VistaBloques vb = new VistaBloques();
            vb.Show();
            this.Visible = false;
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            VistaAsignaturas va = new VistaAsignaturas();
            va.Show();
            this.Visible = false;
        }
    }
}
