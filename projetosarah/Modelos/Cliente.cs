
using LiteDB;

namespace Modelos;

public class Cliente : Pessoas
{
  public string endereço { get; set; }

  public string CPF { get; set; }
}