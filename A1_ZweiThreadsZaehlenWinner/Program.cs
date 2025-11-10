using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace A1_ZweiThreadsZaehlenWinner;

class Program
{
        static int countA = 0;
        static int countB = 100;
       
    
    public static void Main(string[] args)
    {
                
        Console.WriteLine("Übung 1: Zwei Threads – Zählen & Winner");
        Thread threadA = new Thread(() => CountUpThreadA());
        Thread threadB = new Thread(() => CountDownThreadB());
        threadA.Start();
        threadB.Start();
        threadA.Join();
        threadB.Join();

        
        
    }

    private static void CountUpThreadA()
    {

        for (int i = 1; i <= 100; i++)
        {
            countA = i;
            Thread.Sleep(100);
            if (countA == countB)
            {
                Console.WriteLine("CountA und CountB sind gleich: " + countA);


            }

        }
    }
     private static void CountDownThreadB()
    {

        for (int i = 100; i >= 0; i--)
        {
            countB = i;
            Thread.Sleep(100);
            if (countA == countB)
            {
                Console.WriteLine("CountA und CountB sind gleich: " + countA);


            }

        }
    }
 
}
