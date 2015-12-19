namespace Centro_Loca_Mais
{
    partial class HistoricoDeLocacao
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalLocacao = new System.Windows.Forms.Label();
            this.dlwHistoricoLocacao = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dlwHistoricoLocacao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Historico de locacão";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total de Locação";
            // 
            // lblTotalLocacao
            // 
            this.lblTotalLocacao.AutoSize = true;
            this.lblTotalLocacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLocacao.Location = new System.Drawing.Point(355, 147);
            this.lblTotalLocacao.Name = "lblTotalLocacao";
            this.lblTotalLocacao.Size = new System.Drawing.Size(0, 16);
            this.lblTotalLocacao.TabIndex = 3;
            // 
            // dlwHistoricoLocacao
            // 
            this.dlwHistoricoLocacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dlwHistoricoLocacao.Location = new System.Drawing.Point(1, 191);
            this.dlwHistoricoLocacao.Name = "dlwHistoricoLocacao";
            this.dlwHistoricoLocacao.Size = new System.Drawing.Size(841, 311);
            this.dlwHistoricoLocacao.TabIndex = 4;
            // 
            // HistoricoDeLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(839, 561);
            this.Controls.Add(this.dlwHistoricoLocacao);
            this.Controls.Add(this.lblTotalLocacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "HistoricoDeLocacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centro Loca Mais";
            ((System.ComponentModel.ISupportInitialize)(this.dlwHistoricoLocacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalLocacao;
        private System.Windows.Forms.DataGridView dlwHistoricoLocacao;
    }
}