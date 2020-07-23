using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace TaskLesson
{
    class Program
    {
        static void Main(string[] args)
        {

            Task task = Task.Run(() =>
            {
                Thread.Sleep(3000);
                System.Console.WriteLine("FOO1");
            });
            System.Console.WriteLine(task.IsCompleted);
            task.Wait();
            System.Console.WriteLine(task.IsCompleted);


            Task task1 = Task.Factory.StartNew(() =>
            {
                Thread.Sleep(3000);
                System.Console.WriteLine("FOO2");
            }, TaskCreationOptions.LongRunning);

            //返回值
            Task<int> task2 = Task.Run(() =>
            {
                System.Console.WriteLine("FOO3");
                return 3;
            });
            int result = task2.Result;
            System.Console.WriteLine(result);


            Task<int> primeNumberTask = Task.Run(() =>
                Enumerable.Range(2, 3000000).Count(n =>
                         Enumerable.Range(2, (int)Math.Sqrt(n) - 1).All(i => n % i > 0)));
            
            System.Console.WriteLine("Task is running");
            System.Console.WriteLine("The answer is"+primeNumberTask.Result);

        }
    }
}
