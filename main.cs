using System;

class MainClass {
  public static void Main (string[] args) {
    // Get input
    Console.WriteLine ("Enter temperature in Celsius:");
    double temperatureInCelsius = Convert.ToDouble(Console.ReadLine());
    // Calculate Fahrenheit
    double temperatureInFahrenheit = (temperatureInCelsius * 9/5) + 32;
    // Display the temperature in Fahrenheit
    Console.WriteLine ("Fahrenheit equivilant for " + temperatureInCelsius + " degrees celsius is " + temperatureInFahrenheit + ".");
    // Display whether or not the temperature in Fahrenheit is below freezing(which is 32) or display that the temparature is above boiling (above 212).
    if (temperatureInFahrenheit < 32) 
    {
      Console.WriteLine ("This temperature is below the freezing temperature of 32 degrees Fahrenheit.");
    }
    else if (temperatureInFahrenheit > 212)
    {
      Console.WriteLine ("This temperature is above the boiling temperature of 212 degrees Fahrenheit.");
    }
  }
}