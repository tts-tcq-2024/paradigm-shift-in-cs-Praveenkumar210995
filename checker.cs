using System;
using System.Diagnostics;
namespace paradigm_shift_csharp
{
    class Checker
    {
        float TempMin,TempMax, SocMin, SocMax, ChargeMin, ChargeMax;
        static bool TempCheck(float temperature)
        {
            if (temperature < TempMin || temperature > TempMax)
            {
                Console.WriteLine("Temperature is out of range!");
                return false;
            }
            else if ((temperature > (TempMax - (TempMax * 0.05f))&& (temperature < TempMax)
           {
                Console.WriteLine("Temperature is near the maxinum range!");
                return true;
           }
            return true;
        }

        static bool ChargeCheck(float soc)
        {
            if (soc < SocMin || soc > SocMax)
            {
                Console.WriteLine("State of Charge is out of range!");
                return false;
            }
            return true;
        }

        static bool ChargeRateCheck(float chargeRate)
        {
            if (chargeRate > ChargeMin)
            {
                Console.WriteLine("Charge Rate is out of range!");
                return false;
            }
            return true;
        }

        static bool batteryIsOk(float temperature, float soc, float chargeRate)
        {
            return TempCheck(temperature) && ChargeCheck(soc) && ChargeRateCheck(chargeRate);
        }

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

        static int Main()
        {
            ExpectTrue(batteryIsOk(25, 70, 0.7f));
            ExpectFalse(batteryIsOk(50, 85, 0.0f));
            Console.WriteLine("All ok");
            return 0;
        }
    }
}
