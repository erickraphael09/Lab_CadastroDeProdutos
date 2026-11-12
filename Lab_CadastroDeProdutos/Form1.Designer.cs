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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.cmbFornecedor = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblNomeDoProduto = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.gbDadosPrincipais = new System.Windows.Forms.GroupBox();
            this.nudEstoqueMinimo = new System.Windows.Forms.NumericUpDown();
            this.nudEstoque = new System.Windows.Forms.NumericUpDown();
            this.txtMargem = new System.Windows.Forms.TextBox();
            this.numCusto = new System.Windows.Forms.NumericUpDown();
            this.numVenda = new System.Windows.Forms.NumericUpDown();
            this.lblStrockMinimo = new System.Windows.Forms.Label();
            this.lblStockInicial = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblMargem = new System.Windows.Forms.Label();
            this.lblPrecoCusto = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbsituacao = new System.Windows.Forms.GroupBox();
            this.dtpCadastro = new System.Windows.Forms.DateTimePicker();
            this.chkProdutoAtivo = new System.Windows.Forms.CheckBox();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.gbDadosPrincipais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstoqueMinimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCusto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVenda)).BeginInit();
            this.gbsituacao.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.groupBox1.Size = new System.Drawing.Size(776, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Principais";
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
            // cmbFornecedor
            // 
            this.cmbFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFornecedor.FormattingEnabled = true;
            this.cmbFornecedor.Items.AddRange(new object[] {
            "Fornecedor: Hubbay",
            "Fornecedor: Guras",
            "Fornecedor: CityDenim",
            "Fornecedor: Outros",
            "",
            "",
            ""});
            this.cmbFornecedor.Location = new System.Drawing.Point(21, 104);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(178, 24);
            this.cmbFornecedor.TabIndex = 12;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Calçados",
            "Jaquetas",
            "Blusoes",
            "Calcas",
            "Bermuda/Short",
            "Acessorios"});
            this.cmbCategoria.Location = new System.Drawing.Point(588, 40);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 24);
            this.cmbCategoria.TabIndex = 11;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(243, 40);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(214, 22);
            this.txtNome.TabIndex = 10;
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
            this.gbDadosPrincipais.Location = new System.Drawing.Point(12, 243);
            this.gbDadosPrincipais.Name = "gbDadosPrincipais";
            this.gbDadosPrincipais.Size = new System.Drawing.Size(438, 157);
            this.gbDadosPrincipais.TabIndex = 0;
            this.gbDadosPrincipais.TabStop = false;
            this.gbDadosPrincipais.Text = "Precificação e estoque";
            this.gbDadosPrincipais.Enter += new System.EventHandler(this.groupBox2_Enter);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 0;
            // 
            // gbsituacao
            // 
            this.gbsituacao.Controls.Add(this.dtpCadastro);
            this.gbsituacao.Controls.Add(this.chkProdutoAtivo);
            this.gbsituacao.Controls.Add(this.lblDataCadastro);
            this.gbsituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbsituacao.Location = new System.Drawing.Point(456, 251);
            this.gbsituacao.Name = "gbsituacao";
            this.gbsituacao.Size = new System.Drawing.Size(301, 133);
            this.gbsituacao.TabIndex = 0;
            this.gbsituacao.TabStop = false;
            this.gbsituacao.Text = "Situação/Detalhes";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.pictureBox1);
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
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(138, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Produtos";
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNovo.Location = new System.Drawing.Point(165, 405);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(106, 38);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalvar.Location = new System.Drawing.Point(277, 405);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(114, 37);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpar.Location = new System.Drawing.Point(398, 405);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(112, 37);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExcluir.Location = new System.Drawing.Point(516, 406);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(115, 37);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Lab_CadastroDeProdutos.Properties.Resources.simbolo_limpar;
            this.pictureBox6.Location = new System.Drawing.Point(401, 410);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(22, 28);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Lab_CadastroDeProdutos.Properties.Resources.simbolo_novo_arquivo;
            this.pictureBox2.Location = new System.Drawing.Point(182, 414);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(19, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Lab_CadastroDeProdutos.Properties.Resources.simbolo_excluir;
            this.pictureBox5.Location = new System.Drawing.Point(525, 414);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(23, 21);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Lab_CadastroDeProdutos.Properties.Resources.simbolo_salvar;
            this.pictureBox3.Location = new System.Drawing.Point(286, 414);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Lab_CadastroDeProdutos.Properties.Resources.simbolo_limpar;
            this.pictureBox4.Location = new System.Drawing.Point(398, 414);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 21);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab_CadastroDeProdutos.Properties.Resources.icone_titulo;
            this.pictureBox1.Location = new System.Drawing.Point(33, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.pictureBox4);
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
            ((System.ComponentModel.ISupportInitialize)(this.nudEstoqueMinimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCusto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVenda)).EndInit();
            this.gbsituacao.ResumeLayout(false);
            this.gbsituacao.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}

