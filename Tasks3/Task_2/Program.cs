Console.Clear();

Console.Write("Введите x первой точки: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y первой точки: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите z первой точки: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите x второй точки: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y второй точки: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите z второй точки: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double dist = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));

Console.Write(Math.Round(dist, 2));