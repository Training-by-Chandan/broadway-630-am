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
            t2 = FunctionTwo();

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

        public async Task FunctionTwo()
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

    public class TaskSampleV2
    {
        public int x = 0;
        private CancellationTokenSource tokenSource = new CancellationTokenSource();

        public void MainFunction()
        {
            Task t1 = new Task(FunctionOne, tokenSource.Token);
            Task t2 = new Task(FunctionTwo, tokenSource.Token);
            Task t3 = new Task(FunctionThree, tokenSource.Token);

            Task T = Task.Run(() =>
            {
                t1.Start();
                t2.Start();
            }).ContinueWith(a =>
            {
                t3.Start();
            }, tokenSource.Token, TaskContinuationOptions.OnlyOnRanToCompletion, TaskScheduler.Default);

            // tokenSource.CancelAfter(5000);
        }

        public async void FunctionOne()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"1st Function Says {i} at {DateTime.Now} & X={x}");
                x++;
                await Task.Delay(1250);
            }
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

            //  tokenSource.CancelAfter(2000);
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

    public class TaskSampleV3
    {
        public async void MainFunction()
        {
            //var i = await FunctionOne();
            //var j = FunctionTwo();
            //FunctionThree("no dependency");
            //Task t = Task.Factory.StartNew(() => {
            //});

            List<Action> tasks = new List<Action>();
            tasks.Add(() => FunctionOne());
            tasks.Add(() => { FunctionOne(); });
            tasks.Add(() => { FunctionOne(); });
            tasks.Add(() => { FunctionTwo(); });
            tasks.Add(() => { FunctionTwo(); });
            Parallel.Invoke(tasks.ToArray());
        }

        public async Task<int> FunctionOne()
        {
            Console.WriteLine("Entering FunctionOne");
            await Task.Delay(10000);
            Console.WriteLine("Exiting FunctionOne");
            return 10;
        }

        public async Task<string> FunctionTwo()
        {
            Console.WriteLine("Entering Function Two");
            await Task.Delay(6000);
            Console.WriteLine("Exiting from Function Two");
            return "Something";
        }

        public async Task FunctionThree(string s)
        {
            Console.WriteLine("Entering FunctionThree");

            await Task.Delay(3000);
            Console.WriteLine("From Function Three the value of s is " + s);
        }
    }
}