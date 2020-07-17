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
    public partial class VistaPeriodos : Form
    {
        public VistaPeriodos()
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
            List<Periodo> lista = new List<Periodo>();
            Control_Periodo _ctrlPeriodos = new Control_Periodo();
            dataGridView1.DataSource = _ctrlPeriodos.consulta(dato);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            Periodo _periodo = new Periodo();
            _periodo.Ano_escolar = int.Parse(txtano.Text);


            Control_Periodo ctrl = new Control_Periodo();


            if (txtid.Text != "")
            {
                _periodo.Id = int.Parse(txtid.Text);
                bandera = ctrl.actualizar(_periodo);

            }
            else
            {
                bandera = ctrl.insertar(_periodo);

            }

            if (bandera)
            {
                MessageBox.Show("Registro del periodo guardado!!");
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
            txtano.Text = "";

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtano.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            bool bandera = false;

            DialogResult resultado = MessageBox.Show("Estás seguro que deseas eliminar el registro?", "Salir",
                MessageBoxButtons.YesNoCancel);
            if (resultado == DialogResult.Yes)
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                Control_Periodo _ctrl = new Control_Periodo();
                bandera = _ctrl.eliminar(id);


                if (bandera)
                {
                    MessageBox.Show("Registro del periodo eliminado!!");
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
