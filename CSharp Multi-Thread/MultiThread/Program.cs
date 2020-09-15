﻿using System;
using System.Threading;

namespace MultiThread
{
    class Program
    {

        /*
          创建线程
            Thread t = new Thread(要执行的方法);
            t.Start();
          暂停线程
            
          线程等待
          终止线程
          
          
          asdfasdf
          asdfasdf
         */
        static void Main(string[] args)
        {
            //使用c#创建线程
            Thread t = new Thread(PrintNumbersWithDelay);
            t.Start();
            //t.Join()方法，该方法允许等待直到线程t完成。当线程t完成时，主程序会继续运行。
            t.Join();
            //PrintNumbers();
            Console.WriteLine("Thread completed");
            Console.ReadLine();
        }

        static void PrintNumbers()
        {
            Console.WriteLine("Starting....");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void PrintNumbersWithDelay()
        {
            Console.WriteLine("Starting....");
            for (int i = 0; i < 10; i++)
            {
                //暂停线程  让一个线程等待一段时间而不用消耗系统资源
                Thread.Sleep(TimeSpan.FromSeconds(2));
                Console.WriteLine(i);
            }
        }
    }
}
