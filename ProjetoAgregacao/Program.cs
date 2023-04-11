namespace ProjetoAgregacao;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Trabalhando com Agregação");

        //INSTANCIANDO OS OBJETOS
        CartaoDeCredito cdc = new CartaoDeCredito();
        Cliente cli = new Cliente();

        //ADICIONANDO UM NOME PARA UM CLIENTE 
        cli.Nome = "Gabriel Garcia da Silva";

        //ADCIONANDO NÚMERO E VALIDADE DO CARTÃO DE CRÉDITO
        cdc.Numero = "123456789";
        cdc.DataValidade = "07/2025";

        //ASSOCIANDO O CLIENTE AO ATRIBUTO DE AGREGAÇÃO EM CARTÃO DE CRÉDITO
        cdc.cliente = cli;

        //VISUALIZANDO AS INFORMAÇÕES 
        Console.WriteLine("O nome do cliente é: " + cli.Nome);
        Console.WriteLine("O número do cartão é: " + cdc.Numero);
        Console.WriteLine("A data de validação é: " + cdc.DataValidade);
        Console.WriteLine("O nome do cliente AGREGADO é: " + cdc.cliente.Nome);
    }
}
