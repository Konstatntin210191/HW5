/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

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

double [] GetArray(int length)
{
    double [] arr = new double[length];
    Random rnd = new Random();

    for(int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(-100, 100);
    }
    return arr;
}

string PrintArray(double[] array)
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

double GetFindMax(double[] array)
{
    double max = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
            max = array[i];
    }
    return max;
}

double GetFindMin(double[] array)
{
    double min = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
            min = array[i];
    }
    return min;
}

double GetDiff(double max, double min)
{
    double diff = max - min;
    return diff;
}

string message = "Введите длину массива";
int length = GetNumber(message);
double[] arr = GetArray(length);
string array = PrintArray(arr);
Console.WriteLine(array);
double max = GetFindMax(arr);
double min = GetFindMin(arr);
Console.WriteLine($"Максимальное число: {max}");
Console.WriteLine($"Минимальное число: {min}");
double diff = GetDiff(max, min);
Console.WriteLine($"Разница между максимальным и минимальным числом: {diff}");
