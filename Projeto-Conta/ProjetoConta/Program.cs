namespace ProjetoConta;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("PROJETO BANCO ETEC MCM");
        //Instanciar/Criar um objeto
        Conta c = new Conta();

        //SET = "setar" um valor
        // c.Saldo = 1000;
        c.Depositar(1000);
        c.Sacar(800);
        // c.Limite = 500;
        c.AjustarLimite(500);

        double valorTotal = c.MostrarSaldo();

        //Console.WriteLine("Seu saldo é de " + c.Saldo + ". Com limite de: " + c.Limite);

        Console.WriteLine("Seu saldo total é de: " + valorTotal);
        Console.WriteLine("Seu saldo total é de: " + Sacar);

    }
}
