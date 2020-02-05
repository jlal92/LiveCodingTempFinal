﻿using System;

namespace LiveCodingTempFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            double clear = (250 * 0.10 + 250);
            Console.WriteLine("How much candy do you need to buy if it's clear, and in the 50s?");
            Console.WriteLine(clear*3); 
            Console.ReadLine();

            double fullmoon = (250 * 0.25 + 250);
            double fortys = (-250 * 0.05);
            Console.WriteLine("How much candy do you need to buy if it's a full moon, and in the 40s?");
            Console.WriteLine((fullmoon + fortys) * 3);
            Console.ReadLine();

            double raining = (-250 * 0.25);
            double seventys = (250 * 0.20 + 250);
            Console.WriteLine("How much candy do you need to buy if it's raining, and in the 70s?");
            Console.WriteLine((raining + seventys) * 3);
            Console.ReadLine();
        }
    }
}


/*"""Halloween is coming, and you need to figure out how much candy to buy.
Luckily you have tracked the weather, temperature, and number of tricker treaters from years past.
From your research you have tracked 4 different types of weather: "Clear", "Cloudy", "Raining", "Full Moon"
From your research you have tracked 4 differnt types of temperature 40s, 50s, 60s, 70s
You get 10% more trick or treaters if the weather is clear
You get 0% more trick or treaters if the weather is cloudy
You get 25% less trick or treaters if the weather is rainy
You get 25% more trick or treaters if the weather is Full Moon
You get more trick or treaters the warmer the weather
You get 5% less trick or treaters if it's in the 40s
You get 0% more trick or treaters if it's in the 50s
You get 5% more trick or treaters if it's in the 60s
You get 20% more trick or treaters if its' in the 70s
On average you get 250 trick or treaters, and you want to give each kid 3 pieces of candy.
How much candy do you need to buy if it's clear, and in the 50s?
825
How much candy do you need to buy if it's a full moon, and in the 40s?
900
How much candy do you need to buy if it's raining, and in the 70s?
712.5"""*/
