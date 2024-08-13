using LiteDB;

namespace Modelos;

public class MateriaPrima: Pessoas
{
  [BsonId]
  
  public string cor { get; set; }

  public string unidade { get; set; }
  public int Id { get; set; }

  public int código { get; set; }
}