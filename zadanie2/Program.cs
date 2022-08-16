// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобрадует строку в целое число
    return result;                          // Возвращает результат
}

int aX = Prompt("Введите aX> ");
int aY = Prompt("Введите aY> ");
int aZ = Prompt("Введите aZ> ");
int bX = Prompt("Введите bX> ");
int bY = Prompt("Введите bY> ");
int bZ = Prompt("Введите bZ> ");

double result = Math.Sqrt((aX - bX) * (aX - bX) + (aY - bY) * (aY - bY) + (aZ - bZ) * (aZ - bZ));
System.Console.WriteLine($"{result}");

