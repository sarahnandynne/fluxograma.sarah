namespace Modelos;

public class MatériaPrima:Registro
{
    string cor;
    int id;
    int código;
    string unidade;
    public void SetCor (string C)
    {
        cor = C;
    }
    public string GetCor ()
    {
        return cor;
    }
     public void SetId (int I)
    {
        id = I;
    }
    public int GetId ()
    {
        return id;
    }
    public void SetCódigo (int C)
    {
        código = C;
    }
    public int GetCódigo ()
    {
        return código;
    }
    public void SetUnida (string U)
    {
        unidade = U;
    }
    public string GetUnidade()
    {
        return unidade;
    }
}