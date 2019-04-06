using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Xml;
using TP_ArquiteturaComputadores.Interfaces;

namespace TP_ArquiteturaComputadores.Classes
{
  public class XML : IXML
  {
    public List<string> LstNodos => new List<string> {
       @"/Category[name='Recursos de Hardware']/Category[name='E/S']",
       @"/Category[name='Recursos de Hardware']/Category[name='IRQs']",
       @"/Category[name='Recursos de Hardware']/Category[name='Memória']"
    };

    public void CriaArquivoInfo()
    {
      try
      {
        Process.Start(XMLParams.CMD_GERA_ARQUIVO_INFO);

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

    public XmlNodeList RetNodeXML(XmlDocument xmlDocument, string pathNodo)
    {
      try
      {
        XmlNodeList list = xmlDocument.SelectNodes(pathNodo);
        return list;
      }
      catch (Exception)
      {

        throw;
      }
    }
  }
}
