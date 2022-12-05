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
            this.biblioBooksDataSet = new PI_2_Biblio.Books.BiblioBooksDataSet();
            this.ordersTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableTableAdapter = new PI_2_Biblio.Books.BiblioBooksDataSetTableAdapters.OrdersTableTableAdapter();
            this.gpFilter = new System.Windows.Forms.GroupBox();
            this.rdBook = new System.Windows.Forms.RadioButton();
            this.rdCpf = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblioBooksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTableBindingSource)).BeginInit();
            this.gpFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPedidos.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(94, 347);
            this.dgvPedidos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowHeadersWidth = 51;
            this.dgvPedidos.RowTemplate.Height = 24;
            this.dgvPedidos.Size = new System.Drawing.Size(999, 224);
            this.dgvPedidos.TabIndex = 37;
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
            this.btnCadastrarPedidos.Location = new System.Drawing.Point(1002, 311);
            this.btnCadastrarPedidos.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnExcluirPedidos.Location = new System.Drawing.Point(907, 311);
            this.btnExcluirPedidos.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnConsultarPedidos.Location = new System.Drawing.Point(534, 207);
            this.btnConsultarPedidos.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultarPedidos.Name = "btnConsultarPedidos";
            this.btnConsultarPedidos.Size = new System.Drawing.Size(122, 40);
            this.btnConsultarPedidos.TabIndex = 33;
            this.btnConsultarPedidos.Text = "Consultar";
            this.btnConsultarPedidos.UseVisualStyleBackColor = false;
            this.btnConsultarPedidos.Click += new System.EventHandler(this.btnConsultarPedidos_Click);
            // 
            // lbCPF
            // 
            this.lbCPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCPF.AutoSize = true;
            this.lbCPF.BackColor = System.Drawing.Color.Transparent;
            this.lbCPF.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPF.Location = new System.Drawing.Point(607, 157);
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
            this.txCPF.Location = new System.Drawing.Point(661, 156);
            this.txCPF.Margin = new System.Windows.Forms.Padding(2);
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
            this.lbNome.Location = new System.Drawing.Point(306, 158);
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
            this.txNomeLivro.Location = new System.Drawing.Point(371, 157);
            this.txNomeLivro.Margin = new System.Windows.Forms.Padding(2);
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
            this.lbIDLivro.Location = new System.Drawing.Point(290, 116);
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
            this.txIDPedido.Location = new System.Drawing.Point(371, 115);
            this.txIDPedido.Margin = new System.Windows.Forms.Padding(2);
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
            this.lbPedidosTitulo.Location = new System.Drawing.Point(547, 45);
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
            this.lbNomeCliente.Location = new System.Drawing.Point(571, 116);
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
            this.txNomeCPedidos.Location = new System.Drawing.Point(661, 115);
            this.txNomeCPedidos.Margin = new System.Windows.Forms.Padding(2);
            this.txNomeCPedidos.MaxLength = 100;
            this.txNomeCPedidos.Name = "txNomeCPedidos";
            this.txNomeCPedidos.Size = new System.Drawing.Size(166, 29);
            this.txNomeCPedidos.TabIndex = 38;
            // 
            // biblioBooksDataSet
            // 
            this.biblioBooksDataSet.DataSetName = "BiblioBooksDataSet";
            this.biblioBooksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableBindingSource
            // 
            this.ordersTableBindingSource.DataMember = "OrdersTable";
            this.ordersTableBindingSource.DataSource = this.biblioBooksDataSet;
            // 
            // ordersTableTableAdapter
            // 
            this.ordersTableTableAdapter.ClearBeforeFill = true;
            // 
            // gpFilter
            // 
            this.gpFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gpFilter.Controls.Add(this.rdBook);
            this.gpFilter.Controls.Add(this.rdCpf);
            this.gpFilter.Location = new System.Drawing.Point(899, 111);
            this.gpFilter.Name = "gpFilter";
            this.gpFilter.Size = new System.Drawing.Size(200, 100);
            this.gpFilter.TabIndex = 40;
            this.gpFilter.TabStop = false;
            this.gpFilter.Text = "Consultar por";
            // 
            // rdBook
            // 
            this.rdBook.AutoSize = true;
            this.rdBook.Location = new System.Drawing.Point(23, 60);
            this.rdBook.Name = "rdBook";
            this.rdBook.Size = new System.Drawing.Size(68, 17);
            this.rdBook.TabIndex = 1;
            this.rdBook.Text = "Livro (ID)";
            this.rdBook.UseVisualStyleBackColor = true;
            // 
            // rdCpf
            // 
            this.rdCpf.AutoSize = true;
            this.rdCpf.Checked = true;
            this.rdCpf.Location = new System.Drawing.Point(23, 37);
            this.rdCpf.Name = "rdCpf";
            this.rdCpf.Size = new System.Drawing.Size(45, 17);
            this.rdCpf.TabIndex = 0;
            this.rdCpf.TabStop = true;
            this.rdCpf.Text = "CPF";
            this.rdCpf.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button1.Location = new System.Drawing.Point(95, 304);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 36);
            this.button1.TabIndex = 41;
            this.button1.Text = "Limpar Filtro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1206, 590);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gpFilter);
            this.Controls.Add(this.lbNomeCliente);
            this.Controls.Add(this.txNomeCPedidos);
            this.Controls.Add(this.dgvPedidos);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Pedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Pedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblioBooksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTableBindingSource)).EndInit();
            this.gpFilter.ResumeLayout(false);
            this.gpFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedidos;
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
        private BiblioBooksDataSet biblioBooksDataSet;
        private System.Windows.Forms.BindingSource ordersTableBindingSource;
        private BiblioBooksDataSetTableAdapters.OrdersTableTableAdapter ordersTableTableAdapter;
        private System.Windows.Forms.GroupBox gpFilter;
        private System.Windows.Forms.RadioButton rdBook;
        private System.Windows.Forms.RadioButton rdCpf;
        private System.Windows.Forms.Button button1;
    }
}