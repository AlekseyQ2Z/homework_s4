// Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе, **которые являются делителями числа.**

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int temp = number;
int SumOfDigits = 0;

while (temp > 0)
{
    SumOfDigits = SumOfDigits + temp % 10;
    temp = temp / 10;
}
// **
// while (temp > 0)
// {
//     if (temp % 10 > 0 && number % (temp % 10) == 0)
//     {
//         SumOfDigits = SumOfDigits + temp % 10;
//     }
//     temp = temp / 10;
// }
// **

Console.WriteLine("Сумма цифр в числе " + SumOfDigits);