using PizzariaCSharp.Controller;
using PizzariaCSharp.Entities;
using PizzariaCSharp.Enums;
using PizzariaCSharp.Repository;

Console.Clear();
Console.WriteLine("########################################");
Console.WriteLine("##########   Pizzaria Veloz   ##########");
Console.WriteLine("########################################");

//Simular novo banco de dados
var controllerBebida = new BebidaController(new BebidaRepository());
var controllerCliente = new ClienteController(new ClienteRepository());
var controllerItem = new SaborController(new SaborRepository());
var controllerPedido = new PedidoController(new PedidoRepository());
var controllerPizza = new PizzaController(new PizzaRepository());

//Teste - cadastrar três bebidas
var bebida1 = controllerBebida.Adicionar(new Bebida("Coca-Cola 350ml", 6.00));
var bebida2 = controllerBebida.Adicionar(new Bebida("H2O Limoneto", 10.00));
var bebida3 = controllerBebida.Adicionar(new Bebida("Itaipava Garrafa", 13.00));

// Cadastrar 4 sabores
var sabor1 = controllerItem.Adicionar(new Sabor("Quatro Queijos", "Mussarela, provolone, gorgonzola, parmesao, molho de tomare e orégano"));
var sabor2 = controllerItem.Adicionar(new Sabor("Mussarela", "Mussarela, molho de tomare e orégano"));
var sabor3 = controllerItem.Adicionar(new Sabor("Portuguesa", "presunto, mussarela, palmito, ervilhas, milhos, ovos e tomate"));
var sabor4 = controllerItem.Adicionar(new Sabor("Frango com Catupiry", "Frango, catupiry original, molho de tomare e orégano"));

// Criar 4 pizzas
var pizza1 = new Pizza(ETamanho.GIGANTE, EBorda.FRANGO, 45.0, new List<Sabor>(){ sabor1, sabor2 });
var pizza2 = new Pizza(ETamanho.PEQUENA, EBorda.SIMPLES, 52.0, new List<Sabor>(){ sabor3 });
var pizza3 = new Pizza(ETamanho.MEDIA, EBorda.MUSSARELA, 58.0, new List<Sabor>(){ sabor4, sabor1 });
var pizza4 = new Pizza(ETamanho.GRANTE, EBorda.CHOCOLATE, 45.0, new List<Sabor>(){ sabor4, sabor3 });

// Cadastrar 2 Clientes
var cliente1 = controllerCliente.Adicionar(new Cliente("Luiz Inácio", "01378946543"));
var cliente2 = controllerCliente.Adicionar(new Cliente("Jair Messias", "013998876655"));

var pedido1 = new Pedido(cliente1);
var valor1 = pedido1
    .AdicionarBebida(bebida1)
    .AdicionarBebida(bebida3)
    .AdicionarPizza(pizza1)
    .AdicionarPizza(pizza2)
    .CalcularValorPedido();

pedido1.FinalizarPedido();
controllerPedido.Adicionar(pedido1);

var pedido2 = new Pedido(cliente2);
var valor2 = pedido2
    .AdicionarBebida(bebida2)
    .AdicionarPizza(pizza3)
    .CalcularValorPedido();

pedido2.FinalizarPedido();
controllerPedido.Adicionar(pedido2);

Console.WriteLine($"\nRESUMO DO PEDIDO 1\n");

Console.WriteLine($"Cliente: {pedido1.Cliente.Nome}");
Console.Write($"Produtos: ");
pedido1.Pizzas.ForEach(p => p.Sabores.ForEach(s => Console.WriteLine(s.Descricao)));
pedido1.Bebidas.ForEach(b => Console.WriteLine(b.Nome));
Console.Write("Itens no pedido:");
Console.WriteLine(pedido1.Bebidas.Count + pedido1.Pizzas.Count);
Console.WriteLine($"Valor do pedido 1: R$ {valor1.ToString("F2")}");
// Console.WriteLine($"");