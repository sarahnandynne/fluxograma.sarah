
using LiteDB;

namespace Modelos;

public class FornecedorMateriaPrima: Registro
{
  [BsonId]
  
  public int idfornecedor { get; set; }

  public int idmateriaprima { get; set; }
}
