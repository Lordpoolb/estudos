namespace Aula0309
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMarcaCarro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModeloCarro = new System.Windows.Forms.TextBox();
            this.btnReservar = new System.Windows.Forms.Button();
            this.chkManha = new System.Windows.Forms.CheckBox();
            this.chkTarde = new System.Windows.Forms.CheckBox();
            this.chkNoite = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelplaca = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.pgPix = new System.Windows.Forms.RadioButton();
            this.pgCartao = new System.Windows.Forms.RadioButton();
            this.pgDinheiro = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(12, 75);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome Cliente";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(12, 144);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(100, 20);
            this.txtNomeCliente.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Marca Veiculo";
            // 
            // txtMarcaCarro
            // 
            this.txtMarcaCarro.Location = new System.Drawing.Point(12, 220);
            this.txtMarcaCarro.Name = "txtMarcaCarro";
            this.txtMarcaCarro.Size = new System.Drawing.Size(100, 20);
            this.txtMarcaCarro.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Modelo Veiculo";
            // 
            // txtModeloCarro
            // 
            this.txtModeloCarro.Location = new System.Drawing.Point(12, 289);
            this.txtModeloCarro.Name = "txtModeloCarro";
            this.txtModeloCarro.Size = new System.Drawing.Size(100, 20);
            this.txtModeloCarro.TabIndex = 1;
            // 
            // btnReservar
            // 
            this.btnReservar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnReservar.Location = new System.Drawing.Point(12, 365);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(1174, 75);
            this.btnReservar.TabIndex = 2;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = false;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // chkManha
            // 
            this.chkManha.AutoSize = true;
            this.chkManha.Location = new System.Drawing.Point(622, 75);
            this.chkManha.Name = "chkManha";
            this.chkManha.Size = new System.Drawing.Size(59, 17);
            this.chkManha.TabIndex = 3;
            this.chkManha.Text = "Manhã";
            this.chkManha.UseVisualStyleBackColor = true;
            // 
            // chkTarde
            // 
            this.chkTarde.AutoSize = true;
            this.chkTarde.Location = new System.Drawing.Point(726, 75);
            this.chkTarde.Name = "chkTarde";
            this.chkTarde.Size = new System.Drawing.Size(54, 17);
            this.chkTarde.TabIndex = 3;
            this.chkTarde.Text = "Tarde";
            this.chkTarde.UseVisualStyleBackColor = true;
            // 
            // chkNoite
            // 
            this.chkNoite.AutoSize = true;
            this.chkNoite.Location = new System.Drawing.Point(822, 75);
            this.chkNoite.Name = "chkNoite";
            this.chkNoite.Size = new System.Drawing.Size(51, 17);
            this.chkNoite.TabIndex = 3;
            this.chkNoite.Text = "Noite";
            this.chkNoite.UseVisualStyleBackColor = true;
            this.chkNoite.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(738, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Periodo";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelplaca
            // 
            this.labelplaca.AutoSize = true;
            this.labelplaca.Location = new System.Drawing.Point(193, 41);
            this.labelplaca.Name = "labelplaca";
            this.labelplaca.Size = new System.Drawing.Size(87, 13);
            this.labelplaca.TabIndex = 0;
            this.labelplaca.Text = "Placa do Veiculo";
            this.labelplaca.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(196, 75);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 20);
            this.txtPlaca.TabIndex = 1;
            this.txtPlaca.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pgPix
            // 
            this.pgPix.AutoSize = true;
            this.pgPix.Checked = true;
            this.pgPix.Location = new System.Drawing.Point(622, 273);
            this.pgPix.Name = "pgPix";
            this.pgPix.Size = new System.Drawing.Size(42, 17);
            this.pgPix.TabIndex = 5;
            this.pgPix.TabStop = true;
            this.pgPix.Text = "PIX";
            this.pgPix.UseVisualStyleBackColor = true;
            this.pgPix.CheckedChanged += new System.EventHandler(this.pgPix_CheckedChanged);
            // 
            // pgCartao
            // 
            this.pgCartao.AutoSize = true;
            this.pgCartao.Location = new System.Drawing.Point(726, 273);
            this.pgCartao.Name = "pgCartao";
            this.pgCartao.Size = new System.Drawing.Size(56, 17);
            this.pgCartao.TabIndex = 5;
            this.pgCartao.TabStop = true;
            this.pgCartao.Text = "Cartão";
            this.pgCartao.UseVisualStyleBackColor = true;
            this.pgCartao.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // pgDinheiro
            // 
            this.pgDinheiro.AutoSize = true;
            this.pgDinheiro.Location = new System.Drawing.Point(822, 273);
            this.pgDinheiro.Name = "pgDinheiro";
            this.pgDinheiro.Size = new System.Drawing.Size(64, 17);
            this.pgDinheiro.TabIndex = 5;
            this.pgDinheiro.TabStop = true;
            this.pgDinheiro.Text = "Dinheiro";
            this.pgDinheiro.UseVisualStyleBackColor = true;
            this.pgDinheiro.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(676, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Formas de pagamento";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1198, 494);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pgDinheiro);
            this.Controls.Add(this.pgCartao);
            this.Controls.Add(this.pgPix);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkNoite);
            this.Controls.Add(this.chkTarde);
            this.Controls.Add(this.chkManha);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.txtModeloCarro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.txtMarcaCarro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.labelplaca);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Reserve seu Carro ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMarcaCarro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtModeloCarro;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.CheckBox chkManha;
        private System.Windows.Forms.CheckBox chkTarde;
        private System.Windows.Forms.CheckBox chkNoite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelplaca;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.RadioButton pgPix;
        private System.Windows.Forms.RadioButton pgCartao;
        private System.Windows.Forms.RadioButton pgDinheiro;
        private System.Windows.Forms.Label label6;
    }
}

