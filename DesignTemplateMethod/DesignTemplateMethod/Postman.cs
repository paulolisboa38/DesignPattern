using System;

namespace DesignTemplateMethod
{
    internal class Postman
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
                (" Sorting mail, delivering letters and packages, and collecting outgoing mail...");
        }

        public void ReturnToHome()
        {
            Console.WriteLine(" Returning home...");
        }

        public void Relax()
        {
            Console.WriteLine(" Relaxing...");
        }

        public void Sleep()
        {
            Console.WriteLine(" Sleeping...");
        }
    }
}
