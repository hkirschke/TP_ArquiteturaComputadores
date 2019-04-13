using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;

namespace TP_ArquiteturaComputadores.Interfaces
{
  public interface IXML
  {
    /// <summary>
    /// Lê arquivo XML.
    /// </summary> 
    /// <returns></returns>
    void LeInfoXML();

    /// <summary>
    /// Retorna dados do nodo informado.
    /// </summary> 
    /// <param name="_pathNodo"></param>
    /// <returns></returns>
    IEnumerable<XElement> RetNodeXML(string _pathNodo);

    /// <summary>
    /// Cria diretório do XML caso não exista.
    /// </summary>
    void CriaDiretorio();

    /// <summary>
    /// Cria arquivo XML com as informações.
    /// </summary>
    void CriaArquivoInfo();

    /// <summary>
    /// Retorna conteúdo do nodo
    /// </summary>
    /// <returns></returns>
    string RetConteudoNodo();
  }
}
