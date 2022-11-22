namespace PI_2_Biblio.Books
{
    partial class AddLivro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLivro));
            this.lbNomeCliente = new System.Windows.Forms.Label();
            this.txAutorEstoque = new System.Windows.Forms.TextBox();
            this.lbCPF = new System.Windows.Forms.Label();
            this.txEditoraEstoque = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.txTituloEstoque = new System.Windows.Forms.TextBox();
            this.lbIDLivro = new System.Windows.Forms.Label();
            this.txIDEstoque = new System.Windows.Forms.TextBox();
            this.lbClientesTitulo = new System.Windows.Forms.Label();
            this.btnCancelarCadLivro = new System.Windows.Forms.Button();
            this.btnCadastrarLivro = new System.Windows.Forms.Button();
            this.AddImagemLivro = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AddImagemLivro)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNomeCliente
            // 
            this.lbNomeCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNomeCliente.AutoSize = true;
            this.lbNomeCliente.BackColor = System.Drawing.Color.Transparent;
            this.lbNomeCliente.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeCliente.Location = new System.Drawing.Point(391, 132);
            this.lbNomeCliente.Margin = new System.Windows.Forms.Padding(0);
            this.lbNomeCliente.Name = "lbNomeCliente";
            this.lbNomeCliente.Size = new System.Drawing.Size(63, 25);
            this.lbNomeCliente.TabIndex = 61;
            this.lbNomeCliente.Text = "Autor";
            this.lbNomeCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txAutorEstoque
            // 
            this.txAutorEstoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txAutorEstoque.BackColor = System.Drawing.SystemColors.Menu;
            this.txAutorEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txAutorEstoque.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txAutorEstoque.Location = new System.Drawing.Point(454, 131);
            this.txAutorEstoque.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txAutorEstoque.MaxLength = 100;
            this.txAutorEstoque.Name = "txAutorEstoque";
            this.txAutorEstoque.Size = new System.Drawing.Size(166, 29);
            this.txAutorEstoque.TabIndex = 60;
            // 
            // lbCPF
            // 
            this.lbCPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCPF.AutoSize = true;
            this.lbCPF.BackColor = System.Drawing.Color.Transparent;
            this.lbCPF.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPF.Location = new System.Drawing.Point(377, 175);
            this.lbCPF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(76, 25);
            this.lbCPF.TabIndex = 59;
            this.lbCPF.Text = "Editora";
            this.lbCPF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txEditoraEstoque
            // 
            this.txEditoraEstoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txEditoraEstoque.BackColor = System.Drawing.SystemColors.Menu;
            this.txEditoraEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txEditoraEstoque.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txEditoraEstoque.Location = new System.Drawing.Point(454, 173);
            this.txEditoraEstoque.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txEditoraEstoque.MaxLength = 11;
            this.txEditoraEstoque.Name = "txEditoraEstoque";
            this.txEditoraEstoque.Size = new System.Drawing.Size(166, 29);
            this.txEditoraEstoque.TabIndex = 58;
            // 
            // lbNome
            // 
            this.lbNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNome.AutoSize = true;
            this.lbNome.BackColor = System.Drawing.Color.Transparent;
            this.lbNome.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(113, 175);
            this.lbNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(65, 25);
            this.lbNome.TabIndex = 57;
            this.lbNome.Text = "Titulo";
            this.lbNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txTituloEstoque
            // 
            this.txTituloEstoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txTituloEstoque.BackColor = System.Drawing.SystemColors.Menu;
            this.txTituloEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txTituloEstoque.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTituloEstoque.Location = new System.Drawing.Point(178, 174);
            this.txTituloEstoque.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txTituloEstoque.Name = "txTituloEstoque";
            this.txTituloEstoque.Size = new System.Drawing.Size(166, 29);
            this.txTituloEstoque.TabIndex = 56;
            // 
            // lbIDLivro
            // 
            this.lbIDLivro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbIDLivro.AutoSize = true;
            this.lbIDLivro.BackColor = System.Drawing.Color.Transparent;
            this.lbIDLivro.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDLivro.Location = new System.Drawing.Point(98, 132);
            this.lbIDLivro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIDLivro.Name = "lbIDLivro";
            this.lbIDLivro.Size = new System.Drawing.Size(81, 25);
            this.lbIDLivro.TabIndex = 55;
            this.lbIDLivro.Text = "IDLivro";
            this.lbIDLivro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txIDEstoque
            // 
            this.txIDEstoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txIDEstoque.BackColor = System.Drawing.SystemColors.Menu;
            this.txIDEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txIDEstoque.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txIDEstoque.Location = new System.Drawing.Point(178, 131);
            this.txIDEstoque.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txIDEstoque.MaxLength = 10;
            this.txIDEstoque.Name = "txIDEstoque";
            this.txIDEstoque.Size = new System.Drawing.Size(166, 29);
            this.txIDEstoque.TabIndex = 54;
            // 
            // lbClientesTitulo
            // 
            this.lbClientesTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbClientesTitulo.AutoSize = true;
            this.lbClientesTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbClientesTitulo.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClientesTitulo.Location = new System.Drawing.Point(288, 26);
            this.lbClientesTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbClientesTitulo.Name = "lbClientesTitulo";
            this.lbClientesTitulo.Size = new System.Drawing.Size(180, 26);
            this.lbClientesTitulo.TabIndex = 62;
            this.lbClientesTitulo.Text = "Cadastrar Livro";
            // 
            // btnCancelarCadLivro
            // 
            this.btnCancelarCadLivro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelarCadLivro.BackColor = System.Drawing.Color.Brown;
            this.btnCancelarCadLivro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarCadLivro.FlatAppearance.BorderSize = 0;
            this.btnCancelarCadLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCadLivro.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCadLivro.ForeColor = System.Drawing.Color.White;
            this.btnCancelarCadLivro.Location = new System.Drawing.Point(406, 504);
            this.btnCancelarCadLivro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelarCadLivro.Name = "btnCancelarCadLivro";
            this.btnCancelarCadLivro.Size = new System.Drawing.Size(137, 40);
            this.btnCancelarCadLivro.TabIndex = 64;
            this.btnCancelarCadLivro.Text = "Cancelar";
            this.btnCancelarCadLivro.UseVisualStyleBackColor = false;
            this.btnCancelarCadLivro.Click += new System.EventHandler(this.btnCancelarCadLivro_Click);
            // 
            // btnCadastrarLivro
            // 
            this.btnCadastrarLivro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrarLivro.BackColor = System.Drawing.Color.Green;
            this.btnCadastrarLivro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarLivro.FlatAppearance.BorderSize = 0;
            this.btnCadastrarLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarLivro.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarLivro.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarLivro.Location = new System.Drawing.Point(206, 504);
            this.btnCadastrarLivro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCadastrarLivro.Name = "btnCadastrarLivro";
            this.btnCadastrarLivro.Size = new System.Drawing.Size(137, 40);
            this.btnCadastrarLivro.TabIndex = 63;
            this.btnCadastrarLivro.Text = "Cadastrar";
            this.btnCadastrarLivro.UseVisualStyleBackColor = false;
            this.btnCadastrarLivro.Click += new System.EventHandler(this.btnCadastrarLivro_Click);
            // 
            // AddImagemLivro
            // 
            this.AddImagemLivro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddImagemLivro.BackgroundImage")));
            this.AddImagemLivro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddImagemLivro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddImagemLivro.Location = new System.Drawing.Point(285, 266);
            this.AddImagemLivro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddImagemLivro.Name = "AddImagemLivro";
            this.AddImagemLivro.Size = new System.Drawing.Size(166, 180);
            this.AddImagemLivro.TabIndex = 65;
            this.AddImagemLivro.TabStop = false;
            // 
            // AddLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(742, 566);
            this.Controls.Add(this.AddImagemLivro);
            this.Controls.Add(this.btnCancelarCadLivro);
            this.Controls.Add(this.btnCadastrarLivro);
            this.Controls.Add(this.lbClientesTitulo);
            this.Controls.Add(this.lbNomeCliente);
            this.Controls.Add(this.txAutorEstoque);
            this.Controls.Add(this.lbCPF);
            this.Controls.Add(this.txEditoraEstoque);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.txTituloEstoque);
            this.Controls.Add(this.lbIDLivro);
            this.Controls.Add(this.txIDEstoque);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddLivro";
            ((System.ComponentModel.ISupportInitialize)(this.AddImagemLivro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNomeCliente;
        private System.Windows.Forms.TextBox txAutorEstoque;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.TextBox txEditoraEstoque;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txTituloEstoque;
        private System.Windows.Forms.Label lbIDLivro;
        private System.Windows.Forms.TextBox txIDEstoque;
        private System.Windows.Forms.Label lbClientesTitulo;
        private System.Windows.Forms.Button btnCancelarCadLivro;
        private System.Windows.Forms.Button btnCadastrarLivro;
        private System.Windows.Forms.PictureBox AddImagemLivro;
    }
}