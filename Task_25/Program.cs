// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B

Console.Clear();

int Squar(int number, int power)
{
    int sqr = 1;

    for(int i = 0; i < power; i++)
    {
        sqr *= number;
    }
    return sqr;
}

Console.Write("Enter the first number: ");
int numA = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Enter the second number: ");
int numB = int.Parse(Console.ReadLine() ?? "0");

int sqr = Squar(numA, numB);

Console.Write($"{numA} in power {numB} is {sqr}");