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
    public partial class VistaSalas : Form
    {
        public VistaSalas()
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
            List<Sala> lista = new List<Sala>();
            Control_Salas _ctrlSalas = new Control_Salas();
            dataGridView1.DataSource = _ctrlSalas.consulta(dato);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            Sala _sala = new Sala();
            _sala.Numero = int.Parse(txtnumero.Text);
            _sala.Ubicacion = txtubicacion.Text;


            Control_Salas ctrl = new Control_Salas();


            if (txtid.Text != "")
            {
                _sala.Id = int.Parse(txtid.Text);
                bandera = ctrl.actualizar(_sala);

            }
            else
            {
                bandera = ctrl.insertar(_sala);

            }

            if (bandera)
            {
                MessageBox.Show("Registro de la sala guardado!!");
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
            txtnumero.Text = "";
            txtubicacion.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtnumero.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtubicacion.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            bool bandera = false;

            DialogResult resultado = MessageBox.Show("Estás seguro que deseas eliminar el registro?", "Salir",
                MessageBoxButtons.YesNoCancel);
            if (resultado == DialogResult.Yes)
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                Control_Salas _ctrl = new Control_Salas();
                bandera = _ctrl.eliminar(id);


                if (bandera)
                {
                    MessageBox.Show("Registro de la sala eliminado!!");
                    limpiar();
                    cargarTabla(null);
                }
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
