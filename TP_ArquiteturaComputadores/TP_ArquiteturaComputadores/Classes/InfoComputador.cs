using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_ArquiteturaComputadores.Interfaces;

namespace TP_ArquiteturaComputadores.Classes
{
  public class InfoComputador2 : IInfo
  {
    public string Item { get; set; }
    public string Valor { get; set; }

    public string NameInfo()
    {
      return "Resumo do Computador";
    }
  }
}
