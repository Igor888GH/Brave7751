
/*
Напишите программу, которая на вход
принимает два целых числа и проверяет,
является ли первое число квадратом второго.
a = 25, b = 5 => да
a = 2, b = 10 => нет
a = 9, b = -3 => да
a = -3, b = 9 => нет
*/

// тип_данных имя_переменной = значение;
// // camelCase:  firstNumber, secondNumber - если переменная состоит из нескольких слов
// int number = 9; // number = 9
// int result = number * number; // 81

// Console.ReadLine() - получить информацию из строчки

// Console.Write("Введите число: ");
// int input = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(input + 1000);

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine()); //a

Console.Write("Введите первое число: "); //b
int secondNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber == secondNumber * secondNumber)
{
    Console.WriteLine("Да " + firstNumber + " является кв. числа " + secondNumber);
}
else
{
    Console.WriteLine("НЕТ " + firstNumber + " НЕ является кв. числа " + secondNumber);
}

