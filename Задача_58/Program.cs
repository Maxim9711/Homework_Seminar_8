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

int [,] MultArray(int [,] arrayFirst, int [,] arraySecond){

  if (arrayFirst.GetLength(1) != arraySecond.GetLength(0))
    return new int [0, 0];

  int [,] multArray = new int [arrayFirst.GetLength(0), arraySecond.GetLength(1)];

  // i < multArray.GetLength(0) & j < multArray.GetLength(1)
  for(int i=0, j=0;; j++){

    if (j == multArray.GetLength(1)){
      i++;
      j=0;
    }

    if (i == multArray.GetLength(0)) break;

    for(int k=0; k < arrayFirst.GetLength(1); k++)
      multArray[i,j] += arrayFirst[i,k] * arraySecond[k,j];

  }


  return multArray;
}


int [,] arrayFirst = new int [2, 3]; // 5 7
int [,] arraySecond = new int [3, 2]; // 7 5

FillArray(arrayFirst);
ShowArray(arrayFirst);

FillArray(arraySecond);
ShowArray(arraySecond);


int [,] multArray; // 5 7
multArray = MultArray(arrayFirst, arraySecond);
ShowArray(multArray);
