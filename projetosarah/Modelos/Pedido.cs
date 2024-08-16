using LiteDB;

namespace Modelos;

public class Pedido: Pessoas
{
  
  public string cor { get; set; }

  public string endereço { get; set; }

   [BsonId]
  public int Id { get; set; }
    public string valortotal { get; set; }
  public int quantidade { get; set; }

  public int código { get; set; }
}