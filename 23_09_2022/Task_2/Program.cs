int i = 0, j = 0;
int[,] arr1 = new int[,] {{7,4},
                          {3,2},
                          };

int[,] arr2 = new int[,]{{6,4},
                         {3,5},
                         };

int[,] arrprod = new int[2, 2];

ArrProd();

void ArrProd()
{
arrprod[i, j] = arr1[i, j] * arr2[i, j] + arr1[i, j + 1] * arr2[i + 1, j];

arrprod[i, j + 1] = arr1[i, j] * arr2[i, j + 1] + arr1[i, j + 1] * arr2[i + 1, j + 1];

arrprod[i + 1, j] = arr1[i + 1, j] * arr2[i, j] + arr1[i + 1, j + 1] * arr2[i + 1, j];

arrprod[i + 1, j + 1] = arr1[i + 1, j] * arr2[i, j + 1] + 
                        arr1[i + 1, j + 1] * arr2[i + 1, j + 1];

Console.WriteLine($" '{arr1[i, j]}' '{arr1[i, j+1]}' ");
Console.WriteLine($" '{arr1[i+1, j]}' '{arr1[i+1, j+1]}' ");
Console.WriteLine("--------");
Console.WriteLine($" '{arr2[i, j]}' '{arr2[i, j+1]}' ");
Console.WriteLine($" '{arr2[i+1, j]}' '{arr2[i+1, j+1]}' ");
Console.WriteLine("--------");
Console.WriteLine($" '{arrprod[i, j]}' '{arrprod[i, j+1]}' ");
Console.WriteLine($" '{arrprod[i+1, j]}' '{arrprod[i+1, j+1]}' ");
}
