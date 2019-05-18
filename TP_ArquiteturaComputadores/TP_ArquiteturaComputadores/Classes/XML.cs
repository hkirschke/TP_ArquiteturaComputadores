using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using TP_ArquiteturaComputadores.Interfaces;

namespace TP_ArquiteturaComputadores.Classes
{
  public class XML : IXML
  {
    public XMLParams XMLParams;

    /// <summary>
    /// Cria arquivo XML com as informações.
    /// </summary>
    public void CriaArquivoInfo()
    {
      try
      {
        if (!File.Exists(XMLParams.PathArquivo))
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

    /// <summary>
    /// Cria diretório do XML caso não exista. 
    /// </summary>
    public void CriaDiretorio()
    {
      if (!Directory.Exists(XMLParams.PATH_TEMP))
        Directory.CreateDirectory(XMLParams.PATH_TEMP);
    }

    /// <summary>
    /// Lê arquivo XML.
    /// </summary>
    public void LeInfoXML()
    {
      try
      {
        XDocument xDoc = XDocument.Load(Path.Combine(XMLParams.PATH_TEMP, "info.xml"));
        XMLParams.XmlDocument = xDoc;
      }
      catch (Exception)
      {
        throw;
      }
    }

    /// <summary>
    /// Retorna conteúdo do nodo
    /// </summary>
    /// <param name="nodeName"></param>
    /// <returns></returns>
    public IEnumerable<XElement> RetConteudoNodo(string nodeName)
    {
      try
      { 
        IEnumerable<XElement> items = from item in XMLParams.XmlDocument.Descendants("Category")
                                      where item.Attribute("name").Value.Equals(nodeName)
                                      select item;

        IEnumerable<XElement> result = items.Descendants();
        result.Descendants("Status").Remove();

        return result;
      }
      catch (Exception)
      {
        throw;
      }
    }

    /// <summary>
    /// Retorna conteúdo do nodo para Resumo do Sistema
    /// </summary>
    /// <param name="nodeName"></param>
    /// <returns></returns>
    public IEnumerable<XElement> GetNodoInfo(string nodeName)
    {
      try
      { 
        IEnumerable<XElement> items = from item in XMLParams.XmlDocument.Descendants("Category")
                                      where item.Attribute("name").Value.Equals(nodeName) 
                                      select item; 
        IEnumerable<XElement> result = items.Elements(); 
        result.Elements("Category").Remove();
        result.Descendants("Status").Remove(); 
        return result;
      }
      catch (Exception)
      {
        throw;
      }
    }

    public XML()
    {
      XMLParams = new XMLParams();
    }
  }
}
