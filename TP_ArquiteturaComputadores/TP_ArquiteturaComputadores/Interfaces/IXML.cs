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
    IEnumerable<XElement> RetConteudoNodo(string nodeName);

    /// <summary>
    /// Retorna conteúdo do nodo para Resumo do Sistema
    /// </summary>
    /// <param name="nodeName"></param>
    /// <returns></returns>
    IEnumerable<XElement> GetNodoInfo(string nodeName);
  }
}
