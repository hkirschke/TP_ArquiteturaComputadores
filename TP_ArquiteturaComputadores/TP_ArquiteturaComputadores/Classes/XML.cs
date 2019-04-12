using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Xml;
using TP_ArquiteturaComputadores.Interfaces;

namespace TP_ArquiteturaComputadores.Classes
{
  public class XML : IXML
  {
    private XMLParams _XMLParams;
    public void CriaArquivoInfo()
    {
      try
      {
        if (!File.Exists(_XMLParams.PathArquivo))
          Process.Start(_XMLParams.CmdGeraArquivo);
      }
      catch (Exception)
      {
        throw;
      }
    }

    public void CriaDiretorio()
    {
      if (!Directory.Exists(XMLParams.PATH_TEMP))
        Directory.CreateDirectory(XMLParams.PATH_TEMP);
    }

    public void LeInfoXML()
    {
      try
      {
        XmlDocument xDoc = new XmlDocument();
        xDoc.Load(Path.Combine(XMLParams.PATH_TEMP, "info.xml"));
        _XMLParams.xmlDocument = xDoc;
        //return xDoc;
      }
      catch (Exception)
      {
        throw;
      }
    }

    public XmlNodeList RetNodeXML(string _pathNodo)
    {
      try
      {
        //descendant::Category
        XmlNodeList list = _XMLParams.xmlDocument.SelectNodes(_pathNodo);
        return list;
      }
      catch (Exception)
      {
        throw;
      }
    }
    /// <summary>
    /// Retorna conteúdo do nodo
    /// </summary>
    /// <returns></returns>
    public string RetConteudoNodo()
    {
      StringBuilder strBuilder = new StringBuilder();
      XmlNodeList nodeList;
      foreach (var item in _XMLParams.LstNodos)
      {
        nodeList = RetNodeXML(item);
        strBuilder.AppendLine(nodeList.ToString());
      }
      return strBuilder.ToString();
    }

    public XML()
    {
      _XMLParams = new XMLParams(); 
    }
  }
}
