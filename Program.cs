using System;

namespace helloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      var car1 = new Car();

      car1.color = "Red";
      car1.manufacturer = "Toyota";

      Console.WriteLine(car1.color);
      Console.WriteLine(car1.manufacturer);

      var saloonCar1 = new SaloonCar(2);
      var saloonCar2 = new SaloonCar(3, "Nissan");
      var saloonCar3 = new SaloonCar(4, "Ford", "Purple");

      Console.WriteLine(saloonCar1.numOfSeats);

      Console.WriteLine(saloonCar2.numOfSeats);
      Console.WriteLine(saloonCar2.manufacturer);

      Console.WriteLine(saloonCar3.numOfSeats);
      Console.WriteLine(saloonCar3.manufacturer);
      Console.WriteLine(saloonCar3.color);
    }
    public class Car
    {
      public string color { get; set; }
      public string manufacturer { get; set; }
    }
    public class SaloonCar : Car
    {
      public SaloonCar(int _numOfSeats)
      {
        this.numOfSeats = _numOfSeats;
      }
      public SaloonCar(int _numOfSeats, string _manufacturer)
      {
        this.numOfSeats = _numOfSeats;
        this.manufacturer = _manufacturer;
      }
      public SaloonCar(int _numOfSeats, string _manufacturer, string _color)
      {
        this.numOfSeats = _numOfSeats;
        this.manufacturer = _manufacturer;
        this.color = _color;
      }
      public int numOfSeats { get; set; }
    }
  }
}
