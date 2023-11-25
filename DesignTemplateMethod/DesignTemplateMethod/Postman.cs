using System;

namespace DesignTemplateMethod
{
    internal class Postman : Worker
    {
        protected override void GoToWork()
        {
            base.GoToWork();
        }

        protected override void Work()
        {
            Console.WriteLine
                (" Sorting mail, delivering letters and packages, and collecting outgoing mail...");
        }

        protected override void Relax()
        {
            Console.WriteLine(" Reading a book in the park and enjoying a quiet evening at home.");
        }
    }
}
