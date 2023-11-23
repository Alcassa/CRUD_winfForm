using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.telas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text.Equals("alcassa") && txtSenha.Text.Equals("123"))
                {
                    var menu = new MenuPrincipal();
                    this.Visible = false;
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("usuário ou senha incorreto",
                        "Desculpe",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Desculpe",
                ex.Message
                , MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } 
}
