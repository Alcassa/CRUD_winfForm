namespace WindowsFormsApp1.telas
{
    partial class MenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarCadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(822, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarCadastroToolStripMenuItem,
            this.pesquisarCadastrosToolStripMenuItem,
            this.relatórioToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 22);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // adicionarCadastroToolStripMenuItem
            // 
            this.adicionarCadastroToolStripMenuItem.Name = "adicionarCadastroToolStripMenuItem";
            this.adicionarCadastroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adicionarCadastroToolStripMenuItem.Text = "Adicionar cadastro";
            this.adicionarCadastroToolStripMenuItem.Click += new System.EventHandler(this.AdicionarCadastroToolStripMenuItem_Click);
            // 
            // pesquisarCadastrosToolStripMenuItem
            // 
            this.pesquisarCadastrosToolStripMenuItem.Name = "pesquisarCadastrosToolStripMenuItem";
            this.pesquisarCadastrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pesquisarCadastrosToolStripMenuItem.Text = "Pesquisar cadastros";
            this.pesquisarCadastrosToolStripMenuItem.Click += new System.EventHandler(this.PesquisarCadastrosToolStripMenuItem_Click);
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.relatórioToolStripMenuItem.Text = "Relatório";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 399);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarCadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarCadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
    }
}