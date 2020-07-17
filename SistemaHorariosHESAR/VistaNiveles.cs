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
    public partial class VistaNiveles : Form
    {
        public VistaNiveles()
        {
            InitializeComponent();
            cargarTabla(null);
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            VistaBloques vb = new VistaBloques();
            vb.Show();
            this.Visible = false;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string dato = txtcampo.Text;
            cargarTabla(dato);
        }

        private void cargarTabla(string dato)
        {
            List<Nivel> lista = new List<Nivel>();
            Control_Niveles _ctrlNiveles = new Control_Niveles();
            dataGridView1.DataSource = _ctrlNiveles.consulta(dato);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            Nivel _nivel = new Nivel();
            _nivel.Codigo = txtcodigo.Text;
            _nivel.Descripcion = txtdescripcion.Text;


            Control_Niveles ctrl = new Control_Niveles();


            if (txtid.Text != "")
            {
                _nivel.Id = int.Parse(txtid.Text);
                bandera = ctrl.actualizar(_nivel);

            }
            else
            {
                bandera = ctrl.insertar(_nivel);

            }

            if (bandera)
            {
                MessageBox.Show("Registro del nivel guardado!!");
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
            txtdescripcion.Text = "";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtcodigo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtdescripcion.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            bool bandera = false;

            DialogResult resultado = MessageBox.Show("Estás seguro que deseas eliminar el registro?", "Salir",
                MessageBoxButtons.YesNoCancel);
            if (resultado == DialogResult.Yes)
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                Control_Niveles _ctrl = new Control_Niveles();
                bandera = _ctrl.eliminar(id);


                if (bandera)
                {
                    MessageBox.Show("Registro del nivel eliminado!!");
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
