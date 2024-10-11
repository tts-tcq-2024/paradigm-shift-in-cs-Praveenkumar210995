using System;
using System.Diagnostics;
using System.Reflection.Metadata;
namespace paradigm_shift_csharp
{
    class Checker
    {

        static void HigherRangeWarning(float CurrentVal, float MaxiValue, String Parameter)
        {
            if ((CurrentVal > (MaxiValue - (MaxiValue * 0.05f))) && (CurrentVal < MaxiValue))
            {
                Console.WriteLine(Parameter + " is near the maxinum range!");
            }
        }

        static void LowerRangeWarning(float CurrentVal, float MinValue, String Parameter)
        {
            if ((CurrentVal > (MinValue + (MinValue * 0.05f))) && (CurrentVal > MinValue))
            {
                Console.WriteLine(Parameter + " is near the minimum range!");
            }
        }

        static bool TempCheck(float Temperature)
        {
            float TempMin = 0, TempMax = 45;
            string Parameter = "Temperature";
            if (Temperature < TempMin || Temperature > TempMax)
            {
                Console.WriteLine("Temperature is out of range!");
                return false;
            }
            HigherRangeWarning(Temperature, TempMax, Parameter);
            LowerRangeWarning(Temperature, TempMin, Parameter);
            return true;
        }



        static bool ChargeCheck(float soc)
        {
            float SocMin = 20, SocMax = 80;
            string Parameter = "Soc";
            if (soc < SocMin || soc > SocMax)
            {
                Console.WriteLine("State of Charge is out of range!");
                return false;
            }
            HigherRangeWarning(soc, SocMax, Parameter);
            LowerRangeWarning(soc, SocMin, Parameter);
            return true;
        }

        static bool ChargeRateCheck(float chargeRate)
        {
            float ChargeRateMax = 0.8f;
            String Parameter = "Charge Rate";
            if (chargeRate > ChargeRateMax)
            {
                Console.WriteLine("Charge Rate is out of range!");
                return false;
            }
            HigherRangeWarning(chargeRate, ChargeRateMax, Parameter);
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
