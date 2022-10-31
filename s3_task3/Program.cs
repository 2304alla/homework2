Console.WriteLine("Введите координаты точки A");

Console.Write("x1=  ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("y1=  ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");

Console.Write("x2=  ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("y2=  ");
int y2 = Convert.ToInt32(Console.ReadLine());

double Distance(int a1, int b1, int a2, int b2)
{
    double dist =Math.Sqrt((a1-a2)*(a1-a2)+(b1-b2)*(b1-b2));
    return dist;
}

double distance= Distance(x1,y1,x2,y2);
Console.WriteLine(Math.Round(distance, 2, MidpointRounding.ToZero));