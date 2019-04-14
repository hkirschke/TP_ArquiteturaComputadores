using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_ArquiteturaComputadores.Interfaces;

namespace TP_ArquiteturaComputadores.Classes
{
  public class InfoHardware : IInfo
  {
    public string Recurso { get; set; }
    public string Dispositivo { get; set; } 

    public string NameInfo()
    {
      return "Recursos de Hardware";
    }
  }
}
