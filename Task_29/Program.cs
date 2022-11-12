// Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.(в примере показаны два разных массива, 
// создаем именно для 8 элементов)

void Array (int size)
{
 
    int [] array = new int [size];

    Console.Write("[");

    for(int i = 0; i < size-1; i++)
    {
        array[i] = new Random().Next(0, 100);
        Console.Write($"{array[i]}, ");
    }
    
    array[size-1] = new Random().Next(0, 100);
    Console.Write($"{array[size-1]}]");
}

Console.Clear();

Array(8);