
namespace PDVProject.UI
{
    partial class MainForm2
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
            this.btnNovoCliente = new System.Windows.Forms.Button();
            this.btnNovoProduto = new System.Windows.Forms.Button();
            this.btn_func = new System.Windows.Forms.Button();
            this.btn_vendas = new System.Windows.Forms.Button();
            this.btn_pg = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVenda = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNovoCliente.Location = new System.Drawing.Point(309, 463);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Size = new System.Drawing.Size(156, 40);
            this.btnNovoCliente.TabIndex = 0;
            this.btnNovoCliente.Text = "Clientes";
            this.btnNovoCliente.UseVisualStyleBackColor = true;
            this.btnNovoCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNovoProduto
            // 
            this.btnNovoProduto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNovoProduto.Location = new System.Drawing.Point(309, 536);
            this.btnNovoProduto.Name = "btnNovoProduto";
            this.btnNovoProduto.Size = new System.Drawing.Size(156, 40);
            this.btnNovoProduto.TabIndex = 1;
            this.btnNovoProduto.Text = "Produtos";
            this.btnNovoProduto.UseVisualStyleBackColor = true;
            this.btnNovoProduto.Click += new System.EventHandler(this.btnNovoProduto_Click);
            // 
            // btn_func
            // 
            this.btn_func.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_func.Location = new System.Drawing.Point(548, 463);
            this.btn_func.Name = "btn_func";
            this.btn_func.Size = new System.Drawing.Size(156, 40);
            this.btn_func.TabIndex = 4;
            this.btn_func.Text = "Funcionários";
            this.btn_func.UseVisualStyleBackColor = true;
            this.btn_func.Click += new System.EventHandler(this.btn_func_Click);
            // 
            // btn_vendas
            // 
            this.btn_vendas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_vendas.Location = new System.Drawing.Point(548, 536);
            this.btn_vendas.Name = "btn_vendas";
            this.btn_vendas.Size = new System.Drawing.Size(156, 40);
            this.btn_vendas.TabIndex = 5;
            this.btn_vendas.Text = "Consultar vendas";
            this.btn_vendas.UseVisualStyleBackColor = true;
            // 
            // btn_pg
            // 
            this.btn_pg.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_pg.Location = new System.Drawing.Point(789, 463);
            this.btn_pg.Name = "btn_pg";
            this.btn_pg.Size = new System.Drawing.Size(156, 40);
            this.btn_pg.TabIndex = 6;
            this.btn_pg.Text = "Formas de pagamento";
            this.btn_pg.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(789, 536);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Consultar caixas";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnVenda
            // 
            this.btnVenda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVenda.Location = new System.Drawing.Point(309, 247);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(156, 58);
            this.btnVenda.TabIndex = 8;
            this.btnVenda.Text = "Iniciar venda";
            this.btnVenda.UseVisualStyleBackColor = true;
            this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(548, 247);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 58);
            this.button3.TabIndex = 9;
            this.button3.Text = "Configurações";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_finalizar.Location = new System.Drawing.Point(789, 247);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(156, 58);
            this.btn_finalizar.TabIndex = 10;
            this.btn_finalizar.Text = "Finalizar";
            this.btn_finalizar.UseVisualStyleBackColor = true;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(470, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 50);
            this.label1.TabIndex = 11;
            this.label1.Text = "Etrade Crackeado";
            // 
            // MainForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_finalizar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnVenda);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_pg);
            this.Controls.Add(this.btn_vendas);
            this.Controls.Add(this.btn_func);
            this.Controls.Add(this.btnNovoProduto);
            this.Controls.Add(this.btnNovoCliente);
            this.Name = "MainForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDVProject";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovoCliente;
        private System.Windows.Forms.Button btnNovoProduto;
        private System.Windows.Forms.Button btn_func;
        private System.Windows.Forms.Button btn_vendas;
        private System.Windows.Forms.Button btn_pg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVenda;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.Label label1;
    }
}