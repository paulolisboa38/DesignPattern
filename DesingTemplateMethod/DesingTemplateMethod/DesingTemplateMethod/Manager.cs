using System;

namespace DesignTemplateMethod
{
    internal class Manager
    {
        public void GetUp()
        {
            Console.WriteLine(" Getting out of bed...");
        }

        public void EatBreakfast()
        {
            Console.WriteLine(" Having breakfast...");
        }

        public void GoToWork()
        {
            Console.WriteLine(" Going to work...");
        }

        public void Work()
        {
            Console.WriteLine
                (" Overseeing operations, managing staff, making strategic decisions," +
                " and coordinating with other departments.");
        }

        public void ReturnToHome()
        {
            Console.WriteLine(" Returning home...");
        }

        public void Relax()
        {
            Console.WriteLine(" Playing golf, reading industry-related literature," +
                "networking at events, or enjoying a quiet evening.");
        }

        public void Sleep()
        {
            Console.WriteLine(" Sleeping...");
        }
    }
}
