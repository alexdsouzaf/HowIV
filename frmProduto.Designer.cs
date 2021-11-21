
namespace HowIV
{
    partial class frmProduto
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdFiltro = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnConsultar = new System.Windows.Forms.ToolStripButton();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.grdProduto = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DES_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTD_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_CADASTRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VAL_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblEst = new System.Windows.Forms.Label();
            this.txtEst = new System.Windows.Forms.TextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnGravar = new System.Windows.Forms.ToolStripButton();
            this.btnAlterar = new System.Windows.Forms.ToolStripButton();
            this.btnRemover = new System.Windows.Forms.ToolStripButton();
            this.lblObs = new System.Windows.Forms.Label();
            this.lblDatCadastro = new System.Windows.Forms.Label();
            this.lblVal = new System.Windows.Forms.Label();
            this.lblQuant = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtVal = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpFiltros.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduto)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(501, 314);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpFiltros);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Controls.Add(this.pnlGrid);
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(493, 288);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consulta";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // grpFiltros
            // 
            this.grpFiltros.Controls.Add(this.label1);
            this.grpFiltros.Controls.Add(this.txtIdFiltro);
            this.grpFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpFiltros.Location = new System.Drawing.Point(3, 3);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Size = new System.Drawing.Size(487, 56);
            this.grpFiltros.TabIndex = 6;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Filtros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID";
            // 
            // txtIdFiltro
            // 
            this.txtIdFiltro.Location = new System.Drawing.Point(6, 30);
            this.txtIdFiltro.Name = "txtIdFiltro";
            this.txtIdFiltro.Size = new System.Drawing.Size(43, 20);
            this.txtIdFiltro.TabIndex = 8;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConsultar});
            this.toolStrip1.Location = new System.Drawing.Point(3, 62);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(487, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnConsultar
            // 
            this.btnConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnConsultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(62, 22);
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.grdProduto);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlGrid.Location = new System.Drawing.Point(3, 87);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(487, 176);
            this.pnlGrid.TabIndex = 2;
            // 
            // grdProduto
            // 
            this.grdProduto.AllowUserToDeleteRows = false;
            this.grdProduto.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DES_PRODUTO,
            this.OBS,
            this.QTD_PRODUTO,
            this.DATA_CADASTRO,
            this.VAL_PRODUTO,
            this.Column1});
            this.grdProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdProduto.Location = new System.Drawing.Point(0, 0);
            this.grdProduto.Name = "grdProduto";
            this.grdProduto.ReadOnly = true;
            this.grdProduto.RowTemplate.Height = 25;
            this.grdProduto.Size = new System.Drawing.Size(487, 176);
            this.grdProduto.TabIndex = 0;
            this.grdProduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProduto_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 35;
            // 
            // DES_PRODUTO
            // 
            this.DES_PRODUTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DES_PRODUTO.HeaderText = "Descrição";
            this.DES_PRODUTO.Name = "DES_PRODUTO";
            this.DES_PRODUTO.ReadOnly = true;
            this.DES_PRODUTO.Width = 80;
            // 
            // OBS
            // 
            this.OBS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OBS.HeaderText = "Observação";
            this.OBS.Name = "OBS";
            this.OBS.ReadOnly = true;
            this.OBS.Width = 90;
            // 
            // QTD_PRODUTO
            // 
            this.QTD_PRODUTO.HeaderText = "Quantidade";
            this.QTD_PRODUTO.Name = "QTD_PRODUTO";
            this.QTD_PRODUTO.ReadOnly = true;
            this.QTD_PRODUTO.Width = 80;
            // 
            // DATA_CADASTRO
            // 
            this.DATA_CADASTRO.HeaderText = "Data Cadastro";
            this.DATA_CADASTRO.Name = "DATA_CADASTRO";
            this.DATA_CADASTRO.ReadOnly = true;
            this.DATA_CADASTRO.Width = 70;
            // 
            // VAL_PRODUTO
            // 
            this.VAL_PRODUTO.HeaderText = "Valor (R$)";
            this.VAL_PRODUTO.Name = "VAL_PRODUTO";
            this.VAL_PRODUTO.ReadOnly = true;
            this.VAL_PRODUTO.Width = 55;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ESTOQUE";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(3, 263);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(487, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblEst);
            this.tabPage2.Controls.Add(this.txtEst);
            this.tabPage2.Controls.Add(this.toolStrip2);
            this.tabPage2.Controls.Add(this.lblObs);
            this.tabPage2.Controls.Add(this.lblDatCadastro);
            this.tabPage2.Controls.Add(this.lblVal);
            this.tabPage2.Controls.Add(this.lblQuant);
            this.tabPage2.Controls.Add(this.lblDescricao);
            this.tabPage2.Controls.Add(this.lblId);
            this.tabPage2.Controls.Add(this.txtVal);
            this.tabPage2.Controls.Add(this.txtData);
            this.tabPage2.Controls.Add(this.txtQuant);
            this.tabPage2.Controls.Add(this.txtObs);
            this.tabPage2.Controls.Add(this.txtDesc);
            this.tabPage2.Controls.Add(this.txtId);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(493, 288);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cadastro";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblEst
            // 
            this.lblEst.AutoSize = true;
            this.lblEst.Location = new System.Drawing.Point(405, 70);
            this.lblEst.Name = "lblEst";
            this.lblEst.Size = new System.Drawing.Size(46, 13);
            this.lblEst.TabIndex = 14;
            this.lblEst.Text = "Estoque";
            this.lblEst.Visible = false;
            // 
            // txtEst
            // 
            this.txtEst.Location = new System.Drawing.Point(405, 86);
            this.txtEst.Name = "txtEst";
            this.txtEst.Size = new System.Drawing.Size(61, 20);
            this.txtEst.TabIndex = 13;
            this.txtEst.Visible = false;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGravar,
            this.btnAlterar,
            this.btnRemover});
            this.toolStrip2.Location = new System.Drawing.Point(3, 260);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(487, 25);
            this.toolStrip2.TabIndex = 12;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnGravar
            // 
            this.btnGravar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnGravar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(45, 22);
            this.btnGravar.Text = "Gravar";
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(46, 22);
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Visible = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRemover.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(58, 22);
            this.btnRemover.Text = "Remover";
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(7, 69);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(65, 13);
            this.lblObs.TabIndex = 11;
            this.lblObs.Text = "Observação";
            // 
            // lblDatCadastro
            // 
            this.lblDatCadastro.AutoSize = true;
            this.lblDatCadastro.Location = new System.Drawing.Point(408, 29);
            this.lblDatCadastro.Name = "lblDatCadastro";
            this.lblDatCadastro.Size = new System.Drawing.Size(75, 13);
            this.lblDatCadastro.TabIndex = 10;
            this.lblDatCadastro.Text = "Data Cadastro";
            // 
            // lblVal
            // 
            this.lblVal.AutoSize = true;
            this.lblVal.Location = new System.Drawing.Point(267, 29);
            this.lblVal.Name = "lblVal";
            this.lblVal.Size = new System.Drawing.Size(70, 13);
            this.lblVal.TabIndex = 9;
            this.lblVal.Text = "Valor Unitário";
            // 
            // lblQuant
            // 
            this.lblQuant.AutoSize = true;
            this.lblQuant.Location = new System.Drawing.Point(339, 29);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(62, 13);
            this.lblQuant.TabIndex = 9;
            this.lblQuant.Text = "Quantidade";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(54, 29);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 8;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(6, 29);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "ID";
            // 
            // txtVal
            // 
            this.txtVal.Location = new System.Drawing.Point(267, 45);
            this.txtVal.Name = "txtVal";
            this.txtVal.Size = new System.Drawing.Size(68, 20);
            this.txtVal.TabIndex = 6;
            // 
            // txtData
            // 
            this.txtData.Enabled = false;
            this.txtData.Location = new System.Drawing.Point(408, 45);
            this.txtData.Mask = "00/00/0000 90:00";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(79, 20);
            this.txtData.TabIndex = 5;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // txtQuant
            // 
            this.txtQuant.Location = new System.Drawing.Point(339, 45);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(61, 20);
            this.txtQuant.TabIndex = 4;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(7, 86);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(394, 20);
            this.txtObs.TabIndex = 3;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(54, 45);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(207, 20);
            this.txtDesc.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(6, 45);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(43, 20);
            this.txtId.TabIndex = 0;
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 314);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..:: Produto ::..";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProduto)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView grdProduto;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnConsultar;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.Label lblDatCadastro;
        private System.Windows.Forms.Label lblVal;
        private System.Windows.Forms.Label lblQuant;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtVal;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnGravar;
        private System.Windows.Forms.ToolStripButton btnAlterar;
        private System.Windows.Forms.ToolStripButton btnRemover;
        private System.Windows.Forms.Label lblEst;
        private System.Windows.Forms.TextBox txtEst;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DES_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTD_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_CADASTRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VAL_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdFiltro;
    }
}