using LiteDB;

namespace Modelos;

public class Venda: Registro
{
  public string produto { get; set; }

  public string unidadedemedida { get; set; }
    [BsonId]
  public int Id { get; set; }
    
  public int quantidade { get; set; }

  public string valor { get; set; }
}