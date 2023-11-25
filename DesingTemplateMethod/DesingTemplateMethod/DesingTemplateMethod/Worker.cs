using System;

namespace DesignTemplateMethod
{
    internal class Worker
    {
        // Template method
        public void DailyRoutine()
        {
            GetUp();
            EatBreakfast();
            GoToWork();
            Work();
            ReturnToHome();
            Relax();
            Sleep();
        }

        protected void GetUp()
        {
            Console.WriteLine(" Getting out of bed...");
        }

        protected void EatBreakfast()
        {
            Console.WriteLine(" Having breakfast...");
        }

        protected void GoToWork()
        {
            Console.WriteLine(" Going to work...");
        }

        protected void Work()
        {
            Console.WriteLine(" Working...");
        }

        protected void ReturnToHome()
        {
            Console.WriteLine(" Returning home...");
        }

        protected void Relax()
        {
            Console.WriteLine(" Relaxing...");
        }

        protected void Sleep()
        {
            Console.WriteLine(" Sleeping...");
        }
    }
}
