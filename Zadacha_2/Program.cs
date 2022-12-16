// See https://aka.ms/new-console-template for more information
Console.Write("Введите число, ");
int vvod = Convert.ToInt32(Console.ReadLine());
int n = vvod;
int sum = 0;
for(int i = 0; i <= n; i++)
{
	int c = n % 10;
	if ((vvod % c == 0))
    {
		sum = sum + c;
	}
    if(c == 0)
    {
        Console.WriteLine("деление на 0");
    }
	n = n / 10;

}
Console.WriteLine(sum);