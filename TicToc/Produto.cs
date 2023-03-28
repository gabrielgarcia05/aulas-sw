namespace TicToc;
class Produto
{
    //Construtores

    public Produto(){
        this.Nome = "TIC TOC";
        this.Preco = 15;
    }
    public Produto(string nome){
        this.Nome = nome;
        this.Preco = 10;
    }

    public Produto(string nome, int desconto){
        this.Nome = nome;
        this.Preco = 10 - (10*desconto/100);
    }

    //consequentemente por estar privado, devemos usar os métodos

    private string? Nome {get; set;}
    private double Preco {get; set;}

    //Métodos

    public void AlteraNome(string nome){
        this.Nome = nome;
    }

    public void MostraPreco(double preco){
        this.Preco = preco;
    }

    public void MostraDados(){
        Console.WriteLine("Nome: " + this.Nome);
        Console.WriteLine("Preco: " + this.Preco);
    }
}
