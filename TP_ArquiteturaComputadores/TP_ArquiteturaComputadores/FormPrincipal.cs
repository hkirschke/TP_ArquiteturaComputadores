using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        MessageBox.Show("Erro ao abrir informações sobre aplicação");
        throw;
      }
    }

    private void BtnGeraArquivo_Click(object sender, EventArgs e)
    {
      try
      {
        XML.CriaArquivoInfo();
      }
      catch (Exception)
      {
        throw;
      }
    }

    private void BtnCarregaInfo_Click(object sender, EventArgs e)
    {
      try
      {
        XML.LeInfoXML();
        txtBoxInfo.Text = XML.RetConteudoNodo();
      }
      catch (Exception)
      {

        throw;
      }
    }
  }
}
