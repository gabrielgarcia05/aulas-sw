namespace ProjetoConta18_04;
class Program
{
    static void Main(string[] args)
    {
        Banco b = new Banco();

        b.imprimi(b.emprestimo(12,1000));
    }
}
