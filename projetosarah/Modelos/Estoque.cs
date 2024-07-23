namespace Modelos

public class Estoque:Registro
{
    string item;
    int id;
    int quantidade;
    string unidade;

    public void SetItem (string I)
    {
        item = I;
    }
    public string GetItem ()
    {
        return item;
    }
     public void SetId (int I)
    {
        id = I;
    }
    public int GetId ()
    {
        return = id;
    }
    public void SetQuantidade(int Q)
    {
        quantidade = Q;
    }
    public int GetQuantidade ()
    {
        return quantidade;
    }
    public void SetUnidade (string U)
    {
        unidade = U;
    }
    public string GetUnidade ()
    {
        return = unidade;
    }
}