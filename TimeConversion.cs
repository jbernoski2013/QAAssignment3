using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectC
{
    public static class TimeConversion
    {

        public static double timeValue = 1;

        public static double Convert(double value, string convertFrom, string convertTo)
        {
            string conFrom = ModifyInput(convertFrom);
            string conTo = ModifyInput(convertTo);
            double getMultiplier = GetMultiplier(conFrom, conTo);
            double answer = value * getMultiplier;
            Console.WriteLine("Your Final Result: " + answer);
            return answer;
        }


        private static string ModifyInput(string input)
        {
            
            if(input == "seconds" || input == "Seconds" || input == "s" || input == "S")
            {
                input = "seconds";
            }
            else if (input == "minutes" || input == "Minutes" || input == "m" || input == "M")
            {
                input = "minutes";
            }
            else if (input == "hours" || input == "Hours" || input == "h" || input == "H")
            {
                input = "hours";
            }
            else if (input == "days" || input == "Days" || input == "d" || input == "D")
            {
                input = "days";
            }
            else
            {
                Console.WriteLine("incorrect unit of time.");
                timeValue = 0.0;
            }

            return input;
        }


       private static double GetMultiplier(string convertFrom, string convertTo)
        {
            if (convertFrom == "seconds")
            {
                if(convertTo == "seconds")
                {
                    timeValue = 1.0;
                }
                else if(convertTo == "minutes")
                {
                    timeValue = 0.0166667;
                }
                else if(convertTo == "hours")
                {
                    timeValue = 0.000277778;
                }
                else if(convertTo == "days")
                {
                    timeValue = 0.0000115741;
                }
            }
            else if (convertFrom == "minutes")
            {
                if (convertTo == "seconds")
                {
                    timeValue = 60.0;
                }
                else if (convertTo == "minutes")
                {
                    timeValue = 1.0;
                }
                else if (convertTo == "hours")
                {
                    timeValue = 0.0166667;
                }
                else if (convertTo == "days")
                {
                    timeValue = 0.000694444;
                }

            }
            else if (convertFrom == "hours")
            {
                if (convertTo == "seconds")
                {
                    timeValue = 3600.0;
                }
                else if (convertTo == "minutes")
                {
                    timeValue = 60.0;
                }
                else if (convertTo == "hours")
                {
                    timeValue = 1.0;
                }
                else if (convertTo == "days")
                {
                    timeValue = 0.0416667;
                }

            }
            else if (convertFrom == "days")
            {
                if (convertTo == "seconds")
                {
                    timeValue = 86400.0;
                }
                else if (convertTo == "minutes")
                {
                    timeValue = 1440.0;
                }
                else if (convertTo == "hours")
                {
                    timeValue = 24.0;
                }
                else if (convertTo == "days")
                {
                    timeValue = 1.0;
                }

            }
            else
            {
                timeValue = 0.0;
            }

            return timeValue;
        }
    }
}
