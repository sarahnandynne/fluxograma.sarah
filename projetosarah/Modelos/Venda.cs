namespace Modelos;

public class Venda:Registro
{
    string produto;
    int id;
    int quantidade;
    string unidadedemedida;
    string valor;

    public void SetProduto (string P)
    {
        produto = P;
    }
    public string GetProduto ()
    {
        return produto;
    }
     public void SetId (int I)
    {
        id = I;
    }
    public int GetId ()
    {
        return id;
    }
    public void SetQuantidade(int Q)
    {
        quantidade = Q;
    }
    public int GetQuantidade ()
    {
        return quantidade;
    }
    public void SetUnidadeDeMedida (string U)
    {
        unidadedemedida = U;
    }
    public string GetUnidadeDeMedida()
    {
        return unidadedemedida;
    }
     public void SetValor (string V)
    {
        valor = V;
    }
    public string GetValor()
    {
        return valor;
    }
}