using System;

namespace ParadigmShiftCSharp
{
    class Checker
    {
        static void Main()
        {
            BatteryStatusCheck BatteryMonitor = new BatteryStatusCheck();
            BatteryMonitor.ExpectTrue(BatteryStatusCheck.BatteryIsOk(25, 70, 0.7f));
            BatteryMonitor.ExpectFalse(BatteryStatusCheck.BatteryIsOk(50, 85, 0.0f));
            Console.WriteLine("All checks passed!");
        }
    }
}
