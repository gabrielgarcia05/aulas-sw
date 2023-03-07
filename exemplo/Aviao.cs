namespace exemplo;

class Aviao
{
    public string modelo="";
    public string marca="";
    public int velocidade;
    public int altitude;

    public void acelerar(){
        Console.WriteLine("Estou acelerando");
    }
        public void acelerarParametro(string valor){
        Console.WriteLine("Estou acelerando" + (", ") + valor);
    }

    public string informacoes(){
        return"Aperte os cintos";
    }

    public int soma(int a, int b){
        int soma = a+b;
        
        return a+b;
    }
}

