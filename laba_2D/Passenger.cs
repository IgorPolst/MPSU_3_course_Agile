using System.Collections.ObjectModel;

namespace laba_2D;

class Passenger
{
    public string Name { get; init; }
    public string Ticket { get; init; }
    public Seat Place { get; init; }

    public Passenger(string name, string ticket, Seat place)
    {
        Name = name;
        Ticket = ticket;
        Place = place;
    }

    public override string ToString()
    {
        string res = $"ФИО: {Name}\n Номер билета: ";
        res += $"{Ticket}\n Посадочное место: {Place}\n";

        return res;
    }
}