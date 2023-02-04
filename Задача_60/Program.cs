void ShowArray (int [,,] array){
    for(int k=0; k < array.GetLength(2); k++ )
      for(int i=0; i < array.GetLength(0); i++){
        for(int j=0; j < array.GetLength(1); j++)
          Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
          Console.Write("\n");
      }
    Console.WriteLine();
}

void FillArray (int [,,] array){

  int num = 10;
  for(int k=0; k < array.GetLength(2); k++)
    for (int i=0; i < array.GetLength(0); i++)
      for (int j=0; j < array.GetLength(1); j++)
        array[i, j, k] = num++;
}



int [,,] array = new int [2, 2, 2]; // По условаию задания массив 2x2x2

FillArray(array);
ShowArray(array);
