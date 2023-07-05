// 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Сделать так, чтобы проверялись не только цифры, но и строчки
Console.Write("Введите пять символов: ");
string? userNumber = Console.ReadLine(); 
int number;
bool isNumber = int.TryParse(userNumber, out number);
if (userNumber.Length==5)
{
    if (userNumber[0]==userNumber[4] && userNumber[1]==userNumber[3])
    {
        Console.Write($"Строка {userNumber} является палиндромом");
    }
    else
    {
        Console.Write($"Строка {userNumber} не является палиндромом");
    }
}
else 
{
    Console.Write($"В строке {userNumber} не 5 символов");
}
// 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
// 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N