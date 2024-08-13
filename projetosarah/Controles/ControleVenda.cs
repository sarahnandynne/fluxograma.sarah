using Modelos;

namespace Controles;

public class ControleVenda: ControleBase
{
  //----------------------------------------------------------------------------

  public ControleVenda() : base()
  {
    NomeDaTabela = "Venda";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idVenda)
  {
    var collection = liteDB.GetCollection<Venda>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idVenda);
  }

  //----------------------------------------------------------------------------

  public virtual List<Venda>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Venda>(NomeDaTabela);
    return new List<Venda>(tabela.FindAll());
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idVenda)
  {
    var collection = liteDB.GetCollection<Venda>(NomeDaTabela);
    collection.Delete(idVenda);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Venda venda)
  {
    var collection = liteDB.GetCollection<Venda>(NomeDaTabela);
    collection.Upsert(venda);
  }

  //----------------------------------------------------------------------------
}