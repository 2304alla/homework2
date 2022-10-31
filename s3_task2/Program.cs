//программа, которая по заданному диапозону четверти выдает возможный диапахон точек

Console.WriteLine("Введите диапазон");
int d = Convert.ToInt32(Console.ReadLine());

string Quarter(int a)
{
    if (a == 1) return "x > 0 ; y > 0";
    if (a == 2) return "x < 0 ; y > 0";
    if (a == 3) return "x < 0 ; y < 0";
    if (a == 4) return "x > 0 ; y < 0";
    return null;
}

string quarter = Quarter(d);

Console.WriteLine(quarter== null
? "Не верное значение"
: $" Диапазон возможных координатных точек в этой четверти: {quarter}");
