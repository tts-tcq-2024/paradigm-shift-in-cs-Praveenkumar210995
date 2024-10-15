using System;

namespace ParadigmShiftCSharp
{
    class BatteryChecks
    {
        private const float ChargeRateMax = 0.8f;
        public static bool LimitCheck(float input, float minValue, float maxValue, string parameter, bool validate)
        {
            HigherRangeWarning(input, maxValue, parameter, validate);
            LowerRangeWarning(input, minValue, parameter, validate);
            if (input < minValue || input > maxValue)
            {
                Console.WriteLine($"{parameter} is out of range!");
                return false;
            }
            return true;
        }

        public static bool ChargeRateCheck(float chargeRate)
        {
            if (chargeRate > ChargeRateMax)
            {
                Console.WriteLine("Charge Rate is out of range!");
                return false;
            }
            HigherRangeWarning(chargeRate, ChargeRateMax, "Charge Rate", true);
            return true;
        }

        private static void HigherRangeWarning(float currentVal, float maxValue, string parameter, bool validate)
        {
            if (validate && currentVal > (maxValue - (maxValue * 0.05f)) && currentVal < maxValue)
            {
                Console.WriteLine($"{parameter} is near the maximum range!");
            }
        }

        private static void LowerRangeWarning(float currentVal, float minValue, string parameter, bool validate)
        {
            if (validate && currentVal > (minValue + (minValue * 0.05f)) && currentVal > minValue)
            {
                Console.WriteLine($"{parameter} is near the minimum range!");
            }
        }

    }
}
