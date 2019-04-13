using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
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
        {
          Process process = new Process();
          ProcessStartInfo startInfo = new ProcessStartInfo
          {
            WindowStyle = ProcessWindowStyle.Normal,
            FileName = @"C:\Windows\System32\msinfo32.exe",
            Arguments = @"/nfo C:\temp\info.xml"
          };
          process.StartInfo = startInfo;
          process.Start();
          process.WaitForExit();
          process.Close();
        }
        else
        {
          throw new Exception("Arquivo já existe");
        }
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
        XDocument xDoc = XDocument.Load(Path.Combine(XMLParams.PATH_TEMP, "info.xml"));
        _XMLParams.xmlDocument = xDoc;
        //return xDoc;
      }
      catch (Exception)
      {
        throw;
      }
    }

    public IEnumerable<XElement> RetNodeXML(string _pathNodo)
    {
      try
      {
        IEnumerable<XElement> items = from item in _XMLParams.xmlDocument.Descendants("Category")
                                      where item.Attribute("name").Value.Equals(_pathNodo)
                                      select item;

        var teste1 = _XMLParams.xmlDocument.Descendants("Category");
        IEnumerable<XElement> teste2 = items.Descendants();
        var teste3 = _XMLParams.xmlDocument.Descendants("Category");
        //descendant::Category
        //XmlNodeList test1 = _XMLParams.xmlDocument.SelectNodes("MsInfo/Category");
        //XmlNodeList test2 = _XMLParams.xmlDocument.SelectNodes("descendant::Category");
        //XmlNodeList test3 = _XMLParams.xmlDocument.SelectNodes("descendant::Category");
        //XmlNodeList list = _XMLParams.xmlDocument.SelectNodes(_pathNodo);
        return teste2;
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
      IEnumerable<XElement> nodeList;
      foreach (var item in _XMLParams.LstNodos)
      {
        strBuilder.AppendLine($"    Informações sobre - {item.ToString()}");
        nodeList = RetNodeXML(item);
        foreach (var iNode in nodeList)
        {
          if (!iNode.Name.LocalName.Equals("Status") && !iNode.Name.LocalName.Equals("Data"))
            strBuilder.AppendLine(iNode.Value.ToString());
        }
        strBuilder.AppendLine();
      }
      return strBuilder.ToString();
    }

    public XML()
    {
      _XMLParams = new XMLParams();
    }
  }
}
