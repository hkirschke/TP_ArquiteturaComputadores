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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
      this.txtBoxInfo = new System.Windows.Forms.TextBox();
      this.BtnGeraArquivo = new System.Windows.Forms.Button();
      this.BtnSobreInfo = new System.Windows.Forms.Button();
      this.BtnCarregaInfo = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // txtBoxInfo
      // 
      resources.ApplyResources(this.txtBoxInfo, "txtBoxInfo");
      this.txtBoxInfo.Name = "txtBoxInfo";
      // 
      // BtnGeraArquivo
      // 
      resources.ApplyResources(this.BtnGeraArquivo, "BtnGeraArquivo");
      this.BtnGeraArquivo.Name = "BtnGeraArquivo";
      this.BtnGeraArquivo.UseVisualStyleBackColor = true;
      this.BtnGeraArquivo.Click += new System.EventHandler(this.BtnGeraArquivo_Click);
      // 
      // BtnSobreInfo
      // 
      resources.ApplyResources(this.BtnSobreInfo, "BtnSobreInfo");
      this.BtnSobreInfo.Name = "BtnSobreInfo";
      this.BtnSobreInfo.UseVisualStyleBackColor = true;
      this.BtnSobreInfo.Click += new System.EventHandler(this.BtnSobreInfo_Click);
      // 
      // BtnCarregaInfo
      // 
      resources.ApplyResources(this.BtnCarregaInfo, "BtnCarregaInfo");
      this.BtnCarregaInfo.Name = "BtnCarregaInfo";
      this.BtnCarregaInfo.UseVisualStyleBackColor = true;
      this.BtnCarregaInfo.Click += new System.EventHandler(this.BtnCarregaInfo_Click);
      // 
      // FormPrincipal
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.BtnCarregaInfo);
      this.Controls.Add(this.BtnSobreInfo);
      this.Controls.Add(this.BtnGeraArquivo);
      this.Controls.Add(this.txtBoxInfo);
      this.Name = "FormPrincipal";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

    #endregion

    private System.Windows.Forms.TextBox txtBoxInfo;
    private System.Windows.Forms.Button BtnGeraArquivo;
    private System.Windows.Forms.Button BtnSobreInfo;
    private System.Windows.Forms.Button BtnCarregaInfo;
  }
}

