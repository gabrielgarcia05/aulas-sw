namespace TicToc;
class Program
{
    static void Main(string[] args)
    {
        Produto p1 = new Produto("ABC", 10);
        p1.MostraDados();
    }
}


//SEM VALOR ALGUM
// --> Produto p1 = new Produto();
//Nome: TIC TOC
//Preco: 15

//XYZ
// --> Produto p1 = new Produto(XYZ);
//Nome: XYZ
//Preco: 10

//ABC, 10
// --> Produto p1 = new Produto("ABC", 10);
//Nome: ABC
//Preco: 9

