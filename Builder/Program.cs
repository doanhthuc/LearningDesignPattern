using System;
using Builder.CarParts;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car(4,
                        new SeatBelt("Audi"),
                        "red",
                        new Windscreen("Audi"),
                        new Engine("V8"));
            var carByBuilder = new CarBuilder()
                                      .AddWheels(4)
                                      .AddSeatBelts(new SeatBelt("BMW Seat Belt"))
                                      .AddWindscreen(new Windscreen("BMW wind screen"))
                                      .AddEngine(new Engine("BMW V8"))
                                      .Paint("red")
                                      .Build();
            Console.WriteLine(car.ToString());
            Console.WriteLine("------------------------------------");
            Console.WriteLine(carByBuilder.ToString());
        }
    }
}
