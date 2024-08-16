using LiteDB;

namespace Modelos;

public class Pessoas: Registro
{
  
  
  public string nome { get; set; }


  public string telefone { get; set; }
  [BsonId]
  public int Id { get; set; }
}