void ShowArray (int [,] array){
    for(int i=0; i < array.GetLength(0); i++){
      for(int j=0; j < array.GetLength(1); j++)
        Console.Write($"{array[i, j]}  ");
      Console.Write("\n");
    }
    Console.WriteLine();
}

void FillArray (int [,] array){

  for (int i=0; i < array.GetLength(0); i++)
    for (int j=0; j < array.GetLength(1); j++)
      array[i, j] = new Random().Next(0, 51);
}

void SumRow(int [,] array, int [] sumRow){

  for(int i=0; i < sumRow.Length; i++)
    sumRow[i] = 0;

  for(int i=0; i < array.GetLength(0); i++)
    for(int j=0; j < array.GetLength(1); j++){
      sumRow[i] += array[i,j];
    }
}

int FoundMinSumRow(int [] array){

  int min = array[0];
  int index = 0;

  for(int i=0; i < array.Length; i++)
    if(min > array[i]){
      min = array[i];
      index = i;
    }

    return index;
}

int [,] array = new int [5, 7];
FillArray(array);
ShowArray(array);

int [] sumRow = new int [array.GetLength(0)];
SumRow(array, sumRow);

// for (int i=0; i < sumRow.Length; i++)
//   Console.Write($"{sumRow[i]} ");
// Console.WriteLine();

Console.WriteLine($"Индекс строки с наименьшим значением суммы элементов: {FoundMinSumRow(sumRow)}");
