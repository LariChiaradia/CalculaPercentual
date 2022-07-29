using CalculaPercentual.Executer;
using CalculaPercentual.Models;

var estados = new List<Estado>
{
    new()
    {
        Name = "SP",
        Valor = 67836.43
    },
    new()
    {
        Name = "RJ",
        Valor = 36678.66
    },
    new()
    {
        Name = "MG",
        Valor = 29229.88
    },
    new()
    {
        Name = "ES",
        Valor = 27165.48
    },
    new()
    {
        Name = "Outros",
        Valor = 19849.53
    }
};

var total = estados.Sum(x => x.Valor);

foreach (var estado in estados)
{
    var porcentagem = PorcentagemExecuter.Porcentagem(estado.Valor, total);
    Console.WriteLine($"Estado : {estado.Name} Porcentagem: %{porcentagem}");
}