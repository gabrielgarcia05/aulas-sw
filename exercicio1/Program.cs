namespace Exercicio1;
class Program
{
    static void Main(string[] args)
    {
        Alunos aluno1 = new Alunos();
        Console.WriteLine("Digite seu nome: ");
        aluno1.nome = Console.ReadLine();

        Console.WriteLine("_______________________________________________");

        Console.WriteLine("Digite sua primeira nota: ");
        aluno1.nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("_______________________________________________");

        Console.WriteLine("Digite sua segunda nota: ");
        aluno1.nota2 = double.Parse(Console.ReadLine());
        
        Console.WriteLine("_______________________________________________");

        aluno1.mensagem();

        Console.WriteLine("_______________________________________________");
    }
}
