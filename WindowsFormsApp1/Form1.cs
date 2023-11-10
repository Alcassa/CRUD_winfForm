﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void musicaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.musicaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.musicaDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'musicaDataSet.Musica'. Você pode movê-la ou removê-la conforme necessário.
            this.musicaTableAdapter.Fill(this.musicaDataSet.Musica);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
         if(MessageBox.Show("Confirma exclusão", "Excluindo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                musicaBindingSource.RemoveCurrent();
            }   
        }
    }
}
