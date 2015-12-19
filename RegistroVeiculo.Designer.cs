namespace Centro_Loca_Mais
{
    partial class RegistroVeiculo
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
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblCarroNome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCarroNome = new System.Windows.Forms.TextBox();
            this.mkdCarroPlaca = new System.Windows.Forms.MaskedTextBox();
            this.mkdCarroAnoFaabricacao = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCarroKilometragem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.cbxFabricanteNome = new System.Windows.Forms.ComboBox();
            this.txtValorLocacao = new System.Windows.Forms.TextBox();
            this.lblAvisoDeErro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(302, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Veiculos";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(315, 470);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(100, 36);
            this.btnAdicionar.TabIndex = 8;
            this.btnAdicionar.Text = "Adicinar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click_1);
            // 
            // lblCarroNome
            // 
            this.lblCarroNome.AutoSize = true;
            this.lblCarroNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarroNome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCarroNome.Location = new System.Drawing.Point(47, 136);
            this.lblCarroNome.Name = "lblCarroNome";
            this.lblCarroNome.Size = new System.Drawing.Size(144, 20);
            this.lblCarroNome.TabIndex = 2;
            this.lblCarroNome.Text = "Nome do Veiculo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(15, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Categoria do Veiculo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(25, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome do Fabricante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(411, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ano Fabricação (AAAA-MM-DD)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(633, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Placa";
            // 
            // txtCarroNome
            // 
            this.txtCarroNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarroNome.Location = new System.Drawing.Point(197, 133);
            this.txtCarroNome.Name = "txtCarroNome";
            this.txtCarroNome.Size = new System.Drawing.Size(193, 24);
            this.txtCarroNome.TabIndex = 1;
            // 
            // mkdCarroPlaca
            // 
            this.mkdCarroPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkdCarroPlaca.Location = new System.Drawing.Point(708, 234);
            this.mkdCarroPlaca.Mask = "aaa0000   ";
            this.mkdCarroPlaca.Name = "mkdCarroPlaca";
            this.mkdCarroPlaca.Size = new System.Drawing.Size(75, 24);
            this.mkdCarroPlaca.TabIndex = 7;
            // 
            // mkdCarroAnoFaabricacao
            // 
            this.mkdCarroAnoFaabricacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkdCarroAnoFaabricacao.Location = new System.Drawing.Point(692, 186);
            this.mkdCarroAnoFaabricacao.Mask = "0000-00-00";
            this.mkdCarroAnoFaabricacao.Name = "mkdCarroAnoFaabricacao";
            this.mkdCarroAnoFaabricacao.Size = new System.Drawing.Size(91, 24);
            this.mkdCarroAnoFaabricacao.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(442, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Valor de Locação(00,00)";
            // 
            // txtCarroKilometragem
            // 
            this.txtCarroKilometragem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarroKilometragem.Location = new System.Drawing.Point(197, 256);
            this.txtCarroKilometragem.Name = "txtCarroKilometragem";
            this.txtCarroKilometragem.Size = new System.Drawing.Size(193, 24);
            this.txtCarroKilometragem.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(73, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Kilometragem";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(431, 470);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(100, 36);
            this.btnFinalizar.TabIndex = 9;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(197, 214);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(193, 26);
            this.cbxCategoria.TabIndex = 3;
            // 
            // cbxFabricanteNome
            // 
            this.cbxFabricanteNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFabricanteNome.FormattingEnabled = true;
            this.cbxFabricanteNome.Location = new System.Drawing.Point(197, 172);
            this.cbxFabricanteNome.Name = "cbxFabricanteNome";
            this.cbxFabricanteNome.Size = new System.Drawing.Size(193, 26);
            this.cbxFabricanteNome.TabIndex = 2;
            // 
            // txtValorLocacao
            // 
            this.txtValorLocacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorLocacao.Location = new System.Drawing.Point(670, 132);
            this.txtValorLocacao.Name = "txtValorLocacao";
            this.txtValorLocacao.Size = new System.Drawing.Size(113, 24);
            this.txtValorLocacao.TabIndex = 5;
            // 
            // lblAvisoDeErro
            // 
            this.lblAvisoDeErro.AutoSize = true;
            this.lblAvisoDeErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvisoDeErro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAvisoDeErro.Location = new System.Drawing.Point(312, 429);
            this.lblAvisoDeErro.Name = "lblAvisoDeErro";
            this.lblAvisoDeErro.Size = new System.Drawing.Size(0, 16);
            this.lblAvisoDeErro.TabIndex = 15;
            // 
            // RegistroVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(839, 561);
            this.Controls.Add(this.lblAvisoDeErro);
            this.Controls.Add(this.txtValorLocacao);
            this.Controls.Add(this.cbxFabricanteNome);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.txtCarroKilometragem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mkdCarroAnoFaabricacao);
            this.Controls.Add(this.mkdCarroPlaca);
            this.Controls.Add(this.txtCarroNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCarroNome);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "RegistroVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centro Loca Mais";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblCarroNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCarroNome;
        private System.Windows.Forms.MaskedTextBox mkdCarroPlaca;
        private System.Windows.Forms.MaskedTextBox mkdCarroAnoFaabricacao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCarroKilometragem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.ComboBox cbxFabricanteNome;
        private System.Windows.Forms.TextBox txtValorLocacao;
        private System.Windows.Forms.Label lblAvisoDeErro;
    }
}