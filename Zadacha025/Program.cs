// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите основание: ");
int bace = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int exponent = Convert.ToInt32(Console.ReadLine());
int stepen = 1;
for (int i = 0; i < exponent; i++)
{
    stepen *= bace;
}

Console.WriteLine(stepen);