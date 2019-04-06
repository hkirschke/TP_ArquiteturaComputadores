using System.Collections.Generic;

namespace TP_ArquiteturaComputadores.Classes
{
  public static class XMLParams
  {
    public static string PATH_TEMP => @"c:\Temp\";

    public static string CMD_GERA_ARQUIVO_INFO => $"msinfo32.exe /nfo {PATH_TEMP}Info.xml";

    public static string PATH_PADRAO_XML => "MsInfo/Category[name='Resumo do Sistema']/Category[name='{0}']";

    public static string PATH_PADRAO_XML_RECURSOS_HARDWARE => "MsInfo/Category[name='Resumo do Sistema']/Category[name='Recursos de Hardware']/Category[name='{0}']"; 
  }
}
   
