using Builder.CarParts;

namespace Builder
{
    interface ICarBuilder
    {
        ICarBuilder AddWheels(int numberOfWheels);
        ICarBuilder AddSeatBelts(SeatBelt seatBelt);
        ICarBuilder Paint(string color);
        ICarBuilder AddWindscreen(Windscreen windscreen);
        ICarBuilder AddEngine(Engine engine);
        Car Build();
    }
}