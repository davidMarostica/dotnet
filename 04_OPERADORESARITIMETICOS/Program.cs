using _04_OPERADORESARITIMETICOS.Models;

// string a = "15";

// int b = Convert.ToInt32(a);

// Console.WriteLine(b);

string a = "15-";

int.TryParse(a, out int b);

Console.WriteLine(b);
Console.WriteLine("Fim do programa");