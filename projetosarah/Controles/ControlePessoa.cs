using Modelos;

namespace Controles;

public class ControlePessoa: ControleBase
{
  //----------------------------------------------------------------------------

  public ControlePessoa() : base()
  {
    NomeDaTabela = "Pessoas";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idPessoas)
  {
    var collection = liteDB.GetCollection<Pessoas>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idPessoas);
  }

  //----------------------------------------------------------------------------

  public virtual List<Pessoas>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Pessoas>(NomeDaTabela);
    return new List<Pessoas>(tabela.FindAll());
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idPessoas)
  {
    var collection = liteDB.GetCollection<Pessoas>(NomeDaTabela);
    collection.Delete(idPessoas);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Pessoas pessoas)
  {
    var collection = liteDB.GetCollection<Pessoas>(NomeDaTabela);
    collection.Upsert(pessoas);
  }

  //----------------------------------------------------------------------------
}