using System.Diagnostics;
using System.Globalization;

var date = new DateTime(2022, 08, 26);

Debug.WriteLine(date);
Debug.WriteLine(date.ToString("d"));
Debug.WriteLine(date.ToString("d", new CultureInfo("pt-BR")));
Debug.WriteLine(date.ToString("dd/MM"));
Debug.WriteLine(date.ToString("dd/MM/yy"));

date = new DateTime(2022, 08, 26, 13, 14, 15, 987);
Debug.WriteLine(date);
Debug.WriteLine(date.ToString("HH:mm"));
Debug.WriteLine(date.ToString("HH:mm:ss.fff"));

Debug.WriteLine(date.ToString("D"));
Debug.WriteLine(date.ToString("m"));
Debug.WriteLine(date.ToString("Y"));

Debug.WriteLine(date.ToString("G"));
Debug.WriteLine(date.ToString("g"));

Debug.WriteLine(date.ToString("O"));

Debug.WriteLine(date.ToString("t"));



