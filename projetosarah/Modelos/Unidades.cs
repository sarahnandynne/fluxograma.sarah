using LiteDB;

namespace Modelos;

public class Unidades: Pessoas
{
  [BsonId]
  
  public string nome { get; set; }

}