using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;

namespace TP_ArquiteturaComputadores.Classes
{
  public class XMLParams
  {
    public string ResumoSistema = "Resumo do Sistema";

    public string InfoES = "E/S";

    public string InfoIRQ = "IRQs";

    public string Memo = "Memória";

    public const string PATH_TEMP = @"c:\Temp\";

    public string PathArquivo = $"{PATH_TEMP}info.xml";

    public string CmdGeraArquivo = @"C:\Windows\System32\msinfo32.exe /nfo C:\temp\info.xml";  

    public const string PATH_PADRAO_XML = "MsInfo/Category[name='Resumo do Sistema']/Category[name='{0}']";

    public const string PATH_PADRAO_XML_RECURSOS_HARDWARE = "MsInfo/Category[name='Resumo do Sistema']/Category[name='Recursos de Hardware']/Category[name='{0}']";

    public XDocument XmlDocument = new XDocument();
  }
}

