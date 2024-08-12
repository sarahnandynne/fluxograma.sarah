using LiteDB;

namespace Modelos;

public class Transportadora: Pessoas
{
  [BsonId]
  
  public string CNPJ { get; set; }

}