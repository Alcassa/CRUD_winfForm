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
    public partial class MenuPrincipal : Form
    {
        public Boolean limiteDeLimitedeTelas = false;
        public Boolean limiteDeLimitedeTelas2 = false;
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void AdicionarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!limiteDeLimitedeTelas)
            {
                limiteDeLimitedeTelas = true;
                var adicionar = new Form1();
                adicionar.Show();
            }
            else
            {
                MessageBox.Show("Já existe uma janela em aberto");
            }

        }

        private void PesquisarCadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!limiteDeLimitedeTelas2)
            {
                limiteDeLimitedeTelas2 = true;
                var pesquisar = new Cadastros();
                pesquisar.Show();
            }
            else
            {
                MessageBox.Show("Já existe uma janela em aberto");
            }
        }
    }
}
