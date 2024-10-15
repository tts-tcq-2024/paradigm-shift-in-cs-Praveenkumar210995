using System;

namespace ParadigmShiftCSharp
{
    class BatteryStatusCheck
    {
        static void ExpectTrue(bool expression)
        {
            if (!expression)
            {
                Console.WriteLine("Expected true, but got false");
                Environment.Exit(1);
            }
        }

        static void ExpectFalse(bool expression)
        {
            if (expression)
            {
                Console.WriteLine("Expected false, but got true");
                Environment.Exit(1);
            }
        }
    }
}
