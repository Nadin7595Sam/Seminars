// Функции
// Необходимо вывести наибольшее число из 2-х

Console.Clear();

char test(int a, int b)
{
    if(a > b)
        return '>';
    return '<';
}

Console.Clear();
Console.Write("Введите 1-е число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(test(n, m));

// 1. return
//         * Возвращает аргумент туда, где была вызвана функция
//         * Завершает работу функции
//         * Возвращаемое значение необходимо принимать в консоль (вывод) или в переменную нужного типа данных
//         * Сколько аргументов принимаем, столько и передаём