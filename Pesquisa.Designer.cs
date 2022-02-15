namespace gestao_de_cliente
{
    partial class frm_pesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_pesquisa));
            this.btn_listagem = new System.Windows.Forms.Button();
            this.dgv_listaClientes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ordenar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.txt_pesquizar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_listagem
            // 
            this.btn_listagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(32)))), ((int)(((byte)(131)))));
            this.btn_listagem.FlatAppearance.BorderSize = 0;
            this.btn_listagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listagem.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listagem.ForeColor = System.Drawing.Color.White;
            this.btn_listagem.Location = new System.Drawing.Point(302, 508);
            this.btn_listagem.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_listagem.Name = "btn_listagem";
            this.btn_listagem.Size = new System.Drawing.Size(95, 34);
            this.btn_listagem.TabIndex = 4;
            this.btn_listagem.Text = "Listar";
            this.btn_listagem.UseVisualStyleBackColor = false;
            this.btn_listagem.Click += new System.EventHandler(this.btn_listagem_Click);
            // 
            // dgv_listaClientes
            // 
            this.dgv_listaClientes.AllowUserToAddRows = false;
            this.dgv_listaClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(215)))));
            this.dgv_listaClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_listaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Saldo,
            this.Column4});
            this.dgv_listaClientes.Location = new System.Drawing.Point(8, 135);
            this.dgv_listaClientes.Name = "dgv_listaClientes";
            this.dgv_listaClientes.Size = new System.Drawing.Size(904, 366);
            this.dgv_listaClientes.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nome";
            this.Column1.MinimumWidth = 200;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 230;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "N° Conta";
            this.Column2.Name = "Column2";
            this.Column2.Width = 160;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "IBAM";
            this.Column3.Name = "Column3";
            this.Column3.Width = 240;
            // 
            // Saldo
            // 
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Senha";
            this.Column4.Name = "Column4";
            this.Column4.Width = 80;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-26, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(32)))), ((int)(((byte)(131)))));
            this.btn_limpar.FlatAppearance.BorderSize = 0;
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.ForeColor = System.Drawing.Color.White;
            this.btn_limpar.Location = new System.Drawing.Point(512, 508);
            this.btn_limpar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(95, 34);
            this.btn_limpar.TabIndex = 11;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(194, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 38);
            this.label1.TabIndex = 12;
            this.label1.Text = "Lintagem Geral dos Clientes";
            // 
            // btn_ordenar
            // 
            this.btn_ordenar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(32)))), ((int)(((byte)(131)))));
            this.btn_ordenar.FlatAppearance.BorderSize = 0;
            this.btn_ordenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ordenar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ordenar.ForeColor = System.Drawing.Color.White;
            this.btn_ordenar.Location = new System.Drawing.Point(407, 508);
            this.btn_ordenar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_ordenar.Name = "btn_ordenar";
            this.btn_ordenar.Size = new System.Drawing.Size(95, 34);
            this.btn_ordenar.TabIndex = 13;
            this.btn_ordenar.Text = "Ordenar";
            this.btn_ordenar.UseVisualStyleBackColor = false;
            this.btn_ordenar.Click += new System.EventHandler(this.btn_ordenar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(219, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nome";
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(32)))), ((int)(((byte)(131)))));
            this.btn_pesquisar.FlatAppearance.BorderSize = 0;
            this.btn_pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pesquisar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesquisar.ForeColor = System.Drawing.Color.White;
            this.btn_pesquisar.Location = new System.Drawing.Point(617, 88);
            this.btn_pesquisar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(76, 27);
            this.btn_pesquisar.TabIndex = 16;
            this.btn_pesquisar.Text = "Buscar";
            this.btn_pesquisar.UseVisualStyleBackColor = false;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // txt_pesquizar
            // 
            this.txt_pesquizar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pesquizar.Location = new System.Drawing.Point(288, 88);
            this.txt_pesquizar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_pesquizar.Name = "txt_pesquizar";
            this.txt_pesquizar.Size = new System.Drawing.Size(319, 27);
            this.txt_pesquizar.TabIndex = 15;
            // 
            // frm_pesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(924, 555);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.txt_pesquizar);
            this.Controls.Add(this.btn_ordenar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.dgv_listaClientes);
            this.Controls.Add(this.btn_listagem);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frm_pesquisa";
            this.Text = "Pesquisa";
            this.Load += new System.EventHandler(this.Pesquisa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_listagem;
        private System.Windows.Forms.DataGridView dgv_listaClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ordenar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.TextBox txt_pesquizar;
    }
}