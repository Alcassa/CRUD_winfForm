
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label artistaLabel;
            System.Windows.Forms.Label categoriaLabel;
            System.Windows.Forms.Label dataLancamentoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.musicaDataSet = new WindowsFormsApp1.MusicaDataSet();
            this.musicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musicaTableAdapter = new WindowsFormsApp1.MusicaDataSetTableAdapters.MusicaTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.MusicaDataSetTableAdapters.TableAdapterManager();
            this.musicaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.musicaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.artistaTextBox = new System.Windows.Forms.TextBox();
            this.categoriaTextBox = new System.Windows.Forms.TextBox();
            this.dataLancamentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            nomeLabel = new System.Windows.Forms.Label();
            artistaLabel = new System.Windows.Forms.Label();
            categoriaLabel = new System.Windows.Forms.Label();
            dataLancamentoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.musicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicaBindingNavigator)).BeginInit();
            this.musicaBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(237, 170);
            nomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome:";
            // 
            // artistaLabel
            // 
            artistaLabel.AutoSize = true;
            artistaLabel.Location = new System.Drawing.Point(237, 190);
            artistaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            artistaLabel.Name = "artistaLabel";
            artistaLabel.Size = new System.Drawing.Size(39, 13);
            artistaLabel.TabIndex = 5;
            artistaLabel.Text = "Artista:";
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Location = new System.Drawing.Point(237, 211);
            categoriaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new System.Drawing.Size(55, 13);
            categoriaLabel.TabIndex = 7;
            categoriaLabel.Text = "Categoria:";
            // 
            // dataLancamentoLabel
            // 
            dataLancamentoLabel.AutoSize = true;
            dataLancamentoLabel.Location = new System.Drawing.Point(237, 233);
            dataLancamentoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dataLancamentoLabel.Name = "dataLancamentoLabel";
            dataLancamentoLabel.Size = new System.Drawing.Size(95, 13);
            dataLancamentoLabel.TabIndex = 9;
            dataLancamentoLabel.Text = "Data Lancamento:";
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
            // musicaBindingNavigator
            // 
            this.musicaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.musicaBindingNavigator.BindingSource = this.musicaBindingSource;
            this.musicaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.musicaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.musicaBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.musicaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.musicaBindingNavigatorSaveItem});
            this.musicaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.musicaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.musicaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.musicaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.musicaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.musicaBindingNavigator.Name = "musicaBindingNavigator";
            this.musicaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.musicaBindingNavigator.Size = new System.Drawing.Size(744, 31);
            this.musicaBindingNavigator.TabIndex = 0;
            this.musicaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 28);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(35, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // musicaBindingNavigatorSaveItem
            // 
            this.musicaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.musicaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("musicaBindingNavigatorSaveItem.Image")));
            this.musicaBindingNavigatorSaveItem.Name = "musicaBindingNavigatorSaveItem";
            this.musicaBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.musicaBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.musicaBindingNavigatorSaveItem.Click += new System.EventHandler(this.musicaBindingNavigatorSaveItem_Click);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.musicaBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(335, 168);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(135, 20);
            this.nomeTextBox.TabIndex = 4;
            // 
            // artistaTextBox
            // 
            this.artistaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.musicaBindingSource, "Artista", true));
            this.artistaTextBox.Location = new System.Drawing.Point(335, 188);
            this.artistaTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.artistaTextBox.Name = "artistaTextBox";
            this.artistaTextBox.Size = new System.Drawing.Size(135, 20);
            this.artistaTextBox.TabIndex = 6;
            // 
            // categoriaTextBox
            // 
            this.categoriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.musicaBindingSource, "Categoria", true));
            this.categoriaTextBox.Location = new System.Drawing.Point(335, 209);
            this.categoriaTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.categoriaTextBox.Name = "categoriaTextBox";
            this.categoriaTextBox.Size = new System.Drawing.Size(135, 20);
            this.categoriaTextBox.TabIndex = 8;
            // 
            // dataLancamentoDateTimePicker
            // 
            this.dataLancamentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.musicaBindingSource, "DataLancamento", true));
            this.dataLancamentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataLancamentoDateTimePicker.Location = new System.Drawing.Point(335, 230);
            this.dataLancamentoDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataLancamentoDateTimePicker.Name = "dataLancamentoDateTimePicker";
            this.dataLancamentoDateTimePicker.Size = new System.Drawing.Size(135, 20);
            this.dataLancamentoDateTimePicker.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 340);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(artistaLabel);
            this.Controls.Add(this.artistaTextBox);
            this.Controls.Add(categoriaLabel);
            this.Controls.Add(this.categoriaTextBox);
            this.Controls.Add(dataLancamentoLabel);
            this.Controls.Add(this.dataLancamentoDateTimePicker);
            this.Controls.Add(this.musicaBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicaBindingNavigator)).EndInit();
            this.musicaBindingNavigator.ResumeLayout(false);
            this.musicaBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MusicaDataSet musicaDataSet;
        private System.Windows.Forms.BindingSource musicaBindingSource;
        private MusicaDataSetTableAdapters.MusicaTableAdapter musicaTableAdapter;
        private MusicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator musicaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton musicaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox artistaTextBox;
        private System.Windows.Forms.TextBox categoriaTextBox;
        private System.Windows.Forms.DateTimePicker dataLancamentoDateTimePicker;
    }
}

