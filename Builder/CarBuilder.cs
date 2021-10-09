using System;
using System.Collections.Generic;
using System.Text;
using Builder.CarParts;

namespace Builder
{
    class CarBuilder : ICarBuilder
    {
        public int NumberOfWheels { get; set; }
        public SeatBelt SeatBelt { get; set; }
        public string Color { get; set; }
        public Windscreen Windscreen { get; set; }
        public Engine Engine { get; set; }
        public ICarBuilder AddEngine(Engine engine)
        {
            Engine = engine;
            return this;
        }

        public ICarBuilder AddSeatBelts(SeatBelt seatBelt)
        {
            SeatBelt = seatBelt;
            return this;
        }

        public ICarBuilder AddWheels(int numberOfWheels)
        {
            NumberOfWheels = numberOfWheels;
            return this;
        }

        public ICarBuilder AddWindscreen(Windscreen windscreen)
        {
            Windscreen = windscreen;
            return this;
        }
        public ICarBuilder Paint(string color)
        {
            Color = color;
            return this;
        }
        public Car Build()
        {
            return new Car(NumberOfWheels, SeatBelt, Color, Windscreen, Engine);
        }

    }
}