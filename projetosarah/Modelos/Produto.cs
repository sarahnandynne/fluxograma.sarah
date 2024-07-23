namespace Modelos

public class Produto:Registro
{
    string nome;
    int id;
    string unidade;
    string valor;

    public void SetNome (string N)
    {
        nome = N;
    }
    public string GetNome ()
    {
        return nome;
    }
     public void SetId (int I)
    {
        id = I;
    }
    public int GetId ()
    {
        return = id;
    }
    public void SetUnidade (string U)
    {
        unidade = U;
    }
    public string GetUnidade()
    {
        return = unidade;
    }
     public void SetValor (string V)
    {
        valor = V;
    }
    public string GetValor()
    {
        return = valor;
    }
}