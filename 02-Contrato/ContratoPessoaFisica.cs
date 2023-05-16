namespace _02_Contrato;

class ContratoPessoaFisica: Contrato

{
    public string? Cpf {get;set;}
    public int Idade {get;set;}


    public override string MostraDados()
    {
        return base.MostraDados()+ " - "+ this.Cpf+" - "+this.Idade;
    }
}
