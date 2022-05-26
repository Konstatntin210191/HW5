/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/


int GetNumber(string msg)
{
    while(true)
    {
    Console.WriteLine(msg);
    string valueFromConsole = Console.ReadLine();
    

        if(int.TryParse(valueFromConsole, out int number))
        {
            if(number != 0)
                return number;
                else
                {
                    Console.WriteLine("Число должно отличаться от 0. Введите другое число");
                }
        }
        else
        {
            Console.WriteLine("Вы ввели не число. Нужно ввести число, отличное от нуля");
        }
    }
}  

int [] GetArray(int length)
{
    int [] arr = new int[length];
    Random rnd = new Random();

    for(int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(99, 1000);
    }
    return arr;
}

string PrintArray(int[] array)
{
    string result = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) result = "[" + Convert.ToString(array[i]) + ", ";//string builder
        else if (i < array.Length-1)
            result = result + Convert.ToString(array[i]) + ", ";
        else result = result + Convert.ToString(array[i]) + "]";
    }
return result;
}

int GetCountEven(int [] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0)
            count++;
    }
    return count;
}

string message = "Введите длину массива";
int length = GetNumber(message);
int[] arr = GetArray(length);
string array = PrintArray(arr);
Console.WriteLine(array);
int even = GetCountEven(arr);
Console.Write($"Количество четных чисел в массиве равно: {even}");


