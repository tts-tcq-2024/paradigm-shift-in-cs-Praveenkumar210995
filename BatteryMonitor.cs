using System;

namespace ParadigmShiftCSharp
{
    class Checker
    {
        static void Main()
        {
            ExpectTrue(BatteryIsOk(25, 70, 0.7f));
            ExpectFalse(BatteryIsOk(50, 85, 0.0f));
            Console.WriteLine("All checks passed!");
        }
    }
}
