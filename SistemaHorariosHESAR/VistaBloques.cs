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
    public partial class VistaBloques : Form
    {
        public VistaBloques()
        {
            InitializeComponent();
            cargarTabla(null);
        }


        private void cargarTabla(string dato)
        {
            List<Bloque> lista = new List<Bloque>();
            Control_Bloques _ctrlBloques = new Control_Bloques();
            dataGridView1.DataSource = _ctrlBloques.consulta(dato);

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            Bloque _bloque = new Bloque();
            _bloque.Numero_bloque = int.Parse(txtnrobloque.Text);
            _bloque.Dia = int.Parse(txtdia.Text);
            _bloque.Hora_inicio = txthorainicio.Text;
            _bloque.Hora_fin = txthorafin.Text;

            Control_Bloques ctrl = new Control_Bloques();


            if (txtid.Text != "")
            {
                _bloque.Id = int.Parse(txtid.Text);
                bandera = ctrl.actualizar(_bloque);

            }
            else
            {
                bandera = ctrl.insertar(_bloque);

            }

            if (bandera)
            {
                MessageBox.Show("Registro del bloque guardado!!");
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
            txtnrobloque.Text = "";
            txtdia.Text = "";
            txthorainicio.Text = "";
            txthorafin.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtnrobloque.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtdia.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txthorainicio.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txthorafin.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            bool bandera = false;

            DialogResult resultado = MessageBox.Show("Estás seguro que deseas eliminar el registro?", "Salir",
                MessageBoxButtons.YesNoCancel);
            if (resultado == DialogResult.Yes)
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                Control_Bloques _ctrl = new Control_Bloques();
                bandera = _ctrl.eliminar(id);


                if (bandera)
                {
                    MessageBox.Show("Registro del bloque eliminado!!");
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
            VistaNiveles vn = new VistaNiveles();
            vn.Show();
            this.Visible = false;
        }

        private void btnguardar_Click_1(object sender, EventArgs e)
        {
            bool bandera = false;
            Bloque _bloque = new Bloque();
            _bloque.Numero_bloque = int.Parse(txtnrobloque.Text);
            _bloque.Dia = int.Parse(txtdia.Text);
            _bloque.Hora_inicio = txthorainicio.Text;
            _bloque.Hora_fin = txthorafin.Text;

            Control_Bloques ctrl = new Control_Bloques();


            if (txtid.Text != "")
            {
                _bloque.Id = int.Parse(txtid.Text);
                bandera = ctrl.actualizar(_bloque);

            }
            else
            {
                bandera = ctrl.insertar(_bloque);

            }

            if (bandera)
            {
                MessageBox.Show("Registro del bloque guardado!!");
                limpiar();
                cargarTabla(null);
            }
            else
            {
                MessageBox.Show("Registro no se pudo guardar :( ");
            }
        }

        private void btnbuscar_Click_1(object sender, EventArgs e)
        {
            string dato = txtcampo.Text;
            cargarTabla(dato);
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            VistaColegios vc = new VistaColegios();
            vc.Show();
            this.Visible = false;
        }
    }
}