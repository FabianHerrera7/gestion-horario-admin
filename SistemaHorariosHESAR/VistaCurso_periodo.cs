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
    public partial class VistaCurso_periodo : Form
    {
        public VistaCurso_periodo()
        {
            InitializeComponent();

            

            

            //MyObject newItem = (MyObject)listbox.SelectedItem;
        }


        private void btnagregar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(txtcampo.Text);
            txtcampo.Text = "";
            txtcampo.Focus();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            foreach (object obj in listBox1.SelectedItems)
            {
                MessageBox.Show(obj.ToString());
            }
        }


        private void MoverItemsLista(ListBox source, ListBox destination)
        {
            ListBox.SelectedObjectCollection sourceItems = source.SelectedItems;
            foreach (var item in sourceItems)
            {
                destination.Items.Add(item);
            }
            while (source.SelectedItems.Count > 0)
            {
                source.Items.Remove(source.SelectedItems[0]);
            }
        }

        private void btnder_Click(object sender, EventArgs e)
        {
            MoverItemsLista(listBox1, listBox2);
        }

        private void btnizq_Click(object sender, EventArgs e)
        {
            MoverItemsLista(listBox2, listBox1);
        }

        private void VistaCurso_periodo_Load(object sender, EventArgs e)
        {
            List<Curso> lista = new List<Curso>();
            Control_Cursos _ctrlCursos = new Control_Cursos();
            listBox1.DataSource=_ctrlCursos.consulta(null);
            listBox1.DisplayMember = "codigoCurso";
            listBox1.ValueMember = "id";
        }
    }
}
