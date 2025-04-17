namespace Comercio_02
{
    partial class Vendas
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
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblQtde = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblprecounit = new System.Windows.Forms.Label();
            this.btnBuscaCliente = new System.Windows.Forms.Button();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.btnBuscProd = new System.Windows.Forms.Button();
            this.txtPrecoUnico = new System.Windows.Forms.TextBox();
            this.dgVendas = new System.Windows.Forms.DataGridView();
            this.txtTotalComDesconto = new System.Windows.Forms.TextBox();
            this.txtTotalSemDesconto = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.txtDataCompra = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtidCliente = new System.Windows.Forms.TextBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtidProd = new System.Windows.Forms.TextBox();
            this.txtidVendas = new System.Windows.Forms.TextBox();
            this.lbltotalcomDesconto = new System.Windows.Forms.Label();
            this.lbltotalsemdesconto = new System.Windows.Forms.Label();
            this.lbldesconto = new System.Windows.Forms.Label();
            this.lbldatacompra = new System.Windows.Forms.Label();
            this.lblidcliente = new System.Windows.Forms.Label();
            this.lblIDProd = new System.Windows.Forms.Label();
            this.lblIDVendas = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(599, 509);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(84, 24);
            this.btnExcluir.TabIndex = 30;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(599, 537);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(84, 20);
            this.btnAlterar.TabIndex = 29;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // lblQtde
            // 
            this.lblQtde.AutoSize = true;
            this.lblQtde.Location = new System.Drawing.Point(117, 237);
            this.lblQtde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQtde.Name = "lblQtde";
            this.lblQtde.Size = new System.Drawing.Size(62, 13);
            this.lblQtde.TabIndex = 7;
            this.lblQtde.Text = "Quantidade";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(599, 483);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(85, 22);
            this.btnAdicionar.TabIndex = 28;
            this.btnAdicionar.Text = "Adicionar Mestre";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lblprecounit
            // 
            this.lblprecounit.AutoSize = true;
            this.lblprecounit.Location = new System.Drawing.Point(195, 237);
            this.lblprecounit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblprecounit.Name = "lblprecounit";
            this.lblprecounit.Size = new System.Drawing.Size(74, 13);
            this.lblprecounit.TabIndex = 9;
            this.lblprecounit.Text = "Preço Unitário";
            // 
            // btnBuscaCliente
            // 
            this.btnBuscaCliente.Location = new System.Drawing.Point(146, 152);
            this.btnBuscaCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscaCliente.Name = "btnBuscaCliente";
            this.btnBuscaCliente.Size = new System.Drawing.Size(21, 19);
            this.btnBuscaCliente.TabIndex = 27;
            this.btnBuscaCliente.Text = "...";
            this.btnBuscaCliente.UseVisualStyleBackColor = true;
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(120, 252);
            this.txtQtde.Margin = new System.Windows.Forms.Padding(2);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(60, 20);
            this.txtQtde.TabIndex = 23;
            // 
            // btnBuscProd
            // 
            this.btnBuscProd.Location = new System.Drawing.Point(56, 197);
            this.btnBuscProd.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscProd.Name = "btnBuscProd";
            this.btnBuscProd.Size = new System.Drawing.Size(15, 19);
            this.btnBuscProd.TabIndex = 26;
            this.btnBuscProd.Text = "...";
            this.btnBuscProd.UseVisualStyleBackColor = true;
            // 
            // txtPrecoUnico
            // 
            this.txtPrecoUnico.Location = new System.Drawing.Point(199, 252);
            this.txtPrecoUnico.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecoUnico.Name = "txtPrecoUnico";
            this.txtPrecoUnico.Size = new System.Drawing.Size(139, 20);
            this.txtPrecoUnico.TabIndex = 22;
            // 
            // dgVendas
            // 
            this.dgVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVendas.Location = new System.Drawing.Point(24, 329);
            this.dgVendas.Margin = new System.Windows.Forms.Padding(2);
            this.dgVendas.Name = "dgVendas";
            this.dgVendas.RowHeadersWidth = 51;
            this.dgVendas.RowTemplate.Height = 24;
            this.dgVendas.Size = new System.Drawing.Size(557, 259);
            this.dgVendas.TabIndex = 25;
            // 
            // txtTotalComDesconto
            // 
            this.txtTotalComDesconto.Location = new System.Drawing.Point(351, 290);
            this.txtTotalComDesconto.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalComDesconto.Name = "txtTotalComDesconto";
            this.txtTotalComDesconto.Size = new System.Drawing.Size(100, 20);
            this.txtTotalComDesconto.TabIndex = 21;
            // 
            // txtTotalSemDesconto
            // 
            this.txtTotalSemDesconto.Location = new System.Drawing.Point(120, 289);
            this.txtTotalSemDesconto.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalSemDesconto.Name = "txtTotalSemDesconto";
            this.txtTotalSemDesconto.Size = new System.Drawing.Size(101, 20);
            this.txtTotalSemDesconto.TabIndex = 20;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(24, 289);
            this.txtDesconto.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(81, 20);
            this.txtDesconto.TabIndex = 19;
            // 
            // txtDataCompra
            // 
            this.txtDataCompra.Location = new System.Drawing.Point(24, 252);
            this.txtDataCompra.Margin = new System.Windows.Forms.Padding(2);
            this.txtDataCompra.Name = "txtDataCompra";
            this.txtDataCompra.Size = new System.Drawing.Size(83, 20);
            this.txtDataCompra.TabIndex = 24;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(173, 169);
            this.txtNomeCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(164, 20);
            this.txtNomeCliente.TabIndex = 18;
            // 
            // txtidCliente
            // 
            this.txtidCliente.Location = new System.Drawing.Point(103, 169);
            this.txtidCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtidCliente.Name = "txtidCliente";
            this.txtidCliente.Size = new System.Drawing.Size(66, 20);
            this.txtidCliente.TabIndex = 17;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(86, 214);
            this.txtNomeProduto.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(252, 20);
            this.txtNomeProduto.TabIndex = 16;
            // 
            // txtidProd
            // 
            this.txtidProd.Location = new System.Drawing.Point(25, 214);
            this.txtidProd.Margin = new System.Windows.Forms.Padding(2);
            this.txtidProd.Name = "txtidProd";
            this.txtidProd.Size = new System.Drawing.Size(51, 20);
            this.txtidProd.TabIndex = 15;
            // 
            // txtidVendas
            // 
            this.txtidVendas.Location = new System.Drawing.Point(26, 169);
            this.txtidVendas.Margin = new System.Windows.Forms.Padding(2);
            this.txtidVendas.Name = "txtidVendas";
            this.txtidVendas.Size = new System.Drawing.Size(57, 20);
            this.txtidVendas.TabIndex = 14;
            // 
            // lbltotalcomDesconto
            // 
            this.lbltotalcomDesconto.AutoSize = true;
            this.lbltotalcomDesconto.Location = new System.Drawing.Point(348, 274);
            this.lbltotalcomDesconto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltotalcomDesconto.Name = "lbltotalcomDesconto";
            this.lbltotalcomDesconto.Size = new System.Drawing.Size(103, 13);
            this.lbltotalcomDesconto.TabIndex = 12;
            this.lbltotalcomDesconto.Text = "Total com Desconto";
            // 
            // lbltotalsemdesconto
            // 
            this.lbltotalsemdesconto.AutoSize = true;
            this.lbltotalsemdesconto.Location = new System.Drawing.Point(114, 274);
            this.lbltotalsemdesconto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltotalsemdesconto.Name = "lbltotalsemdesconto";
            this.lbltotalsemdesconto.Size = new System.Drawing.Size(102, 13);
            this.lbltotalsemdesconto.TabIndex = 11;
            this.lbltotalsemdesconto.Text = "Total sem Desconto";
            // 
            // lbldesconto
            // 
            this.lbldesconto.AutoSize = true;
            this.lbldesconto.Location = new System.Drawing.Point(21, 274);
            this.lbldesconto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldesconto.Name = "lbldesconto";
            this.lbldesconto.Size = new System.Drawing.Size(53, 13);
            this.lbldesconto.TabIndex = 10;
            this.lbldesconto.Text = "Desconto";
            // 
            // lbldatacompra
            // 
            this.lbldatacompra.AutoSize = true;
            this.lbldatacompra.Location = new System.Drawing.Point(21, 237);
            this.lbldatacompra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldatacompra.Name = "lbldatacompra";
            this.lbldatacompra.Size = new System.Drawing.Size(66, 13);
            this.lbldatacompra.TabIndex = 8;
            this.lbldatacompra.Text = "DataCompra";
            // 
            // lblidcliente
            // 
            this.lblidcliente.AutoSize = true;
            this.lblidcliente.Location = new System.Drawing.Point(100, 154);
            this.lblidcliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblidcliente.Name = "lblidcliente";
            this.lblidcliente.Size = new System.Drawing.Size(50, 13);
            this.lblidcliente.TabIndex = 6;
            this.lblidcliente.Text = "IDCliente";
            // 
            // lblIDProd
            // 
            this.lblIDProd.AutoSize = true;
            this.lblIDProd.Location = new System.Drawing.Point(21, 199);
            this.lblIDProd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIDProd.Name = "lblIDProd";
            this.lblIDProd.Size = new System.Drawing.Size(40, 13);
            this.lblIDProd.TabIndex = 13;
            this.lblIDProd.Text = "IDProd";
            // 
            // lblIDVendas
            // 
            this.lblIDVendas.AutoSize = true;
            this.lblIDVendas.Location = new System.Drawing.Point(23, 152);
            this.lblIDVendas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIDVendas.Name = "lblIDVendas";
            this.lblIDVendas.Size = new System.Drawing.Size(18, 13);
            this.lblIDVendas.TabIndex = 5;
            this.lblIDVendas.Text = "ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 129);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(557, 10);
            this.dataGridView1.TabIndex = 31;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(351, 252);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 20);
            this.textBox1.TabIndex = 32;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.Location = new System.Drawing.Point(225, 289);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 20);
            this.textBox2.TabIndex = 33;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox3.Location = new System.Drawing.Point(457, 289);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(124, 20);
            this.textBox3.TabIndex = 34;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox4.Location = new System.Drawing.Point(351, 214);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(230, 20);
            this.textBox4.TabIndex = 35;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox5.Location = new System.Drawing.Point(351, 169);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(102, 20);
            this.textBox5.TabIndex = 36;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox6.Location = new System.Drawing.Point(457, 169);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(124, 20);
            this.textBox6.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 274);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Null";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 237);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Null";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Null";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 152);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Null";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 274);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Null";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(454, 114);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "TOTAL";
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 599);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.lblQtde);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lblprecounit);
            this.Controls.Add(this.btnBuscaCliente);
            this.Controls.Add(this.txtQtde);
            this.Controls.Add(this.btnBuscProd);
            this.Controls.Add(this.txtPrecoUnico);
            this.Controls.Add(this.dgVendas);
            this.Controls.Add(this.txtTotalComDesconto);
            this.Controls.Add(this.txtTotalSemDesconto);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.txtDataCompra);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.txtidCliente);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.txtidProd);
            this.Controls.Add(this.txtidVendas);
            this.Controls.Add(this.lbltotalcomDesconto);
            this.Controls.Add(this.lbltotalsemdesconto);
            this.Controls.Add(this.lbldesconto);
            this.Controls.Add(this.lbldatacompra);
            this.Controls.Add(this.lblidcliente);
            this.Controls.Add(this.lblIDProd);
            this.Controls.Add(this.lblIDVendas);
            this.Name = "Vendas";
            this.Text = "Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.dgVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label lblQtde;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblprecounit;
        private System.Windows.Forms.Button btnBuscaCliente;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Button btnBuscProd;
        private System.Windows.Forms.TextBox txtPrecoUnico;
        private System.Windows.Forms.DataGridView dgVendas;
        private System.Windows.Forms.TextBox txtTotalComDesconto;
        private System.Windows.Forms.TextBox txtTotalSemDesconto;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.TextBox txtDataCompra;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtidCliente;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtidProd;
        private System.Windows.Forms.TextBox txtidVendas;
        private System.Windows.Forms.Label lbltotalcomDesconto;
        private System.Windows.Forms.Label lbltotalsemdesconto;
        private System.Windows.Forms.Label lbldesconto;
        private System.Windows.Forms.Label lbldatacompra;
        private System.Windows.Forms.Label lblidcliente;
        private System.Windows.Forms.Label lblIDProd;
        private System.Windows.Forms.Label lblIDVendas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}