namespace gestao_de_cliente
{
    partial class frm_dentro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_dentro));
            this.btn_consultaDados = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btn_saldo = new System.Windows.Forms.Button();
            this.btn_saques = new System.Windows.Forms.Button();
            this.btn_tranferencias = new System.Windows.Forms.Button();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_fe = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_consultaDados
            // 
            this.btn_consultaDados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(225)))));
            this.btn_consultaDados.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_consultaDados.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold);
            this.btn_consultaDados.Location = new System.Drawing.Point(92, 205);
            this.btn_consultaDados.Name = "btn_consultaDados";
            this.btn_consultaDados.Size = new System.Drawing.Size(203, 71);
            this.btn_consultaDados.TabIndex = 0;
            this.btn_consultaDados.Text = "Consutar Dados";
            this.btn_consultaDados.UseVisualStyleBackColor = false;
            this.btn_consultaDados.Click += new System.EventHandler(this.btn_consultaDados_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(12, 140);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(344, 35);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Movimento de conta";
            // 
            // btn_saldo
            // 
            this.btn_saldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(225)))));
            this.btn_saldo.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold);
            this.btn_saldo.Location = new System.Drawing.Point(333, 205);
            this.btn_saldo.Name = "btn_saldo";
            this.btn_saldo.Size = new System.Drawing.Size(202, 71);
            this.btn_saldo.TabIndex = 3;
            this.btn_saldo.Text = "Consultar Saldo";
            this.btn_saldo.UseVisualStyleBackColor = false;
            this.btn_saldo.Click += new System.EventHandler(this.btn_saldo_Click);
            // 
            // btn_saques
            // 
            this.btn_saques.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(225)))));
            this.btn_saques.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold);
            this.btn_saques.Location = new System.Drawing.Point(92, 303);
            this.btn_saques.Name = "btn_saques";
            this.btn_saques.Size = new System.Drawing.Size(203, 71);
            this.btn_saques.TabIndex = 4;
            this.btn_saques.Text = "Saques";
            this.btn_saques.UseVisualStyleBackColor = false;
            this.btn_saques.Click += new System.EventHandler(this.btn_saques_Click);
            // 
            // btn_tranferencias
            // 
            this.btn_tranferencias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(225)))));
            this.btn_tranferencias.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold);
            this.btn_tranferencias.Location = new System.Drawing.Point(333, 303);
            this.btn_tranferencias.Name = "btn_tranferencias";
            this.btn_tranferencias.Size = new System.Drawing.Size(202, 71);
            this.btn_tranferencias.TabIndex = 5;
            this.btn_tranferencias.Text = "Transferencias";
            this.btn_tranferencias.UseVisualStyleBackColor = false;
            this.btn_tranferencias.Click += new System.EventHandler(this.btn_tranferencias_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_nome.Location = new System.Drawing.Point(345, 146);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(230, 29);
            this.lbl_nome.TabIndex = 7;
            this.lbl_nome.Text = "(*************)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, -36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(495, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btn_fe
            // 
            this.btn_fe.BackColor = System.Drawing.Color.Transparent;
            this.btn_fe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_fe.FlatAppearance.BorderSize = 0;
            this.btn_fe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(32)))), ((int)(((byte)(131)))));
            this.btn_fe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fe.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fe.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_fe.Location = new System.Drawing.Point(43, 407);
            this.btn_fe.Name = "btn_fe";
            this.btn_fe.Size = new System.Drawing.Size(63, 31);
            this.btn_fe.TabIndex = 9;
            this.btn_fe.Text = "Sair";
            this.btn_fe.UseVisualStyleBackColor = false;
            this.btn_fe.Click += new System.EventHandler(this.btn_fe_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(18, 410);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(308, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 66);
            this.label2.TabIndex = 12;
            this.label2.Text = "Económico";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(157, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 66);
            this.label1.TabIndex = 11;
            this.label1.Text = "Banco ";
            // 
            // frm_dentro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(32)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(628, 451);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.btn_tranferencias);
            this.Controls.Add(this.btn_saques);
            this.Controls.Add(this.btn_saldo);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btn_consultaDados);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_fe);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_dentro";
            this.Text = "Dentro";
            this.Load += new System.EventHandler(this.frm_dentro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_consultaDados;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btn_saldo;
        private System.Windows.Forms.Button btn_saques;
        private System.Windows.Forms.Button btn_tranferencias;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_fe;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}