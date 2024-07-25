namespace Modelos;

public class Pessoas:Registro
{
    string nome;
    string telefone;
    int id;

    public void SetNome (string N)
    {
        nome = N;
    }
    public string GetNome ()
    {
        return nome;
    }
    public void SetTelefone (string T)
    {
        telefone = T;
    }
    public string GetTelefone ()
    {
        return telefone;
    }
    public void SetId (int I)
    {
        id = I;
    }
    public int GetId ()
    {
        return id;
    }
}