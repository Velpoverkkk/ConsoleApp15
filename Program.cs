using System;
class Program
{   //Задана матрица размером NxM.Определить количество "ососбых" элементов матрицы,считая элемент особым , если он больше суммы  остальны элементов столбца 
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int N, M, n = 0,sum=0,i=0;
        System.Console.WriteLine("Razmer massiva NxM");
        N = System.Convert.ToInt32(Console.ReadLine());
        M = System.Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[N, M];
        for (int j = 0; j < N; j++)
        {
            for (int k = 0; k < M; k++)
            {
                array[j, k] = rnd.Next(0, 10);
                Console.Write(array[j, k]);
            }
            Console.WriteLine();
        }
        for (int j = 0; j < N; j++)
        {   
            for (int k = 0; k < M ; k++)
            {  
                sum =sum +array[k, j];
            }
            for (int k = 0; k < M; k++) 
            {
                if (array[k, j] > (sum - array[k, j]))
                {
                    n++;
                    Console.WriteLine(array[k, j]+"  "+sum+" "+k+" "+j);
                }
            }
            sum = 0;
        }
        Console.WriteLine("Kolvo os el: "+n);
    }
}
