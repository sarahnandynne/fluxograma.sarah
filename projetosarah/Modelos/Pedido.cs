using LiteDB;

namespace Modelos;

public class Pedido: Pessoas
{
  [BsonId]
  
  public string cor { get; set; }

  public string endereço { get; set; }
  public int id { get; set; }
    public string valortotal { get; set; }
  public int quantidade { get; set; }

  public int código { get; set; }
}