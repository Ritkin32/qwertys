//Метод 1

//void Metod1()

//{
// Console.WriteLine("Автор");
//}
//Metod1();

// Метод2 ничего не возвращают, но могут принимать аргументы
//void Metod2(string msg)
//{
//  Console.WriteLine(msg);
//}
//Metod2("Текст сообщения");

//аргументы

void Metod21(string msg, int count)
{
    int i = 0;
    while (1 < count)
    {
      Console.WriteLine(msg);
      count++;
    }
}
Metod21(msg: "текст", count: 4);
