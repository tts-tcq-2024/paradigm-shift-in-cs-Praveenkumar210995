using System;

namespace ParadigmShiftCSharp
{
    class BatteryStatusCheck
    {
        private const float SocMin = 20f;
        private const float SocMax = 80f;
        private const float TempMin = 0f;
        private const float TempMax = 45f;
        BatteryChecks BatteryLimituse = new BatteryChecks();
        public void ExpectTrue(bool expression)
        {
            if (!expression)
            {
                Console.WriteLine("Expected true, but got false");
                Environment.Exit(1);
            }
        }

        public void ExpectFalse(bool expression)
        {
            if (expression)
            {
                Console.WriteLine("Expected false, but got true");
                Environment.Exit(1);
            }
        }

        public static bool BatteryIsOk(float temperature, float soc, float chargeRate)
        {
            return BatteryChecks.LimitCheck(temperature, TempMin, TempMax, "Temperature", true) &&
                   BatteryChecks.LimitCheck(soc, SocMin, SocMax, "SoC", true) &&
                   BatteryChecks.ChargeRateCheck(chargeRate);
        }
    }
}
