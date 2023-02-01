/* Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

void FullArray(int [] array) 
{
    int result = 0;
    Random random = new Random();

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1, 101);  
    }    

    int maxElement = array[0];
    int minElement = array[0];
 
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > maxElement)
        {
        maxElement = array[i];
        Console.WriteLine(maxElement);
        }
    }

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < minElement)
        {
        minElement = array[i];
        Console.WriteLine(minElement);
        }
    }

    result = maxElement - minElement; 
              
}    
// Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {result}");  

   
void PrintArray(int [] array) 
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