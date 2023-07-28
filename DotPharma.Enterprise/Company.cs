namespace DotPharma.Company.Contracts;

public class Company
{
    public string Acronym { get; set; }
    public string BusinessName { get; set; }
    public string LegalName { get; set; }
    public CNPJ CNPJ { get; set; }
    public InscricaoEstadual InscricaoEstadual { get; set; }
}

public readonly struct CNPJ
{
    public readonly string Value;

    public CNPJ(string value)
    {
        Value = value;
    }
}

public readonly struct InscricaoEstadual
{
    public readonly string Value;

    public InscricaoEstadual(string value)
    {
        Value = value;
    }
}