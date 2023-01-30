/* Задайте массив заполненный случайными положительными
трёхзначными числами. Напишите программу, которая покажет 
количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

void FullArray(int[] array) 
{
    int count = 0;

    Random random = new Random();

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000);  
        if (array[i] % 2 == 0)
            count++;      
    }
    Console.WriteLine($"Четных чисел в массиве {count}");
}

void PrintArray(int[] array) 
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int[N];
FullArray(array);
Console.WriteLine("Ваш массив: "); // String.Join();
PrintArray(array);

