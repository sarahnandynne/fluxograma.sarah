using LiteDB;

namespace Modelos;

public class Produto: Registro
{
  [BsonId]
  
  public string nome { get; set; }

  public string unidade { get; set; }
  public int id { get; set; }
    public string valor { get; set; }
}