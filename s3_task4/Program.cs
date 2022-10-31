//квдрат числа n от 1 до n

Console.Write("Ведите натуральное число:  ");
int num = Convert.ToInt32(Console.ReadLine());


void Quarter(int number)
{
    if(number > 0)
    {
        int i= 1;
        while(i<= number)
        {
            Console.WriteLine($"{i,4}   {i*i,4}");
            i++;
        }
    }
    else Console.WriteLine("Не верное значение");
}

Quarter(num);
