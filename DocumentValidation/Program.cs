using Caelum.Stella.CSharp.Validation;
using System.Diagnostics;

var cpf = new List<string>
{
    "71001482000",
    "58570540010",
    "49007853007"
};

var cnpj = new List<string>
{
    "95890248000181",
    "19970218000105",
    "10433898000149"
};

var voterRegistration = new List<string>
{
    "062401430229",
    "534083420205",
    "585803400248"
};

foreach (var document in cpf)
{
    CPFValidation(document);
}

foreach (var document in cnpj)
{
    CNPJValidation(document);
}

foreach (var document in voterRegistration)
{
    VoterRegistrationValidation(document);
}

static void CPFValidation(string document)
{
    if (new CPFValidator().IsValid(document))
    {
        Debug.WriteLine($"CPF válido: {document}");
    }
    else
    {
        Debug.WriteLine($"CPF inválido: {document}");
    }
}

static void CNPJValidation(string document)
{
    if (new CNPJValidator().IsValid(document))
    {
        Debug.WriteLine($"CNPJ válido: {document}");
    }
    else
    {
        Debug.WriteLine($"CNPJ inválido: {document}");
    }
}

static void VoterRegistrationValidation(string document)
{
    if (new TituloEleitoralValidator().IsValid(document))
    {
        Debug.WriteLine($"Titulo eleitoral válido: {document}");
    }
    else
    {
        Debug.WriteLine($"Titulo eleitoral inválido: {document}");
    }
}