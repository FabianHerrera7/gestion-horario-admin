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
    public partial class VistaSedes : Form
    {
        public VistaSedes()
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
            List<Sede> lista = new List<Sede>();
            Control_Sedes _ctrlSedes = new Control_Sedes();
            dataGridView1.DataSource = _ctrlSedes.consulta(dato);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            Sede _sede = new Sede();
            _sede.Codigo = txtcodigo.Text;
            _sede.Direccion = txtdireccion.Text;


            Control_Sedes ctrl = new Control_Sedes();


            if (txtid.Text != "")
            {
                _sede.Id = int.Parse(txtid.Text);
                bandera = ctrl.actualizar(_sede);

            }
            else
            {
                bandera = ctrl.insertar(_sede);

            }

            if (bandera)
            {
                MessageBox.Show("Registro de la sede guardado!!");
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
            txtdireccion.Text = "";

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtcodigo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtdireccion.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            bool bandera = false;

            DialogResult resultado = MessageBox.Show("Estás seguro que deseas eliminar el registro?", "Salir",
                MessageBoxButtons.YesNoCancel);
            if (resultado == DialogResult.Yes)
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                Control_Sedes _ctrl = new Control_Sedes();
                bandera = _ctrl.eliminar(id);


                if (bandera)
                {
                    MessageBox.Show("Registro de la sede eliminado!!");
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
