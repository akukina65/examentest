using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{

    class Me
    {
        public int[,] Createmasiv()
        {
            Console.WriteLine("Введит кол-во путей");
            int m = Convert.ToInt32(Console.ReadLine());
            int [,] masiv = new int[m,m];
            Console.Write("Введите элементы \n");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {

                    masiv[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return masiv;
        }

        public void Prinmasiv(int[,] masiv)
        {
            int m = masiv.GetLength(0);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    
                        Console.Write(masiv[i, j] + " ");   

                }
                Console.WriteLine();
            }
        }
        public void Metod(int[,] masiv)
        {
            int m = masiv.GetLength(0);
            int[] dist = new int[m];
            bool[] visited = new bool[m];

            
            for (int l = 0; l < m; l++)
            {
                dist[l] = int.MaxValue;
                visited[l] = false;
            }
            dist[0] = 0;

            
            

            for (int count = 0; count < m - 1; count++)
            {
                Console.WriteLine($"\nИтерация {count + 1}:");

               
                int u = -1;
                int minDist = int.MaxValue;

                for (int v = 0; v < m; v++)
                {
                    if (!visited[v] && dist[v] < minDist)
                    {
                        minDist = dist[v];
                        u = v;
                    }
                }

                if (u == -1)
                {
                    Console.WriteLine("Нет непосещенных вершин. Завершаем.");
                    break;
                }

                Console.WriteLine($"Выбрана вершина {u} с минимальным расстоянием {minDist}");
                visited[u] = true; 

                
                

                
                for (int v = 0; v < m; v++)
                {
                    if (masiv[u, v] != 0 && dist[u] != int.MaxValue)
                    {
                        int newDist = dist[u] + masiv[u, v];
                        if (newDist < dist[v])
                        {
                            Console.WriteLine($"Улучшаем расстояние до вершины {v + 1}: с {dist[v]} на {newDist}");
                            dist[v] = newDist;

                        }
                    }
                }
                Console.WriteLine($"После обновления соседей вершины {u}, значения dist:");
                
            }

           
            Console.WriteLine("\nКратчайшие расстояния от вершины 0:");
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine($"До вершины {i + 1}: {dist[i]}");
            }

            
        }







    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Me me = new Me();
            int[,] masiv = me.Createmasiv();
            me.Prinmasiv(masiv);
            me.Metod(masiv);
            Console.ReadKey();
        }
    }

    //gbjhbgizsuhdfjux
    //d;xfjivgbxp;fgojb'fg
    //kjfnvx;lkfcbxfgbxfgblz'fi
}
