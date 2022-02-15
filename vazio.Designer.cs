namespace gestao_de_cliente
{
    partial class frm_vazio
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
            this.pnl_vazio = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnl_vazio
            // 
            this.pnl_vazio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_vazio.Location = new System.Drawing.Point(0, 0);
            this.pnl_vazio.Name = "pnl_vazio";
            this.pnl_vazio.Size = new System.Drawing.Size(689, 368);
            this.pnl_vazio.TabIndex = 1;
            // 
            // frm_vazio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 368);
            this.Controls.Add(this.pnl_vazio);
            this.Name = "frm_vazio";
            this.Text = "vazio";
            this.Load += new System.EventHandler(this.frm_vazio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_vazio;
    }
}