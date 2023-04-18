namespace ProjetoConta18_04;
class Banco
{
    public double parcela {get; set;}
    public double valor {get; set;}

    public string emprestimo(int parcelas, double dinheiro){
        this.parcela = parcelas;
        this.valor = dinheiro;
        
        double div = dinheiro/parcelas;
        double mult = dinheiro * 0.06;
        double soma = mult + div;
        double total = soma *parcelas;

        string resultado = "O valor da sua parcela sem juros é: "+ div +". O valor da parcela com juros: "+ mult + ". O valor do juros com prestações é de: "+ soma +"e o valor total a pagar é de: "+total;
        return resultado;
        
     
    }
    public void imprimi(string texto){
        Console.WriteLine(texto);
    }
}
