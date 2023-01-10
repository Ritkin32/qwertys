// 4 метод

//string Metod4(int count, string text) // правой кнопкой мыши ренейм буква изм на текст
//{
    //int i = 0;
   // string result = string.Empty; // строка пусто значение

     // while (i < count)
     // {
         // result = result + text;
         // i++;
      //}

   // return result;
//}

//string res = Metod4(10, "z");
//Console.WriteLine(res);




//string Metod4(int count, string text) // правой кнопкой мыши ренейм буква изм на текст
//{ 
     // string result = string.Empty;
     // for(int i = 0; i < count; i++)  // все изменения в 1 месте
      //{
       //   result = result + text;
      //}

   // return result;
//}

//string res = Metod4(10, "z");
//Console.WriteLine(res);


// цикл в цикле и for  на примере таблицы умножения

for (int i = 2; i <= 10; i++)
{
    for (int j = 0; j <= 10; j++)
    {
         Console.WriteLine($"{i}*{j} = {i * j}");
    }
     Console.WriteLine();
}



