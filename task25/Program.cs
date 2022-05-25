Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Программа которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B");

Console.WriteLine("Введите число для возведения его в степень: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите стпень: ");
int step = Convert.ToInt32(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Blue;
Console.Write($"{number}^{step} = ");
Console.WriteLine(Math.Pow(number,step));
