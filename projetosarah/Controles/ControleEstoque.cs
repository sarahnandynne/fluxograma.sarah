using Modelos;

namespace Controles;

public class ControleEstoque : ControleBase
{
  //----------------------------------------------------------------------------

  public ControleEstoque() : base()
  {
    NomeDaTabela = "Estoque";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idEstoque)
  {
    var collection = liteDB.GetCollection<Estoque>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idEstoque);
  }

  //----------------------------------------------------------------------------

  public virtual List<Estoque>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Estoque>(NomeDaTabela);
    return new List<Estoque>(tabela.FindAll());
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idEstoque)
  {
    var collection = liteDB.GetCollection<Estoque>(NomeDaTabela);
    collection.Delete(idEstoque);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Estoque estoque)
  {
    var collection = liteDB.GetCollection<Estoque>(NomeDaTabela);
    collection.Upsert(estoque);
  }

  //----------------------------------------------------------------------------
}