using Caelum.Stella.CSharp.Http;
using System.Diagnostics;

var zipCodes = new List<string>()
{
     "34580170"
    ,"31250280"
};

foreach (var zipCode in zipCodes)
{
    GetAddress(zipCode);
}

static void GetAddress(string zipCode)
{
    var url = $"http://viacep.com.br/ws/{zipCode}/json/";
    
    var jsonAddress = new ViaCEP().GetEnderecoJson(zipCode);
    Debug.WriteLine(jsonAddress);

    var asyncJsonAddress = new ViaCEP().GetEnderecoJson(zipCode);
}