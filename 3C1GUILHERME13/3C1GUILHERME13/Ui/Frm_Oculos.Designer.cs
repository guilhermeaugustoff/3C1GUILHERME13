namespace _3C1GUILHERME13
{
    partial class Frm_Oculos
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
            this.lbl_id = new System.Windows.Forms.Label();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.dgv_oculos = new System.Windows.Forms.DataGridView();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_cor = new System.Windows.Forms.Label();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_cor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_oculos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(12, 16);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 13);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "ID";
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(12, 69);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(184, 50);
            this.btn_cadastrar.TabIndex = 1;
            this.btn_cadastrar.Text = "CADASTRAR";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(12, 32);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(184, 20);
            this.txt_id.TabIndex = 2;
            this.txt_id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgv_oculos
            // 
            this.dgv_oculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_oculos.Location = new System.Drawing.Point(12, 135);
            this.dgv_oculos.Name = "dgv_oculos";
            this.dgv_oculos.Size = new System.Drawing.Size(626, 232);
            this.dgv_oculos.TabIndex = 3;
            this.dgv_oculos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_oculos_CellContentClick);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(232, 16);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(39, 13);
            this.lbl_nome.TabIndex = 4;
            this.lbl_nome.Text = "NOME";
            this.lbl_nome.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_cor
            // 
            this.lbl_cor.AutoSize = true;
            this.lbl_cor.Location = new System.Drawing.Point(456, 16);
            this.lbl_cor.Name = "lbl_cor";
            this.lbl_cor.Size = new System.Drawing.Size(30, 13);
            this.lbl_cor.TabIndex = 5;
            this.lbl_cor.Text = "COR";
            this.lbl_cor.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(235, 69);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(187, 50);
            this.btn_editar.TabIndex = 6;
            this.btn_editar.Text = "EDITAR";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(459, 69);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(179, 50);
            this.btn_excluir.TabIndex = 7;
            this.btn_excluir.Text = "EXCLUIR";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(235, 32);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(187, 20);
            this.txt_nome.TabIndex = 8;
            // 
            // txt_cor
            // 
            this.txt_cor.Location = new System.Drawing.Point(459, 32);
            this.txt_cor.Name = "txt_cor";
            this.txt_cor.Size = new System.Drawing.Size(179, 20);
            this.txt_cor.TabIndex = 9;
            this.txt_cor.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Frm_Oculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 378);
            this.Controls.Add(this.txt_cor);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.lbl_cor);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.dgv_oculos);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.lbl_id);
            this.Name = "Frm_Oculos";
            this.Text = "Frm_Oculos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_oculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.DataGridView dgv_oculos;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_cor;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_cor;
    }
}

