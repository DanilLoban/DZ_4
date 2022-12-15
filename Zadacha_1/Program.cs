// See https://aka.ms/new-console-template for more information
Console.Write("Введите первое число, ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число, ");
int B = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 1; i <= B; i++)
{
    result = result * A;
}
Console.WriteLine(result);