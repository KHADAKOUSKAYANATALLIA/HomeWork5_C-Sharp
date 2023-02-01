/* Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/


void FullArray(int[] array) 
{
    int sum = 0;
    Random random = new Random();

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1 , 100); 
    }

    for(int i = 1; i < array.Length; i+=2)
    {
        sum = sum + array[i];
    }

    Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {sum}");
}

void PrintArray(int[] array) 
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int[n];
FullArray(array);

Console.WriteLine("Ваш массив: ");
PrintArray(array);
Console.WriteLine(String.Join(", ", array));