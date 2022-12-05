namespace PI_2_Biblio.Books
{
    partial class Clientes
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
            this.txID = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.txNome = new System.Windows.Forms.TextBox();
            this.lbCPF = new System.Windows.Forms.Label();
            this.txCPF = new System.Windows.Forms.TextBox();
            this.lbClientesTitulo = new System.Windows.Forms.Label();
            this.lbFone = new System.Windows.Forms.Label();
            this.txEndereco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.btnConsultarClientes = new System.Windows.Forms.Button();
            this.btnExcluirClientes = new System.Windows.Forms.Button();
            this.btnCadastrarClientes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientCpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.biblioBooksDataSet = new PI_2_Biblio.Books.BiblioBooksDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCidades = new System.Windows.Forms.ComboBox();
            this.clientsTableTableAdapter = new PI_2_Biblio.Books.BiblioBooksDataSetTableAdapters.ClientsTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblioBooksDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txID
            // 
            this.txID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txID.BackColor = System.Drawing.SystemColors.Menu;
            this.txID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txID.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txID.Location = new System.Drawing.Point(341, 79);
            this.txID.Margin = new System.Windows.Forms.Padding(2);
            this.txID.MaxLength = 6;
            this.txID.Name = "txID";
            this.txID.Size = new System.Drawing.Size(166, 29);
            this.txID.TabIndex = 6;
            // 
            // lbID
            // 
            this.lbID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbID.AutoSize = true;
            this.lbID.BackColor = System.Drawing.Color.Transparent;
            this.lbID.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(304, 80);
            this.lbID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(34, 25);
            this.lbID.TabIndex = 7;
            this.lbID.Text = "ID";
            this.lbID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNome
            // 
            this.lbNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNome.AutoSize = true;
            this.lbNome.BackColor = System.Drawing.Color.Transparent;
            this.lbNome.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(566, 80);
            this.lbNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(65, 25);
            this.lbNome.TabIndex = 9;
            this.lbNome.Text = "Nome";
            this.lbNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txNome
            // 
            this.txNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txNome.BackColor = System.Drawing.SystemColors.Menu;
            this.txNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txNome.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNome.Location = new System.Drawing.Point(631, 80);
            this.txNome.Margin = new System.Windows.Forms.Padding(2);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(166, 29);
            this.txNome.TabIndex = 8;
            // 
            // lbCPF
            // 
            this.lbCPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCPF.AutoSize = true;
            this.lbCPF.BackColor = System.Drawing.Color.Transparent;
            this.lbCPF.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPF.Location = new System.Drawing.Point(287, 121);
            this.lbCPF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(51, 25);
            this.lbCPF.TabIndex = 11;
            this.lbCPF.Text = "CPF";
            this.lbCPF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txCPF
            // 
            this.txCPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txCPF.BackColor = System.Drawing.SystemColors.Menu;
            this.txCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txCPF.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCPF.Location = new System.Drawing.Point(341, 120);
            this.txCPF.Margin = new System.Windows.Forms.Padding(2);
            this.txCPF.MaxLength = 11;
            this.txCPF.Name = "txCPF";
            this.txCPF.Size = new System.Drawing.Size(166, 29);
            this.txCPF.TabIndex = 10;
            // 
            // lbClientesTitulo
            // 
            this.lbClientesTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbClientesTitulo.AutoSize = true;
            this.lbClientesTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbClientesTitulo.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClientesTitulo.Location = new System.Drawing.Point(512, 20);
            this.lbClientesTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbClientesTitulo.Name = "lbClientesTitulo";
            this.lbClientesTitulo.Size = new System.Drawing.Size(95, 26);
            this.lbClientesTitulo.TabIndex = 0;
            this.lbClientesTitulo.Text = "Clientes";
            // 
            // lbFone
            // 
            this.lbFone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbFone.AutoSize = true;
            this.lbFone.BackColor = System.Drawing.Color.Transparent;
            this.lbFone.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFone.Location = new System.Drawing.Point(546, 122);
            this.lbFone.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.lbFone.Name = "lbFone";
            this.lbFone.Size = new System.Drawing.Size(88, 25);
            this.lbFone.TabIndex = 13;
            this.lbFone.Text = "Telefone";
            this.lbFone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txEndereco
            // 
            this.txEndereco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txEndereco.BackColor = System.Drawing.SystemColors.Menu;
            this.txEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txEndereco.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txEndereco.Location = new System.Drawing.Point(341, 160);
            this.txEndereco.Margin = new System.Windows.Forms.Padding(2);
            this.txEndereco.Name = "txEndereco";
            this.txEndereco.Size = new System.Drawing.Size(455, 29);
            this.txEndereco.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Endereço";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mtxTelefone
            // 
            this.mtxTelefone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxTelefone.BackColor = System.Drawing.SystemColors.Menu;
            this.mtxTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxTelefone.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxTelefone.Location = new System.Drawing.Point(631, 120);
            this.mtxTelefone.Margin = new System.Windows.Forms.Padding(2);
            this.mtxTelefone.Mask = "(99) 99999-9999";
            this.mtxTelefone.Name = "mtxTelefone";
            this.mtxTelefone.Size = new System.Drawing.Size(166, 29);
            this.mtxTelefone.TabIndex = 16;
            // 
            // btnConsultarClientes
            // 
            this.btnConsultarClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConsultarClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnConsultarClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarClientes.FlatAppearance.BorderSize = 0;
            this.btnConsultarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarClientes.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarClientes.ForeColor = System.Drawing.Color.White;
            this.btnConsultarClientes.Location = new System.Drawing.Point(504, 264);
            this.btnConsultarClientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultarClientes.Name = "btnConsultarClientes";
            this.btnConsultarClientes.Size = new System.Drawing.Size(122, 40);
            this.btnConsultarClientes.TabIndex = 17;
            this.btnConsultarClientes.Text = "Consultar";
            this.btnConsultarClientes.UseVisualStyleBackColor = false;
            this.btnConsultarClientes.Click += new System.EventHandler(this.btnConsultarClientes_Click);
            // 
            // btnExcluirClientes
            // 
            this.btnExcluirClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluirClientes.BackColor = System.Drawing.Color.Brown;
            this.btnExcluirClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirClientes.FlatAppearance.BorderSize = 0;
            this.btnExcluirClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirClientes.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirClientes.ForeColor = System.Drawing.Color.White;
            this.btnExcluirClientes.Location = new System.Drawing.Point(856, 287);
            this.btnExcluirClientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluirClientes.Name = "btnExcluirClientes";
            this.btnExcluirClientes.Size = new System.Drawing.Size(82, 28);
            this.btnExcluirClientes.TabIndex = 18;
            this.btnExcluirClientes.Text = "Excluir";
            this.btnExcluirClientes.UseVisualStyleBackColor = false;
            this.btnExcluirClientes.Click += new System.EventHandler(this.btnExcluirClientes_Click);
            // 
            // btnCadastrarClientes
            // 
            this.btnCadastrarClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrarClientes.BackColor = System.Drawing.Color.Green;
            this.btnCadastrarClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarClientes.FlatAppearance.BorderSize = 0;
            this.btnCadastrarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarClientes.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarClientes.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarClientes.Location = new System.Drawing.Point(951, 287);
            this.btnCadastrarClientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastrarClientes.Name = "btnCadastrarClientes";
            this.btnCadastrarClientes.Size = new System.Drawing.Size(94, 28);
            this.btnCadastrarClientes.TabIndex = 19;
            this.btnCadastrarClientes.Text = "Cadastrar";
            this.btnCadastrarClientes.UseVisualStyleBackColor = false;
            this.btnCadastrarClientes.Click += new System.EventHandler(this.btnCadastrarClientes_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1056, 287);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 28);
            this.button1.TabIndex = 20;
            this.button1.Text = "Alterar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnAlterarCliente_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvClientes.AutoGenerateColumns = false;
            this.dgvClientes.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIDDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.clientCpfDataGridViewTextBoxColumn,
            this.clientPhoneDataGridViewTextBoxColumn,
            this.clientAddressDataGridViewTextBoxColumn,
            this.clientCityDataGridViewTextBoxColumn});
            this.dgvClientes.DataSource = this.clientsTableBindingSource;
            this.dgvClientes.Location = new System.Drawing.Point(58, 320);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.Size = new System.Drawing.Size(1057, 263);
            this.dgvClientes.TabIndex = 21;
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "Client_ID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "Client_ID";
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "Client_Name";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "Client_Name";
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            this.clientNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientCpfDataGridViewTextBoxColumn
            // 
            this.clientCpfDataGridViewTextBoxColumn.DataPropertyName = "Client_Cpf";
            this.clientCpfDataGridViewTextBoxColumn.HeaderText = "Client_Cpf";
            this.clientCpfDataGridViewTextBoxColumn.Name = "clientCpfDataGridViewTextBoxColumn";
            this.clientCpfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientPhoneDataGridViewTextBoxColumn
            // 
            this.clientPhoneDataGridViewTextBoxColumn.DataPropertyName = "Client_Phone";
            this.clientPhoneDataGridViewTextBoxColumn.HeaderText = "Client_Phone";
            this.clientPhoneDataGridViewTextBoxColumn.Name = "clientPhoneDataGridViewTextBoxColumn";
            this.clientPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientAddressDataGridViewTextBoxColumn
            // 
            this.clientAddressDataGridViewTextBoxColumn.DataPropertyName = "Client_Address";
            this.clientAddressDataGridViewTextBoxColumn.HeaderText = "Client_Address";
            this.clientAddressDataGridViewTextBoxColumn.Name = "clientAddressDataGridViewTextBoxColumn";
            this.clientAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientCityDataGridViewTextBoxColumn
            // 
            this.clientCityDataGridViewTextBoxColumn.DataPropertyName = "Client_City";
            this.clientCityDataGridViewTextBoxColumn.HeaderText = "Client_City";
            this.clientCityDataGridViewTextBoxColumn.Name = "clientCityDataGridViewTextBoxColumn";
            this.clientCityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientsTableBindingSource
            // 
            this.clientsTableBindingSource.DataMember = "ClientsTable";
            this.clientsTableBindingSource.DataSource = this.biblioBooksDataSet;
            // 
            // biblioBooksDataSet
            // 
            this.biblioBooksDataSet.DataSetName = "BiblioBooksDataSet";
            this.biblioBooksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 201);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Cidade";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbCidades
            // 
            this.cbCidades.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCidades.BackColor = System.Drawing.SystemColors.Menu;
            this.cbCidades.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCidades.FormattingEnabled = true;
            this.cbCidades.Items.AddRange(new object[] {
            "teste",
            "teste",
            "teste"});
            this.cbCidades.Location = new System.Drawing.Point(341, 202);
            this.cbCidades.Margin = new System.Windows.Forms.Padding(2);
            this.cbCidades.Name = "cbCidades";
            this.cbCidades.Size = new System.Drawing.Size(166, 28);
            this.cbCidades.TabIndex = 24;
            // 
            // clientsTableTableAdapter
            // 
            this.clientsTableTableAdapter.ClearBeforeFill = true;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1165, 594);
            this.Controls.Add(this.cbCidades);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCadastrarClientes);
            this.Controls.Add(this.btnExcluirClientes);
            this.Controls.Add(this.btnConsultarClientes);
            this.Controls.Add(this.mtxTelefone);
            this.Controls.Add(this.txEndereco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCPF);
            this.Controls.Add(this.txCPF);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.txID);
            this.Controls.Add(this.lbClientesTitulo);
            this.Controls.Add(this.lbFone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblioBooksDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.TextBox txCPF;
        private System.Windows.Forms.Label lbClientesTitulo;
        private System.Windows.Forms.Label lbFone;
        private System.Windows.Forms.TextBox txEndereco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxTelefone;
        private System.Windows.Forms.Button btnConsultarClientes;
        private System.Windows.Forms.Button btnExcluirClientes;
        private System.Windows.Forms.Button btnCadastrarClientes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCidades;
        private BiblioBooksDataSet biblioBooksDataSet;
        private System.Windows.Forms.BindingSource clientsTableBindingSource;
        private BiblioBooksDataSetTableAdapters.ClientsTableTableAdapter clientsTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientCpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientCityDataGridViewTextBoxColumn;
    }
}