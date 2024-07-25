namespace Modelos;
public class Transportadora:Pessoas
{
string CNPJ;
public void SetCNPJ (string C)
{
    CNPJ = C;
}
public string GetCNPJ ()
{
    return CNPJ;
}
}