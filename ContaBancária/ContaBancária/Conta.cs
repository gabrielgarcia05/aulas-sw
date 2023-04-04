namespace ContaBacária;
class Conta
{
    //get e set são propriedades do C# que informan já a própria classe do que será utilizado (pegar e devolver a informação)
    public int Numrero{get;set;}
    private double Saldo{get;set;}
    public double Limite{get; private set;}

    public void AjustarLimite(double valor){
        this.Limite = valor;
    }

    // a += 10  é o mesmo que:  a = a + 10
    public void Depositar(double valor){
        this.Saldo += valor;
    }
    public void Sacar(double valor){
        if (this.Saldo + this.Limite <= valor){
            Console.WriteLine("Você esta sacando mais do que tem")
        }else{
            this.Saldo -= valor;
        } 
    }
    public double MostrarSaldo(){
        return this.Saldo + this.Limite;
    }
}
