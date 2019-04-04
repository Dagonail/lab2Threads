using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadsFinalLab
{

        class Program
        {
            static AutoResetEvent waitHandler = new AutoResetEvent(false);

            static Thread first;
            public static void SecondThread()
            {
                //waitHandler.WaitOne();
                //Console.ReadLine();
                Console.WriteLine("I'm Second Thread ");
            }
            public static void ThirdThread()
            {
                //waitHandler.WaitOne();
                //Console.ReadLine();
                Console.WriteLine("I'm Third Thread");
            //waitHandler.WaitOne();
            //Thread fifth = new Thread(() => FifthThread());
            //fifth.Start();
        }

            public static void FifthThread()
            {
                Console.WriteLine("I'm Fifth Thread");
                Console.ReadKey();
            }
            public static void SixthThread()
            {
                Console.WriteLine("I'm Sixth thread ");

            }
            public static void SeventhThread()
            {
            waitHandler.WaitOne();

            Console.WriteLine("I'm Seventh thread");

            }

            public static void FourthThread()
            {
            //Console.ReadLine();
            Console.WriteLine("I'm Fouth Thread");
                waitHandler.Set();
            }

            public static void firstThread()
            {
                Console.WriteLine("I'm First Thread ");
                waitHandler.Set();
                //waitHandler.WaitOne();
            }

            public static void RunThreads()
            {
                //waitHandler.WaitOne();

            }


        static void Main(string[] args)
            {
                Console.WriteLine("-------------------------------------------");
                first = new Thread(() => firstThread());
                Thread secondTh = new Thread(() => SecondThread());
                first.Start();
                secondTh.Start();
                waitHandler.WaitOne();
                Thread thirdTh = new Thread(() => ThirdThread());
                Thread fourthTh = new Thread(() => FourthThread());
                 thirdTh.Start();
                fourthTh.Start();
                Thread th = new Thread(() => RunThreads());
                th.Start();         
                Thread fifth = new Thread(() => FifthThread());
                Thread six = new Thread(() => SixthThread());
                fifth.Priority = ThreadPriority.BelowNormal;
                six.Priority = ThreadPriority.BelowNormal;
                fifth.Start();
                six.Start();
                Thread seven = new Thread(() => SeventhThread());
                seven.Priority = ThreadPriority.Lowest;
                seven.Start();


            }
        }
    }

