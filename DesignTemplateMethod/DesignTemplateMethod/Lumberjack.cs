using System;

namespace DesignTemplateMethod
{
    internal class Lumberjack : Worker
    {
        protected override void GoToWork()
        {
            Console.WriteLine(" Driving the truck to the forest.");
        }

        protected override void Work()
        {
            Console.WriteLine
                (" Cutting down trees, preparing and transporting logs...");
        }

        protected override void Relax()
        {
            Console.WriteLine(" Enjoying fishing by the lake and woodworking.");
        }
    }
}
