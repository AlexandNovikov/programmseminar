// написать программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a=25, b=5 -> yes
// a=2, b=10 -> no
// a=9, b=-3 -> yes
// a=-3, b=9 -> no

Console.Write("Введите число 1 -> ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2 -> ");
int num2 = int.Parse(Console.ReadLine());
bool result = num2 * num2 == num1;
Console.WriteLine(result ? "Да" : "Нет");
