//найти позицию минимального элементав в неотсортированной 
//части массива, произвести обмен этого значения со значением 
// первой неотсортированной позиции. Повторять пока есть неотсортированные элементы.


int[] arr = {1, 2 ,3, 4, 1, 5, 6, 7};

void PrintArray (int[] array)
{
       int count = array.Length;

       for (int i = 0; i < count; i++)
      {
          Console.Write($"{array[i]}");
      }
      Console.WriteLine();
}
// 2 этап метод, который будет упорядочивать наш массив

void SelectionSort (int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {

      int minPosition = i;

      for (int j = i + 1; j < array.Length; j++)
    {
         if (array[j] < array[minPosition]) minPosition = j;
    }
       int temporary = array[i];
       array[i] = array[minPosition];
      array[minPosition] = temporary;  

    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);




