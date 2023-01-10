// 4 метод

string Metod4(int count, string text) // правой кнопкой мыши ренейм буква изм на текст
{
    int i = 0;
    string result = string.Empty; // строка пусто значение

      while (i < count)
      {
          result = result + text;
          i++;
      }

    return result;
}

string res = Metod4(10, "z");
Console.WriteLine(res);

