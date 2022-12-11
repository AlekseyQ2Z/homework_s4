// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. 
// Не использовать функцию Math.Pow

Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
int power = 1;
for (int i = 1; number2 >= i; i++)
{
    power = power * number1;

}
Console.WriteLine(number1 + " в степени " + number2 + " равно " + power);