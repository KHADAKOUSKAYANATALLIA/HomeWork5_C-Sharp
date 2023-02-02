/* Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/


void CreateArray(int[] array) 
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
    {
        Console.Write("Ваш массив: ");
        Console.WriteLine(String.Join(", ", array));
    }
}

Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int[n];
CreateArray(array);
PrintArray(array);
