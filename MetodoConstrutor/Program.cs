namespace MetodoConstrutor;
class Program
{
    static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa("FULANO", 23);
        // p1.InsereNome("GABRIEL");
        // p1.InsereSobreNome("GARCIA DA SILVA");
        // p1.InsereIdade(16);

        p1.MostraDados();
    }
}
