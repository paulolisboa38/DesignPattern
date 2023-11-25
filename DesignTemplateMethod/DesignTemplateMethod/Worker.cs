using System;

namespace DesignTemplateMethod
{
    abstract class Worker
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

        // Hook Methods
        protected virtual void GoToWork()
        {
            Console.WriteLine(" Going to work by bus.");
        }

        protected abstract void Work();
        protected abstract void Relax();

        // Concrete Methods
        protected void GetUp()
        {
            Console.WriteLine(" Getting out of bed...");
        }

        protected void EatBreakfast()
        {
            Console.WriteLine(" Having breakfast...");
        }

        protected void ReturnToHome()
        {
            Console.WriteLine(" Returning home...");
        }

        protected void Sleep()
        {
            Console.WriteLine(" Sleeping...");
        }
    }
}
