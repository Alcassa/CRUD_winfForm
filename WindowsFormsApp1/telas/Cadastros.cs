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
    public partial class Cadastros : Form
    {
        public Cadastros()
        {
            InitializeComponent();
        }

        private void musicaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.musicaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.musicaDataSet);

        }

        private void Cadastros_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'musicaDataSet.Musica'. Você pode movê-la ou removê-la conforme necessário.
            this.musicaTableAdapter.Fill(this.musicaDataSet.Musica);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFIltrar_Click(object sender, EventArgs e)
        {
            string vColuna, vTexto, vProcurar, vFiltro;

            vColuna = cmbColuna.Text;
            vProcurar = cmbProcurar.Text;
            vTexto = txtPor.Text;

            vFiltro = vColuna;

            if(vProcurar=="Que começa com")
            {
                vFiltro += "LIKE '" + vTexto + "%'";
            }
            else if (vProcurar == "Que contém")
            {
                vFiltro += "LIKE '%" + vTexto + "%'";
            }
            else if (vProcurar == "Que termina com")
            {
                vFiltro += "LIKE '%" + vTexto + "'";
            }
            else if (vProcurar == "Igual a")
            {
                vFiltro += "LIKE '" + vTexto + "'";
            }
            else
            {
                vFiltro = "";
            }

            musicaBindingSource.Filter = vFiltro;
        }
    }
}
