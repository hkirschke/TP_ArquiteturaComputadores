using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;
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
        LimpaGrades();
        XML.LeInfoXML();
        PreencheGrade(dtgES, XML.RetConteudoNodo(XML.XMLParams.InfoES));
        PreencheGrade(dtgIRQ, XML.RetConteudoNodo(XML.XMLParams.InfoIRQ));
        PreencheGrade(dtgMemo, XML.RetConteudoNodo(XML.XMLParams.Memo));
        PreencheGrade(dtgResumo, XML.GetNodoInfo(XML.XMLParams.ResumoSistema));
      }
      catch (Exception ex)
      {
        MessageBox.Show($"Erro carregar informações: {ex.Message}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void PreencheGrade(DataGridView dtg, IEnumerable<XElement> enumerable)
    {
      try
      { 
        foreach (XElement item in enumerable.Descendants())
        { 
          if (item.NextNode != null && item != null)
          {
            var segundaCol = (XElement)item.NextNode; 
            dtg.Rows.Add(item.Value, segundaCol.Value);
          }
        }
      }
      catch (Exception ex)
      {  
        MessageBox.Show($"Erro preencher grade: {ex.Message}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void LimpaGrades()
    {
      try
      {
        dtgES.Rows.Clear();
        dtgIRQ.Rows.Clear();
        dtgMemo.Rows.Clear();
        dtgResumo.Rows.Clear();
      }
      catch (Exception)
      {

        throw;
      }
    }
  }
}
