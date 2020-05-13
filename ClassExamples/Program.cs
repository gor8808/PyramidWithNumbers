using System;

namespace ClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Enter a number");
                int n = Convert.ToInt32(Console.ReadLine());
                int m = n + n - 1;
                int middle = m - n ;
                int[,] arr = new int[n, m];
                for(int i = 0; i < n; i++)
                {
                    for(int j = 0; j < m; j++)
                    {
                        arr[i, j] = n + 1;
                        arr[0, middle] = 0;
                        if (i != 0)
                        {
                            if(middle - i >= 0)
                            {
                                arr[i, middle - i] = i;

                            }
                            if (middle + i <= m)
                            {
                                arr[i, middle + i] = i;
                            }


                        }
                        if(arr[i,j] == (n+1))
                        {
                            Console.Write("  ");

                        }
                        else
                        {
                            Console.Write(arr[i, j] + " ");

                        }


                    }
                    Console.WriteLine();
                }
            
        }
    }
    
}
