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
      this.BtnGeraArquivo = new System.Windows.Forms.Button();
      this.BtnSobreInfo = new System.Windows.Forms.Button();
      this.BtnCarregaInfo = new System.Windows.Forms.Button();
      this.TabInfoES = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.dtgResumo = new System.Windows.Forms.DataGridView();
      this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.TabInfoHard = new System.Windows.Forms.TabPage();
      this.dtgES = new System.Windows.Forms.DataGridView();
      this.Recurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Dispositivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.dtgIRQ = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tabPage3 = new System.Windows.Forms.TabPage();
      this.dtgMemo = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tabPage4 = new System.Windows.Forms.TabPage();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.dtgDisk = new System.Windows.Forms.DataGridView();
      this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.FreeSpace = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.TabInfoES.SuspendLayout();
      this.tabPage1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgResumo)).BeginInit();
      this.TabInfoHard.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgES)).BeginInit();
      this.tabPage2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgIRQ)).BeginInit();
      this.tabPage3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgMemo)).BeginInit();
      this.tabPage4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtgDisk)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // BtnGeraArquivo
      // 
      resources.ApplyResources(this.BtnGeraArquivo, "BtnGeraArquivo");
      this.BtnGeraArquivo.BackColor = System.Drawing.SystemColors.HotTrack;
      this.BtnGeraArquivo.ForeColor = System.Drawing.SystemColors.ButtonFace;
      this.BtnGeraArquivo.Name = "BtnGeraArquivo";
      this.BtnGeraArquivo.UseVisualStyleBackColor = false;
      this.BtnGeraArquivo.Click += new System.EventHandler(this.BtnGeraArquivo_Click);
      // 
      // BtnSobreInfo
      // 
      resources.ApplyResources(this.BtnSobreInfo, "BtnSobreInfo");
      this.BtnSobreInfo.BackColor = System.Drawing.SystemColors.HotTrack;
      this.BtnSobreInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
      this.BtnSobreInfo.Name = "BtnSobreInfo";
      this.BtnSobreInfo.UseVisualStyleBackColor = false;
      this.BtnSobreInfo.Click += new System.EventHandler(this.BtnSobreInfo_Click);
      // 
      // BtnCarregaInfo
      // 
      resources.ApplyResources(this.BtnCarregaInfo, "BtnCarregaInfo");
      this.BtnCarregaInfo.BackColor = System.Drawing.SystemColors.HotTrack;
      this.BtnCarregaInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
      this.BtnCarregaInfo.Name = "BtnCarregaInfo";
      this.BtnCarregaInfo.UseVisualStyleBackColor = false;
      this.BtnCarregaInfo.Click += new System.EventHandler(this.BtnCarregaInfo_Click);
      // 
      // TabInfoES
      // 
      resources.ApplyResources(this.TabInfoES, "TabInfoES");
      this.TabInfoES.Controls.Add(this.tabPage1);
      this.TabInfoES.Controls.Add(this.TabInfoHard);
      this.TabInfoES.Controls.Add(this.tabPage2);
      this.TabInfoES.Controls.Add(this.tabPage3);
      this.TabInfoES.Controls.Add(this.tabPage4);
      this.TabInfoES.Multiline = true;
      this.TabInfoES.Name = "TabInfoES";
      this.TabInfoES.SelectedIndex = 0;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.dtgResumo);
      resources.ApplyResources(this.tabPage1, "tabPage1");
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // dtgResumo
      // 
      this.dtgResumo.AllowUserToAddRows = false;
      this.dtgResumo.AllowUserToDeleteRows = false;
      this.dtgResumo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      this.dtgResumo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
      this.dtgResumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgResumo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Valor});
      resources.ApplyResources(this.dtgResumo, "dtgResumo");
      this.dtgResumo.Name = "dtgResumo";
      this.dtgResumo.ReadOnly = true;
      this.dtgResumo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
      // 
      // Item
      // 
      resources.ApplyResources(this.Item, "Item");
      this.Item.Name = "Item";
      this.Item.ReadOnly = true;
      // 
      // Valor
      // 
      resources.ApplyResources(this.Valor, "Valor");
      this.Valor.Name = "Valor";
      this.Valor.ReadOnly = true;
      // 
      // TabInfoHard
      // 
      this.TabInfoHard.Controls.Add(this.dtgES);
      resources.ApplyResources(this.TabInfoHard, "TabInfoHard");
      this.TabInfoHard.Name = "TabInfoHard";
      this.TabInfoHard.UseVisualStyleBackColor = true;
      // 
      // dtgES
      // 
      this.dtgES.AllowUserToAddRows = false;
      this.dtgES.AllowUserToDeleteRows = false;
      this.dtgES.AllowUserToOrderColumns = true;
      this.dtgES.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      this.dtgES.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
      this.dtgES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgES.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Recurso,
            this.Dispositivo});
      resources.ApplyResources(this.dtgES, "dtgES");
      this.dtgES.Name = "dtgES";
      this.dtgES.ReadOnly = true;
      // 
      // Recurso
      // 
      resources.ApplyResources(this.Recurso, "Recurso");
      this.Recurso.Name = "Recurso";
      this.Recurso.ReadOnly = true;
      // 
      // Dispositivo
      // 
      resources.ApplyResources(this.Dispositivo, "Dispositivo");
      this.Dispositivo.Name = "Dispositivo";
      this.Dispositivo.ReadOnly = true;
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.dtgIRQ);
      resources.ApplyResources(this.tabPage2, "tabPage2");
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // dtgIRQ
      // 
      this.dtgIRQ.AllowUserToAddRows = false;
      this.dtgIRQ.AllowUserToDeleteRows = false;
      this.dtgIRQ.AllowUserToOrderColumns = true;
      this.dtgIRQ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      this.dtgIRQ.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
      this.dtgIRQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgIRQ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
      resources.ApplyResources(this.dtgIRQ, "dtgIRQ");
      this.dtgIRQ.Name = "dtgIRQ";
      this.dtgIRQ.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn1
      // 
      resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn2
      // 
      resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.ReadOnly = true;
      // 
      // tabPage3
      // 
      this.tabPage3.Controls.Add(this.dtgMemo);
      resources.ApplyResources(this.tabPage3, "tabPage3");
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.UseVisualStyleBackColor = true;
      // 
      // dtgMemo
      // 
      this.dtgMemo.AllowUserToAddRows = false;
      this.dtgMemo.AllowUserToDeleteRows = false;
      this.dtgMemo.AllowUserToOrderColumns = true;
      this.dtgMemo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      this.dtgMemo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
      this.dtgMemo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgMemo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
      resources.ApplyResources(this.dtgMemo, "dtgMemo");
      this.dtgMemo.Name = "dtgMemo";
      this.dtgMemo.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn3
      // 
      resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      this.dataGridViewTextBoxColumn3.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn4
      // 
      resources.ApplyResources(this.dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      this.dataGridViewTextBoxColumn4.ReadOnly = true;
      // 
      // tabPage4
      // 
      this.tabPage4.Controls.Add(this.dataGridView1);
      this.tabPage4.Controls.Add(this.dtgDisk);
      resources.ApplyResources(this.tabPage4, "tabPage4");
      this.tabPage4.Name = "tabPage4";
      this.tabPage4.UseVisualStyleBackColor = true;
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.AllowUserToOrderColumns = true;
      this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      resources.ApplyResources(this.dataGridView1, "dataGridView1");
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      // 
      // dtgDisk
      // 
      this.dtgDisk.AllowUserToAddRows = false;
      this.dtgDisk.AllowUserToDeleteRows = false;
      this.dtgDisk.AllowUserToOrderColumns = true;
      this.dtgDisk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      this.dtgDisk.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
      this.dtgDisk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgDisk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.FreeSpace});
      resources.ApplyResources(this.dtgDisk, "dtgDisk");
      this.dtgDisk.Name = "dtgDisk";
      this.dtgDisk.ReadOnly = true;
      // 
      // Nome
      // 
      resources.ApplyResources(this.Nome, "Nome");
      this.Nome.Name = "Nome";
      this.Nome.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn5
      // 
      resources.ApplyResources(this.dataGridViewTextBoxColumn5, "dataGridViewTextBoxColumn5");
      this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
      this.dataGridViewTextBoxColumn5.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn6
      // 
      resources.ApplyResources(this.dataGridViewTextBoxColumn6, "dataGridViewTextBoxColumn6");
      this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
      this.dataGridViewTextBoxColumn6.ReadOnly = true;
      // 
      // FreeSpace
      // 
      resources.ApplyResources(this.FreeSpace, "FreeSpace");
      this.FreeSpace.Name = "FreeSpace";
      this.FreeSpace.ReadOnly = true;
      // 
      // pictureBox1
      // 
      resources.ApplyResources(this.pictureBox1, "pictureBox1");
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.TabStop = false;
      // 
      // FormPrincipal
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.TabInfoES);
      this.Controls.Add(this.BtnCarregaInfo);
      this.Controls.Add(this.BtnSobreInfo);
      this.Controls.Add(this.BtnGeraArquivo);
      this.Name = "FormPrincipal";
      this.TabInfoES.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dtgResumo)).EndInit();
      this.TabInfoHard.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dtgES)).EndInit();
      this.tabPage2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dtgIRQ)).EndInit();
      this.tabPage3.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dtgMemo)).EndInit();
      this.tabPage4.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtgDisk)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);

        }

    #endregion
    private System.Windows.Forms.Button BtnGeraArquivo;
    private System.Windows.Forms.Button BtnSobreInfo;
    private System.Windows.Forms.Button BtnCarregaInfo;
    private System.Windows.Forms.TabControl TabInfoES;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.DataGridView dtgResumo;
    private System.Windows.Forms.DataGridViewTextBoxColumn Item;
    private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    private System.Windows.Forms.TabPage TabInfoHard;
    private System.Windows.Forms.DataGridView dtgES;
    private System.Windows.Forms.DataGridViewTextBoxColumn Recurso;
    private System.Windows.Forms.DataGridViewTextBoxColumn Dispositivo;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TabPage tabPage3;
    private System.Windows.Forms.DataGridView dtgMemo;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private System.Windows.Forms.DataGridView dtgIRQ;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.TabPage tabPage4;
    private System.Windows.Forms.DataGridView dtgDisk;
    private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    private System.Windows.Forms.DataGridViewTextBoxColumn FreeSpace; 
    private System.Windows.Forms.DataGridView dataGridView1;
  }
}

