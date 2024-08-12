using LiteDB;

namespace Modelos;

public class Venda: Registro
{
  [BsonId]
  
  public string produto { get; set; }

  public string unidadedemedida { get; set; }
  public int id { get; set; }
    
  public int quantidade { get; set; }

  public string valor { get; set; }
}