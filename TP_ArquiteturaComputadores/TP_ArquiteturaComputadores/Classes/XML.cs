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

    public XmlDocument LeInfoXML()
    {
      try
      {
        XmlDocument xDoc = new XmlDocument();
        xDoc.Load(Path.Combine(XMLParams.PATH_TEMP, "info.xml"));
        return xDoc;
      }
      catch (Exception)
      {
        throw;
      }
    }

    public XmlNodeList RetNodeXML(XmlDocument _xmlDocument, string _pathNodo)
    {
      try
      {
        XmlNodeList list = _xmlDocument.SelectNodes(_pathNodo);
        return list;
      }
      catch (Exception)
      {
        throw;
      }
    }

    public string RetConteudoNodo(XmlNodeList _lstNodo)
    {
      StringBuilder strBuilder = new StringBuilder();
      foreach (var item in _lstNodo)
      {
        strBuilder.AppendLine(item.ToString());
      }
      //throw new NotImplementedException();
      return strBuilder.ToString();
    }

    public XML()
    {
      _XMLParams = new XMLParams();
    }
  }
}
