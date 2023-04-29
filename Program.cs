
Console.Clear();

int mg;

Console.WriteLine("---DiabetesGestacional---\n");

Console.Write("Digite o valor em glicerina: ");
mg = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

if (mg <=0)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"O valor {mg} mg/dL e Invalido");
    Console.ResetColor();
    Environment.Exit(1);
}
if (mg < 92)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{mg} mg/dL = reavaliar entre 24 e 28 semanas com TTOG 75g de glicose");
    Console.ResetColor();
    Environment.Exit(1);
}
if (mg >= 126)
{
   Console.ForegroundColor = ConsoleColor.Red;
   Console.WriteLine($"{mg} mg/dL = Diabetes Mellitus na Gravidez");
   Console.ResetColor();
   Environment.Exit(1);
}

 Console.ForegroundColor = ConsoleColor.Yellow;
 Console.WriteLine($"{mg} mg/dL = Compatível com Diabetes Gestacional");
 Console.ResetColor();