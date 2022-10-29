//Первый метод
//void Metod1()
////{
// Console.WriteLine();
//}


// Metod1(); //Вызов метода

//Второй метод

//void Metod2(string msg)
//{
//Console.WriteLine(msg);
//}

//Metod2("сообщение");//Вызов, БЫВАЮТ АРГУМЕНТЫ ИМЕНОВАННЫЕ

// Третий метод

// int Metod3()
// {
//     return DateTime.Now.Year;
// }

// int year = Metod3();// Вызов 
// Console.WriteLine(year);

// 4 метот, принимают и возращают

// string Metod4(int count, string text)
// {
//     int i = 0;
//     string result = string.Empty;

//     while (i<count)
//     {
//         result= result + text;
//         i++;
//     }
//     return result;
// }

// string res= Metod4(10, "poff," );
// Console.Write(res);


//Пробуем цикл for
// string Metod4(int count, string text)
// {

//     string result = String.Empty;
//     for(int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }

// string res = Metod4(10, "poff,");
// Console.Write(res);


//Цикл в цикле for

// for(int i = 2; i < 10; i++)
// {
//     for(int j = 2; j < 10; j++)
//     {
//         Console.WriteLine($"{i}*{j}={i*j}");
//     }
//     Console.WriteLine();
// }



//Задача. 
//Все пробелы заменить черточками
// маленикие буквы "к" заменить большими к
// больште буквы С заменить маленькими с

// string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
//             + "ежели бы вас послали вместо нашего милого"
//             + "Винценгероде, вы бы взяли приступом согласие"
//             + "прусского короля. Вы так красноречивы. Вы"
//             + "дадите мне чаю?";

// string = "qwert"
//           01234   
// s[3] // r

// string Replace(string text, char oldValue,char newValue)
// {
//  string result = String.Empty;
//  int length = text.Length;
//  for(int i = 1; i < 10; i++)
//  {
//     if(text[1] == oldValue) result =result + $"{newValue}";
//     else result = result + $"{text[i]}";
//  }
//  return result;
// }

// string textnew = Replace(text, ' ', '|');
// Console.WriteLine(textnew);





// Задача сортировка

int[] arr = {1, 5, 4, 3, 2, 6,7 ,1 ,1};
void PrintArray(int[] array)// выводит вест массив
{
   int count = array.Length;
   for(int i = 0; i < count; i++)
   {
      Console.Write($"{array[i]} ");
   }
   Console.WriteLine();
}

void SelectionSort(int[] array)// упорядочивает массив
{
 for(int i = 0; i < array.Length-1; i++)// тут добавили в длину -1, что бв ыо внутренем чикце, где ай+1, проходил весь массив
 {
   int minPosition = i;

   for(int j = i + 1; j < array.Length; j++)
   {
    if(array[j]< array[minPosition]) minPosition = j;
   }
   
   int temporary = array[i];//вводим переменную  и соъраняем туда первое хначение
   array[i] = array[minPosition];// первому значение передаем значение мин
   array[minPosition] = temporary;// мин передаем хначение темп





 }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);