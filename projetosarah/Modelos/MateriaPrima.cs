using LiteDB;

namespace Modelos;

public class MateriaPrima: Pessoas
{
 
  
  public string cor { get; set; }

  public string unidade { get; set; }
   [BsonId]
  public int Id { get; set; }

  public int código { get; set; }
}