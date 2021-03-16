namespace Cadastro_de_carros
{
    partial class frmCadastroCarros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroCarros));
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblDono = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblDataCompra = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtDono = new System.Windows.Forms.TextBox();
            this.mtbAno = new System.Windows.Forms.MaskedTextBox();
            this.mtbMarca = new System.Windows.Forms.MaskedTextBox();
            this.dtpDataCompra = new System.Windows.Forms.DateTimePicker();
            this.btnAdiconarCarro = new System.Windows.Forms.Button();
            this.mtbPlaca = new System.Windows.Forms.MaskedTextBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.btnListaClientes = new System.Windows.Forms.Button();
            this.txtLista = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(26, 29);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(40, 13);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "Placa: ";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(26, 71);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(45, 13);
            this.lblModelo.TabIndex = 1;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(26, 118);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca:";
            // 
            // lblDono
            // 
            this.lblDono.AutoSize = true;
            this.lblDono.Location = new System.Drawing.Point(26, 166);
            this.lblDono.Name = "lblDono";
            this.lblDono.Size = new System.Drawing.Size(36, 13);
            this.lblDono.TabIndex = 3;
            this.lblDono.Text = "Dono:";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(26, 204);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(29, 13);
            this.lblAno.TabIndex = 4;
            this.lblAno.Text = "Ano:";
            // 
            // lblDataCompra
            // 
            this.lblDataCompra.AutoSize = true;
            this.lblDataCompra.Location = new System.Drawing.Point(26, 254);
            this.lblDataCompra.Name = "lblDataCompra";
            this.lblDataCompra.Size = new System.Drawing.Size(86, 13);
            this.lblDataCompra.TabIndex = 5;
            this.lblDataCompra.Text = "Data de compra:";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(77, 68);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(227, 20);
            this.txtModelo.TabIndex = 7;
            // 
            // txtDono
            // 
            this.txtDono.Location = new System.Drawing.Point(77, 163);
            this.txtDono.Name = "txtDono";
            this.txtDono.Size = new System.Drawing.Size(227, 20);
            this.txtDono.TabIndex = 9;
            // 
            // mtbAno
            // 
            this.mtbAno.Location = new System.Drawing.Point(77, 204);
            this.mtbAno.Mask = "0000";
            this.mtbAno.Name = "mtbAno";
            this.mtbAno.Size = new System.Drawing.Size(35, 20);
            this.mtbAno.TabIndex = 10;
            // 
            // mtbMarca
            // 
            this.mtbMarca.Location = new System.Drawing.Point(77, 115);
            this.mtbMarca.Mask = "???????????????";
            this.mtbMarca.Name = "mtbMarca";
            this.mtbMarca.Size = new System.Drawing.Size(111, 20);
            this.mtbMarca.TabIndex = 12;
            this.mtbMarca.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbMarca_MaskInputRejected);
            // 
            // dtpDataCompra
            // 
            this.dtpDataCompra.Location = new System.Drawing.Point(118, 248);
            this.dtpDataCompra.Name = "dtpDataCompra";
            this.dtpDataCompra.Size = new System.Drawing.Size(263, 20);
            this.dtpDataCompra.TabIndex = 13;
            // 
            // btnAdiconarCarro
            // 
            this.btnAdiconarCarro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdiconarCarro.Location = new System.Drawing.Point(324, 305);
            this.btnAdiconarCarro.Name = "btnAdiconarCarro";
            this.btnAdiconarCarro.Size = new System.Drawing.Size(57, 48);
            this.btnAdiconarCarro.TabIndex = 14;
            this.btnAdiconarCarro.Text = "Registrar";
            this.btnAdiconarCarro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdiconarCarro.UseVisualStyleBackColor = true;
            this.btnAdiconarCarro.Click += new System.EventHandler(this.btnAdiconarCarro_Click);
            // 
            // mtbPlaca
            // 
            this.mtbPlaca.Location = new System.Drawing.Point(77, 26);
            this.mtbPlaca.Name = "mtbPlaca";
            this.mtbPlaca.Size = new System.Drawing.Size(162, 20);
            this.mtbPlaca.TabIndex = 15;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(64, 305);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(79, 48);
            this.btnProcurar.TabIndex = 16;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // btnListaClientes
            // 
            this.btnListaClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaClientes.Location = new System.Drawing.Point(605, 296);
            this.btnListaClientes.Name = "btnListaClientes";
            this.btnListaClientes.Size = new System.Drawing.Size(120, 66);
            this.btnListaClientes.TabIndex = 17;
            this.btnListaClientes.Text = "Listagem dos clientes";
            this.btnListaClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListaClientes.UseVisualStyleBackColor = true;
            this.btnListaClientes.Click += new System.EventHandler(this.btnListaClientes_Click);
            // 
            // txtLista
            // 
            this.txtLista.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtLista.Location = new System.Drawing.Point(540, 47);
            this.txtLista.Multiline = true;
            this.txtLista.Name = "txtLista";
            this.txtLista.ReadOnly = true;
            this.txtLista.Size = new System.Drawing.Size(211, 221);
            this.txtLista.TabIndex = 18;
            this.txtLista.TextChanged += new System.EventHandler(this.txtLista_TextChanged);
            // 
            // frmCadastroCarros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 513);
            this.Controls.Add(this.txtLista);
            this.Controls.Add(this.btnListaClientes);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.mtbPlaca);
            this.Controls.Add(this.btnAdiconarCarro);
            this.Controls.Add(this.dtpDataCompra);
            this.Controls.Add(this.mtbMarca);
            this.Controls.Add(this.mtbAno);
            this.Controls.Add(this.txtDono);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblDataCompra);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblDono);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblPlaca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastroCarros";
            this.Text = "Cadastro de Carros";
            this.Load += new System.EventHandler(this.frmCadastroCarros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblDono;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblDataCompra;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtDono;
        private System.Windows.Forms.MaskedTextBox mtbAno;
        private System.Windows.Forms.MaskedTextBox mtbMarca;
        private System.Windows.Forms.DateTimePicker dtpDataCompra;
        private System.Windows.Forms.Button btnAdiconarCarro;
        private System.Windows.Forms.MaskedTextBox mtbPlaca;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Button btnListaClientes;
        private System.Windows.Forms.TextBox txtLista;
    }
}

