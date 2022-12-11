// Назовём число «интересным» если его произведение цифр делится на их сумму. 
// Напишите программу, которая заполняет массив на 10 «интересных» случайных целых 
// чисел от 10 до 1000. (каждый эл-т массива – сгенерирован случайно)

int MultiplyDigitsOfNumber(int number)
{
    int result = 1;
    int position = number;
    while (position > 0)
    {
        result = result * (number % 10);
        position = position / 10;
    }
    return result;
}

int SumDigitsOfNumber(int number)
{
    int result = 0;
    int position = number;
    while (position > 0)
    {
        result = result + number % 10;
        position = position / 10;
    }
    return result;
}

void FillingArrayInterestingNumbers(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        int temp = new Random().Next(1, 1001);
        if (SumDigitsOfNumber(temp) > 0 && MultiplyDigitsOfNumber(temp) / SumDigitsOfNumber(temp) == 0)
        {
            collection[index] = temp;
            index++;
        }
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count - 1)
    {
        Console.Write(col[position] + ", ");
        position++;
    }
    Console.Write(col[position]);
}

int[] array = new int[10];
FillingArrayInterestingNumbers(array);
PrintArray(array);


