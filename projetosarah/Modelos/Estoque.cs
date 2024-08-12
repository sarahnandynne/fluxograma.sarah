
using LiteDB;

namespace Modelos;

public class Estoque : Registro
{
  [BsonId]
  public int Id { get; set; }
  public string item { get; set; }
  public int quantidade { get; set; }
  public string unidade { get; set; }
}