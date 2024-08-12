
using LiteDB;

namespace Modelos;

public class Cliente : Pessoas
{
  [BsonId]
  public string endereço { get; set; }

  public string CPF { get; set; }
}