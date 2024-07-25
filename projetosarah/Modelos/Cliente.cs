namespace Modelos;
public class Cliente:Pessoas
{
string endereco;
string CPF;

public void SetEndereco (string E)
{
    endereco = E;
}
public string GetEndereco ()
{
    return endereco;
}
public void SetCPF (string C)
{
    CPF = C;
}
public string GetCPF ()
{
    return CPF;
}
}