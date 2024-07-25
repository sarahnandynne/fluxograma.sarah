namespace Modelos;

public class FornecedorMateriaPrima:Registro
{
    int idfornecedor;
    int idmateriaprima;

    public void SetidF (int IF)
    {
        idfornecedor= IF;
    }
    public int GetidF ()
    {
        return idfornecedor;
    }
    public void SetidM (int IM)
    {
        idmateriaprima = IM;
    }
    public int GetCPF ()
    {
        return idmateriaprima;
    }
}
