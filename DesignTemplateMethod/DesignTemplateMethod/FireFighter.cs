using System;

namespace DesignTemplateMethod
{
    internal class FireFighter : Worker
    {
        protected override void GoToWork()
        {
            Console.WriteLine(" Driving the firetruck to the station.");
        }

        protected override void Work()
        {
            Console.WriteLine
                (" Responding to emergencies, extinguishing fires, and ensuring public safety");
        }

        protected override void Relax()
        {
            Console.WriteLine(" Working out at the gym and reading.");
        }
    }
}
