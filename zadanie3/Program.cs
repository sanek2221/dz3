// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобрадует строку в целое число
    return result;                          // Возвращает результат
}
void kub(int value)
{
    int i = 1;
    while (value >= i)
    {
        int value1 = i * i * i;
        System.Console.WriteLine(value1);
        i++;
    }
}

int num = Prompt("введите число >");

kub(num);
