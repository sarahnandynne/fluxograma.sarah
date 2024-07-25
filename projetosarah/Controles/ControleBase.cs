using Modelos;

namespace Controles
{
    public class ControleBase
 {
    public virtual void Criar (Registro o)
    {
    }
    public virtual void Atualizar (Registro o)
    {
    }
    public virtual void Apagar (int id)
    {
    }
    public virtual Registro Ler (int id)
    {
        return null;
    }
  } 
}