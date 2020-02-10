using System;

namespace liveCodingTemp
{
    class Program
    {
        static void Main(string[] args)
        {
            int average = 250;
            int candy = 3;
            double percentage = 0;
            double num = average * percentage;
            double num2 = 0;


            public double WeatherType(string weather)
            {
                if (weather == "clear")
                {
                    percentage = 0.10;
                    return num;
                }
                else if (weather == "cloudy")
                {
                    percentage = 0;
                    return num;
                }
                else if (weather == "rainy")
                {
                    percentage = 0.25;
                    return num;
                }
                else
                {
                    percentage = .25;
                    return num;
                }
            }

            public double TempType(int temp)
            {

                if (temp == 40)
                {
                    return num2 + .5;
                }
                else if (temp == 50)
                {
                    return num2 + .10;
                }
                else if (temp == 60)
                {
                    return num2 + .15;
                }
                else
                {
                    return num2 + .20;
                }
            }

            public double totalCandy(double theTemperature, double theWeather)
            {
                return (average * candy) + theTemperature + theWeather;

            }

            Console.ReadLine();
        }
    }
}
