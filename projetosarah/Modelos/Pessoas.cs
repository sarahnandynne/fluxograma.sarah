using LiteDB;

namespace Modelos;

public class Pessoas: Registro
{
  
  
  public string Nome { get; set; }


  public string Telefone { get; set; }
  [BsonId]
  public int Id { get; set; }
}