using System;

namespace DesignTemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker[] workers = new Worker[]
            {
                    new FireFighter(),
                    new Lumberjack(),
                    new Postman(),
                    new Manager()
            };

            for(int i = 0; i < workers.Length; i++)
            {
                Console.WriteLine($"\n Routine of a {workers[i].GetType().Name}:");
                workers[i].DailyRoutine();
            }

            Console.ReadKey();
        }
    }
}
