void ShowArray (int [,] array){
    for(int i=0; i < array.GetLength(0); i++){
      for(int j=0; j < array.GetLength(1); j++)
        Console.Write($"{array[i, j]}  ");
      Console.Write("\n");
    }
    Console.WriteLine();
}

void FillArray (int [,] array){

  int n = array.GetLength(0);
  int i=1;
  int j;
  int k;
  int p=n/2;

  // if (n%2==1) array[p,p]=n*n;
  for(k=1;k<=p;k++)
  {
    for(j=k-1; j<n-k+1; j++)
      array[k-1,j]=i++;

    for(j=k; j<n-k+1; j++)
      array[j,n-k]=i++;

    for(j=n-k-1; j>=k-1; --j)
      array[n-k,j]=i++;

    for(j=n-k-1; j>=k; j--)
      array[j,k-1]=i++;
  }
}


int [,] array = new int [4, 4];

FillArray(array);
ShowArray(array);
