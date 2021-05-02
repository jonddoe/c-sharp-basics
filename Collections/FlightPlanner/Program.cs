using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FlightPlanner
{
    class Program
    {
        private const string Path = "flights.txt";

        private static void Main(string[] args)
        {
            var readText = File.ReadAllLines(Path);
            var flightPlan = new List<string>();

            Console.WriteLine(
                "What would you like to do:\nTo display list of the cities press 1\nTo exit program press #");

            var selected = Console.ReadLine();

            switch (selected)
            {
                case "1":
                    Console.WriteLine("Select city from which you'd like to depart");
                    var n = 1;
                    foreach (var c in GetCities(readText))
                    {
                        Console.WriteLine(n + " " + c);
                        n++;
                    }

                    int.TryParse(Console.ReadLine(), out var startCityNum);

                    var startCity = SelectStartCity(GetCities(readText).ToArray(), startCityNum);
                    flightPlan.Add(startCity);

                    Console.WriteLine("Select your flight number: ");

                    foreach (var s in GetFlights(readText))
                    {
                        var index = s.Key.IndexOf(" -", StringComparison.Ordinal);

                        if (s.Key.Substring(0, index) == GetCities(readText).ToArray()[startCityNum - 1])
                        {
                            Console.WriteLine(s.Value + " " + s.Key);
                        }
                    }

                    int.TryParse(Console.ReadLine(), out var nextCityNum);
                    var nextCity = SelectNextCity(GetFlights(readText), nextCityNum);
                    flightPlan.Add(nextCity);

                    do
                    {
                        Console.WriteLine("Select your next flight number: ");

                        foreach (var s in GetFlights(readText))
                        {
                            var index = s.Key.IndexOf(" -", StringComparison.Ordinal);

                            if (s.Key.Substring(0, index) == SelectNextCity(GetFlights(readText), nextCityNum))
                            {
                                Console.WriteLine(s.Value + " " + s.Key);
                            }
                        }

                        int.TryParse(Console.ReadLine(), out nextCityNum);
                        nextCity = SelectNextCity(GetFlights(readText), nextCityNum);
                        flightPlan.Add(nextCity);
                    } while (startCity != nextCity);

                    foreach (var c in flightPlan)
                    {
                        Console.WriteLine(c);
                    }
                    break;

                    case "#":
                        Environment.Exit(1);
                        break;
                }

                Console.Read();
        }
        
        public static string SelectStartCity(string[] flights, int chosenCityNum)
        {
            var city = "";
            foreach (var c in flights)
            {
                if (c == flights[chosenCityNum - 1])
                {
                    city = c;
                }
            }

            return city;
        }

        public static string SelectNextCity(Dictionary<string, int> flights, int chosenFlightNum)
        {
            var city = "";
            foreach (var c in flights)
            {
                if (c.Value == chosenFlightNum)
                {
                    city = c.Key.Substring(c.Key.IndexOf("> ", StringComparison.Ordinal) + 2);
                }
            }

            return city;
        }
        public static HashSet<string> GetCities(string[] flights)
        {
            var cities = new HashSet<string>();
            foreach (var c in flights)
            {
                var index = c.IndexOf(" -", StringComparison.Ordinal);
                cities.Add(c.Substring(0, index));
            }

            return cities;
        }
        public static Dictionary<string, int> GetFlights(string[] flights)
        {
            var flightsDic = new Dictionary<string, int>();
            var n = 1;
            foreach (var c in flights)
            {
                flightsDic.Add(c, n);
                n++;
            }

            return flightsDic;
        }
    }
}