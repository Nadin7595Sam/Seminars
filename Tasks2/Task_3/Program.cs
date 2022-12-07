Console.Clear();
Console.WriteLine ("Введите день недели: ");
int n = Convert.ToInt32(Console.ReadLine());
 
while(n < 1 || n > 7)
{
    Console.WriteLine ("Вы ошиблись!\nВведите день недели: ");
    n = Convert.ToInt32(Console.ReadLine());
}

if (n == 6 || n == 7)
    Console.WriteLine ("Да");
else
    Console.WriteLine ("Нет");