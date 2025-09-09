using System.ComponentModel.Design;
using System.Globalization;

namespace laba_2D;

class Seat
{
    public string ChairNumber { get; init; }
    public string ServiceClass { get; init; }

    public Seat(string chairNumber, string serviceClass)
    {
        ChairNumber = chairNumber;
        ServiceClass = serviceClass;

    }

    public override string ToString()
    {
        return $"Место номер: {ChairNumber}\nКласс обслуживания:{ServiceClass}\n";
    }


}