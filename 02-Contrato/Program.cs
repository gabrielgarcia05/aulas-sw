namespace _02_Contrato;
class Program
{
    static void Main(string[] args)
    {
        ContratoPessoaFisica pf + new ContratoPessoaFisica();

        pf.Nome = "Gabriel";
        pf.Email = "gabriel@gmail.com";
        pf.Cpf = "123.456.789-00";
        pf.Idade = 16;
        pf.Telefone = "(11) 99999-9999";

        Console.WriteLine ("Dados da Pessoa Física: ");
        Console.WriteLine ("pf.MostraDados ()");
        Console.WriteLine ("*****************************************");

        ContratoPessoaJuridica pj = new ContratoPessoaJuridica();

        pj.Nome = "Dra. Ana";
        pj.Email = "ana@gmail.com";
        pj.Cnpj = "88.693.841/0001-72";
        pj.Ie = "975.930.485.080";
        pj.NomeEmpresa = "Ana's Company";
        pj.Telefone = "(11) 99999-9999";

        Console.WriteLine("Dados Pessoa Jurídic: ");
        Console.WriteLine(pj.MostraDados());
        Console.WriteLine ("*****************************************");
    }
}
