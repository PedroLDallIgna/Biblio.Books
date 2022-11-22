namespace PI_2_Biblio.Books
{
    partial class Estoque
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
            this.lbNomeCliente = new System.Windows.Forms.Label();
            this.txAutorEstoque = new System.Windows.Forms.TextBox();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.btnAlterarEstoque = new System.Windows.Forms.Button();
            this.btnAddLivro = new System.Windows.Forms.Button();
            this.btnExcluirEstoque = new System.Windows.Forms.Button();
            this.btnConsultarEstoque = new System.Windows.Forms.Button();
            this.lbCPF = new System.Windows.Forms.Label();
            this.txEditoraEstoque = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.txTituloEstoque = new System.Windows.Forms.TextBox();
            this.lbIDLivro = new System.Windows.Forms.Label();
            this.txIDEstoque = new System.Windows.Forms.TextBox();
            this.lbPedidosTitulo = new System.Windows.Forms.Label();
            this.testDBDataSet = new PI_2_Biblio.Books.TestDBDataSet();
            this.livrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.livrosTableAdapter = new PI_2_Biblio.Books.TestDBDataSetTableAdapters.LivrosTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNomeCliente
            // 
            this.lbNomeCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNomeCliente.AutoSize = true;
            this.lbNomeCliente.BackColor = System.Drawing.Color.Transparent;
            this.lbNomeCliente.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeCliente.Location = new System.Drawing.Point(621, 68);
            this.lbNomeCliente.Margin = new System.Windows.Forms.Padding(0);
            this.lbNomeCliente.Name = "lbNomeCliente";
            this.lbNomeCliente.Size = new System.Drawing.Size(63, 25);
            this.lbNomeCliente.TabIndex = 53;
            this.lbNomeCliente.Text = "Autor";
            this.lbNomeCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txAutorEstoque
            // 
            this.txAutorEstoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txAutorEstoque.BackColor = System.Drawing.SystemColors.Menu;
            this.txAutorEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txAutorEstoque.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txAutorEstoque.Location = new System.Drawing.Point(685, 67);
            this.txAutorEstoque.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txAutorEstoque.MaxLength = 100;
            this.txAutorEstoque.Name = "txAutorEstoque";
            this.txAutorEstoque.Size = new System.Drawing.Size(166, 29);
            this.txAutorEstoque.TabIndex = 52;
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPedidos.AutoGenerateColumns = false;
            this.dgvPedidos.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.autorDataGridViewTextBoxColumn,
            this.editoraDataGridViewTextBoxColumn});
            this.dgvPedidos.DataSource = this.livrosBindingSource;
            this.dgvPedidos.Location = new System.Drawing.Point(11, 307);
            this.dgvPedidos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowHeadersWidth = 51;
            this.dgvPedidos.RowTemplate.Height = 24;
            this.dgvPedidos.Size = new System.Drawing.Size(1025, 322);
            this.dgvPedidos.TabIndex = 51;
            // 
            // btnAlterarEstoque
            // 
            this.btnAlterarEstoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlterarEstoque.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAlterarEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarEstoque.FlatAppearance.BorderSize = 0;
            this.btnAlterarEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarEstoque.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarEstoque.ForeColor = System.Drawing.Color.White;
            this.btnAlterarEstoque.Location = new System.Drawing.Point(1111, 275);
            this.btnAlterarEstoque.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAlterarEstoque.Name = "btnAlterarEstoque";
            this.btnAlterarEstoque.Size = new System.Drawing.Size(82, 28);
            this.btnAlterarEstoque.TabIndex = 50;
            this.btnAlterarEstoque.Text = "Alterar";
            this.btnAlterarEstoque.UseVisualStyleBackColor = false;
            this.btnAlterarEstoque.Click += new System.EventHandler(this.btnAlterarEstoque_Click);
            // 
            // btnAddLivro
            // 
            this.btnAddLivro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddLivro.BackColor = System.Drawing.Color.Green;
            this.btnAddLivro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddLivro.FlatAppearance.BorderSize = 0;
            this.btnAddLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLivro.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLivro.ForeColor = System.Drawing.Color.White;
            this.btnAddLivro.Location = new System.Drawing.Point(991, 275);
            this.btnAddLivro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddLivro.Name = "btnAddLivro";
            this.btnAddLivro.Size = new System.Drawing.Size(108, 28);
            this.btnAddLivro.TabIndex = 49;
            this.btnAddLivro.Text = "Add Livro";
            this.btnAddLivro.UseVisualStyleBackColor = false;
            this.btnAddLivro.Click += new System.EventHandler(this.btnAddLivro_Click);
            // 
            // btnExcluirEstoque
            // 
            this.btnExcluirEstoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluirEstoque.BackColor = System.Drawing.Color.Brown;
            this.btnExcluirEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirEstoque.FlatAppearance.BorderSize = 0;
            this.btnExcluirEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirEstoque.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirEstoque.ForeColor = System.Drawing.Color.White;
            this.btnExcluirEstoque.Location = new System.Drawing.Point(897, 275);
            this.btnExcluirEstoque.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExcluirEstoque.Name = "btnExcluirEstoque";
            this.btnExcluirEstoque.Size = new System.Drawing.Size(82, 28);
            this.btnExcluirEstoque.TabIndex = 48;
            this.btnExcluirEstoque.Text = "Excluir";
            this.btnExcluirEstoque.UseVisualStyleBackColor = false;
            this.btnExcluirEstoque.Click += new System.EventHandler(this.btnExcluirEstoque_Click);
            // 
            // btnConsultarEstoque
            // 
            this.btnConsultarEstoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConsultarEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnConsultarEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarEstoque.FlatAppearance.BorderSize = 0;
            this.btnConsultarEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarEstoque.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarEstoque.ForeColor = System.Drawing.Color.White;
            this.btnConsultarEstoque.Location = new System.Drawing.Point(558, 159);
            this.btnConsultarEstoque.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConsultarEstoque.Name = "btnConsultarEstoque";
            this.btnConsultarEstoque.Size = new System.Drawing.Size(122, 40);
            this.btnConsultarEstoque.TabIndex = 47;
            this.btnConsultarEstoque.Text = "Consultar";
            this.btnConsultarEstoque.UseVisualStyleBackColor = false;
            this.btnConsultarEstoque.Click += new System.EventHandler(this.btnConsultarEstoque_Click);
            // 
            // lbCPF
            // 
            this.lbCPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCPF.AutoSize = true;
            this.lbCPF.BackColor = System.Drawing.Color.Transparent;
            this.lbCPF.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPF.Location = new System.Drawing.Point(608, 110);
            this.lbCPF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(76, 25);
            this.lbCPF.TabIndex = 46;
            this.lbCPF.Text = "Editora";
            this.lbCPF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txEditoraEstoque
            // 
            this.txEditoraEstoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txEditoraEstoque.BackColor = System.Drawing.SystemColors.Menu;
            this.txEditoraEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txEditoraEstoque.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txEditoraEstoque.Location = new System.Drawing.Point(685, 108);
            this.txEditoraEstoque.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txEditoraEstoque.MaxLength = 11;
            this.txEditoraEstoque.Name = "txEditoraEstoque";
            this.txEditoraEstoque.Size = new System.Drawing.Size(166, 29);
            this.txEditoraEstoque.TabIndex = 45;
            // 
            // lbNome
            // 
            this.lbNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNome.AutoSize = true;
            this.lbNome.BackColor = System.Drawing.Color.Transparent;
            this.lbNome.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(330, 110);
            this.lbNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(65, 25);
            this.lbNome.TabIndex = 44;
            this.lbNome.Text = "Titulo";
            this.lbNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txTituloEstoque
            // 
            this.txTituloEstoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txTituloEstoque.BackColor = System.Drawing.SystemColors.Menu;
            this.txTituloEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txTituloEstoque.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTituloEstoque.Location = new System.Drawing.Point(395, 109);
            this.txTituloEstoque.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txTituloEstoque.Name = "txTituloEstoque";
            this.txTituloEstoque.Size = new System.Drawing.Size(166, 29);
            this.txTituloEstoque.TabIndex = 43;
            // 
            // lbIDLivro
            // 
            this.lbIDLivro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbIDLivro.AutoSize = true;
            this.lbIDLivro.BackColor = System.Drawing.Color.Transparent;
            this.lbIDLivro.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDLivro.Location = new System.Drawing.Point(314, 68);
            this.lbIDLivro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIDLivro.Name = "lbIDLivro";
            this.lbIDLivro.Size = new System.Drawing.Size(81, 25);
            this.lbIDLivro.TabIndex = 42;
            this.lbIDLivro.Text = "IDLivro";
            this.lbIDLivro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txIDEstoque
            // 
            this.txIDEstoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txIDEstoque.BackColor = System.Drawing.SystemColors.Menu;
            this.txIDEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txIDEstoque.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txIDEstoque.Location = new System.Drawing.Point(395, 67);
            this.txIDEstoque.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txIDEstoque.MaxLength = 10;
            this.txIDEstoque.Name = "txIDEstoque";
            this.txIDEstoque.Size = new System.Drawing.Size(166, 29);
            this.txIDEstoque.TabIndex = 41;
            // 
            // lbPedidosTitulo
            // 
            this.lbPedidosTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPedidosTitulo.AutoSize = true;
            this.lbPedidosTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbPedidosTitulo.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPedidosTitulo.Location = new System.Drawing.Point(566, 9);
            this.lbPedidosTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPedidosTitulo.Name = "lbPedidosTitulo";
            this.lbPedidosTitulo.Size = new System.Drawing.Size(94, 26);
            this.lbPedidosTitulo.TabIndex = 40;
            this.lbPedidosTitulo.Text = "Estoque";
            // 
            // testDBDataSet
            // 
            this.testDBDataSet.DataSetName = "TestDBDataSet";
            this.testDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // livrosBindingSource
            // 
            this.livrosBindingSource.DataMember = "Livros";
            this.livrosBindingSource.DataSource = this.testDBDataSet;
            // 
            // livrosTableAdapter
            // 
            this.livrosTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // autorDataGridViewTextBoxColumn
            // 
            this.autorDataGridViewTextBoxColumn.DataPropertyName = "autor";
            this.autorDataGridViewTextBoxColumn.HeaderText = "autor";
            this.autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            this.autorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // editoraDataGridViewTextBoxColumn
            // 
            this.editoraDataGridViewTextBoxColumn.DataPropertyName = "editora";
            this.editoraDataGridViewTextBoxColumn.HeaderText = "editora";
            this.editoraDataGridViewTextBoxColumn.Name = "editoraDataGridViewTextBoxColumn";
            this.editoraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.lbNomeCliente);
            this.Controls.Add(this.txAutorEstoque);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.btnAlterarEstoque);
            this.Controls.Add(this.btnAddLivro);
            this.Controls.Add(this.btnExcluirEstoque);
            this.Controls.Add(this.btnConsultarEstoque);
            this.Controls.Add(this.lbCPF);
            this.Controls.Add(this.txEditoraEstoque);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.txTituloEstoque);
            this.Controls.Add(this.lbIDLivro);
            this.Controls.Add(this.txIDEstoque);
            this.Controls.Add(this.lbPedidosTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Estoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Estoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNomeCliente;
        private System.Windows.Forms.TextBox txAutorEstoque;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Button btnAlterarEstoque;
        private System.Windows.Forms.Button btnAddLivro;
        private System.Windows.Forms.Button btnExcluirEstoque;
        private System.Windows.Forms.Button btnConsultarEstoque;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.TextBox txEditoraEstoque;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txTituloEstoque;
        private System.Windows.Forms.Label lbIDLivro;
        private System.Windows.Forms.TextBox txIDEstoque;
        private System.Windows.Forms.Label lbPedidosTitulo;
        private TestDBDataSet testDBDataSet;
        private System.Windows.Forms.BindingSource livrosBindingSource;
        private TestDBDataSetTableAdapters.LivrosTableAdapter livrosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editoraDataGridViewTextBoxColumn;
    }
}