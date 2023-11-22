using System;

namespace DesingTemplateMethod
{
    internal class FireFighter
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
                (" Responding to emergencies, extinguishing fires, and ensuring public safety..");
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
