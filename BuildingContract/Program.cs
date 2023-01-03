using Caelum.Stella.CSharp.Http;
using static System.Runtime.InteropServices.JavaScript.JSType;


var Contract = new
{
    Company = new
    {
        CorporateName = "Lojas ilimitadas",
        document = "95317247000142",
        Address = new ViaCEP().GetEndereco("34580170"),
        CorporateNumber = "456",

    },
    Employee = new
    {
        Name = "Kessy Alessandra",
        document = "01997884054",
        IdentityCard = "386425309",
        Nationality = "Repitiliano(a)",
        MaritalStatus = "Solteiro()",
        Address = new ViaCEP().GetEndereco("30120080"),
        CorporateNumber = "979",
    },
    Occupation = "Eletricista",
    Wage = 2000.50,
    StartDate = new DateTime(2020, 1, 1),
};

string document = $@"CONTRATO INDIVIDUAL DE TRABALHO TEMPORÁRIO

EMPREGADOR: {Contract.Company.CorporateName}, com sede à {Contract.Company.Address.Logradouro}, {Contract.Company.CorporateNumber}, {Contract.Company.Address.Bairro}, CEP {Contract.Company.Address.CEP}, {Contract.Company.Address.Localidade}, {Contract.Company.Address.UF}, inscrita no CNPJ sob nº {Contract.Company.document};

EMPREGADO: {Contract.Employee.Name}, {Contract.Employee.Nationality}, {Contract.Employee.MaritalStatus}, portador da cédula de identidade R.G. nº {Contract.Employee.IdentityCard} e CPF/MF nº {Contract.Employee.document}, residente e domiciliado na {Contract.Employee.Address.Localidade}, {Contract.Employee.CorporateNumber}, {Contract.Employee.Address.Bairro}, CEP {Contract.Employee.Address.CEP}, {Contract.Employee.Address.Localidade}, {Contract.Employee.Address.UF}.

Pelo presente instrumento particular de contrato individual de trabalho, fica justo e contratado o seguinte:

Cláusula 1ª - O EMPREGADO prestará ao EMPREGADOR, a partir de {Contract.StartDate} e assinatura deste instrumento, seus trabalhos exercendo a função de {Contract.Occupation}, prestando pessoalmente o labor diário no período compreendido entre 9 horas às 18 horas, e intervalo de 1 hora para almoço;

Cláusula 2ª - Não haverá expediente nos dias de sábado, sendo prestado a compensação de horário semanal;

Cláusula 3ª - O EMPREGADOR pagará mensalmente, ao EMPREGADO, a título de salário a importância de {Contract.Wage} (SALÁRIO POR EXTENSO), com os descontos previstos por lei;

Cláusula 4ª - Estará o EMPREGADO subordinado a legislação vigente no que diz respeito aos descontos de faltas e demais sanções disciplinares contidas na Consolidação das Leis do Trabalho.

Cláusula 5ª - O prazo de duração do contrato é de 2 (dois) anos, contados a partir da assinatura pelos contratantes;

Cláusula 6ª - O EMPREGADO obedecerá o regulamento interno da empresa, e filosofia de trabalho da mesma.

Como prova do acordado, assinam instrumento, afirmado e respeitando seu teor por inteiro, e firmam conjuntamente a este duas testemunhas, comprovando as razões descritas.

(LOCALIDADE), (DATA POR EXTENSO)


_______________________________________________________
{Contract.Company.CorporateName}

_______________________________________________________
{Contract.Employee.Name}

_______________________________________________________
(Nome, R.G,Testemunha)

_______________________________________________________
(Nome, R.G,Testemunha)";