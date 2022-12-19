using Caelum.Stella.CSharp.Vault;
using System.Diagnostics;
using System.Globalization;

Money money = 10.00;
Debug.WriteLine(money);

double value = 10.00;
double secondValue = 20.00;

Money total = value + secondValue;
Debug.WriteLine(total);

decimal valueDecimal = 10m;
decimal secondValueDecimal = 20m;

Money result = valueDecimal - secondValueDecimal;
Debug.WriteLine(result);

Money euro = new Money(Currency.EUR, 1000);
Debug.WriteLine(euro);

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
Money dolar = new(Currency.USD, 1000);
Debug.WriteLine(dolar);