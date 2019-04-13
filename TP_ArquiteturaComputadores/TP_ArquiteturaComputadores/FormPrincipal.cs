using System;
using System.Windows.Forms;
using TP_ArquiteturaComputadores.Classes;

namespace TP_ArquiteturaComputadores
{
  public partial class FormPrincipal : Form
  {
    private XML XML = new XML();
    public FormPrincipal()
    {
      InitializeComponent();
    }

    private void BtnSobreInfo_Click(object sender, EventArgs e)
    {
      try
      {
        AboutBox aboutBox = new AboutBox();
        aboutBox.Show();
        //Application.Run(aboutBox);
      }
      catch (Exception)
      {
        MessageBox.Show("Erro ao abrir informações sobre aplicação", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void BtnGeraArquivo_Click(object sender, EventArgs e)
    {
      try
      {
        XML.CriaArquivoInfo();
      }
      catch (Exception ex)
      {
        if (ex.Message.Equals("Arquivo já existe"))
          MessageBox.Show($"{ex.Message}","Atenção!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        else
          MessageBox.Show($"Erro gerar arquivo: {ex.Message}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void BtnCarregaInfo_Click(object sender, EventArgs e)
    {
      try
      {
        XML.LeInfoXML();
        txtBoxInfo.Text = XML.RetConteudoNodo();
      }
      catch (Exception ex)
      {
        MessageBox.Show($"Erro carregar informações: {ex.Message}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}
