using System;

namespace ejercicio6
{
    static class Program
    {
        private static int acumulador = 0;
        private static void Main(string[] args)
        {
            
            
            
            Parallel.For(0, 100, dato =>{
                Console.WriteLine($"acumulador: '{acumulador}'. Tarea del hilo '{Environment.CurrentManagedThreadId}' ");

                if (acumulador % 2 == 0)
                {
                    acumulador += dato;
                    Thread.Sleep(100);
                }
                else
                {
                    acumulador -= dato;
                    Thread.Sleep(100);
                }
            });
           
            

        }

    }
}