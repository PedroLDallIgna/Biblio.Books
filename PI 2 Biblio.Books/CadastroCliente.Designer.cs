namespace PI_2_Biblio.Books
{
    partial class CadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCliente));
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.btnCancelarCad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txEndereco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCPF = new System.Windows.Forms.Label();
            this.txCPF = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.txNome = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.txID = new System.Windows.Forms.TextBox();
            this.lbFone = new System.Windows.Forms.Label();
            this.cbCidades = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrarCliente.BackColor = System.Drawing.Color.Green;
            this.btnCadastrarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarCliente.FlatAppearance.BorderSize = 0;
            this.btnCadastrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarCliente.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCliente.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarCliente.Location = new System.Drawing.Point(132, 449);
            this.btnCadastrarCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(137, 40);
            this.btnCadastrarCliente.TabIndex = 20;
            this.btnCadastrarCliente.Text = "Cadastrar";
            this.btnCadastrarCliente.UseVisualStyleBackColor = false;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // btnCancelarCad
            // 
            this.btnCancelarCad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelarCad.BackColor = System.Drawing.Color.Brown;
            this.btnCancelarCad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarCad.FlatAppearance.BorderSize = 0;
            this.btnCancelarCad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCad.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCad.ForeColor = System.Drawing.Color.White;
            this.btnCancelarCad.Location = new System.Drawing.Point(332, 449);
            this.btnCancelarCad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelarCad.Name = "btnCancelarCad";
            this.btnCancelarCad.Size = new System.Drawing.Size(137, 40);
            this.btnCancelarCad.TabIndex = 21;
            this.btnCancelarCad.Text = "Cancelar";
            this.btnCancelarCad.UseVisualStyleBackColor = false;
            this.btnCancelarCad.Click += new System.EventHandler(this.btnCancelarCad_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 333);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "Cidade";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txTelefone
            // 
            this.txTelefone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txTelefone.BackColor = System.Drawing.SystemColors.Menu;
            this.txTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txTelefone.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTelefone.Location = new System.Drawing.Point(132, 254);
            this.txTelefone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txTelefone.Mask = "(99) 99999-9999";
            this.txTelefone.Name = "txTelefone";
            this.txTelefone.Size = new System.Drawing.Size(166, 29);
            this.txTelefone.TabIndex = 34;
            // 
            // txEndereco
            // 
            this.txEndereco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txEndereco.BackColor = System.Drawing.SystemColors.Menu;
            this.txEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txEndereco.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txEndereco.Location = new System.Drawing.Point(132, 294);
            this.txEndereco.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txEndereco.Name = "txEndereco";
            this.txEndereco.Size = new System.Drawing.Size(348, 29);
            this.txEndereco.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 295);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Endereço";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCPF
            // 
            this.lbCPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCPF.AutoSize = true;
            this.lbCPF.BackColor = System.Drawing.Color.Transparent;
            this.lbCPF.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPF.Location = new System.Drawing.Point(78, 215);
            this.lbCPF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(51, 25);
            this.lbCPF.TabIndex = 30;
            this.lbCPF.Text = "CPF";
            this.lbCPF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txCPF
            // 
            this.txCPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txCPF.BackColor = System.Drawing.SystemColors.Menu;
            this.txCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txCPF.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCPF.Location = new System.Drawing.Point(132, 214);
            this.txCPF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txCPF.MaxLength = 11;
            this.txCPF.Name = "txCPF";
            this.txCPF.Size = new System.Drawing.Size(166, 29);
            this.txCPF.TabIndex = 29;
            // 
            // lbNome
            // 
            this.lbNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNome.AutoSize = true;
            this.lbNome.BackColor = System.Drawing.Color.Transparent;
            this.lbNome.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(67, 176);
            this.lbNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(65, 25);
            this.lbNome.TabIndex = 28;
            this.lbNome.Text = "Nome";
            this.lbNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txNome
            // 
            this.txNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txNome.BackColor = System.Drawing.SystemColors.Menu;
            this.txNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txNome.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNome.Location = new System.Drawing.Point(132, 175);
            this.txNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(166, 29);
            this.txNome.TabIndex = 27;
            // 
            // lbID
            // 
            this.lbID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbID.AutoSize = true;
            this.lbID.BackColor = System.Drawing.Color.Transparent;
            this.lbID.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(95, 136);
            this.lbID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(34, 25);
            this.lbID.TabIndex = 26;
            this.lbID.Text = "ID";
            this.lbID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txID
            // 
            this.txID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txID.BackColor = System.Drawing.SystemColors.Menu;
            this.txID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txID.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txID.Location = new System.Drawing.Point(132, 135);
            this.txID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txID.MaxLength = 6;
            this.txID.Name = "txID";
            this.txID.Size = new System.Drawing.Size(166, 29);
            this.txID.TabIndex = 25;
            // 
            // lbFone
            // 
            this.lbFone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbFone.AutoSize = true;
            this.lbFone.BackColor = System.Drawing.Color.Transparent;
            this.lbFone.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFone.Location = new System.Drawing.Point(47, 256);
            this.lbFone.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.lbFone.Name = "lbFone";
            this.lbFone.Size = new System.Drawing.Size(88, 25);
            this.lbFone.TabIndex = 31;
            this.lbFone.Text = "Telefone";
            this.lbFone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.cbCidades.Location = new System.Drawing.Point(132, 335);
            this.cbCidades.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCidades.Name = "cbCidades";
            this.cbCidades.Size = new System.Drawing.Size(166, 28);
            this.cbCidades.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(212, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 37;
            this.label3.Text = "Cadastrar cliente";
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(585, 522);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCidades);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txTelefone);
            this.Controls.Add(this.txEndereco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCPF);
            this.Controls.Add(this.txCPF);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.txID);
            this.Controls.Add(this.lbFone);
            this.Controls.Add(this.btnCancelarCad);
            this.Controls.Add(this.btnCadastrarCliente);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.Button btnCancelarCad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txTelefone;
        private System.Windows.Forms.TextBox txEndereco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.TextBox txCPF;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txID;
        private System.Windows.Forms.Label lbFone;
        private System.Windows.Forms.ComboBox cbCidades;
        private System.Windows.Forms.Label label3;
    }
}