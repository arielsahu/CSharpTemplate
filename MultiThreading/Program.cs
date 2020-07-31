/*
 * MultiThreading Lesson
 * Ariel Sahusilawane 20200731
 */
using System;
using System.Threading;

namespace MultiThreading
{
    class Program
    {
        static void ThreadMethods()
        {
            for (int i =0; i<10;i++)
            {
                Console.WriteLine("Thread Process {0}",i);
                Thread.Sleep(0);
            }
        }

        static void ThreadMethods2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Karate {0}", i);
                Thread.Sleep(0);
            }
        }

        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadMethods));
            Thread t2 = new Thread(new ThreadStart(ThreadMethods2));
            t.Start();
            t2.Start();
            for (int i=0;i<4;i++)
            {
                Console.WriteLine("Main thread: Do some work.");
                Thread.Sleep(0);
            }
            t.Join();
            t2.Join();
        }
    }
}
