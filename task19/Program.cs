// Задача 19

// Напишите программу, 
// которая принимает на вход пятизначное число
//  и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да


void Rivers(int number)
{
    if (number/10 == number/100000 && number/100 == number/10000) return Console.WriteLine("Да");
    return Console.WriteLine("Нет");
    

    
}

Console.Write("Ведите пятизначное  число:  ");
int num = Convert.ToInt32(Console.ReadLine());



if (num > 9999 && num<100000) Console.Write(Rivers(num));




