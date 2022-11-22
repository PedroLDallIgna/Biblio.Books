namespace PI_2_Biblio.Books
{
    partial class Pedidos
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
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.btnAlterarPedidos = new System.Windows.Forms.Button();
            this.btnCadastrarPedidos = new System.Windows.Forms.Button();
            this.btnExcluirPedidos = new System.Windows.Forms.Button();
            this.btnConsultarPedidos = new System.Windows.Forms.Button();
            this.lbCPF = new System.Windows.Forms.Label();
            this.txCPF = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.txNomeLivro = new System.Windows.Forms.TextBox();
            this.lbIDLivro = new System.Windows.Forms.Label();
            this.txIDPedido = new System.Windows.Forms.TextBox();
            this.lbPedidosTitulo = new System.Windows.Forms.Label();
            this.lbNomeCliente = new System.Windows.Forms.Label();
            this.txNomeCPedidos = new System.Windows.Forms.TextBox();
            this.testDBDataSet = new PI_2_Biblio.Books.TestDBDataSet();
            this.pedidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidosTableAdapter = new PI_2_Biblio.Books.TestDBDataSetTableAdapters.PedidosTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idlivroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulolivroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.idlivroDataGridViewTextBoxColumn,
            this.nomeclienteDataGridViewTextBoxColumn,
            this.titulolivroDataGridViewTextBoxColumn,
            this.cpfclienteDataGridViewTextBoxColumn});
            this.dgvPedidos.DataSource = this.pedidosBindingSource;
            this.dgvPedidos.Location = new System.Drawing.Point(30, 307);
            this.dgvPedidos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowHeadersWidth = 51;
            this.dgvPedidos.RowTemplate.Height = 24;
            this.dgvPedidos.Size = new System.Drawing.Size(999, 332);
            this.dgvPedidos.TabIndex = 37;
            // 
            // btnAlterarPedidos
            // 
            this.btnAlterarPedidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlterarPedidos.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAlterarPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarPedidos.FlatAppearance.BorderSize = 0;
            this.btnAlterarPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarPedidos.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarPedidos.ForeColor = System.Drawing.Color.White;
            this.btnAlterarPedidos.Location = new System.Drawing.Point(1111, 275);
            this.btnAlterarPedidos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAlterarPedidos.Name = "btnAlterarPedidos";
            this.btnAlterarPedidos.Size = new System.Drawing.Size(82, 28);
            this.btnAlterarPedidos.TabIndex = 36;
            this.btnAlterarPedidos.Text = "Alterar";
            this.btnAlterarPedidos.UseVisualStyleBackColor = false;
            // 
            // btnCadastrarPedidos
            // 
            this.btnCadastrarPedidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrarPedidos.BackColor = System.Drawing.Color.Green;
            this.btnCadastrarPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarPedidos.FlatAppearance.BorderSize = 0;
            this.btnCadastrarPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarPedidos.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarPedidos.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarPedidos.Location = new System.Drawing.Point(1005, 275);
            this.btnCadastrarPedidos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCadastrarPedidos.Name = "btnCadastrarPedidos";
            this.btnCadastrarPedidos.Size = new System.Drawing.Size(94, 28);
            this.btnCadastrarPedidos.TabIndex = 35;
            this.btnCadastrarPedidos.Text = "Adicionar";
            this.btnCadastrarPedidos.UseVisualStyleBackColor = false;
            this.btnCadastrarPedidos.Click += new System.EventHandler(this.btnCadastrarPedidos_Click);
            // 
            // btnExcluirPedidos
            // 
            this.btnExcluirPedidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluirPedidos.BackColor = System.Drawing.Color.Brown;
            this.btnExcluirPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirPedidos.FlatAppearance.BorderSize = 0;
            this.btnExcluirPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirPedidos.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirPedidos.ForeColor = System.Drawing.Color.White;
            this.btnExcluirPedidos.Location = new System.Drawing.Point(910, 275);
            this.btnExcluirPedidos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExcluirPedidos.Name = "btnExcluirPedidos";
            this.btnExcluirPedidos.Size = new System.Drawing.Size(82, 28);
            this.btnExcluirPedidos.TabIndex = 34;
            this.btnExcluirPedidos.Text = "Excluir";
            this.btnExcluirPedidos.UseVisualStyleBackColor = false;
            // 
            // btnConsultarPedidos
            // 
            this.btnConsultarPedidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConsultarPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnConsultarPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarPedidos.FlatAppearance.BorderSize = 0;
            this.btnConsultarPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarPedidos.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarPedidos.ForeColor = System.Drawing.Color.White;
            this.btnConsultarPedidos.Location = new System.Drawing.Point(558, 159);
            this.btnConsultarPedidos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConsultarPedidos.Name = "btnConsultarPedidos";
            this.btnConsultarPedidos.Size = new System.Drawing.Size(122, 40);
            this.btnConsultarPedidos.TabIndex = 33;
            this.btnConsultarPedidos.Text = "Consultar";
            this.btnConsultarPedidos.UseVisualStyleBackColor = false;
            // 
            // lbCPF
            // 
            this.lbCPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCPF.AutoSize = true;
            this.lbCPF.BackColor = System.Drawing.Color.Transparent;
            this.lbCPF.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPF.Location = new System.Drawing.Point(631, 109);
            this.lbCPF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(51, 25);
            this.lbCPF.TabIndex = 28;
            this.lbCPF.Text = "CPF";
            this.lbCPF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txCPF
            // 
            this.txCPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txCPF.BackColor = System.Drawing.SystemColors.Menu;
            this.txCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txCPF.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCPF.Location = new System.Drawing.Point(685, 108);
            this.txCPF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txCPF.MaxLength = 11;
            this.txCPF.Name = "txCPF";
            this.txCPF.Size = new System.Drawing.Size(166, 29);
            this.txCPF.TabIndex = 27;
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
            this.lbNome.TabIndex = 26;
            this.lbNome.Text = "Titulo";
            this.lbNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txNomeLivro
            // 
            this.txNomeLivro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txNomeLivro.BackColor = System.Drawing.SystemColors.Menu;
            this.txNomeLivro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txNomeLivro.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNomeLivro.Location = new System.Drawing.Point(395, 109);
            this.txNomeLivro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txNomeLivro.Name = "txNomeLivro";
            this.txNomeLivro.Size = new System.Drawing.Size(166, 29);
            this.txNomeLivro.TabIndex = 25;
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
            this.lbIDLivro.TabIndex = 24;
            this.lbIDLivro.Text = "IDLivro";
            this.lbIDLivro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txIDPedido
            // 
            this.txIDPedido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txIDPedido.BackColor = System.Drawing.SystemColors.Menu;
            this.txIDPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txIDPedido.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txIDPedido.Location = new System.Drawing.Point(395, 67);
            this.txIDPedido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txIDPedido.MaxLength = 10;
            this.txIDPedido.Name = "txIDPedido";
            this.txIDPedido.Size = new System.Drawing.Size(166, 29);
            this.txIDPedido.TabIndex = 23;
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
            this.lbPedidosTitulo.Size = new System.Drawing.Size(92, 26);
            this.lbPedidosTitulo.TabIndex = 22;
            this.lbPedidosTitulo.Text = "Pedidos";
            // 
            // lbNomeCliente
            // 
            this.lbNomeCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNomeCliente.AutoSize = true;
            this.lbNomeCliente.BackColor = System.Drawing.Color.Transparent;
            this.lbNomeCliente.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeCliente.Location = new System.Drawing.Point(595, 68);
            this.lbNomeCliente.Margin = new System.Windows.Forms.Padding(0);
            this.lbNomeCliente.Name = "lbNomeCliente";
            this.lbNomeCliente.Size = new System.Drawing.Size(92, 25);
            this.lbNomeCliente.TabIndex = 39;
            this.lbNomeCliente.Text = "Nome C.";
            this.lbNomeCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txNomeCPedidos
            // 
            this.txNomeCPedidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txNomeCPedidos.BackColor = System.Drawing.SystemColors.Menu;
            this.txNomeCPedidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txNomeCPedidos.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNomeCPedidos.Location = new System.Drawing.Point(685, 67);
            this.txNomeCPedidos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txNomeCPedidos.MaxLength = 100;
            this.txNomeCPedidos.Name = "txNomeCPedidos";
            this.txNomeCPedidos.Size = new System.Drawing.Size(166, 29);
            this.txNomeCPedidos.TabIndex = 38;
            // 
            // testDBDataSet
            // 
            this.testDBDataSet.DataSetName = "TestDBDataSet";
            this.testDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pedidosBindingSource
            // 
            this.pedidosBindingSource.DataMember = "Pedidos";
            this.pedidosBindingSource.DataSource = this.testDBDataSet;
            // 
            // pedidosTableAdapter
            // 
            this.pedidosTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idlivroDataGridViewTextBoxColumn
            // 
            this.idlivroDataGridViewTextBoxColumn.DataPropertyName = "id_livro";
            this.idlivroDataGridViewTextBoxColumn.HeaderText = "id_livro";
            this.idlivroDataGridViewTextBoxColumn.Name = "idlivroDataGridViewTextBoxColumn";
            this.idlivroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeclienteDataGridViewTextBoxColumn
            // 
            this.nomeclienteDataGridViewTextBoxColumn.DataPropertyName = "nome_cliente";
            this.nomeclienteDataGridViewTextBoxColumn.HeaderText = "nome_cliente";
            this.nomeclienteDataGridViewTextBoxColumn.Name = "nomeclienteDataGridViewTextBoxColumn";
            this.nomeclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titulolivroDataGridViewTextBoxColumn
            // 
            this.titulolivroDataGridViewTextBoxColumn.DataPropertyName = "titulo_livro";
            this.titulolivroDataGridViewTextBoxColumn.HeaderText = "titulo_livro";
            this.titulolivroDataGridViewTextBoxColumn.Name = "titulolivroDataGridViewTextBoxColumn";
            this.titulolivroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cpfclienteDataGridViewTextBoxColumn
            // 
            this.cpfclienteDataGridViewTextBoxColumn.DataPropertyName = "cpf_cliente";
            this.cpfclienteDataGridViewTextBoxColumn.HeaderText = "cpf_cliente";
            this.cpfclienteDataGridViewTextBoxColumn.Name = "cpfclienteDataGridViewTextBoxColumn";
            this.cpfclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.lbNomeCliente);
            this.Controls.Add(this.txNomeCPedidos);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.btnAlterarPedidos);
            this.Controls.Add(this.btnCadastrarPedidos);
            this.Controls.Add(this.btnExcluirPedidos);
            this.Controls.Add(this.btnConsultarPedidos);
            this.Controls.Add(this.lbCPF);
            this.Controls.Add(this.txCPF);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.txNomeLivro);
            this.Controls.Add(this.lbIDLivro);
            this.Controls.Add(this.txIDPedido);
            this.Controls.Add(this.lbPedidosTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Pedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Pedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Button btnAlterarPedidos;
        private System.Windows.Forms.Button btnCadastrarPedidos;
        private System.Windows.Forms.Button btnExcluirPedidos;
        private System.Windows.Forms.Button btnConsultarPedidos;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.TextBox txCPF;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txNomeLivro;
        private System.Windows.Forms.Label lbIDLivro;
        private System.Windows.Forms.TextBox txIDPedido;
        private System.Windows.Forms.Label lbPedidosTitulo;
        private System.Windows.Forms.Label lbNomeCliente;
        private System.Windows.Forms.TextBox txNomeCPedidos;
        private TestDBDataSet testDBDataSet;
        private System.Windows.Forms.BindingSource pedidosBindingSource;
        private TestDBDataSetTableAdapters.PedidosTableAdapter pedidosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlivroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulolivroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfclienteDataGridViewTextBoxColumn;
    }
}