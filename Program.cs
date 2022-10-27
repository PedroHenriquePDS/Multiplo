System.Console.WriteLine("Digite um número...: ");
int n1 = Convert.ToInt32(Console.ReadLine());



System.Console.WriteLine("Avaliar se é múltiplo de...: ");
int n2 = Convert.ToInt32(Console.ReadLine());


if (n1 % n2 == 0)
{

    System.Console.WriteLine($"\n{n1} é múltiplo de {n2}");
}

else
{

    System.Console.WriteLine($"\n{n1} não é múltiplo de {n2}");
}