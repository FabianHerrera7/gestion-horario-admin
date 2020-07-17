using MySql.Data.MySqlClient;
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
    public partial class VistaProfesores : Form
    {
        public VistaProfesores()
        {
            InitializeComponent();
            cargarTabla(null);
        }

        private void txtfechanac_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string dato = txtcampo.Text;
            cargarTabla(dato);
        }

        private void cargarTabla(string dato)
        {
            List<Profesor> lista = new List<Profesor>();
            Control_Profesores _ctrlProfesores = new Control_Profesores();
            dgProfesor.DataSource = _ctrlProfesores.consulta(dato);

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {


            bool bandera = false;
            Profesor _profesor = new Profesor();
            _profesor.Rut = txtrut.Text;
            _profesor.Nombre = txtnombre.Text;
            _profesor.Apellido_paterno = txtappat.Text;
            _profesor.Apellido_materno = txtapmat.Text;
            _profesor.Fecha_nacimiento = txtfechanac.Text;
            _profesor.Horas_contrato = txthorasaula.Text;
            _profesor.Horas_aula_maxima = txthorasnoaula.Text;
            _profesor.Horas_aula_efectiva = txthrstotales.Text;



            Control_Profesores ctrl = new Control_Profesores();




            if (txtid.Text != "")
            {
                _profesor.Id = int.Parse(txtid.Text);
                bandera = ctrl.actualizar(_profesor);

            }
            else
            {
                bandera = ctrl.insertar(_profesor);

            }

            if (bandera)
            {
                MessageBox.Show("Registro del profesor guardado!!");
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
            txtrut.Text = "";
            txtnombre.Text = "";
            txtappat.Text = "";
            txtapmat.Text = "";
            txtfechanac.Text = "";
            txthorasaula.Text = "";
            txthorasnoaula.Text = "";
            txthrstotales.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            txtid.Text = dgProfesor.CurrentRow.Cells[0].Value.ToString();
            txtrut.Text = dgProfesor.CurrentRow.Cells[1].Value.ToString();
            txtnombre.Text = dgProfesor.CurrentRow.Cells[2].Value.ToString();
            txtappat.Text = dgProfesor.CurrentRow.Cells[3].Value.ToString();
            txtapmat.Text = dgProfesor.CurrentRow.Cells[4].Value.ToString();
            txtfechanac.Text = dgProfesor.CurrentRow.Cells[5].Value.ToString();
            txthorasaula.Text = dgProfesor.CurrentRow.Cells[6].Value.ToString();
            txthorasnoaula.Text = dgProfesor.CurrentRow.Cells[7].Value.ToString();
            txthrstotales.Text = dgProfesor.CurrentRow.Cells[8].Value.ToString();

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            bool bandera = false;

            DialogResult resultado = MessageBox.Show("Estás seguro que deseas eliminar el registro?", "Salir",
                MessageBoxButtons.YesNoCancel);
            if (resultado == DialogResult.Yes)
            {
                int id = int.Parse(dgProfesor.CurrentRow.Cells[0].Value.ToString());
                Control_Profesores _ctrl = new Control_Profesores();
                bandera = _ctrl.eliminar(id);


                if (bandera)
                {
                    MessageBox.Show("Registro del profesor eliminado!!");
                    limpiar();
                    cargarTabla(null);
                }
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            //Asignaturas asig = new Asignaturas();
            //asig.Show();
            //Visible = false;
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {

        }

        private void txtcampo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnmodificar_Click_1(object sender, EventArgs e)
        {
            txtid.Text = dgProfesor.CurrentRow.Cells[0].Value.ToString();
            txtrut.Text = dgProfesor.CurrentRow.Cells[1].Value.ToString();
            txtnombre.Text = dgProfesor.CurrentRow.Cells[2].Value.ToString();
            txtappat.Text = dgProfesor.CurrentRow.Cells[3].Value.ToString();
            txtapmat.Text = dgProfesor.CurrentRow.Cells[4].Value.ToString();
            txtfechanac.Text = dgProfesor.CurrentRow.Cells[5].Value.ToString();
            txthorasaula.Text = dgProfesor.CurrentRow.Cells[6].Value.ToString();
            txthorasnoaula.Text = dgProfesor.CurrentRow.Cells[7].Value.ToString();
            txthrstotales.Text = dgProfesor.CurrentRow.Cells[8].Value.ToString();
        }

        private void Btnbuscar_Click_1(object sender, EventArgs e)
        {

            string dato = txtcampo.Text;
            cargarTabla(dato);
        }

        private void Btneliminar_Click_1(object sender, EventArgs e)
        {
            bool bandera = false;

            DialogResult resultado = MessageBox.Show("Estás seguro que deseas eliminar el registro?", "Salir",
                MessageBoxButtons.YesNoCancel);
            if (resultado == DialogResult.Yes)
            {
                int id = int.Parse(dgProfesor.CurrentRow.Cells[0].Value.ToString());
                Control_Profesores _ctrl = new Control_Profesores();
                bandera = _ctrl.eliminar(id);


                if (bandera)
                {
                    MessageBox.Show("Registro del profesor eliminado!!");
                    limpiar();
                    cargarTabla(null);
                }
            }
        }

        private void btnlimpiar_Click_1(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsiguiente_Click_1(object sender, EventArgs e)
        {
            VistaCurso_periodo vs = new VistaCurso_periodo();
            vs.Show();
            this.Visible = false;

            //VistaAsignaturas va = new VistaAsignaturas();
            //va.Show();
            //this.Visible = false;
        }
    }
}