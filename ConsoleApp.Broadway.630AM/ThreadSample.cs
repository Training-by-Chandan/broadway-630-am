using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp.Broadway._630AM
{
    public class ThreadSample
    {
        public int x = 0;

        public void MainFunction()
        {
            Thread t1 = new Thread(FunctionOne);
            Thread t2 = new Thread(FunctionTwo);
            t1.Start();
            t2.Start();
            Console.WriteLine("Everything looks good");

            Thread t3 = new Thread(new ParameterizedThreadStart(FunctionThree));
            Thread t4 = new Thread(new ParameterizedThreadStart(FunctionThree));
            Thread t5 = new Thread(new ParameterizedThreadStart(FunctionThree));
            t3.Start(12);
            t4.Start(20);
            t5.Start(40);
        }

        public void FunctionThree(object y)
        {
            var sleepinterval = new Random().Next(500, 5000);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{y}th function says {i} at {DateTime.Now}");
                Thread.Sleep(sleepinterval);
            }
        }

        public void FunctionOne()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"1st Function Says {i} at {DateTime.Now} & X={x}");
                x++;
                Thread.Sleep(1000);
            }
        }

        public void FunctionTwo()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"                           2nd Function Says {i} at {DateTime.Now} & X={x}");
                x++;
                Thread.Sleep(1250);
            }
        }
    }

    public class TaskSample
    {
        public int x = 0;
        private CancellationTokenSource tokenSource = new CancellationTokenSource();
        private Task t1, t2;

        public void MainFunction()
        {
            t1 = new Task(FunctionOne, tokenSource.Token);
            t2 = new Task(FunctionTwo, tokenSource.Token);

            t1.Start();
            t2.Start();
        }

        public async void FunctionOne()
        {
            for (int i = 0; i < 20; i++)
            {
                if (tokenSource.Token.IsCancellationRequested)
                {
                    break;
                }
                Console.WriteLine($"1st Function Says {i} at {DateTime.Now} & X={x}");
                x++;
                await Task.Delay(1250);
            }
            Console.WriteLine("The function has been cancelled from function Two");
            //FunctionThree();
        }

        public async void FunctionTwo()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"                           2nd Function Says {i} at {DateTime.Now} & X={x}");
                x++;
                await Task.Delay(1000);
            }

            tokenSource.CancelAfter(2000);
        }

        public async void FunctionThree()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"      3rd Function Says {i} at {DateTime.Now} & X={x}");
                x++;
                await Task.Delay(1000);
            }
        }
    }
}