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
    public partial class LoginHesar : Form
    {
        public LoginHesar()
        {
            InitializeComponent();
        }

        


        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "USUARIO")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.Black;
            }

        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "CONTRASEÑA";
                txtpass.ForeColor = Color.Black;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "USUARIO";
                txtuser.ForeColor = Color.Black;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "CONTRASEÑA")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.Black;
                txtpass.UseSystemPasswordChar = true;
            }

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            //string cmd = string.Format("SELECT * FROM ")
            //MenuPrincipal menup = new MenuPrincipal();
            ////menup.Visible = true;
            //menup.Show();
            //Visible = false;

            string usuario = txtuser.Text;
            string password = txtpass.Text;

            try
            {
                CtrlUsuarios ctrl = new CtrlUsuarios();
                string respuesta = ctrl.ctrllogin(usuario, password);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    FrmRegistro reg = new FrmRegistro();
                    reg.Show();
                    Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }






        }


        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegistro reg = new FrmRegistro();
            reg.Show();
            this.Visible = false;
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

