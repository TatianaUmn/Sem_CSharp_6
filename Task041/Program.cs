// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write($"Введите количество элементов массива (M): ");
int m = Convert.ToInt32(Console.ReadLine());
int[] arrayNumbers = new int[m];

void InputNumbers(int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введите {i+1} число: ");
        arrayNumbers[i] = Convert.ToInt32(Console.ReadLine()); 
    }
}

int ResultNumbers(int[] arrayNumbers)
{
    int counter = 0;
    for (int i = 0; i < arrayNumbers.Length; i++)
    {
        if (arrayNumbers[i] > 0)
        {
            counter += 1;
        }
    }
    return counter;
}

InputNumbers(m);
Console.WriteLine($"Введено чисел больше 0: {ResultNumbers(arrayNumbers)} ");

