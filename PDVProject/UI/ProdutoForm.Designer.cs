
namespace PDVProject.UI
{
    partial class ProdutoForm
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
            this.btn_excluirProd = new System.Windows.Forms.Button();
            this.btn_editarProd = new System.Windows.Forms.Button();
            this.btnCadastrarProd = new System.Windows.Forms.Button();
            this.dataGridProduto = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(433, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de produto";
            // 
            // btn_excluirProd
            // 
            this.btn_excluirProd.Location = new System.Drawing.Point(134, 109);
            this.btn_excluirProd.Name = "btn_excluirProd";
            this.btn_excluirProd.Size = new System.Drawing.Size(61, 33);
            this.btn_excluirProd.TabIndex = 13;
            this.btn_excluirProd.Text = "Excluir";
            this.btn_excluirProd.UseVisualStyleBackColor = true;
            // 
            // btn_editarProd
            // 
            this.btn_editarProd.Location = new System.Drawing.Point(134, 70);
            this.btn_editarProd.Name = "btn_editarProd";
            this.btn_editarProd.Size = new System.Drawing.Size(61, 33);
            this.btn_editarProd.TabIndex = 12;
            this.btn_editarProd.Text = "Editar";
            this.btn_editarProd.UseVisualStyleBackColor = true;
            this.btn_editarProd.Click += new System.EventHandler(this.btn_editarProd_Click);
            // 
            // btnCadastrarProd
            // 
            this.btnCadastrarProd.Location = new System.Drawing.Point(57, 70);
            this.btnCadastrarProd.Name = "btnCadastrarProd";
            this.btnCadastrarProd.Size = new System.Drawing.Size(61, 72);
            this.btnCadastrarProd.TabIndex = 11;
            this.btnCadastrarProd.Text = "Novo";
            this.btnCadastrarProd.UseVisualStyleBackColor = true;
            this.btnCadastrarProd.Click += new System.EventHandler(this.btnCadastrarProd_Click);
            // 
            // dataGridProduto
            // 
            this.dataGridProduto.AllowDrop = true;
            this.dataGridProduto.AllowUserToAddRows = false;
            this.dataGridProduto.AllowUserToDeleteRows = false;
            this.dataGridProduto.AllowUserToOrderColumns = true;
            this.dataGridProduto.AllowUserToResizeColumns = false;
            this.dataGridProduto.AllowUserToResizeRows = false;
            this.dataGridProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProduto.EnableHeadersVisualStyles = false;
            this.dataGridProduto.Location = new System.Drawing.Point(57, 209);
            this.dataGridProduto.MultiSelect = false;
            this.dataGridProduto.Name = "dataGridProduto";
            this.dataGridProduto.RowTemplate.Height = 25;
            this.dataGridProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProduto.ShowCellErrors = false;
            this.dataGridProduto.ShowCellToolTips = false;
            this.dataGridProduto.ShowEditingIcon = false;
            this.dataGridProduto.ShowRowErrors = false;
            this.dataGridProduto.Size = new System.Drawing.Size(1007, 392);
            this.dataGridProduto.TabIndex = 14;
            this.dataGridProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProduto_CellContentClick);
            this.dataGridProduto.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridUmClique);
            this.dataGridProduto.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridDoisCliques);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 168);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(918, 23);
            this.textBox1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(989, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.Location = new System.Drawing.Point(217, 70);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(75, 72);
            this.btn_Atualizar.TabIndex = 17;
            this.btn_Atualizar.Text = "Atualizar";
            this.btn_Atualizar.UseVisualStyleBackColor = true;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click);
            // 
            // ProdutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 667);
            this.Controls.Add(this.btn_Atualizar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridProduto);
            this.Controls.Add(this.btn_excluirProd);
            this.Controls.Add(this.btn_editarProd);
            this.Controls.Add(this.btnCadastrarProd);
            this.Controls.Add(this.label1);
            this.Name = "ProdutoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDVProject";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_excluirProd;
        private System.Windows.Forms.Button btn_editarProd;
        private System.Windows.Forms.Button btnCadastrarProd;
        private System.Windows.Forms.DataGridView dataGridProduto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Atualizar;
    }
}