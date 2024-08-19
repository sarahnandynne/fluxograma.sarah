
using LiteDB;

namespace Modelos;

public class Fornecedor: Pessoas
{
  public string email { get; set; }

  public string CNPJ { get; set; }
}