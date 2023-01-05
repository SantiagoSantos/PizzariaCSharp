using PizzariaCSharp.Controller;
using PizzariaCSharp.Entities;
using PizzariaCSharp.Repository;

Console.Clear();
Console.WriteLine("########################################");
Console.WriteLine("##########   Pizzaria Veloz   ##########");
Console.WriteLine("########################################");

//Simular novo banco de dados
var repository = new BebidaRepository();
var controllerBebida = new BebidaController(repository);

//Teste - cadastrar três bebidas
var bebida1 = controllerBebida.Adicionar(new Bebida("Coca-Cola 350ml", 6.00));
var bebida2 = controllerBebida.Adicionar(new Bebida("H2O Limoneto", 10.00));
var bebida3 = controllerBebida.Adicionar(new Bebida("Itaipava Garrafa", 13.00));

//Teste - Listar Todos
Console.WriteLine("\nListagem de Bebidas\n");
controllerBebida
    .ObterTodos()
    .ForEach(b => Console.WriteLine($"{b.Id}, {b.Nome}, {FormatarCampoMonetario(b.Valor)}"));

Console.WriteLine("\nAtualizar bebida2 \n");
var bebida = new Bebida("H2O Limoneto", 9.00);
controllerBebida.Atualizar(bebida2.Id, bebida);

Console.WriteLine("\nListagem de Bebidas Após atualizar bebida 2 \n");
controllerBebida
    .ObterTodos()
    .ForEach(b => Console.WriteLine($"{b.Id}, {b.Nome}, {FormatarCampoMonetario(b.Valor)}"));

controllerBebida.Remover(bebida1.Id);

Console.WriteLine("\nListagem de Bebidas Após exclusão \n");
controllerBebida
    .ObterTodos()
    .OrderBy(b => b.Id)
    .ToList()
    .ForEach(b => Console.WriteLine($"{b.Id}, {b.Nome}, {FormatarCampoMonetario(b.Valor)}"));

Console.WriteLine("\nRecuperar por ID \n");
var bebidaRecuperada = controllerBebida.ObterPorId(bebida3.Id);
Console.WriteLine($"{bebidaRecuperada.Id}, {bebidaRecuperada.Nome}, {FormatarCampoMonetario(bebidaRecuperada.Valor)}");

string FormatarCampoMonetario(double valor)
{
    return $"R$ {valor.ToString("F2")}";
}