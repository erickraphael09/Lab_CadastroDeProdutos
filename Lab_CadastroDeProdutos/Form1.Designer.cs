namespace Lab_CadastroDeProdutos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbDadosPrincipais = new System.Windows.Forms.GroupBox();
            this.gbsituacao = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.lblNomeDoProduto = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPrecoCusto = new System.Windows.Forms.Label();
            this.lblMargem = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblStockInicial = new System.Windows.Forms.Label();
            this.lblStrockMinimo = new System.Windows.Forms.Label();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.chkProdutoAtivo = new System.Windows.Forms.CheckBox();
            this.dtpCadastro = new System.Windows.Forms.DateTimePicker();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbFornecedor = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.numVenda = new System.Windows.Forms.NumericUpDown();
            this.numCusto = new System.Windows.Forms.NumericUpDown();
            this.txtMargem = new System.Windows.Forms.TextBox();
            this.nudEstoque = new System.Windows.Forms.NumericUpDown();
            this.nudEstoqueMinimo = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.gbDadosPrincipais.SuspendLayout();
            this.gbsituacao.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCusto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstoqueMinimo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.cmbFornecedor);
            this.groupBox1.Controls.Add(this.cmbCategoria);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.lblDescricao);
            this.groupBox1.Controls.Add(this.lblCategoria);
            this.groupBox1.Controls.Add(this.lblNomeDoProduto);
            this.groupBox1.Controls.Add(this.lblFornecedor);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Principais";
            // 
            // gbDadosPrincipais
            // 
            this.gbDadosPrincipais.Controls.Add(this.nudEstoqueMinimo);
            this.gbDadosPrincipais.Controls.Add(this.nudEstoque);
            this.gbDadosPrincipais.Controls.Add(this.txtMargem);
            this.gbDadosPrincipais.Controls.Add(this.numCusto);
            this.gbDadosPrincipais.Controls.Add(this.numVenda);
            this.gbDadosPrincipais.Controls.Add(this.lblStrockMinimo);
            this.gbDadosPrincipais.Controls.Add(this.lblStockInicial);
            this.gbDadosPrincipais.Controls.Add(this.label10);
            this.gbDadosPrincipais.Controls.Add(this.lblMargem);
            this.gbDadosPrincipais.Controls.Add(this.lblPrecoCusto);
            this.gbDadosPrincipais.Controls.Add(this.label7);
            this.gbDadosPrincipais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosPrincipais.Location = new System.Drawing.Point(12, 255);
            this.gbDadosPrincipais.Name = "gbDadosPrincipais";
            this.gbDadosPrincipais.Size = new System.Drawing.Size(438, 157);
            this.gbDadosPrincipais.TabIndex = 0;
            this.gbDadosPrincipais.TabStop = false;
            this.gbDadosPrincipais.Text = "Precificação e estoque";
            this.gbDadosPrincipais.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // gbsituacao
            // 
            this.gbsituacao.Controls.Add(this.dtpCadastro);
            this.gbsituacao.Controls.Add(this.chkProdutoAtivo);
            this.gbsituacao.Controls.Add(this.lblDataCadastro);
            this.gbsituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbsituacao.Location = new System.Drawing.Point(456, 267);
            this.gbsituacao.Name = "gbsituacao";
            this.gbsituacao.Size = new System.Drawing.Size(301, 133);
            this.gbsituacao.TabIndex = 0;
            this.gbsituacao.TabStop = false;
            this.gbsituacao.Text = "Situação/Detalhes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(-10, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 64);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Produtos";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.SystemColors.Control;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCodigo.Location = new System.Drawing.Point(19, 22);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(49, 15);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFornecedor.Location = new System.Drawing.Point(18, 85);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(73, 15);
            this.lblFornecedor.TabIndex = 2;
            this.lblFornecedor.Text = "Fornecedor:";
            // 
            // lblNomeDoProduto
            // 
            this.lblNomeDoProduto.AutoSize = true;
            this.lblNomeDoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeDoProduto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNomeDoProduto.Location = new System.Drawing.Point(240, 22);
            this.lblNomeDoProduto.Name = "lblNomeDoProduto";
            this.lblNomeDoProduto.Size = new System.Drawing.Size(107, 15);
            this.lblNomeDoProduto.TabIndex = 4;
            this.lblNomeDoProduto.Text = "Nome do Produto:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCategoria.Location = new System.Drawing.Point(585, 22);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(63, 15);
            this.lblCategoria.TabIndex = 6;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDescricao.Location = new System.Drawing.Point(240, 76);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(65, 15);
            this.lblDescricao.TabIndex = 8;
            this.lblDescricao.Text = "Descrição:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 0;
            // 
            // lblPrecoCusto
            // 
            this.lblPrecoCusto.AutoSize = true;
            this.lblPrecoCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoCusto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPrecoCusto.Location = new System.Drawing.Point(8, 35);
            this.lblPrecoCusto.Name = "lblPrecoCusto";
            this.lblPrecoCusto.Size = new System.Drawing.Size(120, 15);
            this.lblPrecoCusto.TabIndex = 1;
            this.lblPrecoCusto.Text = "Preço de Custo (R$):";
            // 
            // lblMargem
            // 
            this.lblMargem.AutoSize = true;
            this.lblMargem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMargem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMargem.Location = new System.Drawing.Point(8, 80);
            this.lblMargem.Name = "lblMargem";
            this.lblMargem.Size = new System.Drawing.Size(84, 15);
            this.lblMargem.TabIndex = 3;
            this.lblMargem.Text = "Margem (R$):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(205, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 15);
            this.label10.TabIndex = 4;
            this.label10.Text = "Preço de Venda (R$):";
            // 
            // lblStockInicial
            // 
            this.lblStockInicial.AutoSize = true;
            this.lblStockInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockInicial.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStockInicial.Location = new System.Drawing.Point(8, 124);
            this.lblStockInicial.Name = "lblStockInicial";
            this.lblStockInicial.Size = new System.Drawing.Size(75, 15);
            this.lblStockInicial.TabIndex = 2;
            this.lblStockInicial.Text = "Stock Inicial:";
            // 
            // lblStrockMinimo
            // 
            this.lblStrockMinimo.AutoSize = true;
            this.lblStrockMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrockMinimo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStrockMinimo.Location = new System.Drawing.Point(220, 124);
            this.lblStrockMinimo.Name = "lblStrockMinimo";
            this.lblStrockMinimo.Size = new System.Drawing.Size(85, 15);
            this.lblStrockMinimo.TabIndex = 8;
            this.lblStrockMinimo.Text = "Stock Minimo:";
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCadastro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDataCadastro.Location = new System.Drawing.Point(57, 86);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(105, 15);
            this.lblDataCadastro.TabIndex = 0;
            this.lblDataCadastro.Text = "Data de Cadastro:";
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNovo.Location = new System.Drawing.Point(217, 418);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(85, 30);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalvar.Location = new System.Drawing.Point(314, 418);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 30);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpar.Location = new System.Drawing.Point(406, 418);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 30);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExcluir.Location = new System.Drawing.Point(497, 418);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 30);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // chkProdutoAtivo
            // 
            this.chkProdutoAtivo.AutoSize = true;
            this.chkProdutoAtivo.Checked = true;
            this.chkProdutoAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkProdutoAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkProdutoAtivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkProdutoAtivo.Location = new System.Drawing.Point(60, 40);
            this.chkProdutoAtivo.Name = "chkProdutoAtivo";
            this.chkProdutoAtivo.Size = new System.Drawing.Size(97, 19);
            this.chkProdutoAtivo.TabIndex = 2;
            this.chkProdutoAtivo.Text = "Produto Ativo";
            this.chkProdutoAtivo.UseVisualStyleBackColor = true;
            // 
            // dtpCadastro
            // 
            this.dtpCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCadastro.Location = new System.Drawing.Point(60, 104);
            this.dtpCadastro.Name = "dtpCadastro";
            this.dtpCadastro.Size = new System.Drawing.Size(168, 22);
            this.dtpCadastro.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(243, 40);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(214, 22);
            this.txtNome.TabIndex = 10;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Eletrônicos",
            "",
            "Alimentos",
            "",
            "Roupas",
            "",
            "Bebidas",
            "",
            "Higiene",
            "",
            "Outros"});
            this.cmbCategoria.Location = new System.Drawing.Point(588, 40);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 24);
            this.cmbCategoria.TabIndex = 11;
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFornecedor.FormattingEnabled = true;
            this.cmbFornecedor.Items.AddRange(new object[] {
            "Fornecedor A",
            "",
            "",
            "",
            "",
            "Fornecedor B",
            "",
            "",
            "",
            "",
            "Fornecedor C",
            "",
            "",
            "",
            "",
            "Fornecedor D"});
            this.cmbFornecedor.Location = new System.Drawing.Point(21, 104);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(121, 24);
            this.cmbFornecedor.TabIndex = 12;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(243, 94);
            this.txtDescricao.MaxLength = 500;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescricao.Size = new System.Drawing.Size(527, 57);
            this.txtDescricao.TabIndex = 13;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.LightGray;
            this.txtCodigo.Location = new System.Drawing.Point(22, 40);
            this.txtCodigo.MaxLength = 6;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(120, 22);
            this.txtCodigo.TabIndex = 14;
            this.txtCodigo.Text = "000001";
            // 
            // numVenda
            // 
            this.numVenda.DecimalPlaces = 2;
            this.numVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numVenda.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.numVenda.Location = new System.Drawing.Point(335, 32);
            this.numVenda.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numVenda.Name = "numVenda";
            this.numVenda.Size = new System.Drawing.Size(92, 22);
            this.numVenda.TabIndex = 10;
            this.numVenda.ValueChanged += new System.EventHandler(this.nudVenda_ValueChanged);
            // 
            // numCusto
            // 
            this.numCusto.DecimalPlaces = 2;
            this.numCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCusto.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.numCusto.Location = new System.Drawing.Point(135, 30);
            this.numCusto.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numCusto.Name = "numCusto";
            this.numCusto.Size = new System.Drawing.Size(64, 22);
            this.numCusto.TabIndex = 11;
            this.numCusto.ValueChanged += new System.EventHandler(this.nudCusto_ValueChanged);
            // 
            // txtMargem
            // 
            this.txtMargem.BackColor = System.Drawing.Color.LightGray;
            this.txtMargem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMargem.Location = new System.Drawing.Point(99, 80);
            this.txtMargem.Multiline = true;
            this.txtMargem.Name = "txtMargem";
            this.txtMargem.ReadOnly = true;
            this.txtMargem.Size = new System.Drawing.Size(100, 21);
            this.txtMargem.TabIndex = 12;
            // 
            // nudEstoque
            // 
            this.nudEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudEstoque.Location = new System.Drawing.Point(89, 119);
            this.nudEstoque.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudEstoque.Name = "nudEstoque";
            this.nudEstoque.Size = new System.Drawing.Size(100, 22);
            this.nudEstoque.TabIndex = 13;
            // 
            // nudEstoqueMinimo
            // 
            this.nudEstoqueMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudEstoqueMinimo.Location = new System.Drawing.Point(312, 119);
            this.nudEstoqueMinimo.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudEstoqueMinimo.Name = "nudEstoqueMinimo";
            this.nudEstoqueMinimo.Size = new System.Drawing.Size(120, 22);
            this.nudEstoqueMinimo.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbsituacao);
            this.Controls.Add(this.gbDadosPrincipais);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "Form1";
            this.Text = "Cadastro de produtos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbDadosPrincipais.ResumeLayout(false);
            this.gbDadosPrincipais.PerformLayout();
            this.gbsituacao.ResumeLayout(false);
            this.gbsituacao.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCusto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstoqueMinimo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbDadosPrincipais;
        private System.Windows.Forms.GroupBox gbsituacao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNomeDoProduto;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblMargem;
        private System.Windows.Forms.Label lblPrecoCusto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblStrockMinimo;
        private System.Windows.Forms.Label lblStockInicial;
        private System.Windows.Forms.Label lblDataCadastro;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.CheckBox chkProdutoAtivo;
        private System.Windows.Forms.DateTimePicker dtpCadastro;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ComboBox cmbFornecedor;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.NumericUpDown numVenda;
        private System.Windows.Forms.NumericUpDown numCusto;
        private System.Windows.Forms.NumericUpDown nudEstoqueMinimo;
        private System.Windows.Forms.NumericUpDown nudEstoque;
        private System.Windows.Forms.TextBox txtMargem;
    }
}

