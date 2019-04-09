using System.Collections.Generic;

namespace TP_ArquiteturaComputadores.Classes
{
  public class XMLParams
  {
    public List<string> LstNodos => new List<string> {
       @"/Category[name='Recursos de Hardware']/Category[name='E/S']",
       @"/Category[name='Recursos de Hardware']/Category[name='IRQs']",
       @"/Category[name='Recursos de Hardware']/Category[name='Memória']"
    };
    public const string PATH_TEMP = @"c:\Temp\";

    public string PathArquivo = $"{PATH_TEMP}Info.xml";

    public string CmdGeraArquivo = $"msinfo32.exe /nfo {PATH_TEMP}Info.xml";

    public const string PATH_PADRAO_XML = "MsInfo/Category[name='Resumo do Sistema']/Category[name='{0}']";

    public const string PATH_PADRAO_XML_RECURSOS_HARDWARE = "MsInfo/Category[name='Resumo do Sistema']/Category[name='Recursos de Hardware']/Category[name='{0}']";
  }
}

