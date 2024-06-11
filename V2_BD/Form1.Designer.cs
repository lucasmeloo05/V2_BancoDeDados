namespace V2_BD
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvCarro = new System.Windows.Forms.DataGridView();
            this.btnAdicionarCarro = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.tbxCombustivel = new System.Windows.Forms.TextBox();
            this.tbxCambio = new System.Windows.Forms.TextBox();
            this.tbxCor = new System.Windows.Forms.TextBox();
            this.tbxQuilometragem = new System.Windows.Forms.TextBox();
            this.tbxValor = new System.Windows.Forms.TextBox();
            this.tbxAno = new System.Windows.Forms.TextBox();
            this.tbxMarca = new System.Windows.Forms.TextBox();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.lblCombustivel = new System.Windows.Forms.Label();
            this.lblCambio = new System.Windows.Forms.Label();
            this.lblCor = new System.Windows.Forms.Label();
            this.lblQuilometragem = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbxNomeM = new System.Windows.Forms.TextBox();
            this.btnEditarM = new System.Windows.Forms.Button();
            this.dgvMoto = new System.Windows.Forms.DataGridView();
            this.btnMostrarMoto = new System.Windows.Forms.Button();
            this.btnAdicionarMoto = new System.Windows.Forms.Button();
            this.tbxMarchasM = new System.Windows.Forms.TextBox();
            this.tbxEstiloM = new System.Windows.Forms.TextBox();
            this.tbxCorM = new System.Windows.Forms.TextBox();
            this.tbxQuilometragemM = new System.Windows.Forms.TextBox();
            this.tbxValorM = new System.Windows.Forms.TextBox();
            this.tbxAnoM = new System.Windows.Forms.TextBox();
            this.tbxMarcaM = new System.Windows.Forms.TextBox();
            this.lblMarchasM = new System.Windows.Forms.Label();
            this.lblEstiloM = new System.Windows.Forms.Label();
            this.lblCorM = new System.Windows.Forms.Label();
            this.lblKmM = new System.Windows.Forms.Label();
            this.lblValorM = new System.Windows.Forms.Label();
            this.lblAnoM = new System.Windows.Forms.Label();
            this.lblMarcaM = new System.Windows.Forms.Label();
            this.lblNomeM = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataSet1 = new V2_BD.DataSet1();
            this.carroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carroTableAdapter = new V2_BD.DataSet1TableAdapters.CarroTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarro)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 536);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.btnEditar);
            this.tabPage1.Controls.Add(this.dgvCarro);
            this.tabPage1.Controls.Add(this.btnAdicionarCarro);
            this.tabPage1.Controls.Add(this.btnMostrar);
            this.tabPage1.Controls.Add(this.tbxCombustivel);
            this.tabPage1.Controls.Add(this.tbxCambio);
            this.tabPage1.Controls.Add(this.tbxCor);
            this.tabPage1.Controls.Add(this.tbxQuilometragem);
            this.tabPage1.Controls.Add(this.tbxValor);
            this.tabPage1.Controls.Add(this.tbxAno);
            this.tabPage1.Controls.Add(this.tbxMarca);
            this.tabPage1.Controls.Add(this.tbxNome);
            this.tabPage1.Controls.Add(this.lblCombustivel);
            this.tabPage1.Controls.Add(this.lblCambio);
            this.tabPage1.Controls.Add(this.lblCor);
            this.tabPage1.Controls.Add(this.lblQuilometragem);
            this.tabPage1.Controls.Add(this.lblValor);
            this.tabPage1.Controls.Add(this.lblAno);
            this.tabPage1.Controls.Add(this.lblMarca);
            this.tabPage1.Controls.Add(this.lblNome);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 509);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Carros";
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(498, 238);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(135, 31);
            this.btnEditar.TabIndex = 20;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvCarro
            // 
            this.dgvCarro.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCarro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarro.Location = new System.Drawing.Point(30, 294);
            this.dgvCarro.Name = "dgvCarro";
            this.dgvCarro.Size = new System.Drawing.Size(703, 194);
            this.dgvCarro.TabIndex = 19;
            // 
            // btnAdicionarCarro
            // 
            this.btnAdicionarCarro.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarCarro.Location = new System.Drawing.Point(135, 238);
            this.btnAdicionarCarro.Name = "btnAdicionarCarro";
            this.btnAdicionarCarro.Size = new System.Drawing.Size(135, 31);
            this.btnAdicionarCarro.TabIndex = 18;
            this.btnAdicionarCarro.Text = "ADICIONAR";
            this.btnAdicionarCarro.UseVisualStyleBackColor = true;
            this.btnAdicionarCarro.Click += new System.EventHandler(this.btnAdicionarCarro_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(317, 238);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(135, 31);
            this.btnMostrar.TabIndex = 17;
            this.btnMostrar.Text = "MOSTRAR";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // tbxCombustivel
            // 
            this.tbxCombustivel.Location = new System.Drawing.Point(498, 198);
            this.tbxCombustivel.Name = "tbxCombustivel";
            this.tbxCombustivel.Size = new System.Drawing.Size(263, 20);
            this.tbxCombustivel.TabIndex = 15;
            // 
            // tbxCambio
            // 
            this.tbxCambio.Location = new System.Drawing.Point(498, 143);
            this.tbxCambio.Name = "tbxCambio";
            this.tbxCambio.Size = new System.Drawing.Size(263, 20);
            this.tbxCambio.TabIndex = 14;
            // 
            // tbxCor
            // 
            this.tbxCor.Location = new System.Drawing.Point(498, 89);
            this.tbxCor.Name = "tbxCor";
            this.tbxCor.Size = new System.Drawing.Size(263, 20);
            this.tbxCor.TabIndex = 13;
            // 
            // tbxQuilometragem
            // 
            this.tbxQuilometragem.Location = new System.Drawing.Point(498, 41);
            this.tbxQuilometragem.Name = "tbxQuilometragem";
            this.tbxQuilometragem.Size = new System.Drawing.Size(263, 20);
            this.tbxQuilometragem.TabIndex = 12;
            // 
            // tbxValor
            // 
            this.tbxValor.Location = new System.Drawing.Point(85, 201);
            this.tbxValor.Name = "tbxValor";
            this.tbxValor.Size = new System.Drawing.Size(263, 20);
            this.tbxValor.TabIndex = 11;
            // 
            // tbxAno
            // 
            this.tbxAno.Location = new System.Drawing.Point(85, 146);
            this.tbxAno.Name = "tbxAno";
            this.tbxAno.Size = new System.Drawing.Size(263, 20);
            this.tbxAno.TabIndex = 10;
            // 
            // tbxMarca
            // 
            this.tbxMarca.Location = new System.Drawing.Point(85, 92);
            this.tbxMarca.Name = "tbxMarca";
            this.tbxMarca.Size = new System.Drawing.Size(263, 20);
            this.tbxMarca.TabIndex = 9;
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(85, 41);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(263, 20);
            this.tbxNome.TabIndex = 8;
            // 
            // lblCombustivel
            // 
            this.lblCombustivel.AutoSize = true;
            this.lblCombustivel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombustivel.Location = new System.Drawing.Point(390, 195);
            this.lblCombustivel.Name = "lblCombustivel";
            this.lblCombustivel.Size = new System.Drawing.Size(113, 29);
            this.lblCombustivel.TabIndex = 7;
            this.lblCombustivel.Text = "Combustível:";
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.Location = new System.Drawing.Point(427, 140);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(76, 29);
            this.lblCambio.TabIndex = 6;
            this.lblCambio.Text = "Câmbio:";
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCor.Location = new System.Drawing.Point(460, 86);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(43, 29);
            this.lblCor.TabIndex = 5;
            this.lblCor.Text = "Cor:";
            // 
            // lblQuilometragem
            // 
            this.lblQuilometragem.AutoSize = true;
            this.lblQuilometragem.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuilometragem.Location = new System.Drawing.Point(365, 38);
            this.lblQuilometragem.Name = "lblQuilometragem";
            this.lblQuilometragem.Size = new System.Drawing.Size(138, 29);
            this.lblQuilometragem.TabIndex = 4;
            this.lblQuilometragem.Text = "Quilometragem:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(31, 198);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(58, 29);
            this.lblValor.TabIndex = 3;
            this.lblValor.Text = "Valor:";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(41, 143);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(48, 29);
            this.lblAno.TabIndex = 2;
            this.lblAno.Text = "Ano:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(25, 89);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(64, 29);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(25, 38);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(64, 29);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.Controls.Add(this.tbxNomeM);
            this.tabPage2.Controls.Add(this.btnEditarM);
            this.tabPage2.Controls.Add(this.dgvMoto);
            this.tabPage2.Controls.Add(this.btnMostrarMoto);
            this.tabPage2.Controls.Add(this.btnAdicionarMoto);
            this.tabPage2.Controls.Add(this.tbxMarchasM);
            this.tabPage2.Controls.Add(this.tbxEstiloM);
            this.tabPage2.Controls.Add(this.tbxCorM);
            this.tabPage2.Controls.Add(this.tbxQuilometragemM);
            this.tabPage2.Controls.Add(this.tbxValorM);
            this.tabPage2.Controls.Add(this.tbxAnoM);
            this.tabPage2.Controls.Add(this.tbxMarcaM);
            this.tabPage2.Controls.Add(this.lblMarchasM);
            this.tabPage2.Controls.Add(this.lblEstiloM);
            this.tabPage2.Controls.Add(this.lblCorM);
            this.tabPage2.Controls.Add(this.lblKmM);
            this.tabPage2.Controls.Add(this.lblValorM);
            this.tabPage2.Controls.Add(this.lblAnoM);
            this.tabPage2.Controls.Add(this.lblMarcaM);
            this.tabPage2.Controls.Add(this.lblNomeM);
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 509);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Motos";
            // 
            // tbxNomeM
            // 
            this.tbxNomeM.Location = new System.Drawing.Point(85, 41);
            this.tbxNomeM.Name = "tbxNomeM";
            this.tbxNomeM.Size = new System.Drawing.Size(263, 20);
            this.tbxNomeM.TabIndex = 22;
            // 
            // btnEditarM
            // 
            this.btnEditarM.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarM.Location = new System.Drawing.Point(498, 238);
            this.btnEditarM.Name = "btnEditarM";
            this.btnEditarM.Size = new System.Drawing.Size(135, 31);
            this.btnEditarM.TabIndex = 21;
            this.btnEditarM.Text = "EDITAR";
            this.btnEditarM.UseVisualStyleBackColor = true;
            this.btnEditarM.Click += new System.EventHandler(this.btnEditarM_Click);
            // 
            // dgvMoto
            // 
            this.dgvMoto.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMoto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMoto.Location = new System.Drawing.Point(30, 294);
            this.dgvMoto.Name = "dgvMoto";
            this.dgvMoto.Size = new System.Drawing.Size(703, 194);
            this.dgvMoto.TabIndex = 20;
            // 
            // btnMostrarMoto
            // 
            this.btnMostrarMoto.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarMoto.Location = new System.Drawing.Point(317, 238);
            this.btnMostrarMoto.Name = "btnMostrarMoto";
            this.btnMostrarMoto.Size = new System.Drawing.Size(135, 31);
            this.btnMostrarMoto.TabIndex = 19;
            this.btnMostrarMoto.Text = "MOSTRAR";
            this.btnMostrarMoto.UseVisualStyleBackColor = true;
            this.btnMostrarMoto.Click += new System.EventHandler(this.btnMostrarMoto_Click);
            // 
            // btnAdicionarMoto
            // 
            this.btnAdicionarMoto.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionarMoto.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarMoto.Location = new System.Drawing.Point(135, 238);
            this.btnAdicionarMoto.Name = "btnAdicionarMoto";
            this.btnAdicionarMoto.Size = new System.Drawing.Size(135, 31);
            this.btnAdicionarMoto.TabIndex = 18;
            this.btnAdicionarMoto.Text = "ADICIONAR";
            this.btnAdicionarMoto.UseVisualStyleBackColor = false;
            this.btnAdicionarMoto.Click += new System.EventHandler(this.btnAdicionarMoto_Click);
            // 
            // tbxMarchasM
            // 
            this.tbxMarchasM.Location = new System.Drawing.Point(498, 198);
            this.tbxMarchasM.Name = "tbxMarchasM";
            this.tbxMarchasM.Size = new System.Drawing.Size(263, 20);
            this.tbxMarchasM.TabIndex = 17;
            // 
            // tbxEstiloM
            // 
            this.tbxEstiloM.Location = new System.Drawing.Point(498, 143);
            this.tbxEstiloM.Name = "tbxEstiloM";
            this.tbxEstiloM.Size = new System.Drawing.Size(263, 20);
            this.tbxEstiloM.TabIndex = 16;
            // 
            // tbxCorM
            // 
            this.tbxCorM.Location = new System.Drawing.Point(498, 89);
            this.tbxCorM.Name = "tbxCorM";
            this.tbxCorM.Size = new System.Drawing.Size(263, 20);
            this.tbxCorM.TabIndex = 15;
            // 
            // tbxQuilometragemM
            // 
            this.tbxQuilometragemM.Location = new System.Drawing.Point(498, 41);
            this.tbxQuilometragemM.Name = "tbxQuilometragemM";
            this.tbxQuilometragemM.Size = new System.Drawing.Size(263, 20);
            this.tbxQuilometragemM.TabIndex = 14;
            // 
            // tbxValorM
            // 
            this.tbxValorM.Location = new System.Drawing.Point(85, 201);
            this.tbxValorM.Name = "tbxValorM";
            this.tbxValorM.Size = new System.Drawing.Size(263, 20);
            this.tbxValorM.TabIndex = 13;
            // 
            // tbxAnoM
            // 
            this.tbxAnoM.Location = new System.Drawing.Point(85, 146);
            this.tbxAnoM.Name = "tbxAnoM";
            this.tbxAnoM.Size = new System.Drawing.Size(263, 20);
            this.tbxAnoM.TabIndex = 12;
            // 
            // tbxMarcaM
            // 
            this.tbxMarcaM.Location = new System.Drawing.Point(85, 92);
            this.tbxMarcaM.Name = "tbxMarcaM";
            this.tbxMarcaM.Size = new System.Drawing.Size(263, 20);
            this.tbxMarcaM.TabIndex = 11;
            // 
            // lblMarchasM
            // 
            this.lblMarchasM.AutoSize = true;
            this.lblMarchasM.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarchasM.Location = new System.Drawing.Point(422, 194);
            this.lblMarchasM.Name = "lblMarchasM";
            this.lblMarchasM.Size = new System.Drawing.Size(81, 29);
            this.lblMarchasM.TabIndex = 9;
            this.lblMarchasM.Text = "Marchas:";
            // 
            // lblEstiloM
            // 
            this.lblEstiloM.AutoSize = true;
            this.lblEstiloM.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstiloM.Location = new System.Drawing.Point(444, 139);
            this.lblEstiloM.Name = "lblEstiloM";
            this.lblEstiloM.Size = new System.Drawing.Size(59, 29);
            this.lblEstiloM.TabIndex = 7;
            this.lblEstiloM.Text = "Estilo:";
            // 
            // lblCorM
            // 
            this.lblCorM.AutoSize = true;
            this.lblCorM.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorM.Location = new System.Drawing.Point(460, 86);
            this.lblCorM.Name = "lblCorM";
            this.lblCorM.Size = new System.Drawing.Size(43, 29);
            this.lblCorM.TabIndex = 6;
            this.lblCorM.Text = "Cor:";
            // 
            // lblKmM
            // 
            this.lblKmM.AutoSize = true;
            this.lblKmM.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKmM.Location = new System.Drawing.Point(365, 38);
            this.lblKmM.Name = "lblKmM";
            this.lblKmM.Size = new System.Drawing.Size(138, 29);
            this.lblKmM.TabIndex = 5;
            this.lblKmM.Text = "Quilometragem:";
            // 
            // lblValorM
            // 
            this.lblValorM.AutoSize = true;
            this.lblValorM.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorM.Location = new System.Drawing.Point(31, 198);
            this.lblValorM.Name = "lblValorM";
            this.lblValorM.Size = new System.Drawing.Size(58, 29);
            this.lblValorM.TabIndex = 4;
            this.lblValorM.Text = "Valor:";
            // 
            // lblAnoM
            // 
            this.lblAnoM.AutoSize = true;
            this.lblAnoM.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnoM.Location = new System.Drawing.Point(41, 143);
            this.lblAnoM.Name = "lblAnoM";
            this.lblAnoM.Size = new System.Drawing.Size(48, 29);
            this.lblAnoM.TabIndex = 3;
            this.lblAnoM.Text = "Ano:";
            // 
            // lblMarcaM
            // 
            this.lblMarcaM.AutoSize = true;
            this.lblMarcaM.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaM.Location = new System.Drawing.Point(25, 89);
            this.lblMarcaM.Name = "lblMarcaM";
            this.lblMarcaM.Size = new System.Drawing.Size(64, 29);
            this.lblMarcaM.TabIndex = 2;
            this.lblMarcaM.Text = "Marca:";
            // 
            // lblNomeM
            // 
            this.lblNomeM.AutoSize = true;
            this.lblNomeM.BackColor = System.Drawing.Color.LightGray;
            this.lblNomeM.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeM.Location = new System.Drawing.Point(25, 38);
            this.lblNomeM.Name = "lblNomeM";
            this.lblNomeM.Size = new System.Drawing.Size(64, 29);
            this.lblNomeM.TabIndex = 1;
            this.lblNomeM.Text = "Nome:";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "carro.png");
            this.imageList1.Images.SetKeyName(1, "moto.png");
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carroBindingSource
            // 
            this.carroBindingSource.DataMember = "Carro";
            this.carroBindingSource.DataSource = this.dataSet1;
            // 
            // carroTableAdapter
            // 
            this.carroTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cadastrar Veículo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarro)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCombustivel;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Label lblQuilometragem;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.TextBox tbxCombustivel;
        private System.Windows.Forms.TextBox tbxCambio;
        private System.Windows.Forms.TextBox tbxCor;
        private System.Windows.Forms.TextBox tbxQuilometragem;
        private System.Windows.Forms.TextBox tbxValor;
        private System.Windows.Forms.TextBox tbxAno;
        private System.Windows.Forms.TextBox tbxMarca;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.Button btnAdicionarCarro;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource carroBindingSource;
        private DataSet1TableAdapters.CarroTableAdapter carroTableAdapter;
        private System.Windows.Forms.DataGridView dgvCarro;
        private System.Windows.Forms.Label lblNomeM;
        private System.Windows.Forms.Label lblMarcaM;
        private System.Windows.Forms.Label lblAnoM;
        private System.Windows.Forms.Label lblEstiloM;
        private System.Windows.Forms.Label lblCorM;
        private System.Windows.Forms.Label lblKmM;
        private System.Windows.Forms.Label lblValorM;
        private System.Windows.Forms.Label lblMarchasM;
        private System.Windows.Forms.TextBox tbxMarchasM;
        private System.Windows.Forms.TextBox tbxEstiloM;
        private System.Windows.Forms.TextBox tbxCorM;
        private System.Windows.Forms.TextBox tbxQuilometragemM;
        private System.Windows.Forms.TextBox tbxValorM;
        private System.Windows.Forms.TextBox tbxAnoM;
        private System.Windows.Forms.TextBox tbxMarcaM;
        private System.Windows.Forms.Button btnMostrarMoto;
        private System.Windows.Forms.Button btnAdicionarMoto;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dgvMoto;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEditarM;
        private System.Windows.Forms.TextBox tbxNomeM;
    }
}

