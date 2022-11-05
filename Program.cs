System.Console.WriteLine("--Multiplo--\n");
System.Console.Write("Digite um número:        ");
int numero = Convert.ToInt32(Console.ReadLine()!);
System.Console.Write("Avalie se é múltiplo de: ");
int multiplo = Convert.ToInt32(Console.ReadLine()!);
if (numero % multiplo == 0)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    System.Console.WriteLine($"{numero} é multiplo de {multiplo}\n");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    System.Console.WriteLine($"{numero} não é múltiplo de {multiplo}\n");
    Console.ResetColor();
System.Console.Write("Pressione uma tecla para fechar...");
Console.ReadKey();
}

