namespace _02_Contrato;

class ContratoPessoaJuridica: Contrato

{
    public string? Cnpj {get;set;}
    public string? Ie {get;set;}
    public string? NomeEmpresa {get;set;}


    public override string MostraDados()
    {
        return base.MostraDados()+ " - "+this.Cnpj+" - "+this.Ie+" - "+this.NomeEmpresa;
    } 
}
