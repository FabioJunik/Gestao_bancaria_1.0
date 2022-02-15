namespace gestao_de_cliente
{
    partial class frm_controle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_controle));
            this.btn_listagem = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saque = new System.Windows.Forms.Button();
            this.btn_saldo = new System.Windows.Forms.Button();
            this.btn_tranferencia = new System.Windows.Forms.Button();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.btn_deposito = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_listagem
            // 
            this.btn_listagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(225)))));
            this.btn_listagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listagem.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listagem.ForeColor = System.Drawing.Color.White;
            this.btn_listagem.Location = new System.Drawing.Point(46, 181);
            this.btn_listagem.Name = "btn_listagem";
            this.btn_listagem.Size = new System.Drawing.Size(183, 64);
            this.btn_listagem.TabIndex = 2;
            this.btn_listagem.Text = "Listagem geral de Clientes";
            this.btn_listagem.UseVisualStyleBackColor = false;
            this.btn_listagem.Click += new System.EventHandler(this.btn_listagem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, -59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(553, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(121, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 45);
            this.label1.TabIndex = 10;
            this.label1.Text = "Controle de Clientes";
            // 
            // saque
            // 
            this.saque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(225)))));
            this.saque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saque.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saque.ForeColor = System.Drawing.Color.White;
            this.saque.Location = new System.Drawing.Point(254, 274);
            this.saque.Name = "saque";
            this.saque.Size = new System.Drawing.Size(183, 64);
            this.saque.TabIndex = 15;
            this.saque.Text = "Saque ";
            this.saque.UseVisualStyleBackColor = false;
            this.saque.Click += new System.EventHandler(this.saque_Click);
            // 
            // btn_saldo
            // 
            this.btn_saldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(225)))));
            this.btn_saldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saldo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saldo.ForeColor = System.Drawing.Color.White;
            this.btn_saldo.Location = new System.Drawing.Point(462, 181);
            this.btn_saldo.Name = "btn_saldo";
            this.btn_saldo.Size = new System.Drawing.Size(183, 64);
            this.btn_saldo.TabIndex = 11;
            this.btn_saldo.Text = "Consuta de Saldos";
            this.btn_saldo.UseVisualStyleBackColor = false;
            this.btn_saldo.Click += new System.EventHandler(this.btn_saldo_Click);
            // 
            // btn_tranferencia
            // 
            this.btn_tranferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(225)))));
            this.btn_tranferencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tranferencia.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tranferencia.ForeColor = System.Drawing.Color.White;
            this.btn_tranferencia.Location = new System.Drawing.Point(462, 274);
            this.btn_tranferencia.Name = "btn_tranferencia";
            this.btn_tranferencia.Size = new System.Drawing.Size(183, 64);
            this.btn_tranferencia.TabIndex = 16;
            this.btn_tranferencia.Text = "Transferência";
            this.btn_tranferencia.UseVisualStyleBackColor = false;
            this.btn_tranferencia.Click += new System.EventHandler(this.btn_tranferencia_Click);
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(225)))));
            this.btn_pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pesquisar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesquisar.ForeColor = System.Drawing.Color.White;
            this.btn_pesquisar.Location = new System.Drawing.Point(254, 181);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(183, 64);
            this.btn_pesquisar.TabIndex = 0;
            this.btn_pesquisar.Text = "Pesquisar Clientes";
            this.btn_pesquisar.UseVisualStyleBackColor = false;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // btn_deposito
            // 
            this.btn_deposito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(225)))));
            this.btn_deposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deposito.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deposito.ForeColor = System.Drawing.Color.White;
            this.btn_deposito.Location = new System.Drawing.Point(46, 274);
            this.btn_deposito.Name = "btn_deposito";
            this.btn_deposito.Size = new System.Drawing.Size(183, 64);
            this.btn_deposito.TabIndex = 17;
            this.btn_deposito.Text = "Deposito";
            this.btn_deposito.UseVisualStyleBackColor = false;
            this.btn_deposito.Click += new System.EventHandler(this.btn_deposito_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(558, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 45);
            this.label2.TabIndex = 18;
            this.label2.Text = "______";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(-23, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 94);
            this.label4.TabIndex = 19;
            this.label4.Text = "______";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(322, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 64);
            this.label3.TabIndex = 21;
            this.label3.Text = "Económico";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(155, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 64);
            this.label5.TabIndex = 20;
            this.label5.Text = "Banco ";
            // 
            // frm_controle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(32)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(689, 368);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_deposito);
            this.Controls.Add(this.btn_tranferencia);
            this.Controls.Add(this.saque);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.btn_listagem);
            this.Controls.Add(this.btn_saldo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_controle";
            this.Text = "Controle";
            this.Load += new System.EventHandler(this.frm_controle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_listagem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saque;
        private System.Windows.Forms.Button btn_saldo;
        private System.Windows.Forms.Button btn_tranferencia;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Button btn_deposito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}