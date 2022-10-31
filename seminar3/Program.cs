//Программа, которая принимает на вход координаты точки х и у
//х не равен 0
//у не равен 0
//выдает номер четверти полоски, в которой находиься эта точка

// Console.WriteLine("Введите координаты точки");


// Console.Write("Y=  ");
// int y = Convert.ToInt32(Console.ReadLine());

// int Quarter(int a, int b)
// {
//     if (a > 0 && b > 0) return 1;
//     if (a < 0 && b > 0) return 2;
//     if (a < 0 && b < 0) return 3;
//     if (a > 0 && b < 0) return 4;
//     return 0;
// }

// int quarter =Quarter(x,y);

// string result = quarter > 0 
//               ? $"Координаты соответсвуют четверте - >{quarter}"
//               : $"Введены некоректные координаты";

// Console.WriteLine(result);


//программа, которая по заданному диапозону четверти выдает возможный диапахон точек

Console.WriteLine("Введите диапазон");
int d = Convert.ToInt32(Console.ReadLine());

int Quarter(int a)
{
    if (a = 1) return x > 0 && y > 0;
    if (a = 2) return x < 0 && y > 0;
    if (a = 3) return x < 0 && y < 0;
    if (a = 4) return x > 0 && y < 0;
    if ( a > 4 || a < 1 ) return 0;
}

int quarter = Quarter(d);

string result = quarter > 4 || quarter <1
               ? $"Нет такой четверти "
              : $"Возможный диапазон {quarter}";