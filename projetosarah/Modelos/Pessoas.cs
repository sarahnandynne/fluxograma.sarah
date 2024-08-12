using LiteDB;

namespace Modelos;

public class Pessoas: Registro
{
  [BsonId]
  
  public string nome { get; set; }

  public string telefone { get; set; }
  public int id { get; set; }
}