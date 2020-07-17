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
    public partial class VistaTipoBloque : Form
    {
        public VistaTipoBloque()
        {
            InitializeComponent();
            cargarTabla(null);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string dato = txtcampo.Text;
            cargarTabla(dato);
        }

        private void cargarTabla(string dato)
        {
            List<Tipodebloque> lista = new List<Tipodebloque>();
            Control_Tipodebloque _ctrlTB = new Control_Tipodebloque();
            dataGridView1.DataSource = _ctrlTB.consulta(dato);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            Tipodebloque _tb = new Tipodebloque();
            _tb.Codigo = txtcodigo.Text;
            _tb.Descripcion = txtdescr.Text;



            Control_Tipodebloque ctrl = new Control_Tipodebloque();


            if (txtid.Text != "")
            {
                _tb.Id = int.Parse(txtid.Text);
                bandera = ctrl.actualizar(_tb);

            }
            else
            {
                bandera = ctrl.insertar(_tb);

            }

            if (bandera)
            {
                MessageBox.Show("Registro del tipo de bloque guardado!!");
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
            txtdescr.Text = "";
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtcodigo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtdescr.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            bool bandera = false;

            DialogResult resultado = MessageBox.Show("Estás seguro que deseas eliminar el registro?", "Salir",
                MessageBoxButtons.YesNoCancel);
            if (resultado == DialogResult.Yes)
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                Control_Tipodebloque _ctrl = new Control_Tipodebloque();
                bandera = _ctrl.eliminar(id);


                if (bandera)
                {
                    MessageBox.Show("Registro del tipo de bloque eliminado!!");
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
