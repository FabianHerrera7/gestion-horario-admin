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
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
            cargartipousuarios();

        }



        private void btnregistrar_Click(object sender, EventArgs e)
        {
            

            Usuario usuario = new Usuario();
            usuario.Alias = txtusuario.Text;
            usuario.Password = txtpassword.Text;
            usuario.Conpassword = txtconpassword.Text;
            usuario.Email = txtmail.Text;



            int idtu = int.Parse(cbxtipousu.SelectedValue.ToString());

            try
            {
                //if (cbxtipousu.DisplayMember == "administrador") { 

                

                CtrlUsuarios controlador = new CtrlUsuarios();
                string respuesta = controlador.ctrlregistro(usuario);

                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Usuario registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }





            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            LoginHesar login = new LoginHesar();
            login.Show();
            Visible = false;
        }

        private void cargartipousuarios()
        {
            cbxtipousu.DataSource = null;
            cbxtipousu.Items.Clear();
            string sql = "SELECT id, descripcion FROM rol ORDER BY descripcion ASC";


            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                MySqlDataAdapter data = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                data.Fill(dt);

                cbxtipousu.ValueMember = "id";
                cbxtipousu.DisplayMember = "descripcion";
                cbxtipousu.DataSource = dt;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar categorías" + ex.Message);

            }
            finally
            {
                conexion.Close();
            }
        }
    }
}

