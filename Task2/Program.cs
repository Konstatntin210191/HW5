/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

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
        arr[i] = rnd.Next(-100, 100);
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

int GetSummFromOddPosition(int [] arr)
{
    int summ = 0;
    int i = 0;
    foreach(int item in arr)
    {
        if(i % 2 != 0)
            summ += item;
        i++;
    }
    return summ;
}
string message = "Введите длину массива";
int length = GetNumber(message);
int[] arr = GetArray(length);
string array = PrintArray(arr);
Console.WriteLine(array);
int summOdd = GetSummFromOddPosition(arr);
Console.Write($"Количество элементов на нечетных позициях: {summOdd}");
