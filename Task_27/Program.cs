// Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.

Console.Clear();

int Sum (int num)
{
    int sum = 0;
    while(num > 0)
    {
        sum += num % 10;
        num = num / 10;
    }

    return sum;
}

Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine() ?? "0");

int sum = Sum(number);

Console.Write($"Sum of all digits of number {number} is {sum}");