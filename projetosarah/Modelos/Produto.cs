using LiteDB;

namespace Modelos;

public class Produto: Registro
{
  public string nome { get; set; }

  public string unidade { get; set; }
   [BsonId]
  public int Id { get; set; }
    public string valor { get; set; }
}