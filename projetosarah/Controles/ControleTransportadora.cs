using Modelos;

namespace Controles;

public class ControleTransportadora: ControleBase
{
  //----------------------------------------------------------------------------

  public ControleTransportadora() : base()
  {
    NomeDaTabela = "Transportadora";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idTransportadora)
  {
    var collection = liteDB.GetCollection<Transportadora>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idTransportadora);
  }

  //----------------------------------------------------------------------------

  public virtual List<Transportadora>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Transportadora>(NomeDaTabela);
    return new List<Transportadora>(tabela.FindAll());
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idTransportadora)
  {
    var collection = liteDB.GetCollection<Transportadora>(NomeDaTabela);
    collection.Delete(idTransportadora);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Transportadora transportadora)
  {
    var collection = liteDB.GetCollection<Transportadora>(NomeDaTabela);
    collection.Upsert(transportadora);
  }

  //----------------------------------------------------------------------------
}