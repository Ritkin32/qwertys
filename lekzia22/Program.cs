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

//for (int i = 2; i <= 10; i++)
//{
    //for (int j = 0; j <= 10; j++)
   // {
       //  Console.WriteLine($"{i}*{j} = {i * j}");
    //}
   //  Console.WriteLine();
//}


//замена букв с больших на маленькие // заменить " " на"|" "к" на "К", "С" на "с"

// string s = "qwerty"
//             012
// s [3]= r


string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ужели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";


// string s = "qwerty"
//             012345
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
      string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'а', 'А');
Console.WriteLine(newText);
  
