using Modelos;

namespace Controles;

public class ControleProduto: ControleBase
{
  //----------------------------------------------------------------------------

  public ControleProduto() : base()
  {
    NomeDaTabela = "Produto";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idProduto)
  {
    var collection = liteDB.GetCollection<Produto>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idProduto);
  }

  //----------------------------------------------------------------------------

  public virtual List<Produto>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Produto>(NomeDaTabela);
    return new List<Produto>(tabela.FindAll());
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idProduto)
  {
    var collection = liteDB.GetCollection<Produto>(NomeDaTabela);
    collection.Delete(idProduto);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Produto produto)
  {
    var collection = liteDB.GetCollection<Produto>(NomeDaTabela);
    collection.Upsert(produto);
  }

  //----------------------------------------------------------------------------
}