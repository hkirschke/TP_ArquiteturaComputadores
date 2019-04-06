using System.Xml;

namespace TP_ArquiteturaComputadores.Interfaces
{
  public interface IXML
  {
    /// <summary>
    /// Lê arquivo XML.
    /// </summary> 
    /// <returns></returns>
    XmlDocument LeInfoXML();

    /// <summary>
    /// Retorna dados do nodo informado.
    /// </summary>
    /// <param name="xmlDocument"></param>
    /// <param name="pathNodo"></param>
    /// <returns></returns>
    XmlNodeList RetNodeXML(XmlDocument xmlDocument, string pathNodo);

    /// <summary>
    /// Cria diretório do XML caso não exista.
    /// </summary>
    void CriaDiretorio();

    /// <summary>
    /// Cria arquivo XML com as informações.
    /// </summary>
    void CriaArquivoInfo();
  }
}
