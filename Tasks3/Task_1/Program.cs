Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
string? s = Console.ReadLine();
while(s ?.Length != 5)
{
    Console.WriteLine ("Вы ошиблись!\nВведите пятизначное число: ");
    s = Console.ReadLine();
}
if (s[0] == s[4] && s[1] == s[3])
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");