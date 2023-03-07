namespace exemplo;
class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        // Console.ReadLine();

        // INSTÂNCIA DE UM OBJETO DA CLASSE AVIAO
        Aviao tecoteco = new Aviao();

        //USANDO ATRIBUTOS E/OU MÉTODOS DA CLASSE PELO OBJETO CRIADO
        tecoteco.acelerar(); 

        //MÉTODO SEM RETORNO E COM PARAMETRO
        tecoteco.acelerarParametro("seu burro");

        //MÉTODO COM RETORNI E SEM PARAMETRO
        Console.WriteLine(tecoteco.informacoes());

        //MÉTODO COM RETORNO E COM PARAMETROS
        Console.WriteLine(tecoteco.soma(10,2013));
    }
}
