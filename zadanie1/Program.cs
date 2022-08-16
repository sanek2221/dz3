// Напишите программу, 
// которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считавает с консоли строку
    int result = int.Parse(readValue); // Преобрадует строку в целое число
    return result; // Возвращает результат
}
int cifra1(int number)
{
number = number /10000;
return number;
}
int cifra2(int number)
{
number = number / 1000 % 10;

return number;
}
int cifra3(int number)
{
number = number / 10 % 10;
return number;
}
int cifra4(int number)
{
number = number  % 10;
return number;
}
int num = Prompt("введите 5ти значное число >");
if (num > 100000 || num < 10000)
{
    System.Console.WriteLine("вы ввели не 5ти значное число");
    return;
}
int num1 = cifra1 (num);
int num2 = cifra2 (num);
int num4 = cifra3 (num);
int num5 = cifra4 (num);

if (num1 == num5 && num2==num4)
{
        System.Console.WriteLine("число является палиндромом");
}
else 
{
    System.Console.WriteLine("число не является палиндромом");
}