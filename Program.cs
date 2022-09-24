using System.Security.Cryptography;
int numero, face;
Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine("\n--- Rolagem de Dado ---");

Console.ResetColor();

Console.Write("Quantas faces ?: ");
numero = Convert.ToInt32(Console.ReadLine());

face = RandomNumberGenerator.GetInt32(1,++numero);

Console.Write("\nRolagem: ");

Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine($"{face}\n");

Console.ResetColor();


