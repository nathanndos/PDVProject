namespace PDVProject.UI
{
    partial class MovimentoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOperacao = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.disableOperacao = new System.Windows.Forms.TextBox();
            this.disableCliente = new System.Windows.Forms.TextBox();
            this.disableVendedor = new System.Windows.Forms.TextBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.disableProduto = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecoProduto = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgProdutosVenda = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.btnDesconto = new System.Windows.Forms.Button();
            this.btnFinanceiro = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutosVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Operação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vendedor";
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Location = new System.Drawing.Point(18, 55);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(100, 23);
            this.txtCodProduto.TabIndex = 3;
            this.txtCodProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodProduto_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Código:";
            // 
            // txtOperacao
            // 
            this.txtOperacao.Enabled = false;
            this.txtOperacao.Location = new System.Drawing.Point(106, 121);
            this.txtOperacao.Name = "txtOperacao";
            this.txtOperacao.Size = new System.Drawing.Size(54, 23);
            this.txtOperacao.TabIndex = 10;
            this.txtOperacao.Text = "500";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(428, 121);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(54, 23);
            this.txtCliente.TabIndex = 11;
            this.txtCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCliente_KeyDown);
            // 
            // txtVendedor
            // 
            this.txtVendedor.Location = new System.Drawing.Point(106, 150);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(54, 23);
            this.txtVendedor.TabIndex = 12;
            this.txtVendedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVendedor_KeyDown);
            // 
            // disableOperacao
            // 
            this.disableOperacao.Enabled = false;
            this.disableOperacao.Location = new System.Drawing.Point(166, 121);
            this.disableOperacao.Name = "disableOperacao";
            this.disableOperacao.Size = new System.Drawing.Size(191, 23);
            this.disableOperacao.TabIndex = 13;
            this.disableOperacao.Text = "Venda";
            // 
            // disableCliente
            // 
            this.disableCliente.Enabled = false;
            this.disableCliente.Location = new System.Drawing.Point(488, 121);
            this.disableCliente.Name = "disableCliente";
            this.disableCliente.Size = new System.Drawing.Size(252, 23);
            this.disableCliente.TabIndex = 1;
            // 
            // disableVendedor
            // 
            this.disableVendedor.Enabled = false;
            this.disableVendedor.Location = new System.Drawing.Point(166, 150);
            this.disableVendedor.Name = "disableVendedor";
            this.disableVendedor.Size = new System.Drawing.Size(191, 23);
            this.disableVendedor.TabIndex = 2;
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(133, 55);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(100, 23);
            this.txtQtd.TabIndex = 4;
            this.txtQtd.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Qtd:";
            // 
            // disableProduto
            // 
            this.disableProduto.Enabled = false;
            this.disableProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.disableProduto.Location = new System.Drawing.Point(18, 84);
            this.disableProduto.Name = "disableProduto";
            this.disableProduto.Size = new System.Drawing.Size(848, 29);
            this.disableProduto.TabIndex = 18;
            this.disableProduto.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtPrecoProduto);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dgProdutosVenda);
            this.groupBox1.Controls.Add(this.disableProduto);
            this.groupBox1.Controls.Add(this.txtCodProduto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtQtd);
            this.groupBox1.Location = new System.Drawing.Point(42, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(888, 427);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produtos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(252, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Preço Unitário:";
            // 
            // txtPrecoProduto
            // 
            this.txtPrecoProduto.Location = new System.Drawing.Point(252, 55);
            this.txtPrecoProduto.Name = "txtPrecoProduto";
            this.txtPrecoProduto.Size = new System.Drawing.Size(100, 23);
            this.txtPrecoProduto.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(825, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(744, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Lançar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dgProdutosVenda
            // 
            this.dgProdutosVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutosVenda.Location = new System.Drawing.Point(18, 132);
            this.dgProdutosVenda.Name = "dgProdutosVenda";
            this.dgProdutosVenda.RowTemplate.Height = 25;
            this.dgProdutosVenda.Size = new System.Drawing.Size(848, 275);
            this.dgProdutosVenda.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(771, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Sequencia";
            // 
            // textBox10
            // 
            this.textBox10.Enabled = false;
            this.textBox10.Location = new System.Drawing.Point(850, 121);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(80, 23);
            this.textBox10.TabIndex = 21;
            // 
            // btnDesconto
            // 
            this.btnDesconto.Location = new System.Drawing.Point(227, 65);
            this.btnDesconto.Name = "btnDesconto";
            this.btnDesconto.Size = new System.Drawing.Size(75, 35);
            this.btnDesconto.TabIndex = 0;
            this.btnDesconto.TabStop = false;
            this.btnDesconto.Text = "Desconto";
            this.btnDesconto.UseVisualStyleBackColor = true;
            // 
            // btnFinanceiro
            // 
            this.btnFinanceiro.Location = new System.Drawing.Point(134, 29);
            this.btnFinanceiro.Name = "btnFinanceiro";
            this.btnFinanceiro.Size = new System.Drawing.Size(71, 71);
            this.btnFinanceiro.TabIndex = 0;
            this.btnFinanceiro.TabStop = false;
            this.btnFinanceiro.Text = "Financeiro ";
            this.btnFinanceiro.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(42, 29);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 71);
            this.btnGravar.TabIndex = 0;
            this.btnGravar.TabStop = false;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(227, 29);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 35);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.TabStop = false;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // MovimentoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnFinanceiro);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.disableVendedor);
            this.Controls.Add(this.btnDesconto);
            this.Controls.Add(this.disableCliente);
            this.Controls.Add(this.disableOperacao);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtOperacao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MovimentoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimento";
            this.Load += new System.EventHandler(this.Movimento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutosVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOperacao;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.TextBox disableOperacao;
        private System.Windows.Forms.TextBox disableCliente;
        private System.Windows.Forms.TextBox disableVendedor;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox disableProduto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgProdutosVenda;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button btnDesconto;
        private System.Windows.Forms.Button btnFinanceiro;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrecoProduto;
    }
}