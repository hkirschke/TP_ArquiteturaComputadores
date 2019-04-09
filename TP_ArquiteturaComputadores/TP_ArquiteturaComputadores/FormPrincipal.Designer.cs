namespace TP_ArquiteturaComputadores
{
    partial class FormPrincipal
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
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.BtnGeraArquivo = new System.Windows.Forms.Button();
      this.BtnSobreInfo = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(230, 28);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(558, 367);
      this.textBox1.TabIndex = 0;
      // 
      // BtnGeraArquivo
      // 
      this.BtnGeraArquivo.AutoSize = true;
      this.BtnGeraArquivo.Location = new System.Drawing.Point(28, 96);
      this.BtnGeraArquivo.Name = "BtnGeraArquivo";
      this.BtnGeraArquivo.Size = new System.Drawing.Size(101, 23);
      this.BtnGeraArquivo.TabIndex = 1;
      this.BtnGeraArquivo.Text = "Gera Informações";
      this.BtnGeraArquivo.UseVisualStyleBackColor = true;
      // 
      // BtnSobreInfo
      // 
      this.BtnSobreInfo.Location = new System.Drawing.Point(28, 198);
      this.BtnSobreInfo.Name = "BtnSobreInfo";
      this.BtnSobreInfo.Size = new System.Drawing.Size(75, 23);
      this.BtnSobreInfo.TabIndex = 2;
      this.BtnSobreInfo.Text = "Informações";
      this.BtnSobreInfo.UseVisualStyleBackColor = true;
      // 
      // FormPrincipal
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.BtnSobreInfo);
      this.Controls.Add(this.BtnGeraArquivo);
      this.Controls.Add(this.textBox1);
      this.Name = "FormPrincipal";
      this.Text = "PUC - Arquitetura de Computadores";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

    #endregion

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button BtnGeraArquivo;
    private System.Windows.Forms.Button BtnSobreInfo;
  }
}

