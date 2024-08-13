using Modelos;

namespace Controles;

public class ControleUnidade: ControleBase
{
  //----------------------------------------------------------------------------

  public ControleUnidade() : base()
  {
    NomeDaTabela = "Unidades";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idUnidades)
  {
    var collection = liteDB.GetCollection<Unidades>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idUnidades);
  }

  //----------------------------------------------------------------------------

  public virtual List<Unidades>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Unidades>(NomeDaTabela);
    return new List<Unidades>(tabela.FindAll());
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idUnidades)
  {
    var collection = liteDB.GetCollection<Unidades>(NomeDaTabela);
    collection.Delete(idUnidades);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Unidades unidades)
  {
    var collection = liteDB.GetCollection<Unidades>(NomeDaTabela);
    collection.Upsert(unidades);
  }

  //----------------------------------------------------------------------------
}