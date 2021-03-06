namespace PDVProject.UI
{
    partial class FuncionarioForm
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
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridFuncionarios = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtConsultaFunc = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(129, 113);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(61, 33);
            this.btn_excluir.TabIndex = 10;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(129, 74);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(61, 33);
            this.btn_editar.TabIndex = 9;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(52, 74);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(61, 72);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Novo";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(495, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Consulta de funcionários";
            // 
            // dataGridFuncionarios
            // 
            this.dataGridFuncionarios.AllowUserToAddRows = false;
            this.dataGridFuncionarios.AllowUserToDeleteRows = false;
            this.dataGridFuncionarios.AllowUserToResizeColumns = false;
            this.dataGridFuncionarios.AllowUserToResizeRows = false;
            this.dataGridFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFuncionarios.Location = new System.Drawing.Point(52, 213);
            this.dataGridFuncionarios.MultiSelect = false;
            this.dataGridFuncionarios.Name = "dataGridFuncionarios";
            this.dataGridFuncionarios.RowTemplate.Height = 25;
            this.dataGridFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridFuncionarios.ShowCellErrors = false;
            this.dataGridFuncionarios.ShowCellToolTips = false;
            this.dataGridFuncionarios.ShowEditingIcon = false;
            this.dataGridFuncionarios.ShowRowErrors = false;
            this.dataGridFuncionarios.Size = new System.Drawing.Size(1028, 415);
            this.dataGridFuncionarios.TabIndex = 12;
            this.dataGridFuncionarios.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridFuncionarios_UmClique);
            this.dataGridFuncionarios.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridFuncionarios_DoisCliques);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(1005, 175);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtConsultaFunc
            // 
            this.txtConsultaFunc.Location = new System.Drawing.Point(52, 175);
            this.txtConsultaFunc.Name = "txtConsultaFunc";
            this.txtConsultaFunc.Size = new System.Drawing.Size(925, 23);
            this.txtConsultaFunc.TabIndex = 14;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(208, 74);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 72);
            this.btnAtualizar.TabIndex = 15;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // FuncionarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 667);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.txtConsultaFunc);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dataGridFuncionarios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "FuncionarioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FuncionarioForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridFuncionarios;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtConsultaFunc;
        private System.Windows.Forms.Button btnAtualizar;
    }
}