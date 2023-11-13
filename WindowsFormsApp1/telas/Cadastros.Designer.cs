
namespace WindowsFormsApp1.telas
{
    partial class Cadastros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.musicaDataSet = new WindowsFormsApp1.MusicaDataSet();
            this.musicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musicaTableAdapter = new WindowsFormsApp1.MusicaDataSetTableAdapters.MusicaTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.MusicaDataSetTableAdapters.TableAdapterManager();
            this.musicaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFIltrar = new System.Windows.Forms.Button();
            this.cmbColuna = new System.Windows.Forms.ComboBox();
            this.cmbProcurar = new System.Windows.Forms.ComboBox();
            this.txtPor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.musicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // musicaDataSet
            // 
            this.musicaDataSet.DataSetName = "MusicaDataSet";
            this.musicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musicaBindingSource
            // 
            this.musicaBindingSource.DataMember = "Musica";
            this.musicaBindingSource.DataSource = this.musicaDataSet;
            // 
            // musicaTableAdapter
            // 
            this.musicaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MusicaTableAdapter = this.musicaTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.MusicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // musicaDataGridView
            // 
            this.musicaDataGridView.AutoGenerateColumns = false;
            this.musicaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.musicaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.musicaDataGridView.DataSource = this.musicaBindingSource;
            this.musicaDataGridView.Location = new System.Drawing.Point(52, 183);
            this.musicaDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.musicaDataGridView.Name = "musicaDataGridView";
            this.musicaDataGridView.RowHeadersWidth = 62;
            this.musicaDataGridView.RowTemplate.Height = 28;
            this.musicaDataGridView.Size = new System.Drawing.Size(543, 143);
            this.musicaDataGridView.TabIndex = 1;
            this.musicaDataGridView.VisibleChanged += new System.EventHandler(this.btnFIltrar_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Artista";
            this.dataGridViewTextBoxColumn3.HeaderText = "Artista";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Categoria";
            this.dataGridViewTextBoxColumn4.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DataLancamento";
            this.dataGridViewTextBoxColumn5.HeaderText = "DataLancamento";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // btnFIltrar
            // 
            this.btnFIltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFIltrar.Location = new System.Drawing.Point(529, 17);
            this.btnFIltrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFIltrar.Name = "btnFIltrar";
            this.btnFIltrar.Size = new System.Drawing.Size(85, 37);
            this.btnFIltrar.TabIndex = 2;
            this.btnFIltrar.Text = "Filtrar";
            this.btnFIltrar.UseVisualStyleBackColor = true;
            this.btnFIltrar.Click += new System.EventHandler(this.btnFIltrar_Click);
            // 
            // cmbColuna
            // 
            this.cmbColuna.FormattingEnabled = true;
            this.cmbColuna.Items.AddRange(new object[] {
            "Id",
            "Nome",
            "Artista",
            "Categoria",
            "DataLancamento"});
            this.cmbColuna.Location = new System.Drawing.Point(39, 27);
            this.cmbColuna.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbColuna.Name = "cmbColuna";
            this.cmbColuna.Size = new System.Drawing.Size(129, 21);
            this.cmbColuna.TabIndex = 3;
            // 
            // cmbProcurar
            // 
            this.cmbProcurar.FormattingEnabled = true;
            this.cmbProcurar.Items.AddRange(new object[] {
            "Todos",
            "Igual a",
            "Que começa com",
            "Que contém",
            "Que termina com"});
            this.cmbProcurar.Location = new System.Drawing.Point(201, 27);
            this.cmbProcurar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbProcurar.Name = "cmbProcurar";
            this.cmbProcurar.Size = new System.Drawing.Size(128, 21);
            this.cmbProcurar.TabIndex = 4;
            // 
            // txtPor
            // 
            this.txtPor.Location = new System.Drawing.Point(374, 27);
            this.txtPor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPor.Name = "txtPor";
            this.txtPor.Size = new System.Drawing.Size(125, 20);
            this.txtPor.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Coluna";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Procurar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Por";
            // 
            // Cadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 351);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPor);
            this.Controls.Add(this.cmbProcurar);
            this.Controls.Add(this.cmbColuna);
            this.Controls.Add(this.btnFIltrar);
            this.Controls.Add(this.musicaDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Cadastros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastros";
            this.Load += new System.EventHandler(this.Cadastros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MusicaDataSet musicaDataSet;
        private System.Windows.Forms.BindingSource musicaBindingSource;
        private MusicaDataSetTableAdapters.MusicaTableAdapter musicaTableAdapter;
        private MusicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView musicaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnFIltrar;
        private System.Windows.Forms.ComboBox cmbColuna;
        private System.Windows.Forms.ComboBox cmbProcurar;
        private System.Windows.Forms.TextBox txtPor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}