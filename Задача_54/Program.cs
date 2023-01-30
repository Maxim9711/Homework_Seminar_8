void ShowArray (int [,] array){
    for(int i=0; i < array.GetLength(0); i++){
      for(int j=0; j < array.GetLength(1); j++)
        Console.Write($"{array[i, j]}  ");
      Console.Write("\n");
    }
}

void FillArray (int [,] array){

  for (int i=0; i < array.GetLength(0); i++)
    for (int j=0; j < array.GetLength(1); j++)
      array[i, j] = new Random().Next(-50, 50);
}

void SortRow (int [,] array) {

  int min = 0;
  int count = 0;

  for(int i=0; i < array.GetLength(0); i++){

    min = array[i, 0];
    count = 0;

    for (int j=0; j < array.GetLength(1); j++){
      if (min < array[i, j]){
        array[i, j-1] = array[i, j];
        array[i, j] = min;
        count++;
      }
      else
        min = array[i, j];

      if(count != 0 & j+1 == array.GetLength(1)){
        count = 0;
        j = 0;
        min = array[i, 0];
      }
    }
  }
}


int [,] array = new int [7, 7];
FillArray(array);
ShowArray(array);

Console.WriteLine();
SortRow(array);
ShowArray(array);
