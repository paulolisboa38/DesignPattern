using System;

namespace DesignTemplateMethod
{
    internal class Manager : Worker
    {
        protected override void GoToWork()
        {
            Console.WriteLine(" Taking a taxi.");
        }

        protected override void Work()
        {
            Console.WriteLine
                (" Overseeing operations, managing staff, making strategic decisions," +
                " and coordinating with other departments.");
        }

        protected override void Relax()
        {
            Console.WriteLine(" Playing golf, reading industry-related literature," +
                "networking at events, or enjoying a quiet evening.");
        }
    }
}
